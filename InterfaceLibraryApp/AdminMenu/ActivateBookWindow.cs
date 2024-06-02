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
    public partial class ActivateBookWindow : Form
    {
        public ActivateBookWindow()
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
            int idBookIndex = MainMethods.FindID(GlobalMatrices.booksMatrix, SearchIdTextBox.Text);
            if (idBookIndex == -1)
            {
                MessageBox.Show("ID no encontrado");
                return;
            }
            if (GlobalMatrices.booksMatrix[idBookIndex, 4] == "1")
            {
                MessageBox.Show("El libro ya está activo");
                return;
            }
            else
            {
                ActivateBook(idBookIndex);
            }
        }
        private void ActivateBook(int idBookIndex)
        {
            GlobalMatrices.booksMatrix[idBookIndex, 4] = "1";
            BasicFileFunctions.WriteChanges(GlobalPaths.booksPath, GlobalMatrices.booksMatrix);
            MessageBox.Show("Libro desactivado");
            Close();
        }
    }    
}
