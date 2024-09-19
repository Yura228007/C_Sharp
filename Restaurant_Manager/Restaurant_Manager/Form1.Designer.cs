namespace Restaurant_Manager
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
            panel_main = new Panel();
            groupBox1 = new GroupBox();
            newDish_cost = new NumericUpDown();
            nameFor_newDish = new ComboBox();
            button_dishes_load = new Button();
            nameOf_productFor_dish = new ComboBox();
            panel_infoAbout_dish = new Panel();
            table_info_aboutDish = new TableLayoutPanel();
            button_add_productFor_dish = new Button();
            panel_list_dishes = new Panel();
            button_save_dish = new Button();
            button_delete_dish = new Button();
            label1 = new Label();
            nameOf_productFor_prodList = new ComboBox();
            button_addProduct_prodList = new Button();
            btn_save_prodList = new Button();
            panel_product_list = new Panel();
            table_prodList = new TableLayoutPanel();
            label_productsList = new Label();
            table_list_dishes = new TableLayoutPanel();
            panel_main.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newDish_cost).BeginInit();
            panel_infoAbout_dish.SuspendLayout();
            panel_list_dishes.SuspendLayout();
            panel_product_list.SuspendLayout();
            SuspendLayout();
            // 
            // panel_main
            // 
            panel_main.Controls.Add(groupBox1);
            panel_main.Controls.Add(panel_list_dishes);
            panel_main.Controls.Add(button_save_dish);
            panel_main.Controls.Add(button_delete_dish);
            panel_main.Controls.Add(label1);
            panel_main.Controls.Add(nameOf_productFor_prodList);
            panel_main.Controls.Add(button_addProduct_prodList);
            panel_main.Controls.Add(btn_save_prodList);
            panel_main.Controls.Add(panel_product_list);
            panel_main.Controls.Add(label_productsList);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(0, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1433, 751);
            panel_main.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(newDish_cost);
            groupBox1.Controls.Add(nameFor_newDish);
            groupBox1.Controls.Add(button_dishes_load);
            groupBox1.Controls.Add(nameOf_productFor_dish);
            groupBox1.Controls.Add(panel_infoAbout_dish);
            groupBox1.Controls.Add(button_add_productFor_dish);
            groupBox1.Location = new Point(718, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 405);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление блюда";
            // 
            // newDish_cost
            // 
            newDish_cost.Font = new Font("Segoe UI", 12F);
            newDish_cost.Location = new Point(227, 22);
            newDish_cost.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            newDish_cost.Name = "newDish_cost";
            newDish_cost.Size = new Size(130, 29);
            newDish_cost.TabIndex = 21;
            // 
            // nameFor_newDish
            // 
            nameFor_newDish.DropDownStyle = ComboBoxStyle.Simple;
            nameFor_newDish.Font = new Font("Segoe UI", 12F);
            nameFor_newDish.FormattingEnabled = true;
            nameFor_newDish.Location = new Point(6, 22);
            nameFor_newDish.Name = "nameFor_newDish";
            nameFor_newDish.Size = new Size(215, 29);
            nameFor_newDish.TabIndex = 20;
            // 
            // button_dishes_load
            // 
            button_dishes_load.Dock = DockStyle.Bottom;
            button_dishes_load.Font = new Font("Segoe UI", 12F);
            button_dishes_load.Location = new Point(3, 358);
            button_dishes_load.Name = "button_dishes_load";
            button_dishes_load.Size = new Size(357, 44);
            button_dishes_load.TabIndex = 13;
            button_dishes_load.Text = "Загрузить блюдо";
            button_dishes_load.UseVisualStyleBackColor = true;
            button_dishes_load.Click += button_dishes_load_Click;
            // 
            // nameOf_productFor_dish
            // 
            nameOf_productFor_dish.DropDownStyle = ComboBoxStyle.DropDownList;
            nameOf_productFor_dish.Font = new Font("Segoe UI", 12F);
            nameOf_productFor_dish.FormattingEnabled = true;
            nameOf_productFor_dish.Location = new Point(6, 57);
            nameOf_productFor_dish.Name = "nameOf_productFor_dish";
            nameOf_productFor_dish.Size = new Size(215, 29);
            nameOf_productFor_dish.TabIndex = 22;
            // 
            // panel_infoAbout_dish
            // 
            panel_infoAbout_dish.AutoScroll = true;
            panel_infoAbout_dish.Controls.Add(table_info_aboutDish);
            panel_infoAbout_dish.Font = new Font("Segoe UI", 12F);
            panel_infoAbout_dish.Location = new Point(6, 96);
            panel_infoAbout_dish.Name = "panel_infoAbout_dish";
            panel_infoAbout_dish.Size = new Size(351, 256);
            panel_infoAbout_dish.TabIndex = 19;
            // 
            // table_info_aboutDish
            // 
            table_info_aboutDish.AutoSize = true;
            table_info_aboutDish.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table_info_aboutDish.ColumnCount = 2;
            table_info_aboutDish.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_info_aboutDish.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_info_aboutDish.Dock = DockStyle.Top;
            table_info_aboutDish.Location = new Point(0, 0);
            table_info_aboutDish.Name = "table_info_aboutDish";
            table_info_aboutDish.RowCount = 2;
            table_info_aboutDish.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_info_aboutDish.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_info_aboutDish.Size = new Size(351, 3);
            table_info_aboutDish.TabIndex = 0;
            // 
            // button_add_productFor_dish
            // 
            button_add_productFor_dish.Font = new Font("Segoe UI", 12F);
            button_add_productFor_dish.Location = new Point(227, 57);
            button_add_productFor_dish.Name = "button_add_productFor_dish";
            button_add_productFor_dish.Size = new Size(130, 29);
            button_add_productFor_dish.TabIndex = 21;
            button_add_productFor_dish.Text = "Добавить";
            button_add_productFor_dish.UseVisualStyleBackColor = true;
            button_add_productFor_dish.Click += button_add_productFor_dish_Click;
            // 
            // panel_list_dishes
            // 
            panel_list_dishes.AutoScroll = true;
            panel_list_dishes.Controls.Add(table_list_dishes);
            panel_list_dishes.Font = new Font("Segoe UI", 12F);
            panel_list_dishes.Location = new Point(402, 319);
            panel_list_dishes.Name = "panel_list_dishes";
            panel_list_dishes.Size = new Size(310, 256);
            panel_list_dishes.TabIndex = 3;
            // 
            // button_save_dish
            // 
            button_save_dish.Font = new Font("Segoe UI", 12F);
            button_save_dish.Location = new Point(612, 581);
            button_save_dish.Name = "button_save_dish";
            button_save_dish.Size = new Size(100, 42);
            button_save_dish.TabIndex = 23;
            button_save_dish.Text = "Сохранить";
            button_save_dish.UseVisualStyleBackColor = true;
            button_save_dish.Visible = false;
            // 
            // button_delete_dish
            // 
            button_delete_dish.Font = new Font("Segoe UI", 12F);
            button_delete_dish.Location = new Point(402, 581);
            button_delete_dish.Name = "button_delete_dish";
            button_delete_dish.Size = new Size(100, 42);
            button_delete_dish.TabIndex = 18;
            button_delete_dish.Text = "Удалить";
            button_delete_dish.UseVisualStyleBackColor = true;
            button_delete_dish.Visible = false;
            button_delete_dish.Click += button_delete_dish_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(478, 218);
            label1.Name = "label1";
            label1.Size = new Size(181, 37);
            label1.TabIndex = 14;
            label1.Text = "Список блюд";
            // 
            // nameOf_productFor_prodList
            // 
            nameOf_productFor_prodList.DropDownStyle = ComboBoxStyle.Simple;
            nameOf_productFor_prodList.Font = new Font("Segoe UI", 12F);
            nameOf_productFor_prodList.FormattingEnabled = true;
            nameOf_productFor_prodList.Location = new Point(81, 280);
            nameOf_productFor_prodList.Name = "nameOf_productFor_prodList";
            nameOf_productFor_prodList.Size = new Size(215, 29);
            nameOf_productFor_prodList.TabIndex = 5;
            // 
            // button_addProduct_prodList
            // 
            button_addProduct_prodList.Font = new Font("Segoe UI", 12F);
            button_addProduct_prodList.Location = new Point(302, 274);
            button_addProduct_prodList.Name = "button_addProduct_prodList";
            button_addProduct_prodList.Size = new Size(89, 39);
            button_addProduct_prodList.TabIndex = 4;
            button_addProduct_prodList.Text = "Добавить";
            button_addProduct_prodList.UseVisualStyleBackColor = true;
            button_addProduct_prodList.Click += button_addProduct_prodList_Click;
            // 
            // btn_save_prodList
            // 
            btn_save_prodList.Font = new Font("Segoe UI", 12F);
            btn_save_prodList.Location = new Point(291, 581);
            btn_save_prodList.Name = "btn_save_prodList";
            btn_save_prodList.Size = new Size(100, 42);
            btn_save_prodList.TabIndex = 3;
            btn_save_prodList.Text = "Сохранить";
            btn_save_prodList.UseVisualStyleBackColor = true;
            btn_save_prodList.Click += btn_save_prodList_Click;
            // 
            // panel_product_list
            // 
            panel_product_list.AutoScroll = true;
            panel_product_list.Controls.Add(table_prodList);
            panel_product_list.Font = new Font("Segoe UI", 12F);
            panel_product_list.Location = new Point(81, 319);
            panel_product_list.Name = "panel_product_list";
            panel_product_list.Size = new Size(310, 256);
            panel_product_list.TabIndex = 2;
            // 
            // table_prodList
            // 
            table_prodList.AutoSize = true;
            table_prodList.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table_prodList.ColumnCount = 2;
            table_prodList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_prodList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_prodList.Dock = DockStyle.Top;
            table_prodList.Location = new Point(0, 0);
            table_prodList.Name = "table_prodList";
            table_prodList.RowCount = 2;
            table_prodList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_prodList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_prodList.Size = new Size(310, 3);
            table_prodList.TabIndex = 0;
            // 
            // label_productsList
            // 
            label_productsList.AutoSize = true;
            label_productsList.Font = new Font("Segoe UI", 20F);
            label_productsList.Location = new Point(102, 218);
            label_productsList.Name = "label_productsList";
            label_productsList.Size = new Size(244, 37);
            label_productsList.TabIndex = 1;
            label_productsList.Text = "Список продуктов";
            // 
            // table_list_dishes
            // 
            table_list_dishes.AutoSize = true;
            table_list_dishes.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            table_list_dishes.ColumnCount = 3;
            table_list_dishes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            table_list_dishes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            table_list_dishes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            table_list_dishes.Dock = DockStyle.Top;
            table_list_dishes.Location = new Point(0, 0);
            table_list_dishes.Name = "table_list_dishes";
            table_list_dishes.RowCount = 2;
            table_list_dishes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_list_dishes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_list_dishes.Size = new Size(310, 3);
            table_list_dishes.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 751);
            Controls.Add(panel_main);
            Name = "Form1";
            Text = "Form1";
            panel_main.ResumeLayout(false);
            panel_main.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)newDish_cost).EndInit();
            panel_infoAbout_dish.ResumeLayout(false);
            panel_infoAbout_dish.PerformLayout();
            panel_list_dishes.ResumeLayout(false);
            panel_list_dishes.PerformLayout();
            panel_product_list.ResumeLayout(false);
            panel_product_list.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_main;
        private Label label_productsList;
        private Panel panel_product_list;
        private TableLayoutPanel table_prodList;
        private Button btn_save_prodList;
        private ComboBox nameOf_productFor_prodList;
        private Button button_addProduct_prodList;
        private Button button_delete_dish;
        private Label label1;
        private Button button_dishes_load;
        private Panel panel_infoAbout_dish;
        private TableLayoutPanel table_info_aboutDish;
        private ComboBox nameFor_newDish;
        private ComboBox nameOf_productFor_dish;
        private Button button_add_productFor_dish;
        private Button button_save_dish;
        private Panel panel_list_dishes;
        private GroupBox groupBox1;
        private NumericUpDown newDish_cost;
        private TableLayoutPanel table_list_dishes;
    }
}
