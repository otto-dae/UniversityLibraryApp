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
    public partial class DeactivateBookWindow : Form
    {
        public DeactivateBookWindow()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (SearchIdTextBox.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un ID");
                return;
            }
            if (SearchIdTextBox.Text.Length != 6)
            {
                MessageBox.Show("Ingrese un ID valido");
                return;
            }
            int idBookIndex = MainMethods.FindID(GlobalMatrices.booksMatrix, SearchIdTextBox.Text);
            if (idBookIndex == -1)
            {
                MessageBox.Show("ID no encontrado");
                return;
            }
            if (GlobalMatrices.booksMatrix[idBookIndex, 4] == "0")
            {
                MessageBox.Show("El libro ya está desactivado");
                return;
            }
            else
            {
                DeactivateBook(idBookIndex);
            }
        }
        private void DeactivateBook(int idBookIndex)
        {
            GlobalMatrices.booksMatrix[idBookIndex, 4] = "0";
            BasicFileFunctions.WriteChanges(GlobalPaths.booksPath, GlobalMatrices.booksMatrix);
            MainMethods.WriteToLogs($"Se desactivó el libro con ID: {GlobalMatrices.booksMatrix[idBookIndex, 0]}");
            MessageBox.Show("Libro desactivado");
            Close();
        }
    }
}
