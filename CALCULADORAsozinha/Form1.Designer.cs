
namespace CALCULADORAsozinha
{
    partial class test1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtlabel1 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.btnexibir = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblmen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtlabel1
            // 
            this.txtlabel1.AutoSize = true;
            this.txtlabel1.BackColor = System.Drawing.Color.Olive;
            this.txtlabel1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlabel1.ForeColor = System.Drawing.Color.Red;
            this.txtlabel1.Location = new System.Drawing.Point(63, 50);
            this.txtlabel1.Name = "txtlabel1";
            this.txtlabel1.Size = new System.Drawing.Size(83, 27);
            this.txtlabel1.TabIndex = 0;
            this.txtlabel1.Text = "NOME:";
            // 
            // txtbox1
            // 
            this.txtbox1.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox1.Location = new System.Drawing.Point(171, 52);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(320, 30);
            this.txtbox1.TabIndex = 1;
            this.txtbox1.TextChanged += new System.EventHandler(this.txtbox1_TextChanged);
            // 
            // btnexibir
            // 
            this.btnexibir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnexibir.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexibir.ForeColor = System.Drawing.Color.Yellow;
            this.btnexibir.Location = new System.Drawing.Point(113, 325);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(104, 37);
            this.btnexibir.TabIndex = 2;
            this.btnexibir.Text = "EXIBIR";
            this.btnexibir.UseVisualStyleBackColor = false;
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlimpar.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.Color.Yellow;
            this.btnlimpar.Location = new System.Drawing.Point(255, 326);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(111, 35);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "LIMPAR";
            this.btnlimpar.UseVisualStyleBackColor = false;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsair.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.Yellow;
            this.btnsair.Location = new System.Drawing.Point(400, 326);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(112, 35);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = false;
            // 
            // lblmen
            // 
            this.lblmen.AutoSize = true;
            this.lblmen.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmen.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblmen.Location = new System.Drawing.Point(125, 144);
            this.lblmen.Name = "lblmen";
            this.lblmen.Size = new System.Drawing.Size(0, 25);
            this.lblmen.TabIndex = 5;
            this.lblmen.Click += new System.EventHandler(this.label1_Click);
            // 
            // test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmen);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.txtlabel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "test1";
            this.Text = "CALCULADORAsozinha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtlabel1;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblmen;
    }
}

