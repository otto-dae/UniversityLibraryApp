using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.PerformanceData;

namespace InterfaceLibraryApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BasicFileFunctions.CreateFile(GlobalPaths.usersPath);
            BasicFileFunctions.CreateFile(GlobalPaths.booksPath);
            BasicFileFunctions.CreateFile(GlobalPaths.loansPath);
            BasicFileFunctions.CreateFile(GlobalPaths.logsPath);
            BasicFileFunctions.CreateFile(GlobalPaths.counterPath);
            BasicFileFunctions.CreateFile(GlobalPaths.commentsPath);

            GlobalMatrices.usersMatrix = MainMethods.CreateMatrix(GlobalPaths.usersPath);
            GlobalMatrices.booksMatrix = MainMethods.CreateMatrix(GlobalPaths.booksPath);
            GlobalMatrices.loansMatrix = MainMethods.CreateMatrix(GlobalPaths.loansPath);
            GlobalMatrices.logsMatrix = MainMethods.CreateMatrix(GlobalPaths.logsPath);
            GlobalMatrices.counterMatrix = MainMethods.CreateMatrix(GlobalPaths.counterPath);
            GlobalMatrices.commentsMatrix = MainMethods.CreateMatrix(GlobalPaths.commentsPath);

            string useNumb = BasicFileFunctions.Reader(GlobalPaths.counterPath);
            int useNumber = Convert.ToInt32(useNumb);
            useNumber++;

            StreamWriter counter = File.CreateText(GlobalPaths.counterPath);
            counter.Write(useNumber);
            counter.Close();

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}