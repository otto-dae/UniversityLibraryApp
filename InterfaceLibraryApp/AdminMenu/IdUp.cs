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
    public partial class IdUp : Form
    {
        public IdUp()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string idUser = IdUPTextBox.Text;
            int caseUserId = IdUP(idUser);
            if (caseUserId == 0)
            {
                MessageBox.Show("Campo vacío");
            }
            if (caseUserId == -1)
            {
                MessageBox.Show("Usuario no encontrado");
                Close();
            }
            if (caseUserId == -2)
            {
                MessageBox.Show("Usuario ya estaba activado");
                Close();
            }
            if (caseUserId == 1)
            {
                MessageBox.Show("Usuario activado exitosamente");
                Close();
            }

        }
        private static int IdUP (string idUser)
        {
            int userIdIndex = MainMethods.FindID(GlobalMatrices.usersMatrix, idUser);
            int counter = 0;
            if (idUser == "")
            {
                return 0;
            }
            if (userIdIndex == -1 && counter == 0)
            {
                return -1;
            }
            if (GlobalMatrices.usersMatrix[userIdIndex, 4] == "1" && counter == 0)
            {
                return -2;
            }
            else
            {
                GlobalMatrices.usersMatrix[userIdIndex, 4] = "1";
                BasicFileFunctions.WriteChanges(GlobalPaths.usersPath, GlobalMatrices.usersMatrix);
                return 1;
            }
        }
    }
}
