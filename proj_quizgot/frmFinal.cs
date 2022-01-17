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
    public partial class frmFinal : Form
    {
        public frmFinal()
        {
            InitializeComponent();
        }

        private void btnConclusao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            lblAcertos.Text = VariaveisGlobais.acertos.ToString();
            lblErros.Text = VariaveisGlobais.erros.ToString();
        }
    }
}
