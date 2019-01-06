namespace WindowsFormsApp7
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.InstractionsBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.BackColor = System.Drawing.SystemColors.Control;
            this.NewGameBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewGameBtn.BackgroundImage")));
            this.NewGameBtn.Location = new System.Drawing.Point(467, 275);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(133, 129);
            this.NewGameBtn.TabIndex = 0;
            this.NewGameBtn.UseVisualStyleBackColor = false;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // InstractionsBtn
            // 
            this.InstractionsBtn.Location = new System.Drawing.Point(12, 12);
            this.InstractionsBtn.Name = "InstractionsBtn";
            this.InstractionsBtn.Size = new System.Drawing.Size(90, 37);
            this.InstractionsBtn.TabIndex = 1;
            this.InstractionsBtn.Text = "Instractions";
            this.InstractionsBtn.UseVisualStyleBackColor = true;
            this.InstractionsBtn.Click += new System.EventHandler(this.InstractionsBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Location = new System.Drawing.Point(108, 12);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(90, 37);
            this.AboutBtn.TabIndex = 2;
            this.AboutBtn.Text = "about";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(1082, 12);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(90, 37);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.Text = "settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.InstractionsBtn);
            this.Controls.Add(this.NewGameBtn);
            this.MaximizeBox = false;
            this.Name = "menu";
            this.Text = "Battleship";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Button InstractionsBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button SettingsBtn;
    }
}

