namespace Paint
{
    partial class Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PliktoolStrip = new System.Windows.Forms.ToolStripSplitButton();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obróćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.powieksz_lb = new System.Windows.Forms.Label();
            this.powiekszBar = new System.Windows.Forms.TrackBar();
            this.wypelnienie_cb = new System.Windows.Forms.CheckBox();
            this.gumkaButton = new System.Windows.Forms.Button();
            this.gruboscPedzla_lb = new System.Windows.Forms.Label();
            this.gruboscPedzla_cmb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.siatka_rb = new System.Windows.Forms.RadioButton();
            this.zaznacz_rb = new System.Windows.Forms.RadioButton();
            this.elipsa_rb = new System.Windows.Forms.RadioButton();
            this.prostokat_rb = new System.Windows.Forms.RadioButton();
            this.linia_rb = new System.Windows.Forms.RadioButton();
            this.krzywa_rb = new System.Windows.Forms.RadioButton();
            this.kolorPedzla_lb = new System.Windows.Forms.Label();
            this.wyczyscButton = new System.Windows.Forms.Button();
            this.kolorPedzlaButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powiekszBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PliktoolStrip,
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1010, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PliktoolStrip
            // 
            this.PliktoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PliktoolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.wyjdźToolStripMenuItem,
            this.drukujToolStripMenuItem});
            this.PliktoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("PliktoolStrip.Image")));
            this.PliktoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PliktoolStrip.Name = "PliktoolStrip";
            this.PliktoolStrip.Size = new System.Drawing.Size(42, 22);
            this.PliktoolStrip.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // wyjdźToolStripMenuItem
            // 
            this.wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            this.wyjdźToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.wyjdźToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.wyjdźToolStripMenuItem.Text = "Wyjdź";
            this.wyjdźToolStripMenuItem.Click += new System.EventHandler(this.wyjdźToolStripMenuItem_Click);
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.drukujToolStripMenuItem.Text = "Drukuj";
            this.drukujToolStripMenuItem.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopiujToolStripMenuItem,
            this.wytnijToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.cofnijToolStripMenuItem,
            this.ponówToolStripMenuItem,
            this.obróćToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripSplitButton1.Text = "Edytuj";
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // ponówToolStripMenuItem
            // 
            this.ponówToolStripMenuItem.Name = "ponówToolStripMenuItem";
            this.ponówToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.ponówToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ponówToolStripMenuItem.Text = "Ponów";
            this.ponówToolStripMenuItem.Click += new System.EventHandler(this.ponówToolStripMenuItem_Click);
            // 
            // obróćToolStripMenuItem
            // 
            this.obróćToolStripMenuItem.Name = "obróćToolStripMenuItem";
            this.obróćToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.obróćToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.obróćToolStripMenuItem.Text = "Obróć";
            this.obróćToolStripMenuItem.Click += new System.EventHandler(this.obróćToolStripMenuItem_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(61, 22);
            this.toolStripSplitButton2.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.statusStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1002, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(167, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 510);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.powieksz_lb);
            this.panel1.Controls.Add(this.powiekszBar);
            this.panel1.Controls.Add(this.wypelnienie_cb);
            this.panel1.Controls.Add(this.gumkaButton);
            this.panel1.Controls.Add(this.gruboscPedzla_lb);
            this.panel1.Controls.Add(this.gruboscPedzla_cmb);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.kolorPedzla_lb);
            this.panel1.Controls.Add(this.wyczyscButton);
            this.panel1.Controls.Add(this.kolorPedzlaButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 510);
            this.panel1.TabIndex = 16;
            // 
            // powieksz_lb
            // 
            this.powieksz_lb.AutoSize = true;
            this.powieksz_lb.Location = new System.Drawing.Point(49, 336);
            this.powieksz_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.powieksz_lb.Name = "powieksz_lb";
            this.powieksz_lb.Size = new System.Drawing.Size(52, 13);
            this.powieksz_lb.TabIndex = 148;
            this.powieksz_lb.Text = "Powiększ";
            // 
            // powiekszBar
            // 
            this.powiekszBar.Location = new System.Drawing.Point(16, 358);
            this.powiekszBar.Margin = new System.Windows.Forms.Padding(2);
            this.powiekszBar.Name = "powiekszBar";
            this.powiekszBar.Size = new System.Drawing.Size(123, 45);
            this.powiekszBar.TabIndex = 147;
            this.powiekszBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // wypelnienie_cb
            // 
            this.wypelnienie_cb.AutoSize = true;
            this.wypelnienie_cb.Location = new System.Drawing.Point(36, 187);
            this.wypelnienie_cb.Margin = new System.Windows.Forms.Padding(2);
            this.wypelnienie_cb.Name = "wypelnienie_cb";
            this.wypelnienie_cb.Size = new System.Drawing.Size(84, 17);
            this.wypelnienie_cb.TabIndex = 146;
            this.wypelnienie_cb.Text = "Wypelnienie";
            this.wypelnienie_cb.UseVisualStyleBackColor = true;
            // 
            // gumkaButton
            // 
            this.gumkaButton.Location = new System.Drawing.Point(6, 289);
            this.gumkaButton.Name = "gumkaButton";
            this.gumkaButton.Size = new System.Drawing.Size(76, 23);
            this.gumkaButton.TabIndex = 16;
            this.gumkaButton.Text = "Gumka";
            this.gumkaButton.UseVisualStyleBackColor = true;
            this.gumkaButton.Click += new System.EventHandler(this.GumkaButton_Click);
            // 
            // gruboscPedzla_lb
            // 
            this.gruboscPedzla_lb.AutoSize = true;
            this.gruboscPedzla_lb.Location = new System.Drawing.Point(5, 219);
            this.gruboscPedzla_lb.Name = "gruboscPedzla_lb";
            this.gruboscPedzla_lb.Size = new System.Drawing.Size(81, 13);
            this.gruboscPedzla_lb.TabIndex = 15;
            this.gruboscPedzla_lb.Text = "Grubość pędzla";
            // 
            // gruboscPedzla_cmb
            // 
            this.gruboscPedzla_cmb.FormattingEnabled = true;
            this.gruboscPedzla_cmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.gruboscPedzla_cmb.Location = new System.Drawing.Point(87, 217);
            this.gruboscPedzla_cmb.Name = "gruboscPedzla_cmb";
            this.gruboscPedzla_cmb.Size = new System.Drawing.Size(76, 21);
            this.gruboscPedzla_cmb.TabIndex = 145;
            this.gruboscPedzla_cmb.Text = "1";
            this.gruboscPedzla_cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_PenSize_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.siatka_rb);
            this.groupBox1.Controls.Add(this.zaznacz_rb);
            this.groupBox1.Controls.Add(this.elipsa_rb);
            this.groupBox1.Controls.Add(this.prostokat_rb);
            this.groupBox1.Controls.Add(this.linia_rb);
            this.groupBox1.Controls.Add(this.krzywa_rb);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 160);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // siatka_rb
            // 
            this.siatka_rb.AutoSize = true;
            this.siatka_rb.Location = new System.Drawing.Point(5, 140);
            this.siatka_rb.Name = "siatka_rb";
            this.siatka_rb.Size = new System.Drawing.Size(55, 17);
            this.siatka_rb.TabIndex = 5;
            this.siatka_rb.Text = "Siatka";
            this.siatka_rb.UseVisualStyleBackColor = true;
            this.siatka_rb.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // zaznacz_rb
            // 
            this.zaznacz_rb.AutoSize = true;
            this.zaznacz_rb.Location = new System.Drawing.Point(7, 117);
            this.zaznacz_rb.Name = "zaznacz_rb";
            this.zaznacz_rb.Size = new System.Drawing.Size(66, 17);
            this.zaznacz_rb.TabIndex = 4;
            this.zaznacz_rb.Text = "Zaznacz";
            this.zaznacz_rb.UseVisualStyleBackColor = true;
            // 
            // elipsa_rb
            // 
            this.elipsa_rb.AutoSize = true;
            this.elipsa_rb.Location = new System.Drawing.Point(7, 95);
            this.elipsa_rb.Name = "elipsa_rb";
            this.elipsa_rb.Size = new System.Drawing.Size(53, 17);
            this.elipsa_rb.TabIndex = 3;
            this.elipsa_rb.Text = "Elipsa";
            this.elipsa_rb.UseVisualStyleBackColor = true;
            // 
            // prostokat_rb
            // 
            this.prostokat_rb.AutoSize = true;
            this.prostokat_rb.Location = new System.Drawing.Point(7, 70);
            this.prostokat_rb.Name = "prostokat_rb";
            this.prostokat_rb.Size = new System.Drawing.Size(70, 17);
            this.prostokat_rb.TabIndex = 2;
            this.prostokat_rb.Text = "Prostokąt";
            this.prostokat_rb.UseVisualStyleBackColor = true;
            // 
            // linia_rb
            // 
            this.linia_rb.AutoSize = true;
            this.linia_rb.Location = new System.Drawing.Point(7, 45);
            this.linia_rb.Name = "linia_rb";
            this.linia_rb.Size = new System.Drawing.Size(47, 17);
            this.linia_rb.TabIndex = 1;
            this.linia_rb.Text = "Linia";
            this.linia_rb.UseVisualStyleBackColor = true;
            // 
            // krzywa_rb
            // 
            this.krzywa_rb.AutoSize = true;
            this.krzywa_rb.Checked = true;
            this.krzywa_rb.Location = new System.Drawing.Point(7, 21);
            this.krzywa_rb.Name = "krzywa_rb";
            this.krzywa_rb.Size = new System.Drawing.Size(59, 17);
            this.krzywa_rb.TabIndex = 0;
            this.krzywa_rb.TabStop = true;
            this.krzywa_rb.Text = "Krzywa";
            this.krzywa_rb.UseVisualStyleBackColor = true;
            // 
            // kolorPedzla_lb
            // 
            this.kolorPedzla_lb.AutoSize = true;
            this.kolorPedzla_lb.Location = new System.Drawing.Point(13, 254);
            this.kolorPedzla_lb.Name = "kolorPedzla_lb";
            this.kolorPedzla_lb.Size = new System.Drawing.Size(65, 13);
            this.kolorPedzla_lb.TabIndex = 12;
            this.kolorPedzla_lb.Text = "Kolor pędzla";
            // 
            // wyczyscButton
            // 
            this.wyczyscButton.Location = new System.Drawing.Point(86, 289);
            this.wyczyscButton.Name = "wyczyscButton";
            this.wyczyscButton.Size = new System.Drawing.Size(76, 23);
            this.wyczyscButton.TabIndex = 13;
            this.wyczyscButton.Text = "Wyczyść ";
            this.wyczyscButton.UseVisualStyleBackColor = true;
            this.wyczyscButton.Click += new System.EventHandler(this.wyczyscButton_Click);
            // 
            // kolorPedzlaButton
            // 
            this.kolorPedzlaButton.BackColor = System.Drawing.Color.Red;
            this.kolorPedzlaButton.Location = new System.Drawing.Point(87, 249);
            this.kolorPedzlaButton.Name = "kolorPedzlaButton";
            this.kolorPedzlaButton.Size = new System.Drawing.Size(75, 23);
            this.kolorPedzlaButton.TabIndex = 11;
            this.kolorPedzlaButton.UseVisualStyleBackColor = false;
            this.kolorPedzlaButton.Click += new System.EventHandler(this.kolorButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(2, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(998, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 562);
            this.tabControl1.TabIndex = 3;
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1010, 587);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powiekszBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton PliktoolStrip;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton elipsa_rb;
        private System.Windows.Forms.RadioButton prostokat_rb;
        private System.Windows.Forms.RadioButton linia_rb;
        private System.Windows.Forms.RadioButton krzywa_rb;
        private System.Windows.Forms.Label kolorPedzla_lb;
        private System.Windows.Forms.Button wyczyscButton;
        private System.Windows.Forms.Button kolorPedzlaButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem wyjdźToolStripMenuItem;
        private System.Windows.Forms.ComboBox gruboscPedzla_cmb;
        private System.Windows.Forms.Label gruboscPedzla_lb;
        private System.Windows.Forms.Button gumkaButton;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.RadioButton zaznacz_rb;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ponówToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.RadioButton siatka_rb;
        private System.Windows.Forms.ToolStripMenuItem obróćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Windows.Forms.CheckBox wypelnienie_cb;
        private System.Windows.Forms.Label powieksz_lb;
        private System.Windows.Forms.TrackBar powiekszBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

