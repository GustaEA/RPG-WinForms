
namespace RPG
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtMobAtrDFS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMobAtrATK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVidaMob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNivelMob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeMob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarMob = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnRolarDados = new System.Windows.Forms.Button();
            this.lblResDado = new System.Windows.Forms.Label();
            this.txtResDado = new System.Windows.Forms.TextBox();
            this.lblTipoDado = new System.Windows.Forms.Label();
            this.tipoDado = new System.Windows.Forms.ComboBox();
            this.lblQtdDado = new System.Windows.Forms.Label();
            this.qtdDado = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnVida = new System.Windows.Forms.Button();
            this.btnDano = new System.Windows.Forms.Button();
            this.txtD20 = new System.Windows.Forms.TextBox();
            this.btnD20 = new System.Windows.Forms.Button();
            this.txtModD20 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResD20 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnD20Dfs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtdDado)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.txtMobAtrDFS);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtMobAtrATK);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtVidaMob);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtNivelMob);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtNomeMob);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCriarMob);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(584, 461);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtMobAtrDFS
            // 
            this.txtMobAtrDFS.Location = new System.Drawing.Point(74, 420);
            this.txtMobAtrDFS.Name = "txtMobAtrDFS";
            this.txtMobAtrDFS.Size = new System.Drawing.Size(31, 20);
            this.txtMobAtrDFS.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Atr. de DFS:";
            // 
            // txtMobAtrATK
            // 
            this.txtMobAtrATK.Location = new System.Drawing.Point(74, 390);
            this.txtMobAtrATK.Name = "txtMobAtrATK";
            this.txtMobAtrATK.Size = new System.Drawing.Size(31, 20);
            this.txtMobAtrATK.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Atr. de ATK:";
            // 
            // txtVidaMob
            // 
            this.txtVidaMob.Location = new System.Drawing.Point(47, 356);
            this.txtVidaMob.Name = "txtVidaMob";
            this.txtVidaMob.Size = new System.Drawing.Size(38, 20);
            this.txtVidaMob.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vida:";
            // 
            // txtNivelMob
            // 
            this.txtNivelMob.Location = new System.Drawing.Point(47, 330);
            this.txtNivelMob.Name = "txtNivelMob";
            this.txtNivelMob.Size = new System.Drawing.Size(38, 20);
            this.txtNivelMob.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nível:";
            // 
            // txtNomeMob
            // 
            this.txtNomeMob.Location = new System.Drawing.Point(47, 303);
            this.txtNomeMob.Name = "txtNomeMob";
            this.txtNomeMob.Size = new System.Drawing.Size(100, 20);
            this.txtNomeMob.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // btnCriarMob
            // 
            this.btnCriarMob.Location = new System.Drawing.Point(56, 265);
            this.btnCriarMob.Name = "btnCriarMob";
            this.btnCriarMob.Size = new System.Drawing.Size(75, 23);
            this.btnCriarMob.TabIndex = 0;
            this.btnCriarMob.Text = "Criar Mob";
            this.btnCriarMob.UseVisualStyleBackColor = true;
            this.btnCriarMob.Click += new System.EventHandler(this.CriarMob);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnD20Dfs);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.txtResD20);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.txtModD20);
            this.splitContainer2.Panel2.Controls.Add(this.btnD20);
            this.splitContainer2.Panel2.Controls.Add(this.txtD20);
            this.splitContainer2.Panel2.Controls.Add(this.btnRolarDados);
            this.splitContainer2.Panel2.Controls.Add(this.lblResDado);
            this.splitContainer2.Panel2.Controls.Add(this.txtResDado);
            this.splitContainer2.Panel2.Controls.Add(this.lblTipoDado);
            this.splitContainer2.Panel2.Controls.Add(this.tipoDado);
            this.splitContainer2.Panel2.Controls.Add(this.lblQtdDado);
            this.splitContainer2.Panel2.Controls.Add(this.qtdDado);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.txtValor);
            this.splitContainer2.Panel2.Controls.Add(this.btnVida);
            this.splitContainer2.Panel2.Controls.Add(this.btnDano);
            this.splitContainer2.Size = new System.Drawing.Size(387, 461);
            this.splitContainer2.SplitterDistance = 291;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(382, 283);
            this.tabControl1.TabIndex = 0;
            // 
            // btnRolarDados
            // 
            this.btnRolarDados.Location = new System.Drawing.Point(299, 95);
            this.btnRolarDados.Name = "btnRolarDados";
            this.btnRolarDados.Size = new System.Drawing.Size(75, 23);
            this.btnRolarDados.TabIndex = 10;
            this.btnRolarDados.Text = "Rolar dados";
            this.btnRolarDados.UseVisualStyleBackColor = true;
            this.btnRolarDados.Click += new System.EventHandler(this.RolarDados);
            // 
            // lblResDado
            // 
            this.lblResDado.AutoSize = true;
            this.lblResDado.Location = new System.Drawing.Point(262, 76);
            this.lblResDado.Name = "lblResDado";
            this.lblResDado.Size = new System.Drawing.Size(59, 13);
            this.lblResDado.TabIndex = 9;
            this.lblResDado.Text = "Res. dado:";
            // 
            // txtResDado
            // 
            this.txtResDado.Location = new System.Drawing.Point(327, 69);
            this.txtResDado.Name = "txtResDado";
            this.txtResDado.ReadOnly = true;
            this.txtResDado.Size = new System.Drawing.Size(47, 20);
            this.txtResDado.TabIndex = 8;
            // 
            // lblTipoDado
            // 
            this.lblTipoDado.AutoSize = true;
            this.lblTipoDado.Location = new System.Drawing.Point(285, 48);
            this.lblTipoDado.Name = "lblTipoDado";
            this.lblTipoDado.Size = new System.Drawing.Size(36, 13);
            this.lblTipoDado.TabIndex = 7;
            this.lblTipoDado.Text = "Dado:";
            // 
            // tipoDado
            // 
            this.tipoDado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDado.Items.AddRange(new object[] {
            "d4",
            "d6",
            "d10",
            "d12",
            "d20"});
            this.tipoDado.Location = new System.Drawing.Point(327, 41);
            this.tipoDado.Name = "tipoDado";
            this.tipoDado.Size = new System.Drawing.Size(47, 21);
            this.tipoDado.TabIndex = 6;
            // 
            // lblQtdDado
            // 
            this.lblQtdDado.AutoSize = true;
            this.lblQtdDado.Location = new System.Drawing.Point(253, 22);
            this.lblQtdDado.Name = "lblQtdDado";
            this.lblQtdDado.Size = new System.Drawing.Size(77, 13);
            this.lblQtdDado.TabIndex = 5;
            this.lblQtdDado.Text = "Qtd. de dados:";
            // 
            // qtdDado
            // 
            this.qtdDado.Location = new System.Drawing.Point(336, 15);
            this.qtdDado.Name = "qtdDado";
            this.qtdDado.Size = new System.Drawing.Size(38, 20);
            this.qtdDado.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(52, 12);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(75, 20);
            this.txtValor.TabIndex = 2;
            // 
            // btnVida
            // 
            this.btnVida.Location = new System.Drawing.Point(52, 66);
            this.btnVida.Name = "btnVida";
            this.btnVida.Size = new System.Drawing.Size(75, 23);
            this.btnVida.TabIndex = 1;
            this.btnVida.Text = "Add vida";
            this.btnVida.UseVisualStyleBackColor = true;
            this.btnVida.Click += new System.EventHandler(this.AddVida);
            // 
            // btnDano
            // 
            this.btnDano.Location = new System.Drawing.Point(52, 38);
            this.btnDano.Name = "btnDano";
            this.btnDano.Size = new System.Drawing.Size(75, 23);
            this.btnDano.TabIndex = 0;
            this.btnDano.Text = "Dar dano";
            this.btnDano.UseVisualStyleBackColor = true;
            this.btnDano.Click += new System.EventHandler(this.DarDano);
            // 
            // txtD20
            // 
            this.txtD20.Location = new System.Drawing.Point(12, 112);
            this.txtD20.Name = "txtD20";
            this.txtD20.Size = new System.Drawing.Size(31, 20);
            this.txtD20.TabIndex = 11;
            // 
            // btnD20
            // 
            this.btnD20.Location = new System.Drawing.Point(12, 135);
            this.btnD20.Name = "btnD20";
            this.btnD20.Size = new System.Drawing.Size(62, 23);
            this.btnD20.TabIndex = 12;
            this.btnD20.Text = "D20 ATK";
            this.btnD20.UseVisualStyleBackColor = true;
            this.btnD20.Click += new System.EventHandler(this.JogadaATK);
            // 
            // txtModD20
            // 
            this.txtModD20.Location = new System.Drawing.Point(68, 112);
            this.txtModD20.Name = "txtModD20";
            this.txtModD20.Size = new System.Drawing.Size(31, 20);
            this.txtModD20.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "+";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "=";
            // 
            // txtResD20
            // 
            this.txtResD20.Location = new System.Drawing.Point(124, 112);
            this.txtResD20.Name = "txtResD20";
            this.txtResD20.Size = new System.Drawing.Size(31, 20);
            this.txtResD20.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "d20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "mod";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(126, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Res:";
            // 
            // btnD20Dfs
            // 
            this.btnD20Dfs.Location = new System.Drawing.Point(80, 135);
            this.btnD20Dfs.Name = "btnD20Dfs";
            this.btnD20Dfs.Size = new System.Drawing.Size(62, 23);
            this.btnD20Dfs.TabIndex = 20;
            this.btnD20Dfs.Text = "D20 DFS";
            this.btnD20Dfs.UseVisualStyleBackColor = true;
            this.btnD20Dfs.Click += new System.EventHandler(this.JogadaDFS);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qtdDado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnCriarMob;
        private System.Windows.Forms.TextBox txtNomeMob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMobAtrDFS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMobAtrATK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVidaMob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNivelMob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnVida;
        private System.Windows.Forms.Button btnDano;
        private System.Windows.Forms.Label lblQtdDado;
        private System.Windows.Forms.NumericUpDown qtdDado;
        private System.Windows.Forms.ComboBox tipoDado;
        private System.Windows.Forms.Label lblTipoDado;
        private System.Windows.Forms.Label lblResDado;
        private System.Windows.Forms.TextBox txtResDado;
        private System.Windows.Forms.Button btnRolarDados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResD20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModD20;
        private System.Windows.Forms.Button btnD20;
        private System.Windows.Forms.TextBox txtD20;
        private System.Windows.Forms.Button btnD20Dfs;
    }
}

