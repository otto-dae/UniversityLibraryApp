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
    public partial class ModifyQUantityBookWindow : Form
    {
        int Bookindex;
        public ModifyQUantityBookWindow()
        {
            InitializeComponent();
            label2.Hide();
            NewBookQuantity.Hide();
            AcceptChangesButton.Hide();
        }
        private void SearchIdBook_Click(object sender, EventArgs e)
        {
            if (SearchBookId.Text == "")
            {
                MessageBox.Show("Por favor, llena el campo de busqueda");
                return;
            }
            Bookindex = MainMethods.FindID(GlobalMatrices.booksMatrix, SearchBookId.Text);
            if (Bookindex == -1)
            {
                MessageBox.Show("El libro no existe");
                SearchBookId.Clear();
                return;
            }
            else
            {
                label2.Show();
                NewBookQuantity.Show();
                AcceptChangesButton.Show();
            }
        }
        private void AcceptChangesButton_Click(object sender, EventArgs e)
        {
            if (SearchBookId.Text == "" || NewBookQuantity.Text == "")
            {
                MessageBox.Show("Por favor, llena todos los campos");
                return;
            }
            if (Bookindex == -1)
            {
                MessageBox.Show("El libro no existe");
                SearchBookId.Clear();
                NewBookQuantity.Clear();
                return;
            }
            int Availbooks = MainMethods.IsNumber(NewBookQuantity.Text);
            if (Availbooks == -1)
            {
                MessageBox.Show("La cantidad de libros no es valida");
                NewBookQuantity.Clear();
                return;
            }
            else
            {
                GlobalMatrices.booksMatrix[Bookindex, 1] = NewBookQuantity.Text;
                BasicFileFunctions.WriteChanges(GlobalPaths.booksPath, GlobalMatrices.booksMatrix);
                MessageBox.Show("Cantidad de libros modificada correctamente");
                Close();
            }


        }


    }
}
