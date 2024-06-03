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
    public partial class ReadUsersWindow : Form
    {
        public ReadUsersWindow()
        {
            InitializeComponent();
            int x = GlobalMatrices.usersMatrix.GetLength(0);

            for(int i = 0; i < x; i++)
            {
                ReadUsersGrid.Rows.Add(GlobalMatrices.usersMatrix[i, 0], GlobalMatrices.usersMatrix[i, 1], GlobalMatrices.usersMatrix[i, 2], GlobalMatrices.usersMatrix[i, 3], GlobalMatrices.usersMatrix[i, 4]);
            }
        }
    }
}
