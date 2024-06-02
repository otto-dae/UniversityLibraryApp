using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceLibraryApp
{
    public partial class TransferBookUserWindow : Form
    {
        public TransferBookUserWindow()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string bookId = IdBookTransferUser.Text;
            string targetUserId = IdTargetTransferUser.Text;
            int bookIndexOwner = 0;
            int dateDifference = 0;


            int targetUserIndex = 0;
            int targetUserLoanPos = 0;
            int counter = 0;

            if (IdBookTransferUser.Text == "" || IdTargetTransferUser.Text == "")
            {
                counter++;
                MessageBox.Show("Por favor, llena todos los campos");
                return;
            }
            else
            {

                bookIndexOwner = LoanFunctions.FindIDBook(GlobalMatrices.loansMatrix, bookId, GlobalUserValues.userIndex);
                string dateLoan = GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, bookIndexOwner + 1];
                dateDifference = LoanFunctions.DateDiference(dateLoan);

                targetUserIndex = MainMethods.FindID(GlobalMatrices.loansMatrix, targetUserId);
                targetUserLoanPos = MainMethods.LoanFinder(targetUserIndex);
            }

           
            if (bookIndexOwner == -1)
            {
                counter++;
                MessageBox.Show("El libro no se encuentra en tu posesión");
                Close();
            }
            if(dateDifference != 0)
            {
                counter++;
                MessageBox.Show("No puedes transferir un libro antes de la fecha de entrega");
                Close();
            }
            if(targetUserIndex == -1)
            {
                counter++;
                MessageBox.Show("El usuario al que deseas transferir el libro, no existe");
                Close();
            }
            if(targetUserLoanPos == -1)
            {
                counter++;
                MessageBox.Show("El usuario al que deseas transferir el libro tiene el límite de préstamos alcanzado");
                Close();
            }
            if (counter == 0)
            {
                GlobalMatrices.loansMatrix[targetUserIndex, targetUserLoanPos] = bookId;
                GlobalMatrices.loansMatrix[targetUserIndex, targetUserLoanPos + 1] = LoanFunctions.LoanDateGenerator();
                GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, bookIndexOwner] = "ID";
                GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, bookIndexOwner + 1] = "date";
                BasicFileFunctions.WriteChanges(GlobalPaths.loansPath, GlobalMatrices.loansMatrix);
                MessageBox.Show("Libro transferido con éxito");
                Close();
            }
        }
    }
}
