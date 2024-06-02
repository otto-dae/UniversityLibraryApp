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
    public partial class SearchBookIdWindow : Form
    {
        public SearchBookIdWindow()
        {
            InitializeComponent();
            NameLabelBook.Hide();
            GenreLabelBook.Hide();
            QuantityBookLabel.Hide();
        }
        private void SearchButtonID_Click(object sender, EventArgs e)
        {
            string idBook = IdBookTextBox.Text;
            if (idBook == "")
            {
                MessageBox.Show("Por favor, ingrese un ID");
                return;
            }
            if(idBook.Length != 6)
            {
                MessageBox.Show("El ID debe tener 6 caracteres");
                IdBookTextBox.Clear();
                return;
            }
            int idBookIndex = MainMethods.FindID(GlobalMatrices.booksMatrix, idBook);
            if (idBookIndex == -1)
            {
                MessageBox.Show("No se encontró el libro");
                IdBookTextBox.Clear();
                return;
            }
            else
            {
                NameLabelBook.Show();
                GenreLabelBook.Show();
                QuantityBookLabel.Show();
                NameLabelBook.Text = $"Nombre: {GlobalMatrices.booksMatrix[idBookIndex, 2]}";
                GenreLabelBook.Text = $"Generos: {GlobalMatrices.booksMatrix[idBookIndex, 3]}";
                QuantityBookLabel.Text = $"Cantidad: {GlobalMatrices.booksMatrix[idBookIndex, 1]}";
                MainMethods.WriteToLogs($"El usuario {GlobalUserValues.ID} ha buscado el libro con ID {idBook}");
            }

        }        
    }
}
