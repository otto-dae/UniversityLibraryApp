using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceLibraryApp
{
    public partial class RegisterWindow : Form
    {
        Form MainlogIn;
        public RegisterWindow(Form mainlogIn)
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.LOGO_UAQ;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MainlogIn = mainlogIn;
        }

        private void RegisterButtonAccept_Click(object sender, EventArgs e)
        {
            string newId = MainMethods.CreateId(GlobalMatrices.usersMatrix);
            string fullName = FullNameBox.Text.Replace('|', '*');
            string password = PasswordBox.Text.Replace('|', '*');
            string type = "User";
            string newUser = newId + '|' + password + '|' + fullName + '|' + type + '|' + '1';
            string newUserLoan = newId + '|' + "ID" + '|' + "date" + '|' + "ID" + '|' + "date" + '|' + "ID" + '|' + "date" + '|' + "ID" + '|' + "date";
            StreamWriter addUser = File.AppendText(GlobalPaths.usersPath);
            addUser.WriteLine();
            addUser.Write(newUser);
            addUser.Close();

            StreamWriter addLoans = File.AppendText(GlobalPaths.loansPath);
            addLoans.WriteLine();
            addLoans.Write(newUserLoan);
            addLoans.Close();
            Console.WriteLine("Usuario agregado con exito...");

            MessageBox.Show($"Usuario registrado con éxito\n" +
                $"tu id: {newId}");
            this.Close();
            MainlogIn.Show();
        }

        private void BackLogInButton_Click(object sender, EventArgs e)
        {
            MainlogIn.Show();
            this.Close();
        }
    }
}
