namespace Project2_120924
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
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            button_logIn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(319, 117);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(183, 23);
            textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(319, 146);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(183, 23);
            textBox_password.TabIndex = 0;
            // 
            // button_logIn
            // 
            button_logIn.Location = new Point(427, 175);
            button_logIn.Name = "button_logIn";
            button_logIn.Size = new Size(75, 23);
            button_logIn.TabIndex = 1;
            button_logIn.Text = "Войти";
            button_logIn.UseVisualStyleBackColor = true;
            button_logIn.Click += button_logIn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(483, 355);
            button1.Name = "button1";
            button1.Size = new Size(11, 10);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button_logIn);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_login;
        private TextBox textBox_password;
        private Button button_logIn;
        private Button button1;
    }
}