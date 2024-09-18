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
            buttonCalc = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox_mileageBus = new TextBox();
            textBox_mileageTruck = new TextBox();
            textBox_mileagePassenger = new TextBox();
            label1 = new Label();
            panel_mileage.SuspendLayout();
            SuspendLayout();
            // 
            // panel_mileage
            // 
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
            panel_mileage.Size = new Size(408, 319);
            panel_mileage.TabIndex = 0;
            // 
            // buttonCalc
            // 
            buttonCalc.Font = new Font("Segoe UI", 12F);
            buttonCalc.Location = new Point(274, 255);
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
            ClientSize = new Size(848, 505);
            Controls.Add(panel_mileage);
            Name = "CalculatingExpenses";
            Text = "CalculatingExpenses";
            Load += CalculatingExpenses_Load;
            panel_mileage.ResumeLayout(false);
            panel_mileage.PerformLayout();
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
    }
}