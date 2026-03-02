namespace WindowsFormsApp
{
    partial class Dashbord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbord));
            this.Coffee = new System.Windows.Forms.Panel();
            this.coffee_lbl = new System.Windows.Forms.Label();
            this.latte_txt = new System.Windows.Forms.TextBox();
            this.espresso_txt = new System.Windows.Forms.TextBox();
            this.flatWhite_txt = new System.Windows.Forms.TextBox();
            this.icedLatte_txt = new System.Windows.Forms.TextBox();
            this.macchiato_txt = new System.Windows.Forms.TextBox();
            this.americano_txt = new System.Windows.Forms.TextBox();
            this.cappuccino_txt = new System.Windows.Forms.TextBox();
            this.doubleEspresso_txt = new System.Windows.Forms.TextBox();
            this.icedLatte_chk = new System.Windows.Forms.CheckBox();
            this.FlatWhite_chk = new System.Windows.Forms.CheckBox();
            this.Macchiato_chk = new System.Windows.Forms.CheckBox();
            this.Cappuccino_chk = new System.Windows.Forms.CheckBox();
            this.Americano_chk = new System.Windows.Forms.CheckBox();
            this.DoubleEspresso_chk = new System.Windows.Forms.CheckBox();
            this.Latte_chk = new System.Windows.Forms.CheckBox();
            this.Espresso_chk = new System.Windows.Forms.CheckBox();
            this.Dessert = new System.Windows.Forms.Panel();
            this.Croissant_chk = new System.Windows.Forms.CheckBox();
            this.LemonPie_chk = new System.Windows.Forms.CheckBox();
            this.desserts_lbl = new System.Windows.Forms.Label();
            this.brownies_txt = new System.Windows.Forms.TextBox();
            this.CinnamonRoll_chk = new System.Windows.Forms.CheckBox();
            this.StrawberryWaffle_chk = new System.Windows.Forms.CheckBox();
            this.croissant_txt = new System.Windows.Forms.TextBox();
            this.LemonPie_txt = new System.Windows.Forms.TextBox();
            this.cheesecake_txt = new System.Windows.Forms.TextBox();
            this.cinnamonRoll_txt = new System.Windows.Forms.TextBox();
            this.ChocolateWaffle_chk = new System.Windows.Forms.CheckBox();
            this.ChocolateMuffin_txt = new System.Windows.Forms.TextBox();
            this.ChocolateMuffin_chk = new System.Windows.Forms.CheckBox();
            this.chocolateWaffle_txt = new System.Windows.Forms.TextBox();
            this.Cheesecake_chk = new System.Windows.Forms.CheckBox();
            this.strawberryWaffle_txt = new System.Windows.Forms.TextBox();
            this.Brownies_chk = new System.Windows.Forms.CheckBox();
            this.db_title_lbl = new System.Windows.Forms.Label();
            this.Total_panel1 = new System.Windows.Forms.Panel();
            this.serviceCharge_txt = new System.Windows.Forms.Label();
            this.dessertsTotal_txt = new System.Windows.Forms.Label();
            this.coffeeTotal_txt = new System.Windows.Forms.Label();
            this.sc_lbl = new System.Windows.Forms.Label();
            this.cakeTotal_lbl = new System.Windows.Forms.Label();
            this.coffeeTotal_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.total_panel2 = new System.Windows.Forms.Panel();
            this.total_txt = new System.Windows.Forms.Label();
            this.tax_txt = new System.Windows.Forms.Label();
            this.subTotal_txt = new System.Windows.Forms.Label();
            this.tax_lbl = new System.Windows.Forms.Label();
            this.subTotal_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.Receipt_btn = new System.Windows.Forms.Button();
            this.Total_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.receipt_rtb = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.timer_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Coffee.SuspendLayout();
            this.Dessert.SuspendLayout();
            this.Total_panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.total_panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Coffee
            // 
            this.Coffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.Coffee.Controls.Add(this.coffee_lbl);
            this.Coffee.Controls.Add(this.latte_txt);
            this.Coffee.Controls.Add(this.espresso_txt);
            this.Coffee.Controls.Add(this.flatWhite_txt);
            this.Coffee.Controls.Add(this.icedLatte_txt);
            this.Coffee.Controls.Add(this.macchiato_txt);
            this.Coffee.Controls.Add(this.americano_txt);
            this.Coffee.Controls.Add(this.cappuccino_txt);
            this.Coffee.Controls.Add(this.doubleEspresso_txt);
            this.Coffee.Controls.Add(this.icedLatte_chk);
            this.Coffee.Controls.Add(this.FlatWhite_chk);
            this.Coffee.Controls.Add(this.Macchiato_chk);
            this.Coffee.Controls.Add(this.Cappuccino_chk);
            this.Coffee.Controls.Add(this.Americano_chk);
            this.Coffee.Controls.Add(this.DoubleEspresso_chk);
            this.Coffee.Controls.Add(this.Latte_chk);
            this.Coffee.Controls.Add(this.Espresso_chk);
            this.Coffee.Location = new System.Drawing.Point(99, 91);
            this.Coffee.Name = "Coffee";
            this.Coffee.Size = new System.Drawing.Size(373, 381);
            this.Coffee.TabIndex = 1;
            // 
            // coffee_lbl
            // 
            this.coffee_lbl.AutoSize = true;
            this.coffee_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.coffee_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffee_lbl.Location = new System.Drawing.Point(128, 12);
            this.coffee_lbl.Name = "coffee_lbl";
            this.coffee_lbl.Size = new System.Drawing.Size(116, 37);
            this.coffee_lbl.TabIndex = 17;
            this.coffee_lbl.Text = "Coffee";
            // 
            // latte_txt
            // 
            this.latte_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.latte_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latte_txt.Location = new System.Drawing.Point(247, 313);
            this.latte_txt.Multiline = true;
            this.latte_txt.Name = "latte_txt";
            this.latte_txt.Size = new System.Drawing.Size(100, 29);
            this.latte_txt.TabIndex = 21;
            this.latte_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.latte_txt.Click += new System.EventHandler(this.latte_txt_Click);
            // 
            // espresso_txt
            // 
            this.espresso_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.espresso_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espresso_txt.Location = new System.Drawing.Point(247, 278);
            this.espresso_txt.Multiline = true;
            this.espresso_txt.Name = "espresso_txt";
            this.espresso_txt.Size = new System.Drawing.Size(100, 29);
            this.espresso_txt.TabIndex = 20;
            this.espresso_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.espresso_txt.Click += new System.EventHandler(this.espresso_txt_Click);
            // 
            // flatWhite_txt
            // 
            this.flatWhite_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.flatWhite_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatWhite_txt.Location = new System.Drawing.Point(247, 243);
            this.flatWhite_txt.Multiline = true;
            this.flatWhite_txt.Name = "flatWhite_txt";
            this.flatWhite_txt.Size = new System.Drawing.Size(100, 29);
            this.flatWhite_txt.TabIndex = 19;
            this.flatWhite_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.flatWhite_txt.Click += new System.EventHandler(this.flatWhite_txt_Click);
            // 
            // icedLatte_txt
            // 
            this.icedLatte_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.icedLatte_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icedLatte_txt.Location = new System.Drawing.Point(247, 208);
            this.icedLatte_txt.Multiline = true;
            this.icedLatte_txt.Name = "icedLatte_txt";
            this.icedLatte_txt.Size = new System.Drawing.Size(100, 29);
            this.icedLatte_txt.TabIndex = 18;
            this.icedLatte_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.icedLatte_txt.Click += new System.EventHandler(this.icedLatte_txt_Click);
            // 
            // macchiato_txt
            // 
            this.macchiato_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.macchiato_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macchiato_txt.Location = new System.Drawing.Point(247, 173);
            this.macchiato_txt.Multiline = true;
            this.macchiato_txt.Name = "macchiato_txt";
            this.macchiato_txt.Size = new System.Drawing.Size(100, 29);
            this.macchiato_txt.TabIndex = 17;
            this.macchiato_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.macchiato_txt.Click += new System.EventHandler(this.macchiato_txt_Click);
            // 
            // americano_txt
            // 
            this.americano_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.americano_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.americano_txt.Location = new System.Drawing.Point(247, 138);
            this.americano_txt.Multiline = true;
            this.americano_txt.Name = "americano_txt";
            this.americano_txt.Size = new System.Drawing.Size(100, 29);
            this.americano_txt.TabIndex = 16;
            this.americano_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.americano_txt.Click += new System.EventHandler(this.americano_txt_Click);
            // 
            // cappuccino_txt
            // 
            this.cappuccino_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.cappuccino_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cappuccino_txt.Location = new System.Drawing.Point(247, 103);
            this.cappuccino_txt.Multiline = true;
            this.cappuccino_txt.Name = "cappuccino_txt";
            this.cappuccino_txt.Size = new System.Drawing.Size(100, 29);
            this.cappuccino_txt.TabIndex = 15;
            this.cappuccino_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cappuccino_txt.Click += new System.EventHandler(this.cappuccino_txt_Click);
            this.cappuccino_txt.TextChanged += new System.EventHandler(this.cappuccino_txt_TextChanged);
            // 
            // doubleEspresso_txt
            // 
            this.doubleEspresso_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.doubleEspresso_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleEspresso_txt.Location = new System.Drawing.Point(247, 68);
            this.doubleEspresso_txt.Multiline = true;
            this.doubleEspresso_txt.Name = "doubleEspresso_txt";
            this.doubleEspresso_txt.Size = new System.Drawing.Size(100, 29);
            this.doubleEspresso_txt.TabIndex = 14;
            this.doubleEspresso_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.doubleEspresso_txt.Click += new System.EventHandler(this.doubleEspresso_txt_Click);
            // 
            // icedLatte_chk
            // 
            this.icedLatte_chk.AutoSize = true;
            this.icedLatte_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icedLatte_chk.Location = new System.Drawing.Point(24, 210);
            this.icedLatte_chk.Name = "icedLatte_chk";
            this.icedLatte_chk.Size = new System.Drawing.Size(111, 24);
            this.icedLatte_chk.TabIndex = 13;
            this.icedLatte_chk.Text = "Iced-Latte";
            this.icedLatte_chk.UseVisualStyleBackColor = true;
            this.icedLatte_chk.CheckedChanged += new System.EventHandler(this.icedLatte_chk_CheckedChanged);
            // 
            // FlatWhite_chk
            // 
            this.FlatWhite_chk.AutoSize = true;
            this.FlatWhite_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatWhite_chk.Location = new System.Drawing.Point(24, 245);
            this.FlatWhite_chk.Name = "FlatWhite_chk";
            this.FlatWhite_chk.Size = new System.Drawing.Size(110, 24);
            this.FlatWhite_chk.TabIndex = 12;
            this.FlatWhite_chk.Text = "Flat White";
            this.FlatWhite_chk.UseVisualStyleBackColor = true;
            this.FlatWhite_chk.CheckedChanged += new System.EventHandler(this.FlatWhite_chk_CheckedChanged);
            // 
            // Macchiato_chk
            // 
            this.Macchiato_chk.AutoSize = true;
            this.Macchiato_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Macchiato_chk.Location = new System.Drawing.Point(24, 175);
            this.Macchiato_chk.Name = "Macchiato_chk";
            this.Macchiato_chk.Size = new System.Drawing.Size(110, 24);
            this.Macchiato_chk.TabIndex = 11;
            this.Macchiato_chk.Text = "Macchiato";
            this.Macchiato_chk.UseVisualStyleBackColor = true;
            this.Macchiato_chk.CheckedChanged += new System.EventHandler(this.Macchiato_chk_CheckedChanged);
            // 
            // Cappuccino_chk
            // 
            this.Cappuccino_chk.AutoSize = true;
            this.Cappuccino_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cappuccino_chk.Location = new System.Drawing.Point(24, 105);
            this.Cappuccino_chk.Name = "Cappuccino_chk";
            this.Cappuccino_chk.Size = new System.Drawing.Size(122, 24);
            this.Cappuccino_chk.TabIndex = 10;
            this.Cappuccino_chk.Text = "Cappuccino";
            this.Cappuccino_chk.UseVisualStyleBackColor = true;
            this.Cappuccino_chk.CheckedChanged += new System.EventHandler(this.Cappuccino_chk_CheckedChanged);
            // 
            // Americano_chk
            // 
            this.Americano_chk.AutoSize = true;
            this.Americano_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Americano_chk.Location = new System.Drawing.Point(24, 140);
            this.Americano_chk.Name = "Americano_chk";
            this.Americano_chk.Size = new System.Drawing.Size(113, 24);
            this.Americano_chk.TabIndex = 9;
            this.Americano_chk.Text = "Americano";
            this.Americano_chk.UseVisualStyleBackColor = true;
            this.Americano_chk.CheckedChanged += new System.EventHandler(this.Americano_chk_CheckedChanged);
            // 
            // DoubleEspresso_chk
            // 
            this.DoubleEspresso_chk.AutoSize = true;
            this.DoubleEspresso_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubleEspresso_chk.Location = new System.Drawing.Point(24, 70);
            this.DoubleEspresso_chk.Name = "DoubleEspresso_chk";
            this.DoubleEspresso_chk.Size = new System.Drawing.Size(165, 24);
            this.DoubleEspresso_chk.TabIndex = 8;
            this.DoubleEspresso_chk.Text = "Double Espresso";
            this.DoubleEspresso_chk.UseVisualStyleBackColor = true;
            this.DoubleEspresso_chk.CheckedChanged += new System.EventHandler(this.DoubleEspresso_chk_CheckedChanged);
            // 
            // Latte_chk
            // 
            this.Latte_chk.AutoSize = true;
            this.Latte_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latte_chk.Location = new System.Drawing.Point(24, 315);
            this.Latte_chk.Name = "Latte_chk";
            this.Latte_chk.Size = new System.Drawing.Size(70, 24);
            this.Latte_chk.TabIndex = 7;
            this.Latte_chk.Text = "Latte";
            this.Latte_chk.UseVisualStyleBackColor = true;
            this.Latte_chk.CheckedChanged += new System.EventHandler(this.Latte_chk_CheckedChanged);
            // 
            // Espresso_chk
            // 
            this.Espresso_chk.AutoSize = true;
            this.Espresso_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Espresso_chk.Location = new System.Drawing.Point(24, 280);
            this.Espresso_chk.Name = "Espresso_chk";
            this.Espresso_chk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Espresso_chk.Size = new System.Drawing.Size(103, 24);
            this.Espresso_chk.TabIndex = 6;
            this.Espresso_chk.Text = "Espresso";
            this.Espresso_chk.UseVisualStyleBackColor = true;
            this.Espresso_chk.CheckedChanged += new System.EventHandler(this.Espresso_chk_CheckedChanged);
            // 
            // Dessert
            // 
            this.Dessert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.Dessert.Controls.Add(this.Croissant_chk);
            this.Dessert.Controls.Add(this.LemonPie_chk);
            this.Dessert.Controls.Add(this.desserts_lbl);
            this.Dessert.Controls.Add(this.brownies_txt);
            this.Dessert.Controls.Add(this.CinnamonRoll_chk);
            this.Dessert.Controls.Add(this.StrawberryWaffle_chk);
            this.Dessert.Controls.Add(this.croissant_txt);
            this.Dessert.Controls.Add(this.LemonPie_txt);
            this.Dessert.Controls.Add(this.cheesecake_txt);
            this.Dessert.Controls.Add(this.cinnamonRoll_txt);
            this.Dessert.Controls.Add(this.ChocolateWaffle_chk);
            this.Dessert.Controls.Add(this.ChocolateMuffin_txt);
            this.Dessert.Controls.Add(this.ChocolateMuffin_chk);
            this.Dessert.Controls.Add(this.chocolateWaffle_txt);
            this.Dessert.Controls.Add(this.Cheesecake_chk);
            this.Dessert.Controls.Add(this.strawberryWaffle_txt);
            this.Dessert.Controls.Add(this.Brownies_chk);
            this.Dessert.Location = new System.Drawing.Point(478, 91);
            this.Dessert.Name = "Dessert";
            this.Dessert.Size = new System.Drawing.Size(374, 381);
            this.Dessert.TabIndex = 1;
            // 
            // Croissant_chk
            // 
            this.Croissant_chk.AutoSize = true;
            this.Croissant_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Croissant_chk.Location = new System.Drawing.Point(25, 280);
            this.Croissant_chk.Name = "Croissant_chk";
            this.Croissant_chk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Croissant_chk.Size = new System.Drawing.Size(104, 24);
            this.Croissant_chk.TabIndex = 25;
            this.Croissant_chk.Text = "Croissant";
            this.Croissant_chk.UseVisualStyleBackColor = true;
            this.Croissant_chk.CheckedChanged += new System.EventHandler(this.Croissant_chk_CheckedChanged);
            this.Croissant_chk.Click += new System.EventHandler(this.Croissant_chk_Click);
            // 
            // LemonPie_chk
            // 
            this.LemonPie_chk.AutoSize = true;
            this.LemonPie_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LemonPie_chk.Location = new System.Drawing.Point(25, 245);
            this.LemonPie_chk.Name = "LemonPie_chk";
            this.LemonPie_chk.Size = new System.Drawing.Size(112, 24);
            this.LemonPie_chk.TabIndex = 24;
            this.LemonPie_chk.Text = "Lemon Pie";
            this.LemonPie_chk.UseVisualStyleBackColor = true;
            this.LemonPie_chk.CheckedChanged += new System.EventHandler(this.LemonPie_chk_CheckedChanged);
            // 
            // desserts_lbl
            // 
            this.desserts_lbl.AutoSize = true;
            this.desserts_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.desserts_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desserts_lbl.Location = new System.Drawing.Point(116, 12);
            this.desserts_lbl.Name = "desserts_lbl";
            this.desserts_lbl.Size = new System.Drawing.Size(150, 37);
            this.desserts_lbl.TabIndex = 34;
            this.desserts_lbl.Text = "Desserts";
            // 
            // brownies_txt
            // 
            this.brownies_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.brownies_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brownies_txt.Location = new System.Drawing.Point(248, 313);
            this.brownies_txt.Multiline = true;
            this.brownies_txt.Name = "brownies_txt";
            this.brownies_txt.Size = new System.Drawing.Size(100, 29);
            this.brownies_txt.TabIndex = 38;
            this.brownies_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.brownies_txt.Click += new System.EventHandler(this.brownies_txt_Click);
            // 
            // CinnamonRoll_chk
            // 
            this.CinnamonRoll_chk.AutoSize = true;
            this.CinnamonRoll_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinnamonRoll_chk.Location = new System.Drawing.Point(25, 175);
            this.CinnamonRoll_chk.Name = "CinnamonRoll_chk";
            this.CinnamonRoll_chk.Size = new System.Drawing.Size(144, 24);
            this.CinnamonRoll_chk.TabIndex = 23;
            this.CinnamonRoll_chk.Text = "Cinnamon Roll";
            this.CinnamonRoll_chk.UseVisualStyleBackColor = true;
            this.CinnamonRoll_chk.CheckedChanged += new System.EventHandler(this.CinnamonRoll_chk_CheckedChanged);
            // 
            // StrawberryWaffle_chk
            // 
            this.StrawberryWaffle_chk.AutoSize = true;
            this.StrawberryWaffle_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrawberryWaffle_chk.Location = new System.Drawing.Point(25, 70);
            this.StrawberryWaffle_chk.Name = "StrawberryWaffle_chk";
            this.StrawberryWaffle_chk.Size = new System.Drawing.Size(171, 24);
            this.StrawberryWaffle_chk.TabIndex = 22;
            this.StrawberryWaffle_chk.Text = "Strawberry Waffle";
            this.StrawberryWaffle_chk.UseVisualStyleBackColor = true;
            this.StrawberryWaffle_chk.CheckedChanged += new System.EventHandler(this.StrawberryWaffle_chk_CheckedChanged);
            // 
            // croissant_txt
            // 
            this.croissant_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.croissant_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.croissant_txt.Location = new System.Drawing.Point(248, 278);
            this.croissant_txt.Multiline = true;
            this.croissant_txt.Name = "croissant_txt";
            this.croissant_txt.Size = new System.Drawing.Size(100, 29);
            this.croissant_txt.TabIndex = 37;
            this.croissant_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LemonPie_txt
            // 
            this.LemonPie_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.LemonPie_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LemonPie_txt.Location = new System.Drawing.Point(248, 243);
            this.LemonPie_txt.Multiline = true;
            this.LemonPie_txt.Name = "LemonPie_txt";
            this.LemonPie_txt.Size = new System.Drawing.Size(100, 29);
            this.LemonPie_txt.TabIndex = 36;
            this.LemonPie_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LemonPie_txt.Click += new System.EventHandler(this.LemonPie_txt_Click);
            // 
            // cheesecake_txt
            // 
            this.cheesecake_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.cheesecake_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheesecake_txt.Location = new System.Drawing.Point(248, 208);
            this.cheesecake_txt.Multiline = true;
            this.cheesecake_txt.Name = "cheesecake_txt";
            this.cheesecake_txt.Size = new System.Drawing.Size(100, 29);
            this.cheesecake_txt.TabIndex = 35;
            this.cheesecake_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cheesecake_txt.Click += new System.EventHandler(this.cheesecake_txt_Click);
            // 
            // cinnamonRoll_txt
            // 
            this.cinnamonRoll_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.cinnamonRoll_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinnamonRoll_txt.Location = new System.Drawing.Point(248, 173);
            this.cinnamonRoll_txt.Multiline = true;
            this.cinnamonRoll_txt.Name = "cinnamonRoll_txt";
            this.cinnamonRoll_txt.Size = new System.Drawing.Size(100, 29);
            this.cinnamonRoll_txt.TabIndex = 33;
            this.cinnamonRoll_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cinnamonRoll_txt.Click += new System.EventHandler(this.cinnamonRoll_txt_Click);
            // 
            // ChocolateWaffle_chk
            // 
            this.ChocolateWaffle_chk.AutoSize = true;
            this.ChocolateWaffle_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChocolateWaffle_chk.Location = new System.Drawing.Point(25, 105);
            this.ChocolateWaffle_chk.Name = "ChocolateWaffle_chk";
            this.ChocolateWaffle_chk.Size = new System.Drawing.Size(166, 24);
            this.ChocolateWaffle_chk.TabIndex = 26;
            this.ChocolateWaffle_chk.Text = "Chocolate Waffle";
            this.ChocolateWaffle_chk.UseVisualStyleBackColor = true;
            this.ChocolateWaffle_chk.CheckedChanged += new System.EventHandler(this.ChocolateWaffle_chk_CheckedChanged);
            // 
            // ChocolateMuffin_txt
            // 
            this.ChocolateMuffin_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.ChocolateMuffin_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChocolateMuffin_txt.Location = new System.Drawing.Point(248, 138);
            this.ChocolateMuffin_txt.Multiline = true;
            this.ChocolateMuffin_txt.Name = "ChocolateMuffin_txt";
            this.ChocolateMuffin_txt.Size = new System.Drawing.Size(100, 29);
            this.ChocolateMuffin_txt.TabIndex = 32;
            this.ChocolateMuffin_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChocolateMuffin_txt.Click += new System.EventHandler(this.ChocolateMuffin_txt_Click);
            // 
            // ChocolateMuffin_chk
            // 
            this.ChocolateMuffin_chk.AutoSize = true;
            this.ChocolateMuffin_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChocolateMuffin_chk.Location = new System.Drawing.Point(25, 140);
            this.ChocolateMuffin_chk.Name = "ChocolateMuffin_chk";
            this.ChocolateMuffin_chk.Size = new System.Drawing.Size(164, 24);
            this.ChocolateMuffin_chk.TabIndex = 27;
            this.ChocolateMuffin_chk.Text = "Chocolate Muffin";
            this.ChocolateMuffin_chk.UseVisualStyleBackColor = true;
            this.ChocolateMuffin_chk.CheckedChanged += new System.EventHandler(this.ChocolateMuffin_chk_CheckedChanged);
            // 
            // chocolateWaffle_txt
            // 
            this.chocolateWaffle_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.chocolateWaffle_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocolateWaffle_txt.Location = new System.Drawing.Point(248, 103);
            this.chocolateWaffle_txt.Multiline = true;
            this.chocolateWaffle_txt.Name = "chocolateWaffle_txt";
            this.chocolateWaffle_txt.Size = new System.Drawing.Size(100, 29);
            this.chocolateWaffle_txt.TabIndex = 31;
            this.chocolateWaffle_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chocolateWaffle_txt.Click += new System.EventHandler(this.chocolateWaffle_txt_Click);
            // 
            // Cheesecake_chk
            // 
            this.Cheesecake_chk.AutoSize = true;
            this.Cheesecake_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cheesecake_chk.Location = new System.Drawing.Point(25, 210);
            this.Cheesecake_chk.Name = "Cheesecake_chk";
            this.Cheesecake_chk.Size = new System.Drawing.Size(127, 24);
            this.Cheesecake_chk.TabIndex = 28;
            this.Cheesecake_chk.Text = "Cheesecake";
            this.Cheesecake_chk.UseVisualStyleBackColor = true;
            this.Cheesecake_chk.CheckedChanged += new System.EventHandler(this.Cheesecake_chk_CheckedChanged);
            // 
            // strawberryWaffle_txt
            // 
            this.strawberryWaffle_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.strawberryWaffle_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strawberryWaffle_txt.Location = new System.Drawing.Point(248, 68);
            this.strawberryWaffle_txt.Multiline = true;
            this.strawberryWaffle_txt.Name = "strawberryWaffle_txt";
            this.strawberryWaffle_txt.Size = new System.Drawing.Size(100, 29);
            this.strawberryWaffle_txt.TabIndex = 30;
            this.strawberryWaffle_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.strawberryWaffle_txt.Click += new System.EventHandler(this.strawberryWaffle_txt_Click);
            // 
            // Brownies_chk
            // 
            this.Brownies_chk.AutoSize = true;
            this.Brownies_chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brownies_chk.Location = new System.Drawing.Point(25, 315);
            this.Brownies_chk.Name = "Brownies_chk";
            this.Brownies_chk.Size = new System.Drawing.Size(101, 24);
            this.Brownies_chk.TabIndex = 29;
            this.Brownies_chk.Text = "Brownies";
            this.Brownies_chk.UseVisualStyleBackColor = true;
            this.Brownies_chk.CheckedChanged += new System.EventHandler(this.Brownies_chk_CheckedChanged);
            // 
            // db_title_lbl
            // 
            this.db_title_lbl.AutoSize = true;
            this.db_title_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(191)))), ((int)(((byte)(153)))));
            this.db_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_title_lbl.Location = new System.Drawing.Point(336, 9);
            this.db_title_lbl.Name = "db_title_lbl";
            this.db_title_lbl.Size = new System.Drawing.Size(616, 55);
            this.db_title_lbl.TabIndex = 5;
            this.db_title_lbl.Text = "Cafe Management System";
            // 
            // Total_panel1
            // 
            this.Total_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.Total_panel1.Controls.Add(this.serviceCharge_txt);
            this.Total_panel1.Controls.Add(this.dessertsTotal_txt);
            this.Total_panel1.Controls.Add(this.coffeeTotal_txt);
            this.Total_panel1.Controls.Add(this.sc_lbl);
            this.Total_panel1.Controls.Add(this.cakeTotal_lbl);
            this.Total_panel1.Controls.Add(this.coffeeTotal_lbl);
            this.Total_panel1.Location = new System.Drawing.Point(99, 478);
            this.Total_panel1.Name = "Total_panel1";
            this.Total_panel1.Size = new System.Drawing.Size(373, 203);
            this.Total_panel1.TabIndex = 14;
            // 
            // serviceCharge_txt
            // 
            this.serviceCharge_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.serviceCharge_txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceCharge_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCharge_txt.Location = new System.Drawing.Point(229, 129);
            this.serviceCharge_txt.Name = "serviceCharge_txt";
            this.serviceCharge_txt.Size = new System.Drawing.Size(120, 29);
            this.serviceCharge_txt.TabIndex = 5;
            this.serviceCharge_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dessertsTotal_txt
            // 
            this.dessertsTotal_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.dessertsTotal_txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dessertsTotal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertsTotal_txt.Location = new System.Drawing.Point(229, 84);
            this.dessertsTotal_txt.Name = "dessertsTotal_txt";
            this.dessertsTotal_txt.Size = new System.Drawing.Size(120, 29);
            this.dessertsTotal_txt.TabIndex = 4;
            this.dessertsTotal_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coffeeTotal_txt
            // 
            this.coffeeTotal_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.coffeeTotal_txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.coffeeTotal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeeTotal_txt.Location = new System.Drawing.Point(229, 41);
            this.coffeeTotal_txt.Name = "coffeeTotal_txt";
            this.coffeeTotal_txt.Size = new System.Drawing.Size(120, 29);
            this.coffeeTotal_txt.TabIndex = 3;
            this.coffeeTotal_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sc_lbl
            // 
            this.sc_lbl.AutoSize = true;
            this.sc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sc_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sc_lbl.Location = new System.Drawing.Point(21, 139);
            this.sc_lbl.Name = "sc_lbl";
            this.sc_lbl.Size = new System.Drawing.Size(123, 18);
            this.sc_lbl.TabIndex = 2;
            this.sc_lbl.Text = "Service Charge";
            // 
            // cakeTotal_lbl
            // 
            this.cakeTotal_lbl.AutoSize = true;
            this.cakeTotal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeTotal_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cakeTotal_lbl.Location = new System.Drawing.Point(21, 89);
            this.cakeTotal_lbl.Name = "cakeTotal_lbl";
            this.cakeTotal_lbl.Size = new System.Drawing.Size(119, 18);
            this.cakeTotal_lbl.TabIndex = 1;
            this.cakeTotal_lbl.Text = "Desserts Total";
            // 
            // coffeeTotal_lbl
            // 
            this.coffeeTotal_lbl.AutoSize = true;
            this.coffeeTotal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeeTotal_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.coffeeTotal_lbl.Location = new System.Drawing.Point(21, 46);
            this.coffeeTotal_lbl.Name = "coffeeTotal_lbl";
            this.coffeeTotal_lbl.Size = new System.Drawing.Size(101, 18);
            this.coffeeTotal_lbl.TabIndex = 0;
            this.coffeeTotal_lbl.Text = "Coffee Total";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.receipt_rtb);
            this.panel2.Location = new System.Drawing.Point(858, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 513);
            this.panel2.TabIndex = 2;
            // 
            // total_panel2
            // 
            this.total_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.total_panel2.Controls.Add(this.total_txt);
            this.total_panel2.Controls.Add(this.tax_txt);
            this.total_panel2.Controls.Add(this.subTotal_txt);
            this.total_panel2.Controls.Add(this.tax_lbl);
            this.total_panel2.Controls.Add(this.subTotal_lbl);
            this.total_panel2.Controls.Add(this.total_lbl);
            this.total_panel2.Location = new System.Drawing.Point(478, 478);
            this.total_panel2.Name = "total_panel2";
            this.total_panel2.Size = new System.Drawing.Size(373, 203);
            this.total_panel2.TabIndex = 15;
            // 
            // total_txt
            // 
            this.total_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.total_txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.total_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txt.Location = new System.Drawing.Point(231, 129);
            this.total_txt.Name = "total_txt";
            this.total_txt.Size = new System.Drawing.Size(120, 29);
            this.total_txt.TabIndex = 11;
            this.total_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tax_txt
            // 
            this.tax_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.tax_txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tax_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax_txt.Location = new System.Drawing.Point(231, 41);
            this.tax_txt.Name = "tax_txt";
            this.tax_txt.Size = new System.Drawing.Size(120, 29);
            this.tax_txt.TabIndex = 9;
            this.tax_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subTotal_txt
            // 
            this.subTotal_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.subTotal_txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subTotal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal_txt.Location = new System.Drawing.Point(231, 84);
            this.subTotal_txt.Name = "subTotal_txt";
            this.subTotal_txt.Size = new System.Drawing.Size(120, 29);
            this.subTotal_txt.TabIndex = 10;
            this.subTotal_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tax_lbl
            // 
            this.tax_lbl.AutoSize = true;
            this.tax_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tax_lbl.Location = new System.Drawing.Point(20, 46);
            this.tax_lbl.Name = "tax_lbl";
            this.tax_lbl.Size = new System.Drawing.Size(35, 18);
            this.tax_lbl.TabIndex = 6;
            this.tax_lbl.Text = "Tax";
            // 
            // subTotal_lbl
            // 
            this.subTotal_lbl.AutoSize = true;
            this.subTotal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subTotal_lbl.Location = new System.Drawing.Point(20, 89);
            this.subTotal_lbl.Name = "subTotal_lbl";
            this.subTotal_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subTotal_lbl.Size = new System.Drawing.Size(75, 18);
            this.subTotal_lbl.TabIndex = 7;
            this.subTotal_lbl.Text = "SubTotal";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.total_lbl.Location = new System.Drawing.Point(20, 134);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(46, 18);
            this.total_lbl.TabIndex = 8;
            this.total_lbl.Text = "Total";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.panel4.Controls.Add(this.exit_btn);
            this.panel4.Controls.Add(this.reset_btn);
            this.panel4.Controls.Add(this.Receipt_btn);
            this.panel4.Controls.Add(this.Total_btn);
            this.panel4.Location = new System.Drawing.Point(859, 610);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 71);
            this.panel4.TabIndex = 16;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(290, 13);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(83, 42);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(201, 13);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(83, 42);
            this.reset_btn.TabIndex = 2;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Receipt_btn
            // 
            this.Receipt_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.Receipt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receipt_btn.Location = new System.Drawing.Point(112, 13);
            this.Receipt_btn.Name = "Receipt_btn";
            this.Receipt_btn.Size = new System.Drawing.Size(83, 42);
            this.Receipt_btn.TabIndex = 1;
            this.Receipt_btn.Text = "Receipt";
            this.Receipt_btn.UseVisualStyleBackColor = false;
            this.Receipt_btn.Click += new System.EventHandler(this.Receipt_btn_Click);
            // 
            // Total_btn
            // 
            this.Total_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.Total_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_btn.Location = new System.Drawing.Point(23, 13);
            this.Total_btn.Name = "Total_btn";
            this.Total_btn.Size = new System.Drawing.Size(83, 42);
            this.Total_btn.TabIndex = 0;
            this.Total_btn.Text = "Total";
            this.Total_btn.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // receipt_rtb
            // 
            this.receipt_rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.receipt_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_rtb.Location = new System.Drawing.Point(17, 37);
            this.receipt_rtb.Name = "receipt_rtb";
            this.receipt_rtb.Size = new System.Drawing.Size(357, 463);
            this.receipt_rtb.TabIndex = 0;
            this.receipt_rtb.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(395, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.timer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_lbl.Location = new System.Drawing.Point(99, 68);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(0, 20);
            this.timer_lbl.TabIndex = 17;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(1023, 68);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(0, 20);
            this.date_lbl.TabIndex = 18;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 729);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.total_panel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Total_panel1);
            this.Controls.Add(this.db_title_lbl);
            this.Controls.Add(this.Dessert);
            this.Controls.Add(this.Coffee);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.Coffee.ResumeLayout(false);
            this.Coffee.PerformLayout();
            this.Dessert.ResumeLayout(false);
            this.Dessert.PerformLayout();
            this.Total_panel1.ResumeLayout(false);
            this.Total_panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.total_panel2.ResumeLayout(false);
            this.total_panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Coffee;
        private System.Windows.Forms.Panel Dessert;
        private System.Windows.Forms.Label db_title_lbl;
        private System.Windows.Forms.CheckBox icedLatte_chk;
        private System.Windows.Forms.CheckBox FlatWhite_chk;
        private System.Windows.Forms.CheckBox Macchiato_chk;
        private System.Windows.Forms.CheckBox Cappuccino_chk;
        private System.Windows.Forms.CheckBox Americano_chk;
        private System.Windows.Forms.CheckBox DoubleEspresso_chk;
        private System.Windows.Forms.CheckBox Latte_chk;
        private System.Windows.Forms.CheckBox Espresso_chk;
        private System.Windows.Forms.TextBox flatWhite_txt;
        private System.Windows.Forms.TextBox icedLatte_txt;
        private System.Windows.Forms.TextBox macchiato_txt;
        private System.Windows.Forms.TextBox americano_txt;
        private System.Windows.Forms.TextBox cappuccino_txt;
        private System.Windows.Forms.TextBox doubleEspresso_txt;
        private System.Windows.Forms.Panel Total_panel1;
        private System.Windows.Forms.Label serviceCharge_txt;
        private System.Windows.Forms.Label dessertsTotal_txt;
        private System.Windows.Forms.Label coffeeTotal_txt;
        private System.Windows.Forms.Label sc_lbl;
        private System.Windows.Forms.Label cakeTotal_lbl;
        private System.Windows.Forms.Label coffeeTotal_lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel total_panel2;
        private System.Windows.Forms.Label total_txt;
        private System.Windows.Forms.Label tax_txt;
        private System.Windows.Forms.Label subTotal_txt;
        private System.Windows.Forms.Label tax_lbl;
        private System.Windows.Forms.Label subTotal_lbl;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label coffee_lbl;
        private System.Windows.Forms.TextBox latte_txt;
        private System.Windows.Forms.TextBox espresso_txt;
        private System.Windows.Forms.Label desserts_lbl;
        private System.Windows.Forms.TextBox brownies_txt;
        private System.Windows.Forms.CheckBox StrawberryWaffle_chk;
        private System.Windows.Forms.TextBox croissant_txt;
        private System.Windows.Forms.CheckBox CinnamonRoll_chk;
        private System.Windows.Forms.TextBox LemonPie_txt;
        private System.Windows.Forms.CheckBox LemonPie_chk;
        private System.Windows.Forms.TextBox cheesecake_txt;
        private System.Windows.Forms.CheckBox Croissant_chk;
        private System.Windows.Forms.TextBox cinnamonRoll_txt;
        private System.Windows.Forms.CheckBox ChocolateWaffle_chk;
        private System.Windows.Forms.TextBox ChocolateMuffin_txt;
        private System.Windows.Forms.CheckBox ChocolateMuffin_chk;
        private System.Windows.Forms.TextBox chocolateWaffle_txt;
        private System.Windows.Forms.CheckBox Cheesecake_chk;
        private System.Windows.Forms.TextBox strawberryWaffle_txt;
        private System.Windows.Forms.CheckBox Brownies_chk;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button Receipt_btn;
        private System.Windows.Forms.Button Total_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.RichTextBox receipt_rtb;
        private System.Windows.Forms.Label timer_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}