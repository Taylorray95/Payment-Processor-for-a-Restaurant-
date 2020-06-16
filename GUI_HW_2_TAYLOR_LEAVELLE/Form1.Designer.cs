namespace GUI_HW_2_TAYLOR_LEAVELLE
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.Beverages = new System.Windows.Forms.Label();
            this.Appetizer = new System.Windows.Forms.Label();
            this.MainCourse = new System.Windows.Forms.Label();
            this.Dessert = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menue = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.Button();
            this.subtotal_placeholder = new System.Windows.Forms.Label();
            this.tax_placeholder = new System.Windows.Forms.Label();
            this.total_placeholder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DisplayMember = "Front";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Soda ",
            "Tea",
            "Coffee",
            "Mineral Water",
            "Juice",
            "Milk"});
            this.comboBox1.Location = new System.Drawing.Point(122, 410);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 44);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox2.DisplayMember = "Front";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Apple Pie",
            "Sundae",
            "Carrot Cake",
            "Mud Pie",
            "Apple Crisp"});
            this.comboBox2.Location = new System.Drawing.Point(1149, 410);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(251, 44);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox3.DisplayMember = "Front";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Seafood Alfredo",
            "Chicken Alfredo",
            "Chicken Picatta",
            "Turkey Club",
            "Lobster Pie",
            "Prime Rib",
            "Shrimp Scampi",
            "Turkey Dinner",
            "Stuffed Chicken"});
            this.comboBox3.Location = new System.Drawing.Point(811, 410);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(251, 44);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox4.DisplayMember = "Front";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Buffalo Wings",
            "Buffalo Fingers",
            "Potato Skins",
            "Nachos",
            "Mushroom Caps",
            "Shrimp Cocktail",
            "Chips and Salsa"});
            this.comboBox4.Location = new System.Drawing.Point(471, 410);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(251, 44);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // Beverages
            // 
            this.Beverages.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Beverages.AutoSize = true;
            this.Beverages.Location = new System.Drawing.Point(158, 339);
            this.Beverages.Name = "Beverages";
            this.Beverages.Size = new System.Drawing.Size(165, 36);
            this.Beverages.TabIndex = 4;
            this.Beverages.Text = "Beverages";
            // 
            // Appetizer
            // 
            this.Appetizer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Appetizer.AutoSize = true;
            this.Appetizer.Location = new System.Drawing.Point(513, 339);
            this.Appetizer.Name = "Appetizer";
            this.Appetizer.Size = new System.Drawing.Size(150, 36);
            this.Appetizer.TabIndex = 5;
            this.Appetizer.Text = "Appetizer";
            // 
            // MainCourse
            // 
            this.MainCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainCourse.AutoSize = true;
            this.MainCourse.Location = new System.Drawing.Point(834, 339);
            this.MainCourse.Name = "MainCourse";
            this.MainCourse.Size = new System.Drawing.Size(192, 36);
            this.MainCourse.TabIndex = 6;
            this.MainCourse.Text = "Main Course";
            // 
            // Dessert
            // 
            this.Dessert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dessert.AutoSize = true;
            this.Dessert.Location = new System.Drawing.Point(1213, 339);
            this.Dessert.Name = "Dessert";
            this.Dessert.Size = new System.Drawing.Size(117, 36);
            this.Dessert.TabIndex = 7;
            this.Dessert.Text = "Dessert";
            // 
            // Tax
            // 
            this.Tax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(532, 561);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(70, 36);
            this.Tax.TabIndex = 9;
            this.Tax.Text = "Tax:";
            // 
            // Total
            // 
            this.Total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(513, 621);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(89, 36);
            this.Total.TabIndex = 10;
            this.Total.Text = "Total:";
            // 
            // Clear
            // 
            this.Clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Location = new System.Drawing.Point(501, 774);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(189, 58);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::GUI_HW_2_TAYLOR_LEAVELLE.Properties.Resources.istockphoto_871119224_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(595, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Menue
            // 
            this.Menue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Menue.AutoSize = true;
            this.Menue.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menue.Location = new System.Drawing.Point(688, 34);
            this.Menue.Name = "Menue";
            this.Menue.Size = new System.Drawing.Size(145, 44);
            this.Menue.TabIndex = 16;
            this.Menue.Text = "Menue";
            // 
            // Payment
            // 
            this.Payment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payment.Location = new System.Drawing.Point(501, 686);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(189, 58);
            this.Payment.TabIndex = 17;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = true;
            this.Payment.Click += new System.EventHandler(this.button2_Click);
            // 
            // subtotal_placeholder
            // 
            this.subtotal_placeholder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subtotal_placeholder.AutoSize = true;
            this.subtotal_placeholder.Location = new System.Drawing.Point(656, 518);
            this.subtotal_placeholder.Name = "subtotal_placeholder";
            this.subtotal_placeholder.Size = new System.Drawing.Size(23, 36);
            this.subtotal_placeholder.TabIndex = 19;
            this.subtotal_placeholder.Text = " ";
            // 
            // tax_placeholder
            // 
            this.tax_placeholder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tax_placeholder.AutoSize = true;
            this.tax_placeholder.Location = new System.Drawing.Point(620, 561);
            this.tax_placeholder.Name = "tax_placeholder";
            this.tax_placeholder.Size = new System.Drawing.Size(23, 36);
            this.tax_placeholder.TabIndex = 20;
            this.tax_placeholder.Text = " ";
            // 
            // total_placeholder
            // 
            this.total_placeholder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.total_placeholder.AutoSize = true;
            this.total_placeholder.Location = new System.Drawing.Point(620, 621);
            this.total_placeholder.Name = "total_placeholder";
            this.total_placeholder.Size = new System.Drawing.Size(23, 36);
            this.total_placeholder.TabIndex = 21;
            this.total_placeholder.Text = " ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(924, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.total_placeholder);
            this.panel1.Controls.Add(this.tax_placeholder);
            this.panel1.Controls.Add(this.subtotal_placeholder);
            this.panel1.Controls.Add(this.Payment);
            this.panel1.Controls.Add(this.Menue);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.Tax);
            this.panel1.Controls.Add(this.Dessert);
            this.panel1.Controls.Add(this.MainCourse);
            this.panel1.Controls.Add(this.Appetizer);
            this.panel1.Controls.Add(this.Beverages);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 1062);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "Subtotal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1571, 1062);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1453, 1050);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Restaraunt Checkout Processor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label Beverages;
        private System.Windows.Forms.Label Appetizer;
        private System.Windows.Forms.Label MainCourse;
        private System.Windows.Forms.Label Dessert;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Menue;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Label subtotal_placeholder;
        private System.Windows.Forms.Label tax_placeholder;
        private System.Windows.Forms.Label total_placeholder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

