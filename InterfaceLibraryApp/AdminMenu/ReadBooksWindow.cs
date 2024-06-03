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
    public partial class ReadBooksWindow : Form
    {
        public ReadBooksWindow()
        {
            InitializeComponent();
            int x = GlobalMatrices.booksMatrix.GetLength(0);    

            for(int i = 0; i < x; i ++)
            {
                ReadBooksGrid.Rows.Add(GlobalMatrices.booksMatrix[i, 0], GlobalMatrices.booksMatrix[i, 2], GlobalMatrices.booksMatrix[i, 3], GlobalMatrices.booksMatrix[i, 1], GlobalMatrices.booksMatrix[i, 4]);
            }
        }
    }
}
