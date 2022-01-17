using System;
using System.Windows.Forms;

namespace proj_quizgot
{
    public partial class frmP1 : Form
    {
        public frmP1()
        {
            InitializeComponent();
        }

        private void btnProx1_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa resposta!", "Quiz");
                VariaveisGlobais.acertos++;
                frmP2 p2 = new frmP2();
                p2.Show();
                this.Hide();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta incorreta!", "Quiz");
                VariaveisGlobais.erros++;
                frmP2 p2 = new frmP2();
                p2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa!");
            }
        }
    }
}
