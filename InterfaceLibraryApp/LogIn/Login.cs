using Microsoft.VisualBasic.ApplicationServices;

namespace InterfaceLibraryApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.LOGO_UAQ;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            textBox2.PasswordChar = '*';
        }
        private void LogInAccept_Click(object sender, EventArgs e)
        {
            GlobalUserValues.ID = textBox1.Text;
            GlobalUserValues.password = textBox2.Text;
            GlobalMatrices.usersMatrix = MainMethods.CreateMatrix(GlobalPaths.usersPath);
            GlobalUserValues.userIndex = MainMethods.FindID(GlobalMatrices.usersMatrix, GlobalUserValues.ID);
            LogIn();
        }
        private void LogIn()
        {
            while (GlobalUserValues.userIndex == -1 || GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 1] != GlobalUserValues.password)
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }
            if (GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 4] == "0")
            {
                MessageBox.Show("Favor de comunicarse con un administrador para reactivar su cuenta");
                Application.Exit();
            }
            if (GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 3] == "Admin" && GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 1] == GlobalUserValues.password)
            {
                this.Hide();
                AdminMenu adminWindow = new AdminMenu(this);
                adminWindow.Show();
            }
            if (GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 3] == "User" && GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 1] == GlobalUserValues.password)
            {
                this.Hide();
                UserMenu userWindow = new UserMenu(this);
                userWindow.Show();
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterWindow registerWindow = new RegisterWindow(this);
            registerWindow.Show();
        }
        private void ExitButtonLogIn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
