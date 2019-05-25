namespace Teste_BancoSemar
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnTabInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbControlesConversor = new System.Windows.Forms.TabControl();
            this.tbInfo = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbCaracteresNumero = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConversor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtconversaocaracteres = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcaracteres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbControlesConversor.SuspendLayout();
            this.tbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tbCaracteresNumero.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSobre);
            this.splitContainer1.Panel1.Controls.Add(this.btnConverter);
            this.splitContainer1.Panel1.Controls.Add(this.btnTabInfo);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbControlesConversor);
            this.splitContainer1.Size = new System.Drawing.Size(1162, 576);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSobre
            // 
            this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.Location = new System.Drawing.Point(36, 509);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(209, 44);
            this.btnSobre.TabIndex = 3;
            this.btnSobre.Text = "Sobre o Conversor";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(36, 296);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(209, 44);
            this.btnConverter.TabIndex = 1;
            this.btnConverter.Text = "Conversão de Caracteres \r\npara Número";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.BtnConverter_Click);
            // 
            // btnTabInfo
            // 
            this.btnTabInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabInfo.Location = new System.Drawing.Point(36, 226);
            this.btnTabInfo.Name = "btnTabInfo";
            this.btnTabInfo.Size = new System.Drawing.Size(209, 44);
            this.btnTabInfo.TabIndex = 0;
            this.btnTabInfo.Text = "Informações";
            this.btnTabInfo.UseVisualStyleBackColor = true;
            this.btnTabInfo.Click += new System.EventHandler(this.BtnTabInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Teste_BancoSemar.Properties.Resources.stars;
            this.pictureBox1.Location = new System.Drawing.Point(101, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbControlesConversor
            // 
            this.tbControlesConversor.Controls.Add(this.tbInfo);
            this.tbControlesConversor.Controls.Add(this.tbCaracteresNumero);
            this.tbControlesConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlesConversor.Location = new System.Drawing.Point(3, 3);
            this.tbControlesConversor.Name = "tbControlesConversor";
            this.tbControlesConversor.SelectedIndex = 0;
            this.tbControlesConversor.Size = new System.Drawing.Size(870, 570);
            this.tbControlesConversor.TabIndex = 0;
            // 
            // tbInfo
            // 
            this.tbInfo.Controls.Add(this.label3);
            this.tbInfo.Controls.Add(this.label2);
            this.tbInfo.Controls.Add(this.label1);
            this.tbInfo.Controls.Add(this.pictureBox2);
            this.tbInfo.Location = new System.Drawing.Point(4, 25);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbInfo.Size = new System.Drawing.Size(862, 541);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.Text = "Informações do Conversor";
            this.tbInfo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "I = 1; V = 5; X = 10; L = 50; C = 100; D =500; M = 1000;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(816, 144);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-vindo ao Conversor de Comerciante das Galáxias";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Teste_BancoSemar.Properties.Resources.stars;
            this.pictureBox2.Location = new System.Drawing.Point(761, 451);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tbCaracteresNumero
            // 
            this.tbCaracteresNumero.Controls.Add(this.groupBox3);
            this.tbCaracteresNumero.Controls.Add(this.btnLimpar);
            this.tbCaracteresNumero.Controls.Add(this.btnConversor);
            this.tbCaracteresNumero.Controls.Add(this.label4);
            this.tbCaracteresNumero.Controls.Add(this.groupBox2);
            this.tbCaracteresNumero.Controls.Add(this.groupBox1);
            this.tbCaracteresNumero.Location = new System.Drawing.Point(4, 25);
            this.tbCaracteresNumero.Name = "tbCaracteresNumero";
            this.tbCaracteresNumero.Padding = new System.Windows.Forms.Padding(3);
            this.tbCaracteresNumero.Size = new System.Drawing.Size(862, 541);
            this.tbCaracteresNumero.TabIndex = 1;
            this.tbCaracteresNumero.Text = "Conversor do Comerciante - Caracteres para Números";
            this.tbCaracteresNumero.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblmsg);
            this.groupBox3.Location = new System.Drawing.Point(27, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 50);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status:";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(148, 19);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 16);
            this.lblmsg.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(718, 488);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 31);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnConversor
            // 
            this.btnConversor.Location = new System.Drawing.Point(592, 488);
            this.btnConversor.Name = "btnConversor";
            this.btnConversor.Size = new System.Drawing.Size(112, 31);
            this.btnConversor.TabIndex = 2;
            this.btnConversor.Text = "Converter";
            this.btnConversor.UseVisualStyleBackColor = true;
            this.btnConversor.Click += new System.EventHandler(this.BtnConversor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Conversor de Caracteres para os Números";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtconversaocaracteres);
            this.groupBox2.Location = new System.Drawing.Point(27, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 140);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadeia Convertida.:";
            // 
            // txtconversaocaracteres
            // 
            this.txtconversaocaracteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtconversaocaracteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconversaocaracteres.Location = new System.Drawing.Point(48, 54);
            this.txtconversaocaracteres.Multiline = true;
            this.txtconversaocaracteres.Name = "txtconversaocaracteres";
            this.txtconversaocaracteres.Size = new System.Drawing.Size(696, 38);
            this.txtconversaocaracteres.TabIndex = 0;
            this.txtconversaocaracteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcaracteres);
            this.groupBox1.Location = new System.Drawing.Point(27, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadeia de Caracteres.:";
            // 
            // txtcaracteres
            // 
            this.txtcaracteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcaracteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaracteres.Location = new System.Drawing.Point(48, 51);
            this.txtcaracteres.Multiline = true;
            this.txtcaracteres.Name = "txtcaracteres";
            this.txtcaracteres.Size = new System.Drawing.Size(696, 38);
            this.txtcaracteres.TabIndex = 0;
            this.txtcaracteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcaracteres.TextChanged += new System.EventHandler(this.Txtcaracteres_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 576);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor do Comerciante das Galáxias v.1.0";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbControlesConversor.ResumeLayout(false);
            this.tbInfo.ResumeLayout(false);
            this.tbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tbCaracteresNumero.ResumeLayout(false);
            this.tbCaracteresNumero.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnTabInfo;
        private System.Windows.Forms.TabControl tbControlesConversor;
        private System.Windows.Forms.TabPage tbInfo;
        private System.Windows.Forms.TabPage tbCaracteresNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConversor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtconversaocaracteres;
        private System.Windows.Forms.TextBox txtcaracteres;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblmsg;
    }
}

