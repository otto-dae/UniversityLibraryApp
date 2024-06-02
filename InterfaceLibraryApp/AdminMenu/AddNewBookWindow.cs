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
    public partial class AddNewBookWindow : Form
    {
        public AddNewBookWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string numberBook = AmountAvailableBook.Text;
            if (NewBookNameTextBox.Text == "" || NewBookGenresTextBox.Text == "" || numberBook == "")
            {
                MessageBox.Show("Por favor, llena todos los campos");
                return;
            }
            int Availbooks = MainMethods.IsNumber(numberBook);
            if (Availbooks == -1 && Availbooks < 1)
            {
                MessageBox.Show("La cantidad de libros disponibles no es valida");
                AmountAvailableBook.Clear();
                return;
            }
            else
            {
                string idBook = MainMethods.CreateId(GlobalMatrices.booksMatrix);
                string newBook = idBook + '|' + AmountAvailableBook.Text.Replace('|', '*') + '|' + NewBookNameTextBox.Text.Trim().Replace('|', '*') + '|' + NewBookGenresTextBox.Text.Trim().Replace('|', '*') + '|' + '1';
                StreamWriter addNewBook = File.AppendText(GlobalPaths.booksPath);
                addNewBook.WriteLine();
                addNewBook.Write(newBook);
                addNewBook.Close();
                MessageBox.Show("Libro añadido correctamente");
                Close();
            }

        }
    }
}
