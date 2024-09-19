namespace Transports_1
{
    partial class CalculatingExpenses
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
            panel_mileage = new Panel();
            panel1 = new Panel();
            radioButton_month = new RadioButton();
            radioButton_day = new RadioButton();
            radioButton_season = new RadioButton();
            radioButton_week = new RadioButton();
            radioButton_winter = new RadioButton();
            radioButton_summer = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            buttonCalc = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox_mileageBus = new TextBox();
            textBox_mileageTruck = new TextBox();
            textBox_mileagePassenger = new TextBox();
            label1 = new Label();
            panel_mileage.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_mileage
            // 
            panel_mileage.Controls.Add(panel1);
            panel_mileage.Controls.Add(radioButton_winter);
            panel_mileage.Controls.Add(radioButton_summer);
            panel_mileage.Controls.Add(label6);
            panel_mileage.Controls.Add(label5);
            panel_mileage.Controls.Add(buttonCalc);
            panel_mileage.Controls.Add(label4);
            panel_mileage.Controls.Add(label3);
            panel_mileage.Controls.Add(label2);
            panel_mileage.Controls.Add(textBox_mileageBus);
            panel_mileage.Controls.Add(textBox_mileageTruck);
            panel_mileage.Controls.Add(textBox_mileagePassenger);
            panel_mileage.Controls.Add(label1);
            panel_mileage.Location = new Point(64, 33);
            panel_mileage.Name = "panel_mileage";
            panel_mileage.Size = new Size(421, 404);
            panel_mileage.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton_month);
            panel1.Controls.Add(radioButton_day);
            panel1.Controls.Add(radioButton_season);
            panel1.Controls.Add(radioButton_week);
            panel1.Location = new Point(200, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 65);
            panel1.TabIndex = 1;
            // 
            // radioButton_month
            // 
            radioButton_month.AutoSize = true;
            radioButton_month.Font = new Font("Segoe UI", 12F);
            radioButton_month.Location = new Point(87, 3);
            radioButton_month.Name = "radioButton_month";
            radioButton_month.Size = new Size(72, 25);
            radioButton_month.TabIndex = 9;
            radioButton_month.Text = "месяц";
            radioButton_month.UseVisualStyleBackColor = true;
            radioButton_month.CheckedChanged += radioButton_month_CheckedChanged;
            // 
            // radioButton_day
            // 
            radioButton_day.AutoSize = true;
            radioButton_day.Checked = true;
            radioButton_day.Font = new Font("Segoe UI", 12F);
            radioButton_day.Location = new Point(3, 3);
            radioButton_day.Name = "radioButton_day";
            radioButton_day.Size = new Size(62, 25);
            radioButton_day.TabIndex = 7;
            radioButton_day.TabStop = true;
            radioButton_day.Text = "день";
            radioButton_day.UseVisualStyleBackColor = true;
            radioButton_day.CheckedChanged += radioButton_day_CheckedChanged;
            // 
            // radioButton_season
            // 
            radioButton_season.AutoSize = true;
            radioButton_season.Font = new Font("Segoe UI", 12F);
            radioButton_season.Location = new Point(87, 28);
            radioButton_season.Name = "radioButton_season";
            radioButton_season.Size = new Size(68, 25);
            radioButton_season.TabIndex = 10;
            radioButton_season.Text = "сезон";
            radioButton_season.UseVisualStyleBackColor = true;
            radioButton_season.CheckedChanged += radioButton_season_CheckedChanged;
            // 
            // radioButton_week
            // 
            radioButton_week.AutoSize = true;
            radioButton_week.Font = new Font("Segoe UI", 12F);
            radioButton_week.Location = new Point(3, 28);
            radioButton_week.Name = "radioButton_week";
            radioButton_week.Size = new Size(78, 25);
            radioButton_week.TabIndex = 8;
            radioButton_week.Text = "неделя";
            radioButton_week.UseVisualStyleBackColor = true;
            radioButton_week.CheckedChanged += radioButton_week_CheckedChanged;
            // 
            // radioButton_winter
            // 
            radioButton_winter.AutoSize = true;
            radioButton_winter.Font = new Font("Segoe UI", 12F);
            radioButton_winter.Location = new Point(282, 239);
            radioButton_winter.Name = "radioButton_winter";
            radioButton_winter.Size = new Size(63, 25);
            radioButton_winter.TabIndex = 14;
            radioButton_winter.Text = "зима";
            radioButton_winter.UseVisualStyleBackColor = true;
            radioButton_winter.CheckedChanged += radioButton_winter_CheckedChanged;
            // 
            // radioButton_summer
            // 
            radioButton_summer.AutoSize = true;
            radioButton_summer.Checked = true;
            radioButton_summer.Font = new Font("Segoe UI", 12F);
            radioButton_summer.Location = new Point(200, 239);
            radioButton_summer.Name = "radioButton_summer";
            radioButton_summer.Size = new Size(60, 25);
            radioButton_summer.TabIndex = 13;
            radioButton_summer.TabStop = true;
            radioButton_summer.Text = "лето";
            radioButton_summer.UseVisualStyleBackColor = true;
            radioButton_summer.CheckedChanged += radioButton_summer_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(128, 239);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 12;
            label6.Text = "Сезон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(32, 181);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 11;
            label5.Text = "Период времени";
            // 
            // buttonCalc
            // 
            buttonCalc.Font = new Font("Segoe UI", 12F);
            buttonCalc.Location = new Point(274, 333);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(121, 51);
            buttonCalc.TabIndex = 6;
            buttonCalc.Text = "Расчитать расходы";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(97, 133);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 5;
            label4.Text = "Автобусы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(91, 95);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 4;
            label3.Text = "Грузовики";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(97, 57);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 3;
            label2.Text = "Легковые";
            // 
            // textBox_mileageBus
            // 
            textBox_mileageBus.Font = new Font("Segoe UI", 14F);
            textBox_mileageBus.Location = new Point(198, 130);
            textBox_mileageBus.Name = "textBox_mileageBus";
            textBox_mileageBus.Size = new Size(197, 32);
            textBox_mileageBus.TabIndex = 2;
            // 
            // textBox_mileageTruck
            // 
            textBox_mileageTruck.Font = new Font("Segoe UI", 14F);
            textBox_mileageTruck.Location = new Point(198, 92);
            textBox_mileageTruck.Name = "textBox_mileageTruck";
            textBox_mileageTruck.Size = new Size(197, 32);
            textBox_mileageTruck.TabIndex = 2;
            // 
            // textBox_mileagePassenger
            // 
            textBox_mileagePassenger.Font = new Font("Segoe UI", 14F);
            textBox_mileagePassenger.Location = new Point(198, 54);
            textBox_mileagePassenger.Name = "textBox_mileagePassenger";
            textBox_mileagePassenger.Size = new Size(197, 32);
            textBox_mileagePassenger.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 0;
            label1.Text = "Километраж";
            // 
            // CalculatingExpenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 573);
            Controls.Add(panel_mileage);
            Name = "CalculatingExpenses";
            Text = "CalculatingExpenses";
            Load += CalculatingExpenses_Load;
            panel_mileage.ResumeLayout(false);
            panel_mileage.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_mileage;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox_mileageBus;
        private TextBox textBox_mileageTruck;
        private TextBox textBox_mileagePassenger;
        private Button buttonCalc;
        private RadioButton radioButton_day;
        private Label label5;
        private RadioButton radioButton_season;
        private RadioButton radioButton_month;
        private RadioButton radioButton_week;
        private RadioButton radioButton_winter;
        private RadioButton radioButton_summer;
        private Label label6;
        private Panel panel1;
    }
}