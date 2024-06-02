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
    public partial class IdDown : Form
    {
        public IdDown()
        {
            InitializeComponent();
        }

        private void AcceptIdDownButton_Click(object sender, EventArgs e)
        {
            if (IdDownTextBox.Text.Length != 6)
            {
                MessageBox.Show("Ingrese un ID válido");
                return;
            }
            string userId = IdDownTextBox.Text;
            int caseUserId = IdDownAdmin(userId);
            if (caseUserId == 0)
            {
                MessageBox.Show("Campo vacío");
                return;
            }    
            if (caseUserId == -1)
            {
                MessageBox.Show("Usuario no encontrado");
                Close();
            }
            if (caseUserId == -2)
            {
                MessageBox.Show("Usuario ya estaba dado de baja");
                Close();
            }
            if (caseUserId == 1)
            {
                MessageBox.Show("Usuario dado de baja exitosamente");
                Close();
            }
        }
        private static int IdDownAdmin (string userId)
        {
            int userIdIndex = MainMethods.FindID(GlobalMatrices.usersMatrix, userId);
            if (userId == "")
            {
                return 0;
            }
            if (userIdIndex == -1)
            {  
                return -1;
            }
            if (GlobalMatrices.usersMatrix[userIdIndex, 4] == "0")
            {
                return -2;
            }
            else
            {
                GlobalMatrices.usersMatrix[userIdIndex, 4] = "0";
                MainMethods.WriteToLogs($"Se dio de baja al usuario con ID: {GlobalMatrices.usersMatrix[userIdIndex, 0]}");
                BasicFileFunctions.WriteChanges(GlobalPaths.usersPath, GlobalMatrices.usersMatrix);
                return 1;
            }
        }
    }
}
