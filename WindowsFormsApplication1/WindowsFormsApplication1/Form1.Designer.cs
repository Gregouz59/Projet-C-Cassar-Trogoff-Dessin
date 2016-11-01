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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.messageForTheUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boiteAlcool = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.boire = new System.Windows.Forms.Button();
            this.poserTable = new System.Windows.Forms.Button();
            this.saucission = new System.Windows.Forms.Button();
            this.gratterConso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 588);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Allez au bar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 588);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Allez danser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 588);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Allez à une table";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(821, 530);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // boiteAlcool
            // 
            this.boiteAlcool.Location = new System.Drawing.Point(821, 562);
            this.boiteAlcool.Margin = new System.Windows.Forms.Padding(4);
            this.boiteAlcool.Name = "boiteAlcool";
            this.boiteAlcool.Size = new System.Drawing.Size(175, 22);
            this.boiteAlcool.TabIndex = 7;
            this.boiteAlcool.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(823, 594);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 22);
            this.textBox4.TabIndex = 8;
            // 
            // boire
            // 
            this.boire.Location = new System.Drawing.Point(16, 36);
            this.boire.Name = "boire";
            this.boire.Size = new System.Drawing.Size(138, 44);
            this.boire.TabIndex = 9;
            this.boire.Text = "Boire un coup";
            this.boire.UseVisualStyleBackColor = true;
            this.boire.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // poserTable
            // 
            this.poserTable.Location = new System.Drawing.Point(16, 109);
            this.poserTable.Name = "poserTable";
            this.poserTable.Size = new System.Drawing.Size(138, 45);
            this.poserTable.TabIndex = 10;
            this.poserTable.Text = "Se poser à une table";
            this.poserTable.UseVisualStyleBackColor = true;
            this.poserTable.Click += new System.EventHandler(this.poserTable_Click);
            // 
            // saucission
            // 
            this.saucission.Location = new System.Drawing.Point(16, 176);
            this.saucission.Name = "saucission";
            this.saucission.Size = new System.Drawing.Size(154, 43);
            this.saucission.TabIndex = 11;
            this.saucission.Text = "Acheter un saucisson";
            this.saucission.UseVisualStyleBackColor = true;
            this.saucission.Click += new System.EventHandler(this.saucission_Click);
            // 
            // gratterConso
            // 
            this.gratterConso.Location = new System.Drawing.Point(16, 238);
            this.gratterConso.Name = "gratterConso";
            this.gratterConso.Size = new System.Drawing.Size(143, 64);
            this.gratterConso.TabIndex = 12;
            this.gratterConso.Text = "Essaye de gratter une conso à un pote";
            this.gratterConso.UseVisualStyleBackColor = true;
            this.gratterConso.Click += new System.EventHandler(this.gratterConso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 642);
            this.Controls.Add(this.gratterConso);
            this.Controls.Add(this.saucission);
            this.Controls.Add(this.poserTable);
            this.Controls.Add(this.boire);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.boiteAlcool);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.messageForTheUser);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox messageForTheUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox boiteAlcool;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button boire;
        private System.Windows.Forms.Button poserTable;
        private System.Windows.Forms.Button saucission;
        private System.Windows.Forms.Button gratterConso;
    }
}

