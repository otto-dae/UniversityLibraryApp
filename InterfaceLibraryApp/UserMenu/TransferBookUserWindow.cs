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
            string idBook = IdBookTransferUser.Text;
            string idTargetUser = IdTargetTransferUser.Text;

            if(idBook == "" || idTargetUser == "")
            {
                MessageBox.Show("Porfavor llene los campos");
                return;
            }
            if(idBook.Length != 6 || idTargetUser.Length != 6)
            {
                MessageBox.Show("El id del libro y el id del usuario deben tener 6 caracteres");
                return;
            }
            int idBookOwner = LoanFunctions.FindIDBook(GlobalMatrices.loansMatrix, idBook, GlobalUserValues.userIndex);
            if (idBookOwner == -1)
            {
                MessageBox.Show("El libro no se encuentra en su posesión");
                return;
            }
            int idTargetUserIndex = MainMethods.FindID(GlobalMatrices.loansMatrix, idTargetUser);
            if (idTargetUserIndex == -1)
            {
                MessageBox.Show("El usuario al que desea transferir el libro no existe");
                return;
            }
            if(LoanFunctions.BookOwnerChecker(idBook, idTargetUserIndex) == -1)
            {
                MessageBox.Show("El usuario ya tiene el libro en su posesión");
                return;
            }
            if (LoanFunctions.DateDiference(GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, idBookOwner + 1]) != 0)
            {
                MessageBox.Show("No puede transferir el libro fuera de la ventana de tiempo");
                return;
            }
            int loanPosTarget = LoanFunctions.LoanChecker(idTargetUserIndex);
            if (loanPosTarget == 0)
            {
                MessageBox.Show("El usuario al que desea transferir el libro no tiene espacio para más libros");
                return;
            }
            else
            {
                GlobalMatrices.loansMatrix[idTargetUserIndex, loanPosTarget] = idBook;
                GlobalMatrices.loansMatrix[idTargetUserIndex, loanPosTarget + 1] = LoanFunctions.LoanDateGenerator();
                GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, idBookOwner] = "ID";
                GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, idBookOwner + 1] = "date";
                MessageBox.Show("Libro transferido con éxito");
                MainMethods.WriteToLogs($"Libro {idBook} transferido con éxito a {idTargetUser}");
                BasicFileFunctions.WriteChanges(GlobalPaths.loansPath, GlobalMatrices.loansMatrix);
            }
        }
    }
}
