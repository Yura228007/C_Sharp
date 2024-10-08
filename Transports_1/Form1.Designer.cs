﻿namespace Transports_1
{
    partial class MainForm
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
            panel_addTransport = new Panel();
            comboBox_purposeCar = new ComboBox();
            comboBox_fuelSubtype = new ComboBox();
            comboBox_fuelType = new ComboBox();
            button_addCar = new Button();
            textBox_averageSpeed = new TextBox();
            textBox_fuelConsumption = new TextBox();
            textBox_nameCar = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_add = new Button();
            listBox_transports = new ListBox();
            button_calculation = new Button();
            table_list_dishes = new TableLayoutPanel();
            panel_fuelVolume = new Panel();
            tableLayoutPanel_fuelVolume = new TableLayoutPanel();
            button1 = new Button();
            panel_addTransport.SuspendLayout();
            panel_fuelVolume.SuspendLayout();
            SuspendLayout();
            // 
            // panel_addTransport
            // 
            panel_addTransport.Controls.Add(comboBox_purposeCar);
            panel_addTransport.Controls.Add(comboBox_fuelSubtype);
            panel_addTransport.Controls.Add(comboBox_fuelType);
            panel_addTransport.Controls.Add(button_addCar);
            panel_addTransport.Controls.Add(textBox_averageSpeed);
            panel_addTransport.Controls.Add(textBox_fuelConsumption);
            panel_addTransport.Controls.Add(textBox_nameCar);
            panel_addTransport.Controls.Add(label5);
            panel_addTransport.Controls.Add(label6);
            panel_addTransport.Controls.Add(label4);
            panel_addTransport.Controls.Add(label3);
            panel_addTransport.Controls.Add(label2);
            panel_addTransport.Controls.Add(label1);
            panel_addTransport.Location = new Point(547, 95);
            panel_addTransport.Name = "panel_addTransport";
            panel_addTransport.Size = new Size(420, 261);
            panel_addTransport.TabIndex = 0;
            panel_addTransport.Visible = false;
            // 
            // comboBox_purposeCar
            // 
            comboBox_purposeCar.FormattingEnabled = true;
            comboBox_purposeCar.Location = new Point(179, 54);
            comboBox_purposeCar.Name = "comboBox_purposeCar";
            comboBox_purposeCar.Size = new Size(195, 23);
            comboBox_purposeCar.TabIndex = 4;
            // 
            // comboBox_fuelSubtype
            // 
            comboBox_fuelSubtype.FormattingEnabled = true;
            comboBox_fuelSubtype.Location = new Point(179, 104);
            comboBox_fuelSubtype.Name = "comboBox_fuelSubtype";
            comboBox_fuelSubtype.Size = new Size(195, 23);
            comboBox_fuelSubtype.TabIndex = 3;
            // 
            // comboBox_fuelType
            // 
            comboBox_fuelType.FormattingEnabled = true;
            comboBox_fuelType.Location = new Point(179, 79);
            comboBox_fuelType.Name = "comboBox_fuelType";
            comboBox_fuelType.Size = new Size(195, 23);
            comboBox_fuelType.TabIndex = 3;
            comboBox_fuelType.SelectedIndexChanged += comboBox_fuelType_SelectedIndexChanged;
            // 
            // button_addCar
            // 
            button_addCar.Font = new Font("Segoe UI", 14F);
            button_addCar.Location = new Point(258, 196);
            button_addCar.Name = "button_addCar";
            button_addCar.Size = new Size(116, 37);
            button_addCar.TabIndex = 2;
            button_addCar.Text = "Добавить";
            button_addCar.UseVisualStyleBackColor = true;
            button_addCar.Click += button_addCar_Click;
            // 
            // textBox_averageSpeed
            // 
            textBox_averageSpeed.Location = new Point(179, 155);
            textBox_averageSpeed.Name = "textBox_averageSpeed";
            textBox_averageSpeed.Size = new Size(195, 23);
            textBox_averageSpeed.TabIndex = 1;
            // 
            // textBox_fuelConsumption
            // 
            textBox_fuelConsumption.Location = new Point(179, 129);
            textBox_fuelConsumption.Name = "textBox_fuelConsumption";
            textBox_fuelConsumption.Size = new Size(195, 23);
            textBox_fuelConsumption.TabIndex = 1;
            // 
            // textBox_nameCar
            // 
            textBox_nameCar.Location = new Point(179, 29);
            textBox_nameCar.Name = "textBox_nameCar";
            textBox_nameCar.Size = new Size(195, 23);
            textBox_nameCar.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(22, 102);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 0;
            label5.Text = "Подтип топлива";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(8, 153);
            label6.Name = "label6";
            label6.Size = new Size(169, 25);
            label6.TabIndex = 0;
            label6.Text = "Средняя скорость";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(27, 127);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 0;
            label4.Text = "Расход топлива";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(53, 77);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 0;
            label3.Text = "Тип топлива";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(53, 54);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 0;
            label2.Text = "Назначение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(121, 29);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // button_add
            // 
            button_add.Font = new Font("Segoe UI", 14F);
            button_add.Location = new Point(319, 371);
            button_add.Name = "button_add";
            button_add.Size = new Size(117, 41);
            button_add.TabIndex = 1;
            button_add.Text = "Добавить";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // listBox_transports
            // 
            listBox_transports.FormattingEnabled = true;
            listBox_transports.ItemHeight = 15;
            listBox_transports.Location = new Point(43, 95);
            listBox_transports.Name = "listBox_transports";
            listBox_transports.Size = new Size(393, 259);
            listBox_transports.TabIndex = 2;
            listBox_transports.SelectedIndexChanged += listBox_transports_SelectedIndexChanged;
            // 
            // button_calculation
            // 
            button_calculation.Location = new Point(196, 371);
            button_calculation.Name = "button_calculation";
            button_calculation.Size = new Size(117, 41);
            button_calculation.TabIndex = 4;
            button_calculation.Text = "Рассчитать расходы";
            button_calculation.UseVisualStyleBackColor = true;
            button_calculation.Click += button_calculation_Click;
            // 
            // table_list_dishes
            // 
            table_list_dishes.AutoSize = true;
            table_list_dishes.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table_list_dishes.ColumnCount = 3;
            table_list_dishes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            table_list_dishes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            table_list_dishes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            table_list_dishes.Dock = DockStyle.Top;
            table_list_dishes.Location = new Point(0, 0);
            table_list_dishes.Name = "table_list_dishes";
            table_list_dishes.RowCount = 2;
            table_list_dishes.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            table_list_dishes.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            table_list_dishes.Size = new Size(200, 100);
            table_list_dishes.TabIndex = 0;
            // 
            // panel_fuelVolume
            // 
            panel_fuelVolume.AutoScroll = true;
            panel_fuelVolume.Controls.Add(tableLayoutPanel_fuelVolume);
            panel_fuelVolume.Font = new Font("Segoe UI", 12F);
            panel_fuelVolume.Location = new Point(547, 380);
            panel_fuelVolume.Name = "panel_fuelVolume";
            panel_fuelVolume.Size = new Size(363, 297);
            panel_fuelVolume.TabIndex = 5;
            // 
            // tableLayoutPanel_fuelVolume
            // 
            tableLayoutPanel_fuelVolume.AutoSize = true;
            tableLayoutPanel_fuelVolume.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel_fuelVolume.ColumnCount = 2;
            tableLayoutPanel_fuelVolume.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel_fuelVolume.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_fuelVolume.Dock = DockStyle.Top;
            tableLayoutPanel_fuelVolume.Location = new Point(0, 0);
            tableLayoutPanel_fuelVolume.Name = "tableLayoutPanel_fuelVolume";
            tableLayoutPanel_fuelVolume.RowCount = 2;
            tableLayoutPanel_fuelVolume.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_fuelVolume.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_fuelVolume.Size = new Size(363, 3);
            tableLayoutPanel_fuelVolume.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(680, 683);
            button1.Name = "button1";
            button1.Size = new Size(117, 41);
            button1.TabIndex = 6;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 742);
            Controls.Add(button1);
            Controls.Add(panel_fuelVolume);
            Controls.Add(button_calculation);
            Controls.Add(listBox_transports);
            Controls.Add(button_add);
            Controls.Add(panel_addTransport);
            Name = "MainForm";
            Text = "Form1";
            panel_addTransport.ResumeLayout(false);
            panel_addTransport.PerformLayout();
            panel_fuelVolume.ResumeLayout(false);
            panel_fuelVolume.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_addTransport;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox textBox_fuelConsumption;
        private TextBox textBox_nameCar;
        private TextBox textBox_averageSpeed;
        private Label label6;
        private Button button_addCar;
        private ComboBox comboBox_fuelSubtype;
        private ComboBox comboBox_fuelType;
        private Button button_add;
        private ListBox listBox_transports;
        private ComboBox comboBox_purposeCar;
        private Button button_calculation;
        private TableLayoutPanel table_list_dishes;
        private Panel panel_fuelVolume;
        private TableLayoutPanel tableLayoutPanel_fuelVolume;
        private Button button1;
    }
}
