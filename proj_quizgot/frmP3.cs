using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_quizgot
{
    public partial class frmP3 : Form
    {
        public frmP3()
        {
            InitializeComponent();
        }

        private void btnProximo3_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa resposta!", "Quiz");
                VariaveisGlobais.acertos++;
                frmP4 p4 = new frmP4();
                p4.Show();
                this.Hide();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta incorreta!", "Quiz");
                VariaveisGlobais.erros++;
                frmP4 p4 = new frmP4();
                p4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa!");
            }
        }
    }
}
