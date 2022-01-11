namespace SQL_Tur_Retur
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
            this.components = new System.ComponentModel.Container();
            this.OS_Ok = new System.Windows.Forms.Button();
            this.OS_TextBox_Navn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OS_Cancel = new System.Windows.Forms.Button();
            this.OS_Nr_plade = new System.Windows.Forms.Label();
            this.OS_Dato = new System.Windows.Forms.Label();
            this.OS_TextBox_Nr_plade = new System.Windows.Forms.TextBox();
            this.OS_TextBox_Dato = new System.Windows.Forms.TextBox();
            this.OS_Navn = new System.Windows.Forms.Label();
            this.Opret_Stamdata = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RS_Combobox = new System.Windows.Forms.ComboBox();
            this.RS_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RS_Ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RS_Nr_plade = new System.Windows.Forms.TextBox();
            this.RS_Dato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Rediger_Stamdata = new System.Windows.Forms.Label();
            this.SS_Combobox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SS_Cancel = new System.Windows.Forms.Button();
            this.SS_Ok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Slet_Stamdata = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OKL_Cancel = new System.Windows.Forms.Button();
            this.OKL_Ok = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.OKL_comboBox = new System.Windows.Forms.ComboBox();
            this.OKL_Nr_plade = new System.Windows.Forms.Label();
            this.OKL_Navn = new System.Windows.Forms.Label();
            this.OKL_Opgave = new System.Windows.Forms.Label();
            this.OKL_Dato = new System.Windows.Forms.Label();
            this.OKL_TextBox_Opg = new System.Windows.Forms.TextBox();
            this.OKL_Textbox_Nr_plade = new System.Windows.Forms.TextBox();
            this.OKL_Texbox_Dato = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.din_morDataSet = new SQL_Tur_Retur.Din_morDataSet();
            this.user_dataTableAdapter = new SQL_Tur_Retur.Din_morDataSetTableAdapters.User_dataTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.din_morDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // OS_Ok
            // 
            this.OS_Ok.Location = new System.Drawing.Point(86, 139);
            this.OS_Ok.Name = "OS_Ok";
            this.OS_Ok.Size = new System.Drawing.Size(75, 23);
            this.OS_Ok.TabIndex = 0;
            this.OS_Ok.Text = "OK";
            this.OS_Ok.UseVisualStyleBackColor = true;
            this.OS_Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // OS_TextBox_Navn
            // 
            this.OS_TextBox_Navn.Location = new System.Drawing.Point(59, 35);
            this.OS_TextBox_Navn.Name = "OS_TextBox_Navn";
            this.OS_TextBox_Navn.Size = new System.Drawing.Size(100, 20);
            this.OS_TextBox_Navn.TabIndex = 1;
            this.OS_TextBox_Navn.TextChanged += new System.EventHandler(this.OS_TextBox_Navn_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OS_Cancel);
            this.panel1.Controls.Add(this.OS_Nr_plade);
            this.panel1.Controls.Add(this.OS_Ok);
            this.panel1.Controls.Add(this.OS_Dato);
            this.panel1.Controls.Add(this.OS_TextBox_Nr_plade);
            this.panel1.Controls.Add(this.OS_TextBox_Dato);
            this.panel1.Controls.Add(this.OS_Navn);
            this.panel1.Controls.Add(this.OS_TextBox_Navn);
            this.panel1.Controls.Add(this.Opret_Stamdata);
            this.panel1.Location = new System.Drawing.Point(33, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 165);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // OS_Cancel
            // 
            this.OS_Cancel.Location = new System.Drawing.Point(3, 139);
            this.OS_Cancel.Name = "OS_Cancel";
            this.OS_Cancel.Size = new System.Drawing.Size(75, 23);
            this.OS_Cancel.TabIndex = 5;
            this.OS_Cancel.Text = "Cancel";
            this.OS_Cancel.UseVisualStyleBackColor = true;
            this.OS_Cancel.Click += new System.EventHandler(this.OS_Cancel_Click);
            // 
            // OS_Nr_plade
            // 
            this.OS_Nr_plade.AutoSize = true;
            this.OS_Nr_plade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.OS_Nr_plade.Location = new System.Drawing.Point(3, 91);
            this.OS_Nr_plade.Name = "OS_Nr_plade";
            this.OS_Nr_plade.Size = new System.Drawing.Size(50, 13);
            this.OS_Nr_plade.TabIndex = 3;
            this.OS_Nr_plade.Text = "Nr_plade";
            // 
            // OS_Dato
            // 
            this.OS_Dato.AutoSize = true;
            this.OS_Dato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.OS_Dato.Location = new System.Drawing.Point(7, 62);
            this.OS_Dato.Name = "OS_Dato";
            this.OS_Dato.Size = new System.Drawing.Size(33, 15);
            this.OS_Dato.TabIndex = 2;
            this.OS_Dato.Text = "Dato";
            // 
            // OS_TextBox_Nr_plade
            // 
            this.OS_TextBox_Nr_plade.Location = new System.Drawing.Point(59, 88);
            this.OS_TextBox_Nr_plade.Name = "OS_TextBox_Nr_plade";
            this.OS_TextBox_Nr_plade.Size = new System.Drawing.Size(100, 20);
            this.OS_TextBox_Nr_plade.TabIndex = 4;
            this.OS_TextBox_Nr_plade.TextChanged += new System.EventHandler(this.OS_TextBox_Nr_plade_TextChanged);
            // 
            // OS_TextBox_Dato
            // 
            this.OS_TextBox_Dato.Location = new System.Drawing.Point(59, 62);
            this.OS_TextBox_Dato.Name = "OS_TextBox_Dato";
            this.OS_TextBox_Dato.Size = new System.Drawing.Size(100, 20);
            this.OS_TextBox_Dato.TabIndex = 3;
            this.OS_TextBox_Dato.TextChanged += new System.EventHandler(this.OS_TextBox_Dato_TextChanged);
            // 
            // OS_Navn
            // 
            this.OS_Navn.AutoSize = true;
            this.OS_Navn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.OS_Navn.Location = new System.Drawing.Point(7, 36);
            this.OS_Navn.Name = "OS_Navn";
            this.OS_Navn.Size = new System.Drawing.Size(35, 15);
            this.OS_Navn.TabIndex = 1;
            this.OS_Navn.Text = "Navn";
            this.OS_Navn.Click += new System.EventHandler(this.OS_Navn_Click);
            // 
            // Opret_Stamdata
            // 
            this.Opret_Stamdata.AutoSize = true;
            this.Opret_Stamdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Opret_Stamdata.Location = new System.Drawing.Point(3, 10);
            this.Opret_Stamdata.Name = "Opret_Stamdata";
            this.Opret_Stamdata.Size = new System.Drawing.Size(136, 22);
            this.Opret_Stamdata.TabIndex = 0;
            this.Opret_Stamdata.Text = "Opret Stamdata";
            this.Opret_Stamdata.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RS_Combobox);
            this.panel2.Controls.Add(this.RS_Cancel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.RS_Ok);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.RS_Nr_plade);
            this.panel2.Controls.Add(this.RS_Dato);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Rediger_Stamdata);
            this.panel2.Location = new System.Drawing.Point(238, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 165);
            this.panel2.TabIndex = 3;
            // 
            // RS_Combobox
            // 
            this.RS_Combobox.FormattingEnabled = true;
            this.RS_Combobox.Location = new System.Drawing.Point(59, 36);
            this.RS_Combobox.Name = "RS_Combobox";
            this.RS_Combobox.Size = new System.Drawing.Size(100, 21);
            this.RS_Combobox.TabIndex = 4;
            this.RS_Combobox.SelectedIndexChanged += new System.EventHandler(this.RS_Combobox_SelectedIndexChanged);
            // 
            // RS_Cancel
            // 
            this.RS_Cancel.Location = new System.Drawing.Point(3, 139);
            this.RS_Cancel.Name = "RS_Cancel";
            this.RS_Cancel.Size = new System.Drawing.Size(75, 23);
            this.RS_Cancel.TabIndex = 5;
            this.RS_Cancel.Text = "Cancel";
            this.RS_Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(3, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nr_plade";
            // 
            // RS_Ok
            // 
            this.RS_Ok.Location = new System.Drawing.Point(86, 139);
            this.RS_Ok.Name = "RS_Ok";
            this.RS_Ok.Size = new System.Drawing.Size(75, 23);
            this.RS_Ok.TabIndex = 0;
            this.RS_Ok.Text = "OK";
            this.RS_Ok.UseVisualStyleBackColor = true;
            this.RS_Ok.Click += new System.EventHandler(this.RS_Ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dato";
            // 
            // RS_Nr_plade
            // 
            this.RS_Nr_plade.Location = new System.Drawing.Point(59, 88);
            this.RS_Nr_plade.Name = "RS_Nr_plade";
            this.RS_Nr_plade.Size = new System.Drawing.Size(100, 20);
            this.RS_Nr_plade.TabIndex = 4;
            // 
            // RS_Dato
            // 
            this.RS_Dato.Location = new System.Drawing.Point(59, 62);
            this.RS_Dato.Name = "RS_Dato";
            this.RS_Dato.Size = new System.Drawing.Size(100, 20);
            this.RS_Dato.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Navn";
            // 
            // Rediger_Stamdata
            // 
            this.Rediger_Stamdata.AutoSize = true;
            this.Rediger_Stamdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Rediger_Stamdata.Location = new System.Drawing.Point(3, 10);
            this.Rediger_Stamdata.Name = "Rediger_Stamdata";
            this.Rediger_Stamdata.Size = new System.Drawing.Size(154, 22);
            this.Rediger_Stamdata.TabIndex = 0;
            this.Rediger_Stamdata.Text = "Rediger Stamdata";
            // 
            // SS_Combobox
            // 
            this.SS_Combobox.FormattingEnabled = true;
            this.SS_Combobox.Location = new System.Drawing.Point(87, 30);
            this.SS_Combobox.Name = "SS_Combobox";
            this.SS_Combobox.Size = new System.Drawing.Size(100, 21);
            this.SS_Combobox.TabIndex = 6;
            this.SS_Combobox.SelectedIndexChanged += new System.EventHandler(this.SS_Combobox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SS_Cancel);
            this.panel3.Controls.Add(this.SS_Ok);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Slet_Stamdata);
            this.panel3.Controls.Add(this.SS_Combobox);
            this.panel3.Location = new System.Drawing.Point(440, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 7;
            // 
            // SS_Cancel
            // 
            this.SS_Cancel.Location = new System.Drawing.Point(7, 74);
            this.SS_Cancel.Name = "SS_Cancel";
            this.SS_Cancel.Size = new System.Drawing.Size(75, 23);
            this.SS_Cancel.TabIndex = 6;
            this.SS_Cancel.Text = "Cancel";
            this.SS_Cancel.UseVisualStyleBackColor = true;
            // 
            // SS_Ok
            // 
            this.SS_Ok.Location = new System.Drawing.Point(122, 74);
            this.SS_Ok.Name = "SS_Ok";
            this.SS_Ok.Size = new System.Drawing.Size(75, 23);
            this.SS_Ok.TabIndex = 8;
            this.SS_Ok.Text = "OK";
            this.SS_Ok.UseVisualStyleBackColor = true;
            this.SS_Ok.Click += new System.EventHandler(this.SS_Ok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Navn";
            // 
            // Slet_Stamdata
            // 
            this.Slet_Stamdata.AutoSize = true;
            this.Slet_Stamdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Slet_Stamdata.Location = new System.Drawing.Point(3, 5);
            this.Slet_Stamdata.Name = "Slet_Stamdata";
            this.Slet_Stamdata.Size = new System.Drawing.Size(122, 22);
            this.Slet_Stamdata.TabIndex = 6;
            this.Slet_Stamdata.Text = "Slet Stamdata";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.OKL_Cancel);
            this.panel4.Controls.Add(this.OKL_Ok);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.OKL_comboBox);
            this.panel4.Controls.Add(this.OKL_Nr_plade);
            this.panel4.Controls.Add(this.OKL_Navn);
            this.panel4.Controls.Add(this.OKL_Opgave);
            this.panel4.Controls.Add(this.OKL_Dato);
            this.panel4.Controls.Add(this.OKL_TextBox_Opg);
            this.panel4.Controls.Add(this.OKL_Textbox_Nr_plade);
            this.panel4.Controls.Add(this.OKL_Texbox_Dato);
            this.panel4.Location = new System.Drawing.Point(846, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 179);
            this.panel4.TabIndex = 9;
            // 
            // OKL_Cancel
            // 
            this.OKL_Cancel.Location = new System.Drawing.Point(4, 145);
            this.OKL_Cancel.Name = "OKL_Cancel";
            this.OKL_Cancel.Size = new System.Drawing.Size(75, 23);
            this.OKL_Cancel.TabIndex = 9;
            this.OKL_Cancel.Text = "Cancel";
            this.OKL_Cancel.UseVisualStyleBackColor = true;
            // 
            // OKL_Ok
            // 
            this.OKL_Ok.Location = new System.Drawing.Point(119, 145);
            this.OKL_Ok.Name = "OKL_Ok";
            this.OKL_Ok.Size = new System.Drawing.Size(75, 23);
            this.OKL_Ok.TabIndex = 10;
            this.OKL_Ok.Text = "OK";
            this.OKL_Ok.UseVisualStyleBackColor = true;
            this.OKL_Ok.Click += new System.EventHandler(this.OKL_Ok_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Opret Kørsels log";
            // 
            // OKL_comboBox
            // 
            this.OKL_comboBox.FormattingEnabled = true;
            this.OKL_comboBox.Location = new System.Drawing.Point(82, 33);
            this.OKL_comboBox.Name = "OKL_comboBox";
            this.OKL_comboBox.Size = new System.Drawing.Size(100, 21);
            this.OKL_comboBox.TabIndex = 7;
            this.OKL_comboBox.SelectedIndexChanged += new System.EventHandler(this.OKL_comboBox_SelectedIndexChanged);
            // 
            // OKL_Nr_plade
            // 
            this.OKL_Nr_plade.AutoSize = true;
            this.OKL_Nr_plade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.OKL_Nr_plade.Location = new System.Drawing.Point(26, 88);
            this.OKL_Nr_plade.Name = "OKL_Nr_plade";
            this.OKL_Nr_plade.Size = new System.Drawing.Size(50, 13);
            this.OKL_Nr_plade.TabIndex = 9;
            this.OKL_Nr_plade.Text = "Nr_plade";
            // 
            // OKL_Navn
            // 
            this.OKL_Navn.AutoSize = true;
            this.OKL_Navn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.OKL_Navn.Location = new System.Drawing.Point(30, 33);
            this.OKL_Navn.Name = "OKL_Navn";
            this.OKL_Navn.Size = new System.Drawing.Size(35, 15);
            this.OKL_Navn.TabIndex = 6;
            this.OKL_Navn.Text = "Navn";
            // 
            // OKL_Opgave
            // 
            this.OKL_Opgave.AutoSize = true;
            this.OKL_Opgave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.OKL_Opgave.Location = new System.Drawing.Point(30, 113);
            this.OKL_Opgave.Name = "OKL_Opgave";
            this.OKL_Opgave.Size = new System.Drawing.Size(49, 15);
            this.OKL_Opgave.TabIndex = 6;
            this.OKL_Opgave.Text = "Opgave";
            // 
            // OKL_Dato
            // 
            this.OKL_Dato.AutoSize = true;
            this.OKL_Dato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.OKL_Dato.Location = new System.Drawing.Point(30, 59);
            this.OKL_Dato.Name = "OKL_Dato";
            this.OKL_Dato.Size = new System.Drawing.Size(33, 15);
            this.OKL_Dato.TabIndex = 8;
            this.OKL_Dato.Text = "Dato";
            // 
            // OKL_TextBox_Opg
            // 
            this.OKL_TextBox_Opg.Location = new System.Drawing.Point(82, 112);
            this.OKL_TextBox_Opg.Name = "OKL_TextBox_Opg";
            this.OKL_TextBox_Opg.Size = new System.Drawing.Size(100, 20);
            this.OKL_TextBox_Opg.TabIndex = 7;
            // 
            // OKL_Textbox_Nr_plade
            // 
            this.OKL_Textbox_Nr_plade.Location = new System.Drawing.Point(82, 85);
            this.OKL_Textbox_Nr_plade.Name = "OKL_Textbox_Nr_plade";
            this.OKL_Textbox_Nr_plade.Size = new System.Drawing.Size(100, 20);
            this.OKL_Textbox_Nr_plade.TabIndex = 11;
            // 
            // OKL_Texbox_Dato
            // 
            this.OKL_Texbox_Dato.Location = new System.Drawing.Point(82, 59);
            this.OKL_Texbox_Dato.Name = "OKL_Texbox_Dato";
            this.OKL_Texbox_Dato.Size = new System.Drawing.Size(100, 20);
            this.OKL_Texbox_Dato.TabIndex = 10;
            this.OKL_Texbox_Dato.TextChanged += new System.EventHandler(this.OKL_Texbox_Dato_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(23, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Personale data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(841, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Kørsels log registrering";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(77, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 188);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userdataBindingSource
            // 
            this.userdataBindingSource.DataMember = "User_data";
            this.userdataBindingSource.DataSource = this.din_morDataSet;
            // 
            // din_morDataSet
            // 
            this.din_morDataSet.DataSetName = "Din_morDataSet";
            this.din_morDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_dataTableAdapter
            // 
            this.user_dataTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Location = new System.Drawing.Point(661, 234);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(429, 188);
            this.dataGridView2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.din_morDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OS_Ok;
        private System.Windows.Forms.TextBox OS_TextBox_Navn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Opret_Stamdata;
        private System.Windows.Forms.Label OS_Nr_plade;
        private System.Windows.Forms.Label OS_Dato;
        private System.Windows.Forms.TextBox OS_TextBox_Nr_plade;
        private System.Windows.Forms.TextBox OS_TextBox_Dato;
        private System.Windows.Forms.Label OS_Navn;
        private System.Windows.Forms.Button OS_Cancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox RS_Combobox;
        private System.Windows.Forms.Button RS_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RS_Ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RS_Nr_plade;
        private System.Windows.Forms.TextBox RS_Dato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Rediger_Stamdata;
        private System.Windows.Forms.ComboBox SS_Combobox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Slet_Stamdata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SS_Cancel;
        private System.Windows.Forms.Button SS_Ok;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button OKL_Cancel;
        private System.Windows.Forms.Button OKL_Ok;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox OKL_comboBox;
        private System.Windows.Forms.Label OKL_Nr_plade;
        private System.Windows.Forms.Label OKL_Navn;
        private System.Windows.Forms.Label OKL_Opgave;
        private System.Windows.Forms.Label OKL_Dato;
        private System.Windows.Forms.TextBox OKL_TextBox_Opg;
        private System.Windows.Forms.TextBox OKL_Textbox_Nr_plade;
        private System.Windows.Forms.TextBox OKL_Texbox_Dato;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Din_morDataSet din_morDataSet;
        private System.Windows.Forms.BindingSource userdataBindingSource;
        private Din_morDataSetTableAdapters.User_dataTableAdapter user_dataTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

