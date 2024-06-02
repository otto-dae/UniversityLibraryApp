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
    public partial class ModifyGenresBookWindow : Form
    {
        int bookIndex;
        public ModifyGenresBookWindow()
        {
            InitializeComponent();
            BookNametoChange.Hide();
            CurrentGenres.Hide();
            NewGenrePromp.Hide();
            NewGenresTextBox.Hide();
            ChangeGenres.Hide();
            ChangeGenres.Hide();
            GenrePrompDisclaimer.Hide();

        }

        private void SearchID_Click(object sender, EventArgs e)
        {
            if (SearchIdBookTextBox.Text == "")
            {
                MessageBox.Show("Favor de llenar el campo");
                return;
            }
            if (SearchIdBookTextBox.Text.Length != 6)
            {
                MessageBox.Show("Ingrese un Id valido");
                return;
            }
            bookIndex = MainMethods.FindID(GlobalMatrices.booksMatrix, SearchIdBookTextBox.Text);
            if (bookIndex == -1)
            {
                MessageBox.Show("El libro no existe");
                return;
            }
            else
            {
                BookNametoChange.Text = $"Nombre: {GlobalMatrices.booksMatrix[bookIndex, 2]}";
                CurrentGenres.Text = $"Generos actuales: {GlobalMatrices.booksMatrix[bookIndex, 3]}";
                BookNametoChange.Show();
                CurrentGenres.Show();
                GenrePrompDisclaimer.Show();
                NewGenrePromp.Show();
                NewGenresTextBox.Show();
                ChangeGenres.Show();
            }
        }

        private void ChangeGenres_Click(object sender, EventArgs e)
        {
            if(NewGenresTextBox.Text == "")
            {
                MessageBox.Show("Favor de llenar el campo");
                return;
            }
            if (bookIndex == -1)
            {
                MessageBox.Show("El libro no existe");
                return;
            }
            else
            {
                GlobalMatrices.booksMatrix[bookIndex, 3] = NewGenresTextBox.Text.Replace('|', '*');
                BasicFileFunctions.WriteChanges(GlobalPaths.booksPath, GlobalMatrices.booksMatrix);
                MessageBox.Show("Generos modificados correctamente");
                Close();
            }

        }
    }
}
