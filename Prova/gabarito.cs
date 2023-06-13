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
    public partial class gabarito : Form
    {
        public gabarito()
        {
            InitializeComponent();
           

        }

        private void bt_avaliar_Click(object sender, EventArgs e)
        {
            String qa = Convert.ToString(tx_questao1.Text);
            String qb = Convert.ToString(tx_questao2.Text);
            String qc = Convert.ToString(tx_questao3.Text);
            String qd = Convert.ToString(tx_questao4.Text);
            String qe = Convert.ToString(tx_questao5.Text);
            String qf = Convert.ToString(tx_questao6.Text);
            String qg = Convert.ToString(tx_questao7.Text);
            String qh = Convert.ToString(tx_questao8.Text);
            String qi = Convert.ToString(tx_questao9.Text);
            String qj = Convert.ToString(tx_questao10.Text);

            string[] gab = { "A" + "B" + "D" + "E" + "C" + "A" + "A" + "D" + "E" + "B" };

            int soma = 0;

            if (gab[0] == qa)
            {
                soma += 1;
            }
            if (gab[1] == qb)
            {
                soma += 1;
            }
            if (gab[2] == qc)
            {
                soma += 1;
            }
            if (gab[3] == qd)
            {
                soma += 1;
            }
            if (gab[4] == qe)
            {
                soma += 1;
            }
            if (gab[5] == qf)
            {
                soma += 1;
            }
            if (gab[6] == qg)
            {
                soma += 1;
            }
            if (gab[7] == qh)
            {
                soma += 1;
            }
            if (gab[8] == qi)
            {
                soma += 1;
            }
            if (gab[9] == qj)
            {
                soma += 1;
            }

            MessageBox.Show($"Sua nota é {soma.ToString()}/10");
        }
    }
}
