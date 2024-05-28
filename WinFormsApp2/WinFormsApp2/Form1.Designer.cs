namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            increaseButton = new Button();
            decreaseButton = new Button();
            show_text = new Label();
            show_life = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            show_meter = new Label();
            show_hit = new Label();
            button_start = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // increaseButton
            // 
            increaseButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            increaseButton.Location = new Point(518, 366);
            increaseButton.Name = "increaseButton";
            increaseButton.Size = new Size(117, 72);
            increaseButton.TabIndex = 0;
            increaseButton.Text = "increase";
            increaseButton.UseVisualStyleBackColor = true;
            increaseButton.Click += increaseButton_Click;
            // 
            // decreaseButton
            // 
            decreaseButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            decreaseButton.Location = new Point(150, 366);
            decreaseButton.Name = "decreaseButton";
            decreaseButton.Size = new Size(117, 72);
            decreaseButton.TabIndex = 3;
            decreaseButton.Text = "decrease";
            decreaseButton.UseVisualStyleBackColor = true;
            decreaseButton.Click += DecreaseButton_Click;
            // 
            // show_text
            // 
            show_text.AutoSize = true;
            show_text.Font = new Font("Sitka Small", 51.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            show_text.Location = new Point(273, 339);
            show_text.Name = "show_text";
            show_text.Size = new Size(239, 102);
            show_text.TabIndex = 2;
            show_text.Text = "ready";
            show_text.Click += label1_Click;
            // 
            // show_life
            // 
            show_life.AutoSize = true;
            show_life.Font = new Font("Silkscreen [Rus by Mr.Enot]", 18F, FontStyle.Bold);
            show_life.Location = new Point(269, 251);
            show_life.Name = "show_life";
            show_life.Size = new Size(65, 21);
            show_life.TabIndex = 4;
            show_life.Text = "life";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.scale_12002;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 176);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // show_meter
            // 
            show_meter.AutoSize = true;
            show_meter.Font = new Font("Silkscreen [Rus by Mr.Enot]", 18F, FontStyle.Bold);
            show_meter.Location = new Point(280, 284);
            show_meter.Name = "show_meter";
            show_meter.Size = new Size(79, 21);
            show_meter.TabIndex = 6;
            show_meter.Text = "metr";
            // 
            // show_hit
            // 
            show_hit.AutoSize = true;
            show_hit.Font = new Font("Silkscreen [Rus by Mr.Enot]", 18F, FontStyle.Bold);
            show_hit.Location = new Point(377, 318);
            show_hit.Name = "show_hit";
            show_hit.Size = new Size(53, 21);
            show_hit.TabIndex = 7;
            show_hit.Text = "hit";
            show_hit.Visible = false;
            // 
            // button_start
            // 
            button_start.Location = new Point(497, 274);
            button_start.Name = "button_start";
            button_start.Size = new Size(75, 23);
            button_start.TabIndex = 8;
            button_start.Text = "start";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_start);
            Controls.Add(show_hit);
            Controls.Add(show_meter);
            Controls.Add(pictureBox1);
            Controls.Add(show_life);
            Controls.Add(decreaseButton);
            Controls.Add(show_text);
            Controls.Add(increaseButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button increaseButton;
        private Button decreaseButton;
        private Label show_text;

        private int counter;
        private Label show_life;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label show_meter;
        private Label show_hit;
        private Button button_start;
    }
}
