
namespace proj_quizgot
{
    partial class frmFinal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConclusao = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.btnConclusao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConclusao
            // 
            this.lblConclusao.AutoSize = true;
            this.lblConclusao.BackColor = System.Drawing.Color.BlueViolet;
            this.lblConclusao.Font = new System.Drawing.Font("Perpetua Titling MT", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConclusao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblConclusao.Location = new System.Drawing.Point(251, 65);
            this.lblConclusao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConclusao.Name = "lblConclusao";
            this.lblConclusao.Size = new System.Drawing.Size(606, 52);
            this.lblConclusao.TabIndex = 7;
            this.lblConclusao.Text = "Você concluiu o Quiz!";
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcertos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAcertos.Location = new System.Drawing.Point(281, 233);
            this.lblAcertos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(127, 32);
            this.lblAcertos.TabIndex = 1;
            this.lblAcertos.Text = "Acertos:";
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblErros.Location = new System.Drawing.Point(281, 330);
            this.lblErros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(96, 32);
            this.lblErros.TabIndex = 2;
            this.lblErros.Text = "Erros:";
            // 
            // btnConclusao
            // 
            this.btnConclusao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConclusao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConclusao.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConclusao.ForeColor = System.Drawing.Color.Purple;
            this.btnConclusao.Location = new System.Drawing.Point(449, 474);
            this.btnConclusao.Margin = new System.Windows.Forms.Padding(4);
            this.btnConclusao.Name = "btnConclusao";
            this.btnConclusao.Size = new System.Drawing.Size(213, 50);
            this.btnConclusao.TabIndex = 0;
            this.btnConclusao.Text = "Fechar";
            this.btnConclusao.UseVisualStyleBackColor = false;
            this.btnConclusao.Click += new System.EventHandler(this.btnConclusao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(411, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Acertos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(411, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Erros";
            // 
            // frmFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1082, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConclusao);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.lblAcertos);
            this.Controls.Add(this.lblConclusao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1082, 591);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "frmFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.frmFinal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConclusao;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Button btnConclusao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}