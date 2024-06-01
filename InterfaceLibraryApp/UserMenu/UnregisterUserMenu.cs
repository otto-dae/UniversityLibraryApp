using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfaceLibraryApp
{
    public partial class UnregisterUserMenu : Form
    {
        public UnregisterUserMenu()
        {
            InitializeComponent();
            PasswordUserDownBox.PasswordChar = '*';
        }
        private void AcceptButtonUserDown_Click(object sender, EventArgs e)
        {
            int userDown = UserDown(PasswordUserDownBox.Text);
            if (userDown == 1)
            {
                GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 4] = "0";
                BasicFileFunctions.WriteChanges(GlobalPaths.usersPath, GlobalMatrices.usersMatrix);
                MessageBox.Show("Usuario dado de baja exitosamente");
                Application.Exit();
            }
            if(userDown == 0)
            {
                MessageBox.Show("Contraseña incorrecta");

                PasswordUserDownBox.Clear();
            }
            if(userDown == -1)
            {
                MessageBox.Show("No puedes darte de baja si tienes libros prestados");
                
                PasswordUserDownBox.Clear();
            }

        }
        public static int UserDown(string passwordChecker)
        {

            if (passwordChecker != GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 1])
            {
                return 0;
            }
            if (MainMethods.LoanFinder(GlobalUserValues.userIndex) != -1)
            {
                return -1;
            }
            if (passwordChecker == GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 1])
            {
                return 1;
            }
            return 0; 
        }
    }
}
