namespace MateuszChmielowskiLab6ZadDom
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelExplenation = new System.Windows.Forms.Label();
            this.buttonLogInInvoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 299);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(509, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Okno logowania";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // labelExplenation
            // 
            this.labelExplenation.AutoSize = true;
            this.labelExplenation.Location = new System.Drawing.Point(117, 46);
            this.labelExplenation.Name = "labelExplenation";
            this.labelExplenation.Size = new System.Drawing.Size(290, 91);
            this.labelExplenation.TabIndex = 1;
            this.labelExplenation.Text = resources.GetString("labelExplenation.Text");
            // 
            // buttonLogInInvoke
            // 
            this.buttonLogInInvoke.Location = new System.Drawing.Point(12, 328);
            this.buttonLogInInvoke.Name = "buttonLogInInvoke";
            this.buttonLogInInvoke.Size = new System.Drawing.Size(509, 23);
            this.buttonLogInInvoke.TabIndex = 0;
            this.buttonLogInInvoke.Text = "Okno logowania (drugi wątek)";
            this.buttonLogInInvoke.UseVisualStyleBackColor = true;
            this.buttonLogInInvoke.Click += new System.EventHandler(this.buttonLogInInvoke_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 379);
            this.Controls.Add(this.labelExplenation);
            this.Controls.Add(this.buttonLogInInvoke);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelExplenation;
        private System.Windows.Forms.Button buttonLogInInvoke;
    }
}

