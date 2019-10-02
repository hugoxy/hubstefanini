namespace hub_stefanini_1
{
    partial class TelaZero
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.Label();
            this.labelCopy = new System.Windows.Forms.Label();
            this.lbSoc = new System.Windows.Forms.Label();
            this.pcTwt = new System.Windows.Forms.PictureBox();
            this.pcLink = new System.Windows.Forms.PictureBox();
            this.pcYou = new System.Windows.Forms.PictureBox();
            this.pcFace = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcTwt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcYou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.textBox1.Location = new System.Drawing.Point(73, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "00:00:00";
            // 
            // labelCopy
            // 
            this.labelCopy.AutoSize = true;
            this.labelCopy.BackColor = System.Drawing.SystemColors.Control;
            this.labelCopy.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelCopy.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.labelCopy.Location = new System.Drawing.Point(216, 4);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(182, 15);
            this.labelCopy.TabIndex = 4;
            this.labelCopy.Text = "Copyright © 2019 by Victor Gontijo";
            this.labelCopy.Click += new System.EventHandler(this.labelCopy_Click);
            // 
            // lbSoc
            // 
            this.lbSoc.AutoSize = true;
            this.lbSoc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.lbSoc.Location = new System.Drawing.Point(47, 573);
            this.lbSoc.Name = "lbSoc";
            this.lbSoc.Size = new System.Drawing.Size(91, 17);
            this.lbSoc.TabIndex = 9;
            this.lbSoc.Text = "Social Medias";
            // 
            // pcTwt
            // 
            this.pcTwt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.pcTwt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcTwt.Image = global::hub_stefanini_1.Properties.Resources.twt;
            this.pcTwt.Location = new System.Drawing.Point(122, 593);
            this.pcTwt.Name = "pcTwt";
            this.pcTwt.Size = new System.Drawing.Size(24, 24);
            this.pcTwt.TabIndex = 8;
            this.pcTwt.TabStop = false;
            this.pcTwt.Click += new System.EventHandler(this.pcTwt_Click);
            // 
            // pcLink
            // 
            this.pcLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.pcLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcLink.Image = global::hub_stefanini_1.Properties.Resources.linkd2;
            this.pcLink.Location = new System.Drawing.Point(62, 593);
            this.pcLink.Name = "pcLink";
            this.pcLink.Size = new System.Drawing.Size(24, 24);
            this.pcLink.TabIndex = 7;
            this.pcLink.TabStop = false;
            this.pcLink.Click += new System.EventHandler(this.pcLink_Click);
            // 
            // pcYou
            // 
            this.pcYou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.pcYou.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcYou.Image = global::hub_stefanini_1.Properties.Resources.yb;
            this.pcYou.Location = new System.Drawing.Point(92, 593);
            this.pcYou.Name = "pcYou";
            this.pcYou.Size = new System.Drawing.Size(24, 24);
            this.pcYou.TabIndex = 6;
            this.pcYou.TabStop = false;
            this.pcYou.Click += new System.EventHandler(this.pcYou_Click);
            // 
            // pcFace
            // 
            this.pcFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(162)))));
            this.pcFace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcFace.Image = global::hub_stefanini_1.Properties.Resources.face;
            this.pcFace.Location = new System.Drawing.Point(32, 593);
            this.pcFace.Name = "pcFace";
            this.pcFace.Size = new System.Drawing.Size(24, 24);
            this.pcFace.TabIndex = 5;
            this.pcFace.TabStop = false;
            this.pcFace.Click += new System.EventHandler(this.pcFace_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::hub_stefanini_1.Properties.Resources.shopiestefan_inventida_EXPANDIDA__editada_a_roupa;
            this.pictureBox2.Location = new System.Drawing.Point(430, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(542, 654);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TelaZero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSoc);
            this.Controls.Add(this.pcTwt);
            this.Controls.Add(this.pcLink);
            this.Controls.Add(this.pcYou);
            this.Controls.Add(this.pcFace);
            this.Controls.Add(this.labelCopy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "TelaZero";
            this.Size = new System.Drawing.Size(954, 651);
            ((System.ComponentModel.ISupportInitialize)(this.pcTwt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcYou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.Label labelCopy;
        private System.Windows.Forms.PictureBox pcFace;
        private System.Windows.Forms.PictureBox pcYou;
        private System.Windows.Forms.PictureBox pcLink;
        private System.Windows.Forms.PictureBox pcTwt;
        private System.Windows.Forms.Label lbSoc;
    }
}
