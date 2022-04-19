using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class ImprimirTablero
    {
        // ImprimirTablero, se encarga de imprimir el tablero en Consola, cumple el principio SRP, ya que tiene la única 
        // responsabilidad de imprimir los datos en un medio determinado. Si el día de mañana se desea imprimir el tablero
        // en un medio distinto, se puede realizar la modificación correspondiente.
        public static void ImprimirTableroFuncion(bool[,] b)
        {
            int width = b.GetLength(0);
            int height = b.GetLength(1);

            while (true)
                        {
                            Console.Clear();
                            StringBuilder s = new StringBuilder();
                            for (int y = 0; y < height; y++)
                            {
                                for (int x = 0; x < width; x++)
                                {
                                    if (b[x, y])
                                    {
                                        s.Append("|X|");
                                    }
                                    else
                                    {
                                        s.Append("___");
                                    }
                                }
                                s.Append("\n");
                            }
                            Console.WriteLine(s.ToString());
                            b = Tablero.TableroFuncion(b);
                            Thread.Sleep(300);
                        }
        }
    }
}