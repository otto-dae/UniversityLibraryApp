﻿using System;
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
        public PaymentReturnUser(Form returnBookWindow, int debt)
        {
            InitializeComponent();
            CVVTextBox.PasswordChar = '*';
            ReturnBook = returnBookWindow;
            PaymountAmountPrompt.Text = $"El monto a pagar es de: {debt} pesos";
        }

        private void PayConfirmButton_Click(object sender, EventArgs e)
        {
            if (CardTextBox.Text == "" || CVVTextBox.Text == "")
            {
                MessageBox.Show("Porfavor llene todos los campos");
                return;
            }
            if (CardTextBox.Text.Length != 16 || CVVTextBox.Text.Length != 3)
            {
                MessageBox.Show("Porfavor ingrese un numero de tarjeta valido");
                CardTextBox.Text = "";
                CVVTextBox.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("Pago realizado con exito");
                LoanFunctions.ReturnBook(ReturnBookUserWindows.bookIDPos, ReturnBookUserWindows.bookIndex);
                MainMethods.WriteToLogs($"El usuario {GlobalUserValues.userIndex} ha devuelto el libro {GlobalMatrices.booksMatrix[ReturnBookUserWindows.bookIndex, 2]}");
                Close();
                ReturnBook.Close();
            }

        }
    }
}
