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
    public partial class UserMakeaComment : Form
    {
        public UserMakeaComment()
        {
            InitializeComponent();
            this.CommentBox.MinimumSize = new Size(290, 220);
        }

        private void CommentButton_Click(object sender, EventArgs e)
        {
            if (CommentBox.Text == "")
            {
                MessageBox.Show("Por favor, escribe un comentario");
                return;
            }
            else
            {
                string commentID = MainMethods.CreateId(GlobalMatrices.commentsMatrix);
                string userName = GlobalMatrices.usersMatrix[GlobalUserValues.userIndex, 2].Trim();
                string newComment = commentID + "|" + userName + '|' + CommentBox.Text.Trim().Replace('|', '*');
                StreamWriter addComment = File.AppendText(GlobalPaths.commentsPath);
                addComment.WriteLine();
                addComment.Write(newComment);
                addComment.Close();
                MessageBox.Show("Comentario agregado");
                MainMethods.WriteToLogs($"Usuario {GlobalUserValues.ID} agrego un comentario");
                Close();
            }
        }
    }
}
