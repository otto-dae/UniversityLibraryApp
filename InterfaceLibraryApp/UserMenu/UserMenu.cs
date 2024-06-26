﻿using System;
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
        Form MainlogIn;
        public UserMenu(Form LogIn)
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.LOGO_UAQ;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MainlogIn = LogIn;

            string[] name = GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 2].Split(' ');
            string userName = name[0];
            WelcomeDisplay.Text = "Hola! " + userName;
            BackToAdmin.Hide();
            if (GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 3] == "Admin")
            {
                BackToAdmin.Show();
            }
            UserDownButton.Hide();
            if (GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 3] == "User")
            {
                UserDownButton.Show();
            }
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
            TransferBookUserWindow transferBookUserWindow = new TransferBookUserWindow();
            transferBookUserWindow.Show();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainlogIn.Close();
        }
        private void ReturnBookUserButton_Click(object sender, EventArgs e)
        {
            ReturnBookUserWindows returnBookUserWindows = new ReturnBookUserWindows();
            returnBookUserWindows.Show();
        }
        private void DisplayUserLoansButton_Click(object sender, EventArgs e)
        {
            DisplayUserLoanWindow displayUserLoanWindow = new DisplayUserLoanWindow();
            displayUserLoanWindow.Show();
        }
        private void CommentUserButton_Click(object sender, EventArgs e)
        {
            UserMakeaComment userMakeaComment = new UserMakeaComment();
            userMakeaComment.Show();
        }

        private void BackToAdmin_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu(MainlogIn);
            adminMenu.Show();
            this.Close();
        }
    }
}
