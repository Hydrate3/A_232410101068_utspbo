namespace uts_new
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_kontak = new Button();
            button_register = new Button();
            button_login = new Button();
            SuspendLayout();
            // 
            // button_kontak
            // 
            button_kontak.Location = new Point(746, 245);
            button_kontak.Name = "button_kontak";
            button_kontak.Size = new Size(234, 46);
            button_kontak.TabIndex = 0;
            button_kontak.Text = "Daftar Kontak";
            button_kontak.UseVisualStyleBackColor = true;
            button_kontak.Click += button1_Click;
            // 
            // button_register
            // 
            button_register.Location = new Point(746, 317);
            button_register.Name = "button_register";
            button_register.Size = new Size(234, 46);
            button_register.TabIndex = 1;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            // 
            // button_login
            // 
            button_login.Location = new Point(746, 387);
            button_login.Name = "button_login";
            button_login.Size = new Size(234, 46);
            button_login.TabIndex = 2;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 632);
            Controls.Add(button_login);
            Controls.Add(button_register);
            Controls.Add(button_kontak);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button_kontak;
        private Button button_register;
        private Button button_login;
    }
}
