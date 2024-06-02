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
    public partial class AdminMenu : Form
    {
        Form MainlogIn;
        public AdminMenu(Form LogIn)
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.LOGO_UAQ;
            pictureBox1.Image = Properties.Resources.LOGO_UAQ;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MainlogIn = LogIn;

            string[] name = GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 2].Split(' ');
            string userName = name[0];
            WelcomeDisplay.Text = "Hola! " + userName;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainlogIn.Close();
        }
    }
}
