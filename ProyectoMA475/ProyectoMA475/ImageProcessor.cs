using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProyectoMA475
{
    public class ImageProcessor
    {
        public Bitmap bit;
        public int ancho, alto;
        public int[,] histograma = new int[3, 256]; // El arreglo es de (3 x 256), el tamaño de 3 se debe a que existen tres colores basicos RGB
                                                     // el tamaño de 256 representa el nivel de estos del 0 al 255
                                                     // Si una imagen esta en escala de grises los 3 colores basicos por pixel son iguales
                                                     // En una imagen en escala de grises el valor de ROJO, VERDE, AZUL son iguales
                                                     // Por eso para hallar el histograma en escala de grises solo debemos coger uno de los valores basicos y evaluar
        List<Pixel> pixels = new List<Pixel>();

        public ImageProcessor() { }

        public ImageProcessor(Bitmap bmp)
        {
            bit = bmp;
            ancho = bmp.Width;
            alto = bmp.Height;
        }

        public void SetBitmap(Bitmap bmp)
        {
            bit = bmp;
            ancho = bmp.Width;
            alto = bmp.Height;
        }

        public Bitmap ConversionEscalaDeGrises()
        {
            // Esta funcion convierte una imagen a color a escala de grises
            float G = 0;
            int RED = 0, GREEN = 0, BLUE = 0;

            for (int x = 0; x < ancho; x++)
                for (int y = 0; y < alto; y++)
                {
                    RED = bit.GetPixel(x, y).R;
                    GREEN = bit.GetPixel(x, y).G;
                    BLUE = bit.GetPixel(x, y).B;
                    G = RED * 0.299f + GREEN * 0.587f + BLUE * 0.114f;

                    bit.SetPixel(x, y, Color.FromArgb((int)G, (int)G, (int)G));
                }

            return bit;
        }

        public int[,] LimpiarHistograma()
        {
            // Cada vez que abrimos un archivo o le hacemos algun cambio a la imagen debemos limpiar el arreglo histograma con 0s
            for (int rgb = 0; rgb < 3; rgb++)
                for (int i = 0; i < 256; i++)
                    histograma[rgb, i] = 0;

            return histograma;
        }

        public int[,] CalcularHistograma(int op)
        {
            pixels = new List<Pixel>();
            // Al ser una imagen en escala de grises
            // El color rojo, verde, azul tienen el mismo valor
            for (int x = 0; x < ancho; x++)
                for (int y = 0; y < alto; y++)
                {
                    /*
                        bmp.GetPixel(x, y).R => consigue el valor de un pixel en una posicion (x, y) de la imagen
                        Nos colocamos en el arreglo histoGris[valor del pixel]
                        Por ejemplo si en la imagen hay 50 pixeles de valor 84
                        Entonces en histoGris[0, 84] = 50
                        Otro ejemplo si en la imagen hay 850 pixeles de valor 255
                        Entonces en histoGris[0, 255] = 850
                    */
                    if (op == 0)
                    {
                        
                        Pixel pix = new Pixel();
                        pix.x = x; pix.y = y;
                        pix.nivelGris = bit.GetPixel(x, y).R;
                        pixels.Add(pix);

                        histograma[0, bit.GetPixel(x, y).R]++;
                    }
                    if (op == 1)
                    {
                        histograma[0, bit.GetPixel(x, y).R]++;
                        histograma[1, bit.GetPixel(x, y).G]++;
                        histograma[2, bit.GetPixel(x, y).B]++;
                    }
                }

            if (op == 0)
                for (int i = 0; i < 256; i++)
                    for (int j = 0; j < ancho * alto; j++)
                        if (pixels[j].nivelGris == i)
                            pixels[j].cantPixelNivel = histograma[0, i];

            return histograma;
        }

        public Bitmap EcualizarHistograma()
        {
            int[] acumulado = new int[256];
            acumulado[0] = histograma[0, 0];

            // Calculo de arreglo acumulado
            for (int i = 1; i < 256; i++)
                acumulado[i] = histograma[0, i] + acumulado[i - 1];

            // Aqui se calcula el nuevo histograma ecualizado 
            // Cada valor del arreglo "resultado" representa un nivel de gris
            // Se multiplica el acumulado * ((2 ^ 8) - 1) esto dividido entre la cantidad total de pixeles
            // La operacion en si bota un numero decimal pero se redondea con Math.Floor();
            // Una vez hecha la operacion se guarda en el arreglo resultado[i] = nivel de gris

            int[] resultado = new int[256];
            for (int i = 0; i < 256; i++)
                resultado[i] = (int)Math.Floor(Convert.ToDecimal(255 * (acumulado[i]) / (ancho * alto)));


            // Se recorre la imagen
            for (int x = 0; x < ancho; x++)
                for (int y = 0; y < alto; y++)
                {
                    // Aqui se consigue de resultado el nivel de gris de un pixel en una determinada posicion
                    int nivelGris = resultado[bit.GetPixel(x, y).R];
                    // En caso de que el nivel de gris es mayor a 255 entonces toma el valor de 255
                    if (nivelGris > 255) nivelGris = 255;
                    // Finalmente se hace set en cada pixel el nivel de gris calculado anteriormente
                    bit.SetPixel(x, y, Color.FromArgb(nivelGris, nivelGris, nivelGris));
                }

            return bit;
        }

        public Bitmap ExpansionHistograma(float x1, float x2, float y1, float y2)
        {
            // Funcion => T(r) = m*r + b

            List<List<Pixel>> histogramaInicial = new List<List<Pixel>>();
            List<List<Pixel>> histogramaFinal = new List<List<Pixel>>();


            for (int j = 0; j < 256; j++)
            {
                var t = pixels.FindAll(a => a.nivelGris == j);
                histogramaInicial.Add(t);
                histogramaFinal.Add(new List<Pixel>());
            }

            int[] expandido = new int[256];

            float m = (y2 - y1) / (x2 - x1);
            float b = y1 - (m * x1);
            float Tr, r;

            for (int i = 0; i < 256; i++)
            {
                if (histograma[0, i] != 0)
                {
                    r = i; // Posicion antigua 
                    Tr = (m * r) + b; // Posicion nueva
                    expandido[Convert.ToInt32(Tr)] = histograma[0, Convert.ToInt32(r)];
                    histogramaFinal[Convert.ToInt32(Tr)] = histogramaInicial[Convert.ToInt32(r)];
                }
            }

            int cont = 0;
            foreach (var n in histogramaFinal)
            {
                foreach (var l in n)
                {
                    bit.SetPixel(l.x, l.y, Color.FromArgb(cont, cont, cont));
                }
                cont++;
            }

            return bit;
        }

    }
}
