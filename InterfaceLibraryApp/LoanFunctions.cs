﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibraryApp
{
    static class LoanFunctions
    {
        public static int FindIDBook(string[,] desiredMatrix, string idBook, int userLoansPos)
        {
            int y = desiredMatrix.GetLength(1);
            for (int j = 1; j < y; j++)
            {
                if (desiredMatrix[userLoansPos, j].Trim() == idBook.Trim())
                {
                    return j;
                }
            }
            return -1;
        }
        public static int BookOwnerChecker(string idBook, int userIndex)
        {
            for (int i = 1; i < GlobalMatrices.loansMatrix.GetLength(1); i++)
            {
                if (GlobalMatrices.loansMatrix[userIndex, i].Trim() == idBook.Trim())
                {
                    return -1;
                }
            }
            return 1;
        }   
        public static DateTime DateGen()
        {
            DateTime dateGen = DateTime.Now;
            return dateGen;
        }
        public static string LoanDateGenerator()
        {
            DateTime dateGen = DateTime.Now;
            dateGen = dateGen.AddDays(5);
            string dateLoan = dateGen.ToString();
            return dateLoan;
        }
        public static int DateDiference(string date1)
        {
            DateTime date2 = DateTime.Now;
            DateTime date1Converted = Convert.ToDateTime(date1);
            TimeSpan dif = date2 - date1Converted;
            int difDays = dif.Days;
            return difDays;
        }
        public static int LoanChecker(int userIndex)
        {
            for (int i = 1; i < GlobalMatrices.loansMatrix.GetLength(1); i++)
            {
                if (GlobalMatrices.loansMatrix[userIndex, i] == "ID")
                {
                    return i;
                }
            }
            return 0;
        }
        public static int LoanPosTransfer(int userIndex)
        {
            for (int i = 1; i < GlobalMatrices.loansMatrix.GetLength(1); i++)
            {
                if (GlobalMatrices.loansMatrix[userIndex, i] == "ID")
                {
                    return i;
                }
            }
            return 0;
        }
        public static void ReturnBook (int bookId, int bookIndex)
        {
            GlobalMatrices.booksMatrix[bookId, 1] = (Convert.ToInt32(GlobalMatrices.booksMatrix[bookId, 1]) + 1).ToString();
            GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, bookIndex] = "ID";
            GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, bookIndex + 1] = "date";
            BasicFileFunctions.WriteChanges(GlobalPaths.loansPath, GlobalMatrices.loansMatrix);
            BasicFileFunctions.WriteChanges(GlobalPaths.booksPath, GlobalMatrices.booksMatrix);
        }
    }
}
