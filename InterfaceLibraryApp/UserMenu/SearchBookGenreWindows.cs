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
    public partial class SearchBookGenreWindows : Form
    {
        public SearchBookGenreWindows()
        {
            InitializeComponent();
            GenreBookSearchGrid.Hide();
        }

        private void SearchGenreButton_Click(object sender, EventArgs e)
        {
            string genre = GenreBookTextBox.Text;
            string[] genres = genre.Split(',');
            GenreBookSearchGrid.Rows.Clear();
            int counter = 0;
            if (genre == "")
            {
                MessageBox.Show("Por favor, ingrese un o multiples generos");
                return;
            }
            else
            {
                GenreBookSearchGrid.Show();
                for (int i = 0; i < GlobalMatrices.booksMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < genres.Length; j++)
                    {
                        if (GlobalMatrices.booksMatrix[i, 3].ToLower().Trim().Contains(genres[j].ToLower().Trim()))
                        {
                            GenreBookSearchGrid.Rows.Add(GlobalMatrices.booksMatrix[i, 0], GlobalMatrices.booksMatrix[i, 2], GlobalMatrices.booksMatrix[i, 3], GlobalMatrices.booksMatrix[i, 1]);
                            counter++;
                            break;
                        }
                    }
                }
                MainMethods.WriteToLogs("Busqueda de libros por genero");
            }

            if (counter == 0)
            {
                MessageBox.Show("No se encontro ejemplares");
                return;
            }
        }
    }
}
