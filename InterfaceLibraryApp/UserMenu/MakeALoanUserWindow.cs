using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceLibraryApp
{
    public partial class MakeALoanUserWindow : Form
    {
        public MakeALoanUserWindow()
        {
            InitializeComponent();
            AcceptButtonLoanUser.Visible = false;
            NameBookLoanPompt.Visible = false;
            BookNameForLoanUser.Visible = false;

        }
        private void SearchBookForLoanButton_Click(object sender, EventArgs e)
        { 
            int bookIndex = MainMethods.FindID(GlobalMatrices.booksMatrix, InsertIdBookLoanUser.Text);
            if(InsertIdBookLoanUser.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un ID");
                return;
            }

            if (bookIndex == -1)
            {
                MessageBox.Show("No se encontró el libro");
                InsertIdBookLoanUser.Clear();
                return;
            }
            else
            {
                NameBookLoanPompt.Visible = true;
                BookNameForLoanUser.Visible = true;
                BookNameForLoanUser.Text = GlobalMatrices.booksMatrix[bookIndex, 2];
                AcceptButtonLoanUser.Visible = true;
            }
           
        }
        private void AcceptButtonLoanUser_Click(object sender, EventArgs e)
        {
            int bookIndex = MainMethods.FindID(GlobalMatrices.booksMatrix, InsertIdBookLoanUser.Text);
            int counter = 0;
            if (Convert.ToInt32(GlobalMatrices.booksMatrix[bookIndex, 1]) == 0)
            {
                MessageBox.Show("No hay ejemplares disponibles");
                counter++;
                Close();
            }
            else if(Convert.ToInt32(GlobalMatrices.booksMatrix[bookIndex, 4]) == 0)
            {
                MessageBox.Show("No se puede prestar el libro, está deshabilitado");
                counter++;
                Close();
            }
            if(counter == 0)
            {
                int loanIndex = LoanFunctions.LoanChecker(GlobalUserValues.userIndex);
                GlobalMatrices.booksMatrix[bookIndex, 1] = Convert.ToString(Convert.ToInt32(GlobalMatrices.booksMatrix[bookIndex, 1]) - 1);
                GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, loanIndex] = InsertIdBookLoanUser.Text;
                GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, loanIndex + 1] = LoanFunctions.LoanDateGenerator();
                BasicFileFunctions.WriteChanges(GlobalPaths.booksPath, GlobalMatrices.booksMatrix);
                BasicFileFunctions.WriteChanges(GlobalPaths.loansPath, GlobalMatrices.loansMatrix);
                MessageBox.Show("Préstamo realizado con éxito");
                Close();
            }
        }
    }
}
