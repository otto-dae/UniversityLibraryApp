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
            if(IdUPTextBox.Text == "")
            {
                MessageBox.Show("Campo vacío");
                return;
            }
            if (IdUPTextBox.Text.Length != 6)
            {
                MessageBox.Show("Ingrese un ID válido");
                return;
            }
            string idUser = IdUPTextBox.Text;
            int caseUserId = IdUPAmind(idUser);
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
                MessageBox.Show("Usuario ya estaba activado");
                Close();
            }
            if (caseUserId == 1)
            {
                MessageBox.Show("Usuario activado exitosamente");
                Close();
            }

        }
        private static int IdUPAmind (string idUser)
        {
            int userIdIndex = MainMethods.FindID(GlobalMatrices.usersMatrix, idUser);
            if (idUser == "")
            {
                return 0;
            }
            if (userIdIndex == -1)
            {
                return -1;
            }
            if (GlobalMatrices.usersMatrix[userIdIndex, 4] == "1")
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
