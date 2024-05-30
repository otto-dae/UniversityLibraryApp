using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibraryApp
{
    static class BasicFileFunctions
    {
        public static void CreateFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
        }
        public static void WriteChanges(string path, string[,] dataMatrix)
        {
            StreamWriter changes = File.CreateText(path);
            int x = dataMatrix.GetLength(0);
            int y = dataMatrix.GetLength(1);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (j == y - 1)
                    {
                        changes.Write(dataMatrix[i, j]);
                    }
                    else
                    {
                        changes.Write(dataMatrix[i, j]);
                        changes.Write('|');
                    }
                }
                if (!(i == x - 1))
                {
                    changes.WriteLine();
                }
            }
            changes.Close();
        }
        public static string Reader(string path)
        {
            string text;
            StreamReader reader = new StreamReader(path);
            text = reader.ReadToEnd();
            reader.Close();

            return text;
        }
    }

}
