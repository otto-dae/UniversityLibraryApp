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
    public partial class ChangePrivilagesWindow : Form
    {
        public ChangePrivilagesWindow()
        {
            InitializeComponent();
        }
        public static int userIdIndex;

        private void SearchID_Click(object sender, EventArgs e)
        {
            if(IdSearchPrivilagesTextBox.Text == "")
            {
                MessageBox.Show("Por favor ingrese un ID");
                return;
            }
            if (IdSearchPrivilagesTextBox.Text.Length != 6)
            {
                MessageBox.Show("Ingrese un ID válido");
                return;
            }
            userIdIndex = MainMethods.FindID(GlobalMatrices.usersMatrix, IdSearchPrivilagesTextBox.Text);
            
            if (userIdIndex == -1)
            {
                MessageBox.Show("El ID no existe");
                Close();
            }
            else
            {
                if (GlobalMatrices.usersMatrix[userIdIndex, 3] == "Admin")
                {
                    AcutalStatusLabel.Text = "Privilegios actuales: Admin";
                    SoonTobePrivilages.Text = "Privilegios cambiaran a: Usuario";
                }
                else
                {
                    AcutalStatusLabel.Text = "Privilegios actuales: Usuario";
                    SoonTobePrivilages.Text = "Privilegios cambiaran a: Admin";
                }

            }
        }
        private void AcceptChangesButton_Click(object sender, EventArgs e)
        {
            if (GlobalMatrices.usersMatrix[userIdIndex, 3] == "Admin")
            {
                GlobalMatrices.usersMatrix[userIdIndex, 3] = "User";
                BasicFileFunctions.WriteChanges(GlobalPaths.usersPath, GlobalMatrices.usersMatrix);
                MessageBox.Show("Privilegios cambiados a Usuario");
                MainMethods.WriteToLogs($"Se cambiaron los privilegios de {GlobalMatrices.usersMatrix[userIdIndex, 2]} a Usuario");
                Close();
            }
            else
            {
                GlobalMatrices.usersMatrix[userIdIndex, 3] = "Admin";
                BasicFileFunctions.WriteChanges(GlobalPaths.usersPath, GlobalMatrices.usersMatrix);
                MessageBox.Show("Privilegios cambiados a Admin");
                MainMethods.WriteToLogs($"Se cambiaron los privilegios de {GlobalMatrices.usersMatrix[userIdIndex, 2]} a Admin");
                Close();
            }
        }
    }
}
