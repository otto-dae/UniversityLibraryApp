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
    public partial class ReadCommentsWindow : Form
    {
        public ReadCommentsWindow()
        {
            InitializeComponent();
            int x = GlobalMatrices.commentsMatrix.GetLength(0);

            for (int i = 0; i < x; i++)
            {
                ViewComments.Rows.Add(GlobalMatrices.commentsMatrix[i, 0], GlobalMatrices.commentsMatrix[i, 1], GlobalMatrices.commentsMatrix[i, 2]);
            }
            MainMethods.WriteToLogs("Se han leido los comentarios");
        }
    }
}
