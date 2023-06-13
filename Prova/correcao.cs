using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class correcao : Form
    {
        public correcao()
        {
            InitializeComponent();
        }

        private void bt_correcao_Click(object sender, EventArgs e)
        {
            gabarito gab = new gabarito();
            gab.ShowDialog();
        }
    }
}
