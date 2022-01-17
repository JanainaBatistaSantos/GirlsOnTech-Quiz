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
    public partial class frmP4 : Form
    {
        public frmP4()
        {
            InitializeComponent();
        }

        private void btnProx4_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa resposta!", "Quiz");
                VariaveisGlobais.acertos++;
                frmP5 p5 = new frmP5();
                p5.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton1.Checked)
            {
                MessageBox.Show("Resposta incorreta!", "Quiz");
                VariaveisGlobais.erros++;
                frmP5 p5 = new frmP5();
                p5.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa!");
            }
        }
    }
}
