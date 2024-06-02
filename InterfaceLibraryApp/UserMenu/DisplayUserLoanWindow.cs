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
    public partial class DisplayUserLoanWindow : Form
    {
        public DisplayUserLoanWindow()
        {
            InitializeComponent();
            LoanVisualizerUser.Rows.Add(GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, 1], GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, 2],
                GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, 3],GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, 4],
                GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, 5], GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, 6],
                GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, 7],GlobalMatrices.loansMatrix[GlobalUserValues.userIndex, 8]);
            MainMethods.WriteToLogs($"El usuario {GlobalUserValues.userIndex} ha visualizado sus prestamos");
        }
    }
}
