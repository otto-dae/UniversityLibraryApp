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
        private void UserRegisterAdminButton_Click(object sender, EventArgs e)
        {
            IdUp idUp = new IdUp();
            idUp.Show();
        }
        private void DeactivateUserAdminButton_Click(object sender, EventArgs e)
        {
            IdDown idDown = new IdDown();
            idDown.Show();
        }
        private void ChangePrivilagesAdminButton_Click(object sender, EventArgs e)
        {
            ChangePrivilagesWindow changePrivilagesWindow = new ChangePrivilagesWindow();
            changePrivilagesWindow.Show();
        }
        private void ModifyNameUserAdminButton_Click(object sender, EventArgs e)
        {
            ChangeNameWindow changeNameWindow = new ChangeNameWindow();
            changeNameWindow.Show();
        }
        private void AddNewBookAdminButton_Click(object sender, EventArgs e)
        {
            AddNewBookWindow addNewBookWindow = new AddNewBookWindow();
            addNewBookWindow.Show();
        }
        private void ReUpbookButton_Click(object sender, EventArgs e)
        {
            ActivateBookWindow activateBookWindow = new ActivateBookWindow();
            activateBookWindow.Show();
        }
        private void UnregisterBookAdminButton_Click(object sender, EventArgs e)
        {
            DeactivateBookWindow deactivateBookWindow = new DeactivateBookWindow();
            deactivateBookWindow.Show();
        }
        private void ModifyNameBookAdminButton_Click(object sender, EventArgs e)
        {
            ModifyNameBookWindow modifyNameBookWindow = new ModifyNameBookWindow();
            modifyNameBookWindow.Show();
        }
        private void ChangeGenreButton_Click(object sender, EventArgs e)
        {
            ModifyGenresBookWindow modifyGenreBookWindow = new ModifyGenresBookWindow();
            modifyGenreBookWindow.Show();
        }
        private void ModifyQuantityBookAdminButton_Click(object sender, EventArgs e)
        {
            ModifyQUantityBookWindow modifyQUantityBookWindow = new ModifyQUantityBookWindow();
            modifyQUantityBookWindow.Show();
        }
        private void ShowUserMenuButton_Click(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu(MainlogIn);
            userMenu.Show();
            Close();
        }
        private void ReadCommentsAdminButton_Click(object sender, EventArgs e)
        {
            ReadCommentsWindow readCommentsWindow = new ReadCommentsWindow();
            readCommentsWindow.Show();
        }
        private void ReadLoansAdminButton_Click(object sender, EventArgs e)
        {
            ReadLoansUsers readLoansUser = new ReadLoansUsers();
            readLoansUser.Show();
        }

        private void ReadBitacora_Click(object sender, EventArgs e)
        {
            ReadLogsWindow readLogsWindow = new ReadLogsWindow();
            readLogsWindow.Show();

        }
    }
}
