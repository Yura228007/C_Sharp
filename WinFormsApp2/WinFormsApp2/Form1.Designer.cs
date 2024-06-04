namespace WinFormsApp1
{
    partial class Form1
    {
 
        private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            incr_button = new Button();
            decr_button = new Button();
            show_text = new Label();
            car_player = new PictureBox();
            show_life = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            show_meter = new Label();
            show_hit = new Label();
            button_start = new Button();
            BG_1 = new PictureBox();
            BG_2 = new PictureBox();
            button_stop_resume = new Button();
            button_restart = new Button();
            groupBox1 = new GroupBox();
            show_attr_Y = new Label();
            button_jump = new Button();
            ((System.ComponentModel.ISupportInitialize)car_player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BG_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BG_2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // incr_button
            // 
            incr_button.Font = new Font("Impact", 21.75F);
            incr_button.Location = new Point(362, 325);
            incr_button.Margin = new Padding(3, 2, 3, 2);
            incr_button.Name = "incr_button";
            incr_button.Size = new Size(82, 46);
            incr_button.TabIndex = 0;
            incr_button.Text = "+";
            incr_button.UseVisualStyleBackColor = true;
            incr_button.Click += Incr_button_Click;
            // 
            // decr_button
            // 
            decr_button.Font = new Font("Impact", 21.75F);
            decr_button.Location = new Point(194, 325);
            decr_button.Margin = new Padding(3, 2, 3, 2);
            decr_button.Name = "decr_button";
            decr_button.Size = new Size(82, 46);
            decr_button.TabIndex = 1;
            decr_button.Text = "-";
            decr_button.UseVisualStyleBackColor = true;
            decr_button.Click += Decr_button_Click;
            // 
            // show_text
            // 
            show_text.AutoSize = true;
            show_text.BackColor = SystemColors.HotTrack;
            show_text.Font = new Font("Mongolian Baiti", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show_text.ForeColor = SystemColors.ControlLightLight;
            show_text.Location = new Point(282, 334);
            show_text.Name = "show_text";
            show_text.Size = new Size(80, 30);
            show_text.TabIndex = 2;
            show_text.Text = "speed";
            show_text.Click += show_text_Click;
            // 
            // car_player
            // 
            car_player.BackgroundImage = WinFormsApp2.Properties.Resources.car;
            car_player.BackgroundImageLayout = ImageLayout.Zoom;
            car_player.InitialImage = null;
            car_player.Location = new Point(27, 100);
            car_player.Margin = new Padding(3, 2, 3, 2);
            car_player.Name = "car_player";
            car_player.Size = new Size(134, 47);
            car_player.TabIndex = 3;
            car_player.TabStop = false;
            car_player.Click += pictureBox1_Click;
            // 
            // show_life
            // 
            show_life.AutoSize = true;
            show_life.Font = new Font("Impact", 15.75F);
            show_life.Location = new Point(6, 33);
            show_life.Name = "show_life";
            show_life.Size = new Size(42, 26);
            show_life.TabIndex = 4;
            show_life.Text = "Life";
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // show_meter
            // 
            show_meter.AutoSize = true;
            show_meter.Font = new Font("Impact", 15.75F);
            show_meter.Location = new Point(6, 67);
            show_meter.Name = "show_meter";
            show_meter.Size = new Size(73, 26);
            show_meter.TabIndex = 5;
            show_meter.Text = "Meters";
            // 
            // show_hit
            // 
            show_hit.AutoSize = true;
            show_hit.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            show_hit.ForeColor = Color.Maroon;
            show_hit.Location = new Point(59, 125);
            show_hit.Name = "show_hit";
            show_hit.Size = new Size(60, 36);
            show_hit.TabIndex = 6;
            show_hit.Text = "HIT!";
            show_hit.Visible = false;
            // 
            // button_start
            // 
            button_start.BackColor = Color.LimeGreen;
            button_start.Font = new Font("Impact", 21.75F);
            button_start.Location = new Point(228, 269);
            button_start.Margin = new Padding(3, 2, 3, 2);
            button_start.Name = "button_start";
            button_start.Size = new Size(170, 44);
            button_start.TabIndex = 7;
            button_start.Text = "start";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += buttn_start_Click;
            // 
            // BG_1
            // 
            BG_1.BackgroundImage = WinFormsApp2.Properties.Resources.scale_1200;
            BG_1.BackgroundImageLayout = ImageLayout.Stretch;
            BG_1.Location = new Point(0, 165);
            BG_1.Margin = new Padding(3, 2, 3, 2);
            BG_1.Name = "BG_1";
            BG_1.Size = new Size(705, 86);
            BG_1.TabIndex = 8;
            BG_1.TabStop = false;
            BG_1.Click += BG_1_Click;
            // 
            // BG_2
            // 
            BG_2.BackgroundImage = WinFormsApp2.Properties.Resources.scale_1200;
            BG_2.BackgroundImageLayout = ImageLayout.Stretch;
            BG_2.Location = new Point(705, 165);
            BG_2.Margin = new Padding(3, 2, 3, 2);
            BG_2.Name = "BG_2";
            BG_2.Size = new Size(705, 86);
            BG_2.TabIndex = 9;
            BG_2.TabStop = false;
            // 
            // button_stop_resume
            // 
            button_stop_resume.BackColor = Color.Red;
            button_stop_resume.Font = new Font("Impact", 21.75F);
            button_stop_resume.Location = new Point(198, 269);
            button_stop_resume.Margin = new Padding(3, 2, 3, 2);
            button_stop_resume.Name = "button_stop_resume";
            button_stop_resume.Size = new Size(120, 44);
            button_stop_resume.TabIndex = 10;
            button_stop_resume.Text = "stop";
            button_stop_resume.UseVisualStyleBackColor = false;
            button_stop_resume.Visible = false;
            button_stop_resume.Click += button_stop_resume_Click;
            // 
            // button_restart
            // 
            button_restart.BackColor = Color.DarkOrange;
            button_restart.Font = new Font("Impact", 21.75F);
            button_restart.Location = new Point(324, 269);
            button_restart.Margin = new Padding(3, 2, 3, 2);
            button_restart.Name = "button_restart";
            button_restart.Size = new Size(120, 44);
            button_restart.TabIndex = 11;
            button_restart.Text = "restart";
            button_restart.UseVisualStyleBackColor = false;
            button_restart.Visible = false;
            button_restart.Click += button_restart_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(show_life);
            groupBox1.Controls.Add(show_meter);
            groupBox1.Font = new Font("Impact", 12.75F);
            groupBox1.Location = new Point(282, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 110);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Score";
            // 
            // show_attr_Y
            // 
            show_attr_Y.AutoSize = true;
            show_attr_Y.Location = new Point(90, 56);
            show_attr_Y.Name = "show_attr_Y";
            show_attr_Y.Size = new Size(38, 15);
            show_attr_Y.TabIndex = 13;
            show_attr_Y.Text = "label1";
            // 
            // button_jump
            // 
            button_jump.Location = new Point(69, 296);
            button_jump.Name = "button_jump";
            button_jump.Size = new Size(75, 23);
            button_jump.TabIndex = 14;
            button_jump.Text = "button1";
            button_jump.UseVisualStyleBackColor = true;
            button_jump.Click += button_jump_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(608, 382);
            Controls.Add(button_jump);
            Controls.Add(show_attr_Y);
            Controls.Add(groupBox1);
            Controls.Add(button_restart);
            Controls.Add(button_start);
            Controls.Add(show_hit);
            Controls.Add(car_player);
            Controls.Add(show_text);
            Controls.Add(decr_button);
            Controls.Add(incr_button);
            Controls.Add(BG_2);
            Controls.Add(BG_1);
            Controls.Add(button_stop_resume);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown_1;
            ((System.ComponentModel.ISupportInitialize)car_player).EndInit();
            ((System.ComponentModel.ISupportInitialize)BG_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BG_2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button incr_button;
        private Button decr_button;
        private Label show_text;

        private int counter;
        private PictureBox car_player;
        private Label show_life;
        private System.Windows.Forms.Timer timer1;
        private Label show_meter;
        private Label show_hit;
        private Button button_start;
        private PictureBox BG_1;
        private PictureBox BG_2;
        private Button button_stop_resume;
        private Button button_restart;
        private GroupBox groupBox1;
        private Label show_attr_Y;
        private Button button_jump;
    }
}
