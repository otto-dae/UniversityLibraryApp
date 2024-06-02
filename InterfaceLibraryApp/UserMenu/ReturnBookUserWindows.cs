using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceLibraryApp
{
    public partial class ReturnBookUserWindows : Form
    {
        public ReturnBookUserWindows()
        {
            InitializeComponent();
        }
        public static int bookIDPos;
        public static int bookIndex;
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string dateLoan = "";
            int differenceDay = 0;
            bookIDPos = MainMethods.FindID(GlobalMatrices.booksMatrix, IDBookReturnBox.Text);

            if (IDBookReturnBox.Text == "")
            {
                MessageBox.Show("Porfavor ingrese un ID");
                return;
            }
            
            bookIndex = LoanFunctions.FindIDBook(GlobalMatrices.loansMatrix, IDBookReturnBox.Text, GlobalUserValues.userIndex);
            if(bookIndex == -1 && counter == 0)
            {
                counter++;
                MessageBox.Show("El libro no se encuentra en su lista de prestamos");
                Close();
            }
            if (counter == 0)
            {
                dateLoan = GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, bookIndex + 1];
                differenceDay = LoanFunctions.DateDiference(dateLoan);
            }
            if(differenceDay <= 0 && counter == 0)
            {
                LoanFunctions.ReturnBook(bookIDPos, bookIndex);
                MessageBox.Show("Libro devuelto con exito");
                Close();
            }
            else if (counter == 0)
            {
                MessageBox.Show($"El libro se encuentra atrasado por {differenceDay} dias, porfavor pague la multa");
                PaymentReturnUser paymentReturnUser = new PaymentReturnUser(this,bookIDPos, bookIndex);
                paymentReturnUser.Show();
            }

        }
    }
}

