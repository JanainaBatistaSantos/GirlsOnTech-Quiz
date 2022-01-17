
namespace proj_quizgot
{
    partial class frmP1
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
            this.lblPergunta1 = new System.Windows.Forms.Label();
            this.gbxPergunta1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtnCerta = new System.Windows.Forms.RadioButton();
            this.btnProx1 = new System.Windows.Forms.Button();
            this.gbxPergunta1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPergunta1
            // 
            this.lblPergunta1.AutoSize = true;
            this.lblPergunta1.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta1.ForeColor = System.Drawing.Color.Purple;
            this.lblPergunta1.Location = new System.Drawing.Point(428, 9);
            this.lblPergunta1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPergunta1.Name = "lblPergunta1";
            this.lblPergunta1.Size = new System.Drawing.Size(176, 33);
            this.lblPergunta1.TabIndex = 0;
            this.lblPergunta1.Text = "Questão 1";
            this.lblPergunta1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbxPergunta1
            // 
            this.gbxPergunta1.Controls.Add(this.radioButton4);
            this.gbxPergunta1.Controls.Add(this.radioButton3);
            this.gbxPergunta1.Controls.Add(this.radioButton2);
            this.gbxPergunta1.Controls.Add(this.rbtnCerta);
            this.gbxPergunta1.Location = new System.Drawing.Point(32, 67);
            this.gbxPergunta1.Margin = new System.Windows.Forms.Padding(6);
            this.gbxPergunta1.Name = "gbxPergunta1";
            this.gbxPergunta1.Padding = new System.Windows.Forms.Padding(6);
            this.gbxPergunta1.Size = new System.Drawing.Size(937, 408);
            this.gbxPergunta1.TabIndex = 1;
            this.gbxPergunta1.TabStop = false;
            this.gbxPergunta1.Text = "O que são arrays?";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(60, 300);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(1026, 66);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "São formas de estruturar ou organizar dados na memória RAM do computador, de \r\nmo" +
    "do que você possa utilizar estes dados de uma forma mais eficiente.";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(60, 226);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(678, 35);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Trata-se de uma forma de planejamento do algoritmo.";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(60, 137);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(856, 66);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "São variáveis específicas para armazenamento de números inteiros.\r\n\r\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbtnCerta
            // 
            this.rbtnCerta.AutoSize = true;
            this.rbtnCerta.Location = new System.Drawing.Point(60, 49);
            this.rbtnCerta.Name = "rbtnCerta";
            this.rbtnCerta.Size = new System.Drawing.Size(1045, 66);
            this.rbtnCerta.TabIndex = 1;
            this.rbtnCerta.TabStop = true;
            this.rbtnCerta.Text = "São estruturas de dados homogêneas que possibilitam o armazenamento de grupos\r\nde" +
    " valores do mesmo tipo, em uma única variável.\r\n";
            this.rbtnCerta.UseVisualStyleBackColor = true;
            // 
            // btnProx1
            // 
            this.btnProx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProx1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProx1.ForeColor = System.Drawing.Color.Purple;
            this.btnProx1.Location = new System.Drawing.Point(804, 503);
            this.btnProx1.Margin = new System.Windows.Forms.Padding(6);
            this.btnProx1.Name = "btnProx1";
            this.btnProx1.Size = new System.Drawing.Size(165, 41);
            this.btnProx1.TabIndex = 0;
            this.btnProx1.Text = "Próximo";
            this.btnProx1.UseVisualStyleBackColor = true;
            this.btnProx1.Click += new System.EventHandler(this.btnProx1_Click);
            // 
            // frmP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1000, 574);
            this.Controls.Add(this.btnProx1);
            this.Controls.Add(this.gbxPergunta1);
            this.Controls.Add(this.lblPergunta1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1000, 574);
            this.MinimumSize = new System.Drawing.Size(1000, 574);
            this.Name = "frmP1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 1";
            this.gbxPergunta1.ResumeLayout(false);
            this.gbxPergunta1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta1;
        private System.Windows.Forms.GroupBox gbxPergunta1;
        private System.Windows.Forms.Button btnProx1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtnCerta;
    }
}