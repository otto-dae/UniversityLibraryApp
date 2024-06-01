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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.LOGO_UAQ;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            string[] name = GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 2].Split(' ');
            string userName = name[0];
            WelcomeDisplay.Text = "Hola! " + userName;
        }
        private void UserDownButton_Click(object sender, EventArgs e)
        {
            UnregisterUserMenu unregisterUserMenu = new UnregisterUserMenu();
            unregisterUserMenu.Show();
        }

        private void SearchByIdButton_Click(object sender, EventArgs e)
        {
            SearchBookIdWindow searchBookIdWindow = new SearchBookIdWindow();
            searchBookIdWindow.Show();
        }
        private void SearchByNameButton_Click(object sender, EventArgs e)
        {
            SearchBookNameWindow searchBookNameWindow = new SearchBookNameWindow();
            searchBookNameWindow.Show();
        }

        private void SearchByGenreButton_Click(object sender, EventArgs e)
        {
            SearchBookGenreWindows searchBookGenreWindows = new SearchBookGenreWindows();
            searchBookGenreWindows.Show();
        }

        private void MakeaLoanButton_Click(object sender, EventArgs e)
        {
            MakeALoanUserWindow makeALoanUserWindow = new MakeALoanUserWindow();
            makeALoanUserWindow.Show();
        }

        private void TransferBookUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
