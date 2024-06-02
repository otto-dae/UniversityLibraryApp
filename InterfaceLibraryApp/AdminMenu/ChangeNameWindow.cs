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
    public partial class ChangeNameWindow : Form
    {
        int userIdIndex;
        public ChangeNameWindow()
        {
            InitializeComponent();
            NewNameLabel.Hide();
            NewNameTextBox.Hide();
            AcceptNameChange.Hide();
            CurrentNameLabel.Hide();
        }
        private void SearchId_Click(object sender, EventArgs e)
        {
            userIdIndex = MainMethods.FindID(GlobalMatrices.usersMatrix, SearchIdTextBox.Text);
            if (SearchIdTextBox.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un ID");
                return;
            }
            if (userIdIndex == -1)
            {
                MessageBox.Show("El ID no existe");
                return;
            }     
            else
            {
                NewNameLabel.Show();
                NewNameTextBox.Show();
                AcceptNameChange.Show();
                CurrentNameLabel.Show();
                CurrentNameLabel.Text = "Nombre actual: " + GlobalMatrices.usersMatrix[userIdIndex, 2];
                BasicFileFunctions.WriteChanges(GlobalPaths.usersPath, GlobalMatrices.usersMatrix);
            }
        }
        private void AcceptNameChange_Click(object sender, EventArgs e)
        {
            
            if (SearchIdTextBox.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un ID");
                return;
            }
            if (NewNameTextBox.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un nombre");
                return;
            }
            else
            {
                GlobalMatrices.usersMatrix[userIdIndex, 2] = NewNameTextBox.Text;
                BasicFileFunctions.WriteChanges(GlobalPaths.usersPath, GlobalMatrices.usersMatrix);
                MessageBox.Show("Nombre cambiado exitosamente");
                Close();
            }

        }

        
    }
}
