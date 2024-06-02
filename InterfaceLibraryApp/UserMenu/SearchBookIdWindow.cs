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
        }
        private void SearchButtonID_Click(object sender, EventArgs e)
        {
            string idBook = IdBookTextBox.Text;

            for (int i = 0; i < GlobalMatrices.booksMatrix.GetLength(0); i++)
            {
                if (GlobalMatrices.booksMatrix[i, 0] == idBook)
                {
                    NameLabelBook.Show();
                    NameLabelBook.Text = $"Nombre: {GlobalMatrices.booksMatrix[i, 2]}";
                    GenreLabelBook.Text = $"Generos: {GlobalMatrices.booksMatrix[i, 3]}";
                    QuantityBookLabel.Text = $"Cantidad: {GlobalMatrices.booksMatrix[i, 1]}";
                    return;
                }
            }
            NameLabelBook.Hide();
            GenreLabelBook.Text = "Generos: ";
            QuantityBookLabel.Text = "Cantidad: ";
            MessageBox.Show("No se encontro el libro");
        }        
    }
}
