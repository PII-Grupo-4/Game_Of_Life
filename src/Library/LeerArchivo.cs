using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class LeerArchivo
    {
        // La clase LeerAchivo se encarga de leer un archivo en una ruta determinada, y en base a el crear el tablero
        // del juego. La clase cumple con el principio de responsabilidad única, ya que solamente recibe como parametro
        // el url del archivo, por lo que se pueden seleccionar archivos distintos en Program. Si el día de mañana
        // queremos utilizar otro archivo fuente para iniciar el tablero, podemos hacerlo cambiarlo el argumento de la 
        // función LeerArchivoFuncion en Program.
        public static bool[,] LeerArchivoFuncion(string url_tabla)
        {
            string url = url_tabla;
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int y = 0; y < contentLines.Length; y++)
            {
                for (int x = 0; x < contentLines[y].Length; x++)
                {
                    if (contentLines[y][x] == '1')
                    {
                        board[x, y] = true;
                    }
                }
            }
            return board;
        }
    }
}
