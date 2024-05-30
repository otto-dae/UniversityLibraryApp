using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibraryApp
{
    static class MainMethods
    {
        public static int FindID(string[,] desiredMatrix, string id)
        {
            int x = desiredMatrix.GetLength(0);
            int y = desiredMatrix.GetLength(1);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (desiredMatrix[i, j].Trim() == id.Trim())
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public static string CreateId(string[,] desiredMatrix)
        {
            int x = desiredMatrix.GetLength(0);
            int y = desiredMatrix.GetLength(1);
            string newId = "";
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (j == 0) //Si es la columna de ID
                    {
                        int tempId = Convert.ToInt32(desiredMatrix[i, j]);
                        tempId++;
                        newId = Convert.ToString(tempId).PadLeft(6, '0'); //Biblioteca para añadir ceros a la izquierda
                        //.PadLeft(6, '0') añade ceros a la izquierda hasta que la cadena tenga 6 caracteres
                    }
                }
            }
            return newId;
        }
        public static string[,] CreateMatrix(string path)
        {
            string text = BasicFileFunctions.Reader(path);
            string[] rows = text.Split('\n');
            string[] columns = rows[0].Split('|');

            string[,] Matrix = new string[rows.Length, columns.Length];

            for (int i = 0; i < rows.Length; i++)
            {
                string[] rowsData = rows[i].Split('|');
                for (int j = 0; j < rowsData.Length; j++)
                {
                    Matrix[i, j] = rowsData[j].Trim();
                }
            }
            return Matrix;
        }
        public static int LoanFinder()
        {
            for(int i = 1; i < GlobalMatrices.loansMatrix.GetLength(1); i += 2)
            {
                if (GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, i] != "ID")
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
