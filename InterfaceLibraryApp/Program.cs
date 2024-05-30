using System;
using System.Windows.Forms;
using System.IO;

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
            BasicFileFunctions.CreateFile(GlobalPaths.bitacoraPath);
            BasicFileFunctions.CreateFile(GlobalPaths.counterPath);
            BasicFileFunctions.CreateFile(GlobalPaths.commentsPath);

            GlobalMatrices.usersMatrix = MainMethods.CreateMatrix(GlobalPaths.usersPath);
            GlobalMatrices.booksMatrix = MainMethods.CreateMatrix(GlobalPaths.booksPath);
            GlobalMatrices.loansMatrix = MainMethods.CreateMatrix(GlobalPaths.loansPath);
            GlobalMatrices.bitacoraMatrix = MainMethods.CreateMatrix(GlobalPaths.bitacoraPath);
            GlobalMatrices.counterMatrix = MainMethods.CreateMatrix(GlobalPaths.counterPath);
            GlobalMatrices.commentsMatrix = MainMethods.CreateMatrix(GlobalPaths.commentsPath);


            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}