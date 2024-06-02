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
    public partial class PaymentReturnUser : Form
    {
        Form ReturnBook;
        public PaymentReturnUser(Form returnBookWindow, int bookIdPos, int bookIndex)
        {
            InitializeComponent();
            CVVTextBox.PasswordChar = '*';
            ReturnBook = returnBookWindow;
        }

        private void PayConfirmButton_Click(object sender, EventArgs e)
        {
            if (CardTextBox.Text == "" || CVVTextBox.Text == "")
            {
                MessageBox.Show("Porfavor llene todos los campos");
            }
            if(CardTextBox.Text.Length != 16 || CVVTextBox.Text.Length != 3)
            {
                MessageBox.Show("Porfavor ingrese un numero de tarjeta valido");
                CardTextBox.Text = "";
                CVVTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Pago realizado con exito");
                LoanFunctions.ReturnBook(ReturnBookUserWindows.bookIDPos, ReturnBookUserWindows.bookIndex); 
                Close();
                ReturnBook.Close();
            }

        }
    }
}
