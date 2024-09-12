namespace Project2_120924
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
            button_openForm2 = new Button();
            SuspendLayout();
            // 
            // button_openForm2
            // 
            button_openForm2.Location = new Point(331, 163);
            button_openForm2.Name = "button_openForm2";
            button_openForm2.Size = new Size(111, 72);
            button_openForm2.TabIndex = 0;
            button_openForm2.Text = "Войти";
            button_openForm2.UseVisualStyleBackColor = true;
            button_openForm2.Click += button_openForm2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_openForm2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button_openForm2;
    }
}
