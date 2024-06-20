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
            button_save_dish = new Button();
            nameOf_productFor_dish = new ComboBox();
            button_add_productFor_dish = new Button();
            nameFor_newDish = new ComboBox();
            button_delete_dish = new Button();
            show_info_about_dish = new Label();
            label1 = new Label();
            button_dishes_load = new Button();
            list_dishes = new ListBox();
            nameOf_productFor_prodList = new ComboBox();
            button_addProduct_prodList = new Button();
            btn_save_prodList = new Button();
            panel_product_list = new Panel();
            table_prodList = new TableLayoutPanel();
            label_productsList = new Label();
            panel_infoAbout_dish = new Panel();
            table_info_aboutDish = new TableLayoutPanel();
            panel_main.SuspendLayout();
            panel_product_list.SuspendLayout();
            panel_infoAbout_dish.SuspendLayout();
            SuspendLayout();
            // 
            // panel_main
            // 
            panel_main.Controls.Add(button_save_dish);
            panel_main.Controls.Add(nameOf_productFor_dish);
            panel_main.Controls.Add(button_add_productFor_dish);
            panel_main.Controls.Add(nameFor_newDish);
            panel_main.Controls.Add(button_delete_dish);
            panel_main.Controls.Add(show_info_about_dish);
            panel_main.Controls.Add(label1);
            panel_main.Controls.Add(button_dishes_load);
            panel_main.Controls.Add(list_dishes);
            panel_main.Controls.Add(nameOf_productFor_prodList);
            panel_main.Controls.Add(button_addProduct_prodList);
            panel_main.Controls.Add(btn_save_prodList);
            panel_main.Controls.Add(panel_product_list);
            panel_main.Controls.Add(label_productsList);
            panel_main.Controls.Add(panel_infoAbout_dish);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(0, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1264, 681);
            panel_main.TabIndex = 0;
            // 
            // button_save_dish
            // 
            button_save_dish.Font = new Font("Segoe UI", 12F);
            button_save_dish.Location = new Point(933, 581);
            button_save_dish.Name = "button_save_dish";
            button_save_dish.Size = new Size(100, 42);
            button_save_dish.TabIndex = 23;
            button_save_dish.Text = "Сохранить";
            button_save_dish.UseVisualStyleBackColor = true;
            button_save_dish.Visible = false;
            button_save_dish.Click += button_save_dish_Click;
            // 
            // nameOf_productFor_dish
            // 
            nameOf_productFor_dish.DropDownStyle = ComboBoxStyle.DropDownList;
            nameOf_productFor_dish.Font = new Font("Segoe UI", 12F);
            nameOf_productFor_dish.FormattingEnabled = true;
            nameOf_productFor_dish.Location = new Point(723, 280);
            nameOf_productFor_dish.Name = "nameOf_productFor_dish";
            nameOf_productFor_dish.Size = new Size(215, 29);
            nameOf_productFor_dish.TabIndex = 22;
            nameOf_productFor_dish.Visible = false;
            // 
            // button_add_productFor_dish
            // 
            button_add_productFor_dish.Font = new Font("Segoe UI", 12F);
            button_add_productFor_dish.Location = new Point(944, 274);
            button_add_productFor_dish.Name = "button_add_productFor_dish";
            button_add_productFor_dish.Size = new Size(89, 39);
            button_add_productFor_dish.TabIndex = 21;
            button_add_productFor_dish.Text = "Добавить";
            button_add_productFor_dish.UseVisualStyleBackColor = true;
            button_add_productFor_dish.Visible = false;
            button_add_productFor_dish.Click += button_add_productFor_dish_Click;
            // 
            // nameFor_newDish
            // 
            nameFor_newDish.DropDownStyle = ComboBoxStyle.Simple;
            nameFor_newDish.Font = new Font("Segoe UI", 12F);
            nameFor_newDish.FormattingEnabled = true;
            nameFor_newDish.Location = new Point(402, 280);
            nameFor_newDish.Name = "nameFor_newDish";
            nameFor_newDish.Size = new Size(215, 29);
            nameFor_newDish.TabIndex = 20;
            // 
            // button_delete_dish
            // 
            button_delete_dish.Font = new Font("Segoe UI", 12F);
            button_delete_dish.Location = new Point(723, 581);
            button_delete_dish.Name = "button_delete_dish";
            button_delete_dish.Size = new Size(100, 42);
            button_delete_dish.TabIndex = 18;
            button_delete_dish.Text = "Удалить";
            button_delete_dish.UseVisualStyleBackColor = true;
            button_delete_dish.Visible = false;
            button_delete_dish.Click += button_delete_dish_Click;
            // 
            // show_info_about_dish
            // 
            show_info_about_dish.AutoSize = true;
            show_info_about_dish.Font = new Font("Segoe UI", 20F);
            show_info_about_dish.Location = new Point(715, 218);
            show_info_about_dish.Name = "show_info_about_dish";
            show_info_about_dish.Size = new Size(294, 37);
            show_info_about_dish.TabIndex = 16;
            show_info_about_dish.Text = "Информация о блюде";
            show_info_about_dish.Visible = false;
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
            // button_dishes_load
            // 
            button_dishes_load.Font = new Font("Segoe UI", 12F);
            button_dishes_load.Location = new Point(623, 274);
            button_dishes_load.Name = "button_dishes_load";
            button_dishes_load.Size = new Size(89, 39);
            button_dishes_load.TabIndex = 13;
            button_dishes_load.Text = "Добавить";
            button_dishes_load.UseVisualStyleBackColor = true;
            button_dishes_load.Click += button_dishes_load_Click;
            // 
            // list_dishes
            // 
            list_dishes.Font = new Font("Segoe UI", 12F);
            list_dishes.FormattingEnabled = true;
            list_dishes.ItemHeight = 21;
            list_dishes.Location = new Point(402, 319);
            list_dishes.Name = "list_dishes";
            list_dishes.Size = new Size(310, 256);
            list_dishes.TabIndex = 12;
            list_dishes.SelectedIndexChanged += list_dishes_SelectedIndexChanged;
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
            // panel_infoAbout_dish
            // 
            panel_infoAbout_dish.AutoScroll = true;
            panel_infoAbout_dish.Controls.Add(table_info_aboutDish);
            panel_infoAbout_dish.Font = new Font("Segoe UI", 12F);
            panel_infoAbout_dish.Location = new Point(723, 319);
            panel_infoAbout_dish.Name = "panel_infoAbout_dish";
            panel_infoAbout_dish.Size = new Size(310, 256);
            panel_infoAbout_dish.TabIndex = 19;
            panel_infoAbout_dish.Visible = false;
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
            table_info_aboutDish.Size = new Size(310, 3);
            table_info_aboutDish.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel_main);
            Name = "Form1";
            Text = "Form1";
            panel_main.ResumeLayout(false);
            panel_main.PerformLayout();
            panel_product_list.ResumeLayout(false);
            panel_product_list.PerformLayout();
            panel_infoAbout_dish.ResumeLayout(false);
            panel_infoAbout_dish.PerformLayout();
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
        private Label show_info_about_dish;
        private Label label1;
        private Button button_dishes_load;
        private ListBox list_dishes;
        private Panel panel_infoAbout_dish;
        private TableLayoutPanel table_info_aboutDish;
        private ComboBox nameFor_newDish;
        private ComboBox nameOf_productFor_dish;
        private Button button_add_productFor_dish;
        private Button button_save_dish;
    }
}
