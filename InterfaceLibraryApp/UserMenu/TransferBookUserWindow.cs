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
                Close();
            }
            else
            {

                bookIndexOwner = LoanFunctions.FindIDBook(GlobalMatrices.loansMatrix, bookId, GlobalUserValues.userIndex);
                dateDifference = LoanFunctions.DateDiference(GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, bookIndexOwner + 1]);

                targetUserIndex = MainMethods.FindID(GlobalMatrices.loansMatrix, targetUserId);
                targetUserLoanPos = LoanFunctions.LoanChecker(targetUserIndex);
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
                MessageBox.Show("El usuario al que deseas transferir el libro no existe");
                Close();
            }
            if(targetUserLoanPos != 0)
            {
                counter++;
                MessageBox.Show("El usuario al que deseas transferir el libro tiene el límite de préstamos alcanzado");
                Close();
            }
            if (counter == 0)
            {
                GlobalMatrices.loansMatrix[targetUserIndex, targetUserLoanPos] = bookId;
                GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, bookIndexOwner] = "ID";
                MessageBox.Show("Libro transferido con éxito");
                Close();
            }
        }
    }
}
