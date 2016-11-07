namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.messageForTheUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.argentDansLePorteMonnaie = new System.Windows.Forms.TextBox();
            this.alcoolDansLeSang = new System.Windows.Forms.TextBox();
            this.heureActuelle = new System.Windows.Forms.TextBox();
            this.poserTable = new System.Windows.Forms.Button();
            this.gratterConso = new System.Windows.Forms.Button();
            this.saucisson = new System.Windows.Forms.PictureBox();
            this.allerAuBar = new System.Windows.Forms.PictureBox();
            this.cocacola = new System.Windows.Forms.PictureBox();
            this.rinceCo = new System.Windows.Forms.PictureBox();
            this.progressBarArgent = new System.Windows.Forms.ProgressBar();
            this.progressBarAlcool = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saucisson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allerAuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cocacola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rinceCo)).BeginInit();
            this.SuspendLayout();
            // 
            // messageForTheUser
            // 
            this.messageForTheUser.Location = new System.Drawing.Point(16, 556);
            this.messageForTheUser.Margin = new System.Windows.Forms.Padding(4);
            this.messageForTheUser.Name = "messageForTheUser";
            this.messageForTheUser.Size = new System.Drawing.Size(513, 22);
            this.messageForTheUser.TabIndex = 4;
            this.messageForTheUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1096, 540);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // argentDansLePorteMonnaie
            // 
            this.argentDansLePorteMonnaie.Location = new System.Drawing.Point(821, 505);
            this.argentDansLePorteMonnaie.Margin = new System.Windows.Forms.Padding(4);
            this.argentDansLePorteMonnaie.Name = "argentDansLePorteMonnaie";
            this.argentDansLePorteMonnaie.Size = new System.Drawing.Size(175, 22);
            this.argentDansLePorteMonnaie.TabIndex = 6;
            this.argentDansLePorteMonnaie.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // alcoolDansLeSang
            // 
            this.alcoolDansLeSang.Location = new System.Drawing.Point(821, 562);
            this.alcoolDansLeSang.Margin = new System.Windows.Forms.Padding(4);
            this.alcoolDansLeSang.Name = "alcoolDansLeSang";
            this.alcoolDansLeSang.Size = new System.Drawing.Size(175, 22);
            this.alcoolDansLeSang.TabIndex = 7;
            this.alcoolDansLeSang.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // heureActuelle
            // 
            this.heureActuelle.Location = new System.Drawing.Point(823, 594);
            this.heureActuelle.Margin = new System.Windows.Forms.Padding(4);
            this.heureActuelle.Name = "heureActuelle";
            this.heureActuelle.Size = new System.Drawing.Size(175, 22);
            this.heureActuelle.TabIndex = 8;
            this.heureActuelle.TextChanged += new System.EventHandler(this.heureActuelle_TextChanged);
            // 
            // poserTable
            // 
            this.poserTable.Location = new System.Drawing.Point(21, 208);
            this.poserTable.Name = "poserTable";
            this.poserTable.Size = new System.Drawing.Size(138, 45);
            this.poserTable.TabIndex = 10;
            this.poserTable.Text = "Se poser à une table";
            this.poserTable.UseVisualStyleBackColor = true;
            this.poserTable.Click += new System.EventHandler(this.poserTable_Click);
            // 
            // gratterConso
            // 
            this.gratterConso.Location = new System.Drawing.Point(16, 382);
            this.gratterConso.Name = "gratterConso";
            this.gratterConso.Size = new System.Drawing.Size(143, 64);
            this.gratterConso.TabIndex = 12;
            this.gratterConso.Text = "Essaye de gratter une conso à un pote";
            this.gratterConso.UseVisualStyleBackColor = true;
            this.gratterConso.Click += new System.EventHandler(this.gratterConso_Click);
            // 
            // saucisson
            // 
            this.saucisson.Image = ((System.Drawing.Image)(resources.GetObject("saucisson.Image")));
            this.saucisson.Location = new System.Drawing.Point(25, 273);
            this.saucisson.Name = "saucisson";
            this.saucisson.Size = new System.Drawing.Size(113, 88);
            this.saucisson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.saucisson.TabIndex = 15;
            this.saucisson.TabStop = false;
            this.saucisson.Click += new System.EventHandler(this.saucisson_Click);
            // 
            // allerAuBar
            // 
            this.allerAuBar.Image = ((System.Drawing.Image)(resources.GetObject("allerAuBar.Image")));
            this.allerAuBar.Location = new System.Drawing.Point(25, 34);
            this.allerAuBar.Name = "allerAuBar";
            this.allerAuBar.Size = new System.Drawing.Size(158, 101);
            this.allerAuBar.TabIndex = 16;
            this.allerAuBar.TabStop = false;
            this.allerAuBar.Click += new System.EventHandler(this.allerAuBar_Click);
            // 
            // cocacola
            // 
            this.cocacola.Image = ((System.Drawing.Image)(resources.GetObject("cocacola.Image")));
            this.cocacola.Location = new System.Drawing.Point(285, 34);
            this.cocacola.Name = "cocacola";
            this.cocacola.Size = new System.Drawing.Size(104, 101);
            this.cocacola.TabIndex = 17;
            this.cocacola.TabStop = false;
            this.cocacola.Visible = false;
            this.cocacola.Click += new System.EventHandler(this.cocacola_Click);
            // 
            // rinceCo
            // 
            this.rinceCo.Image = ((System.Drawing.Image)(resources.GetObject("rinceCo.Image")));
            this.rinceCo.Location = new System.Drawing.Point(303, 180);
            this.rinceCo.Name = "rinceCo";
            this.rinceCo.Size = new System.Drawing.Size(140, 221);
            this.rinceCo.TabIndex = 18;
            this.rinceCo.TabStop = false;
            this.rinceCo.Visible = false;
            this.rinceCo.Click += new System.EventHandler(this.rinceCo_Click);
            // 
            // progressBarArgent
            // 
            this.progressBarArgent.Location = new System.Drawing.Point(821, 474);
            this.progressBarArgent.Name = "progressBarArgent";
            this.progressBarArgent.Size = new System.Drawing.Size(175, 24);
            this.progressBarArgent.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarArgent.TabIndex = 19;
            this.progressBarArgent.Click += new System.EventHandler(this.progressBarArgent_Click);
            // 
            // progressBarAlcool
            // 
            this.progressBarAlcool.Location = new System.Drawing.Point(821, 535);
            this.progressBarAlcool.Name = "progressBarAlcool";
            this.progressBarAlcool.Size = new System.Drawing.Size(175, 23);
            this.progressBarAlcool.TabIndex = 20;
            this.progressBarAlcool.Click += new System.EventHandler(this.progressBarAlcool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 642);
            this.Controls.Add(this.progressBarAlcool);
            this.Controls.Add(this.progressBarArgent);
            this.Controls.Add(this.rinceCo);
            this.Controls.Add(this.cocacola);
            this.Controls.Add(this.allerAuBar);
            this.Controls.Add(this.saucisson);
            this.Controls.Add(this.gratterConso);
            this.Controls.Add(this.poserTable);
            this.Controls.Add(this.heureActuelle);
            this.Controls.Add(this.alcoolDansLeSang);
            this.Controls.Add(this.argentDansLePorteMonnaie);
            this.Controls.Add(this.messageForTheUser);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saucisson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allerAuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cocacola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rinceCo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox messageForTheUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox argentDansLePorteMonnaie;
        private System.Windows.Forms.TextBox alcoolDansLeSang;
        private System.Windows.Forms.TextBox heureActuelle;
        private System.Windows.Forms.Button poserTable;
        private System.Windows.Forms.Button gratterConso;
        private System.Windows.Forms.PictureBox saucisson;
        private System.Windows.Forms.PictureBox allerAuBar;
        private System.Windows.Forms.PictureBox cocacola;
        private System.Windows.Forms.PictureBox rinceCo;
        private System.Windows.Forms.ProgressBar progressBarArgent;
        private System.Windows.Forms.ProgressBar progressBarAlcool;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

