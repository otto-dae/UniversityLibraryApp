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
    public partial class ReadLogsWindow : Form
    {
        public ReadLogsWindow()
        {
            InitializeComponent();

            int x = GlobalMatrices.logsMatrix.GetLength(0);

            for(int i = 0; i < x; i++)
            {
                LogsView.Rows.Add(GlobalMatrices.logsMatrix[i, 0], GlobalMatrices.logsMatrix[i, 1], GlobalMatrices.logsMatrix[i, 2]);
            }
        }
    }
}
