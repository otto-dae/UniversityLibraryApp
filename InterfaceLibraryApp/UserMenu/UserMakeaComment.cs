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
            }
            else
            {
                string newComment = GlobalUserValues.ID + "|" + CommentBox.Text;
                StreamWriter addComment = File.AppendText(GlobalPaths.commentsPath);
                addComment.WriteLine(newComment);
                addComment.Close();
                MessageBox.Show("Comentario agregado");
                this.Close();
            }
        }
    }
}
