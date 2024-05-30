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
        public RegisterWindow()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.LOGO_UAQ;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void RegisterButtonAccept_Click(object sender, EventArgs e)
        {
            string newId = MainMethods.CreateId(GlobalMatrices.usersMatrix);
            string fullName = FullNameBox.Text;
            string password = PasswordBox.Text;
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
            Login login = new Login();
            login.Show();
        }
    }
}
