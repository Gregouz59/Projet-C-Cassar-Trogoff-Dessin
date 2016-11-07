namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.userControl2 = new WindowsFormsApplication1.UserControl2();
            this.userControl1 = new WindowsFormsApplication1.UserControl1();
            this.SuspendLayout();
            // 
            // userControl2
            // 
            this.userControl2.Location = new System.Drawing.Point(0, -3);
            this.userControl2.MyProperty = "home";
            this.userControl2.Name = "userControl2";
            this.userControl2.Size = new System.Drawing.Size(596, 374);
            this.userControl2.TabIndex = 3;
            this.userControl2.Visible = false;
            // 
            // userControl1
            // 
            this.userControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl1.BackgroundImage")));
            this.userControl1.ForeColor = System.Drawing.Color.Black;
            this.userControl1.Location = new System.Drawing.Point(0, -3);
            this.userControl1.MyProperty = "zytho";
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(705, 383);
            this.userControl1.TabIndex = 2;
            this.userControl1.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(701, 379);
            this.Controls.Add(this.userControl2);
            this.Controls.Add(this.userControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControl1 userControl1;
        private UserControl2 userControl2;
    }
}