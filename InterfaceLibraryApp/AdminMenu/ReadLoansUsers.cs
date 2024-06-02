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
    public partial class ReadLoansUsers : Form
    {
        public ReadLoansUsers()
        {
            InitializeComponent();
            int x = GlobalMatrices.loansMatrix.GetLength(0);
            for (int i = 0; i < x; i++)
            {
                LoanVisualizerUser.Rows.Add(GlobalMatrices.loansMatrix[i, 0],
                GlobalMatrices.loansMatrix[i, 1], GlobalMatrices.loansMatrix[i, 2],
                GlobalMatrices.loansMatrix[i, 3], GlobalMatrices.loansMatrix[i, 4],
                GlobalMatrices.loansMatrix[i, 5], GlobalMatrices.loansMatrix[i, 6],
                GlobalMatrices.loansMatrix[i, 7], GlobalMatrices.loansMatrix[i, 8]);
            }
            MainMethods.WriteToLogs("Se ha leido la informacion de los prestamos de los usuarios");
        }
    }
}
