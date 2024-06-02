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
    public partial class ModifyNameBookWindow : Form
    {
        int bookIndex;
        public ModifyNameBookWindow()
        {
            InitializeComponent();
            NewNamePrompt.Hide();
            NewNameTextBox.Hide();
            AcceptChanges.Hide();
            CurrentName.Hide();
        }

        private void SearchID_Click(object sender, EventArgs e)
        {
            if (SearchIDTextBox.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un ID");
                return;
            }
            if (SearchIDTextBox.Text.Length != 6)
            {
                MessageBox.Show("El ID debe tener 6 caracteres");
                return;
            }
            bookIndex = MainMethods.FindID(GlobalMatrices.booksMatrix, SearchIDTextBox.Text);
            if (bookIndex == -1)
            {
                MessageBox.Show("No se encontró el libro");
                return;
            }
            else
            {
                CurrentName.Text = GlobalMatrices.booksMatrix[bookIndex, 2];
                NewNamePrompt.Show();
                NewNameTextBox.Show();
                AcceptChanges.Show();
                CurrentName.Show();
            }
        }

        private void AcceptChanges_Click(object sender, EventArgs e)
        {
            if(NewNameTextBox.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un nombre");
                return;
            }
            else
            {
                GlobalMatrices.booksMatrix[bookIndex, 2] = NewNameTextBox.Text.Replace('|', '*');
                BasicFileFunctions.WriteChanges(GlobalPaths.booksPath, GlobalMatrices.booksMatrix);
                MessageBox.Show("Cambios realizados con éxito");
                this.Close();
            }
        }
    }
}
