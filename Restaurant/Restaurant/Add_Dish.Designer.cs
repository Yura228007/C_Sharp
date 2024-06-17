namespace Restaurant
{
    partial class Add_Dish
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
            name_products_for_dish = new ComboBox();
            title_dish = new TextBox();
            value_add_product = new NumericUpDown();
            list_products_for_dish = new ListBox();
            button_add_dish = new Button();
            button_add_product_for_dish = new Button();
            value_price_of_dish = new NumericUpDown();
            show_title_dish = new Label();
            show_ingredients = new Label();
            show_price = new Label();
            button_delete_ingredient = new Button();
            ((System.ComponentModel.ISupportInitialize)value_add_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)value_price_of_dish).BeginInit();
            SuspendLayout();
            // 
            // name_products_for_dish
            // 
            name_products_for_dish.DropDownStyle = ComboBoxStyle.DropDownList;
            name_products_for_dish.Font = new Font("Microsoft Sans Serif", 20.25F);
            name_products_for_dish.FormattingEnabled = true;
            name_products_for_dish.Location = new Point(12, 173);
            name_products_for_dish.Name = "name_products_for_dish";
            name_products_for_dish.Size = new Size(310, 39);
            name_products_for_dish.TabIndex = 0;
            // 
            // title_dish
            // 
            title_dish.Font = new Font("Microsoft Sans Serif", 20.25F);
            title_dish.Location = new Point(13, 51);
            title_dish.Name = "title_dish";
            title_dish.Size = new Size(450, 38);
            title_dish.TabIndex = 1;
            // 
            // value_add_product
            // 
            value_add_product.Font = new Font("Microsoft Sans Serif", 20.25F);
            value_add_product.Location = new Point(328, 173);
            value_add_product.Name = "value_add_product";
            value_add_product.Size = new Size(78, 38);
            value_add_product.TabIndex = 2;
            // 
            // list_products_for_dish
            // 
            list_products_for_dish.Font = new Font("Microsoft Sans Serif", 20F);
            list_products_for_dish.FormattingEnabled = true;
            list_products_for_dish.ItemHeight = 31;
            list_products_for_dish.Location = new Point(12, 218);
            list_products_for_dish.Name = "list_products_for_dish";
            list_products_for_dish.Size = new Size(451, 314);
            list_products_for_dish.TabIndex = 3;
            list_products_for_dish.SelectedIndexChanged += list_products_for_dish_SelectedIndexChanged;
            // 
            // button_add_dish
            // 
            button_add_dish.Font = new Font("Microsoft Sans Serif", 20.25F);
            button_add_dish.Location = new Point(314, 538);
            button_add_dish.Name = "button_add_dish";
            button_add_dish.Size = new Size(149, 47);
            button_add_dish.TabIndex = 6;
            button_add_dish.Text = "Загрузить";
            button_add_dish.UseVisualStyleBackColor = true;
            button_add_dish.Click += button_add_dish_Click;
            // 
            // button_add_product_for_dish
            // 
            button_add_product_for_dish.Font = new Font("Microsoft Sans Serif", 20.25F);
            button_add_product_for_dish.Location = new Point(412, 173);
            button_add_product_for_dish.Name = "button_add_product_for_dish";
            button_add_product_for_dish.Size = new Size(300, 40);
            button_add_product_for_dish.TabIndex = 7;
            button_add_product_for_dish.Text = "Добавить ингредиент";
            button_add_product_for_dish.UseVisualStyleBackColor = true;
            button_add_product_for_dish.Click += button_add_product_for_dish_Click;
            // 
            // value_price_of_dish
            // 
            value_price_of_dish.Font = new Font("Microsoft Sans Serif", 20.25F);
            value_price_of_dish.Location = new Point(503, 51);
            value_price_of_dish.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            value_price_of_dish.Name = "value_price_of_dish";
            value_price_of_dish.Size = new Size(167, 38);
            value_price_of_dish.TabIndex = 8;
            // 
            // show_title_dish
            // 
            show_title_dish.AutoSize = true;
            show_title_dish.Font = new Font("Microsoft Sans Serif", 20.25F);
            show_title_dish.Location = new Point(12, 9);
            show_title_dish.Name = "show_title_dish";
            show_title_dish.Size = new Size(225, 31);
            show_title_dish.TabIndex = 9;
            show_title_dish.Text = "Название блюда";
            // 
            // show_ingredients
            // 
            show_ingredients.AutoSize = true;
            show_ingredients.Font = new Font("Microsoft Sans Serif", 20.25F);
            show_ingredients.Location = new Point(12, 126);
            show_ingredients.Name = "show_ingredients";
            show_ingredients.Size = new Size(322, 31);
            show_ingredients.TabIndex = 10;
            show_ingredients.Text = "Ингредиенты для блюда";
            // 
            // show_price
            // 
            show_price.AutoSize = true;
            show_price.Font = new Font("Microsoft Sans Serif", 20.25F);
            show_price.Location = new Point(503, 9);
            show_price.Name = "show_price";
            show_price.Size = new Size(167, 31);
            show_price.TabIndex = 11;
            show_price.Text = "Цена блюда";
            // 
            // button_delete_ingredient
            // 
            button_delete_ingredient.Font = new Font("Microsoft Sans Serif", 17F);
            button_delete_ingredient.Location = new Point(469, 218);
            button_delete_ingredient.Name = "button_delete_ingredient";
            button_delete_ingredient.Size = new Size(256, 37);
            button_delete_ingredient.TabIndex = 12;
            button_delete_ingredient.Text = "Удалить ингредиент";
            button_delete_ingredient.UseVisualStyleBackColor = true;
            button_delete_ingredient.Visible = false;
            button_delete_ingredient.Click += button_delete_ingredient_Click;
            // 
            // Add_Dish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(button_delete_ingredient);
            Controls.Add(show_price);
            Controls.Add(show_ingredients);
            Controls.Add(show_title_dish);
            Controls.Add(value_price_of_dish);
            Controls.Add(button_add_product_for_dish);
            Controls.Add(button_add_dish);
            Controls.Add(list_products_for_dish);
            Controls.Add(value_add_product);
            Controls.Add(title_dish);
            Controls.Add(name_products_for_dish);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Add_Dish";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление блюда";
            FormClosed += Add_Dish_FormClosed;
            Load += Add_Dish_Load;
            ((System.ComponentModel.ISupportInitialize)value_add_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)value_price_of_dish).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox name_products_for_dish;
        private TextBox title_dish;
        private NumericUpDown value_add_product;
        private ListBox list_products_for_dish;
        private Button button_add_dish;
        private Button button_add_product_for_dish;
        private NumericUpDown value_price_of_dish;
        private Label show_title_dish;
        private Label show_ingredients;
        private Label show_price;
        private Button button_delete_ingredient;
    }
}