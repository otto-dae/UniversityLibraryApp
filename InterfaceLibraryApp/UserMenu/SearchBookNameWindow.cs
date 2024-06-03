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
    public partial class SearchBookNameWindow : Form
    {
        public SearchBookNameWindow()
        {
            InitializeComponent();
            ShowBooksGrid.Hide();
        }
        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            string nameBook = NameBookTextBox.Text;
            nameBook = nameBook.ToLower().Trim();
            ShowBooksGrid.Rows.Clear();

            int counter = 0;
            if (nameBook == "")
            {
                MessageBox.Show("Por favor, ingrese un nombre");
                return;
            }
            else
            {
                ShowBooksGrid.Show();
                for (int i = 0; i < GlobalMatrices.booksMatrix.GetLength(0); i++)
                {
                    if (GlobalMatrices.booksMatrix[i, 2].ToLower().Trim().Contains(nameBook))
                    {
                        counter++;
                        ShowBooksGrid.Rows.Add(GlobalMatrices.booksMatrix[i, 0], GlobalMatrices.booksMatrix[i, 2], GlobalMatrices.booksMatrix[i, 3], GlobalMatrices.booksMatrix[i, 1]);
                    }
                }
            }
            MainMethods.WriteToLogs($"Usuario {GlobalUserValues.ID} busco libros por nombre");



            if (counter == 0)
            {
                MessageBox.Show("No se encontro ejemplares con ese nombre");
            }
        }
    }
}
