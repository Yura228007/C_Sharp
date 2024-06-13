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
            label_list_product = new Label();
            button_product_load = new Button();
            value_product_load = new NumericUpDown();
            name_product_load = new ComboBox();
            list_products = new ListBox();
            main_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)value_product_load).BeginInit();
            SuspendLayout();
            // 
            // main_page
            // 
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
            // label_list_product
            // 
            label_list_product.AutoSize = true;
            label_list_product.Font = new Font("Segoe UI", 14F);
            label_list_product.Location = new Point(75, 279);
            label_list_product.Name = "label_list_product";
            label_list_product.Size = new Size(170, 25);
            label_list_product.TabIndex = 4;
            label_list_product.Text = "Список продуктов";
            // 
            // button_product_load
            // 
            button_product_load.Font = new Font("Segoe UI", 12F);
            button_product_load.Location = new Point(208, 318);
            button_product_load.Name = "button_product_load";
            button_product_load.Size = new Size(91, 28);
            button_product_load.TabIndex = 3;
            button_product_load.Text = "Добавить";
            button_product_load.UseVisualStyleBackColor = true;
            button_product_load.Click += button_product_load_Click;
            // 
            // value_product_load
            // 
            value_product_load.Font = new Font("Segoe UI", 12F);
            value_product_load.Location = new Point(165, 317);
            value_product_load.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            value_product_load.Name = "value_product_load";
            value_product_load.Size = new Size(37, 29);
            value_product_load.TabIndex = 2;
            value_product_load.Value = new decimal(new int[] { 1, 0, 0, 0 });
            value_product_load.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // name_product_load
            // 
            name_product_load.Font = new Font("Segoe UI", 12F);
            name_product_load.FormattingEnabled = true;
            name_product_load.Location = new Point(12, 317);
            name_product_load.Name = "name_product_load";
            name_product_load.Size = new Size(147, 29);
            name_product_load.TabIndex = 1;
            // 
            // list_products
            // 
            list_products.Font = new Font("Segoe UI", 12F);
            list_products.FormattingEnabled = true;
            list_products.ItemHeight = 21;
            list_products.Location = new Point(12, 355);
            list_products.Name = "list_products";
            list_products.Size = new Size(287, 382);
            list_products.TabIndex = 0;
            list_products.SelectedIndexChanged += list_products_SelectedIndexChanged;
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
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
