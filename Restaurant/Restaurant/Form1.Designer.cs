namespace Restaurant
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
            main_page = new Panel();
            button_delete_dish = new Button();
            button_edit_dish = new Button();
            show_info_about_dish = new Label();
            list_info_about_dish = new ListBox();
            label1 = new Label();
            button_dishes_load = new Button();
            list_dishes = new ListBox();
            label_list_product = new Label();
            button_product_load = new Button();
            value_product_load = new NumericUpDown();
            name_product_load = new ComboBox();
            list_products = new ListBox();
            button_delete_product = new Button();
            main_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)value_product_load).BeginInit();
            SuspendLayout();
            // 
            // main_page
            // 
            main_page.Controls.Add(button_delete_product);
            main_page.Controls.Add(button_delete_dish);
            main_page.Controls.Add(button_edit_dish);
            main_page.Controls.Add(show_info_about_dish);
            main_page.Controls.Add(list_info_about_dish);
            main_page.Controls.Add(label1);
            main_page.Controls.Add(button_dishes_load);
            main_page.Controls.Add(list_dishes);
            main_page.Controls.Add(label_list_product);
            main_page.Controls.Add(button_product_load);
            main_page.Controls.Add(value_product_load);
            main_page.Controls.Add(name_product_load);
            main_page.Controls.Add(list_products);
            main_page.Dock = DockStyle.Fill;
            main_page.Location = new Point(0, 0);
            main_page.Name = "main_page";
            main_page.Size = new Size(984, 761);
            main_page.TabIndex = 0;
            main_page.Paint += main_page_Paint;
            // 
            // button_delete_dish
            // 
            button_delete_dish.Font = new Font("Segoe UI", 12F);
            button_delete_dish.Location = new Point(598, 436);
            button_delete_dish.Name = "button_delete_dish";
            button_delete_dish.Size = new Size(91, 28);
            button_delete_dish.TabIndex = 11;
            button_delete_dish.Text = "Удалить";
            button_delete_dish.UseVisualStyleBackColor = true;
            button_delete_dish.Visible = false;
            button_delete_dish.Click += button_delete_dish_Click;
            // 
            // button_edit_dish
            // 
            button_edit_dish.Font = new Font("Segoe UI", 12F);
            button_edit_dish.Location = new Point(758, 437);
            button_edit_dish.Name = "button_edit_dish";
            button_edit_dish.Size = new Size(127, 28);
            button_edit_dish.TabIndex = 10;
            button_edit_dish.Text = "Редактировать";
            button_edit_dish.UseVisualStyleBackColor = true;
            button_edit_dish.Visible = false;
            button_edit_dish.Click += button_edit_Click;
            // 
            // show_info_about_dish
            // 
            show_info_about_dish.AutoSize = true;
            show_info_about_dish.Font = new Font("Segoe UI", 20F);
            show_info_about_dish.Location = new Point(598, 9);
            show_info_about_dish.Name = "show_info_about_dish";
            show_info_about_dish.Size = new Size(294, 37);
            show_info_about_dish.TabIndex = 9;
            show_info_about_dish.Text = "Информация о блюде";
            show_info_about_dish.Visible = false;
            // 
            // list_info_about_dish
            // 
            list_info_about_dish.Font = new Font("Segoe UI", 12F);
            list_info_about_dish.FormattingEnabled = true;
            list_info_about_dish.ItemHeight = 21;
            list_info_about_dish.Location = new Point(598, 49);
            list_info_about_dish.Name = "list_info_about_dish";
            list_info_about_dish.Size = new Size(287, 382);
            list_info_about_dish.TabIndex = 8;
            list_info_about_dish.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(361, 8);
            label1.Name = "label1";
            label1.Size = new Size(181, 37);
            label1.TabIndex = 7;
            label1.Text = "Список блюд";
            // 
            // button_dishes_load
            // 
            button_dishes_load.Font = new Font("Segoe UI", 12F);
            button_dishes_load.Location = new Point(501, 437);
            button_dishes_load.Name = "button_dishes_load";
            button_dishes_load.Size = new Size(91, 28);
            button_dishes_load.TabIndex = 6;
            button_dishes_load.Text = "Добавить";
            button_dishes_load.UseVisualStyleBackColor = true;
            button_dishes_load.Click += button_dishes_load_Click;
            // 
            // list_dishes
            // 
            list_dishes.Font = new Font("Segoe UI", 12F);
            list_dishes.FormattingEnabled = true;
            list_dishes.ItemHeight = 21;
            list_dishes.Location = new Point(305, 49);
            list_dishes.Name = "list_dishes";
            list_dishes.Size = new Size(287, 382);
            list_dishes.TabIndex = 5;
            list_dishes.SelectedIndexChanged += list_dishes_SelectedIndexChanged;
            // 
            // label_list_product
            // 
            label_list_product.AutoSize = true;
            label_list_product.Font = new Font("Segoe UI", 20F);
            label_list_product.Location = new Point(45, 8);
            label_list_product.Name = "label_list_product";
            label_list_product.Size = new Size(244, 37);
            label_list_product.TabIndex = 4;
            label_list_product.Text = "Список продуктов";
            // 
            // button_product_load
            // 
            button_product_load.Font = new Font("Segoe UI", 12F);
            button_product_load.Location = new Point(213, 475);
            button_product_load.Name = "button_product_load";
            button_product_load.Size = new Size(89, 28);
            button_product_load.TabIndex = 3;
            button_product_load.Text = "Загрузить";
            button_product_load.UseVisualStyleBackColor = true;
            button_product_load.Click += button_product_load_Click;
            // 
            // value_product_load
            // 
            value_product_load.Font = new Font("Segoe UI", 12F);
            value_product_load.Location = new Point(231, 436);
            value_product_load.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            value_product_load.Name = "value_product_load";
            value_product_load.Size = new Size(68, 29);
            value_product_load.TabIndex = 2;
            value_product_load.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // name_product_load
            // 
            name_product_load.Font = new Font("Segoe UI", 12F);
            name_product_load.FormattingEnabled = true;
            name_product_load.Location = new Point(12, 436);
            name_product_load.Name = "name_product_load";
            name_product_load.Size = new Size(213, 29);
            name_product_load.TabIndex = 1;
            // 
            // list_products
            // 
            list_products.Font = new Font("Segoe UI", 12F);
            list_products.FormattingEnabled = true;
            list_products.ItemHeight = 21;
            list_products.Location = new Point(12, 48);
            list_products.Name = "list_products";
            list_products.Size = new Size(287, 382);
            list_products.TabIndex = 0;
            list_products.SelectedIndexChanged += list_products_SelectedIndexChanged;
            // 
            // button_delete_product
            // 
            button_delete_product.Font = new Font("Segoe UI", 12F);
            button_delete_product.Location = new Point(12, 475);
            button_delete_product.Name = "button_delete_product";
            button_delete_product.Size = new Size(89, 28);
            button_delete_product.TabIndex = 12;
            button_delete_product.Text = "Удалить";
            button_delete_product.UseVisualStyleBackColor = true;
            button_delete_product.Visible = false;
            button_delete_product.Click += button_delete_product_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(main_page);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная страница";
            TopMost = true;
            Load += Form1_Load;
            VisibleChanged += Form1_VisibleChanged;
            main_page.ResumeLayout(false);
            main_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)value_product_load).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_page;
        private ListBox list_products;
        private Button button_product_load;
        private NumericUpDown value_product_load;
        private ComboBox name_product_load;
        private Label label_list_product;
        private ListBox list_dishes;
        private Label label1;
        private Button button_dishes_load;
        private Label show_info_about_dish;
        private ListBox list_info_about_dish;
        private Button button_edit_dish;
        private Button button_delete_dish;
        private Button button_delete_product;
    }
}
