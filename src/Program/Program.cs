using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {

            bool[,] gameBoard = LeerArchivo.LeerArchivoFuncion(@"../../assets/board.txt");
            ImprimirTablero.ImprimirTableroFuncion(gameBoard);
        }
    }
}
