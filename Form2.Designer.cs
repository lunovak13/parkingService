namespace projekat_pravi
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDautoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vlasnik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vlasnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garazaDataSet = new projekat_pravi.GarazaDataSet();
            this.Marka = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.markaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Radnik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.radnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoTableAdapter = new projekat_pravi.GarazaDataSetTableAdapters.AutoTableAdapter();
            this.vlasnikTableAdapter = new projekat_pravi.GarazaDataSetTableAdapters.VlasnikTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.tbPrikaz = new System.Windows.Forms.TextBox();
            this.markaTableAdapter = new projekat_pravi.GarazaDataSetTableAdapters.MarkaTableAdapter();
            this.radnikTableAdapter = new projekat_pravi.GarazaDataSetTableAdapters.RadnikTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDautoDataGridViewTextBoxColumn,
            this.Vlasnik,
            this.Marka,
            this.bojaDataGridViewTextBoxColumn,
            this.mestoDataGridViewTextBoxColumn,
            this.Radnik});
            this.dataGridView1.DataSource = this.autoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDautoDataGridViewTextBoxColumn
            // 
            this.iDautoDataGridViewTextBoxColumn.DataPropertyName = "IDauto";
            this.iDautoDataGridViewTextBoxColumn.HeaderText = "IDauto";
            this.iDautoDataGridViewTextBoxColumn.Name = "iDautoDataGridViewTextBoxColumn";
            // 
            // Vlasnik
            // 
            this.Vlasnik.DataPropertyName = "Vlasnik";
            this.Vlasnik.DataSource = this.vlasnikBindingSource;
            this.Vlasnik.DisplayMember = "Ime";
            this.Vlasnik.HeaderText = "Vlasnik";
            this.Vlasnik.Name = "Vlasnik";
            this.Vlasnik.ValueMember = "IDVlasnik";
            // 
            // vlasnikBindingSource
            // 
            this.vlasnikBindingSource.DataMember = "Vlasnik";
            this.vlasnikBindingSource.DataSource = this.garazaDataSet;
            // 
            // garazaDataSet
            // 
            this.garazaDataSet.DataSetName = "GarazaDataSet";
            this.garazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "Marka";
            this.Marka.DataSource = this.markaBindingSource;
            this.Marka.DisplayMember = "Ime_Marke";
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.ValueMember = "IDMarka";
            // 
            // markaBindingSource
            // 
            this.markaBindingSource.DataMember = "Marka";
            this.markaBindingSource.DataSource = this.garazaDataSet;
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "Boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            // 
            // mestoDataGridViewTextBoxColumn
            // 
            this.mestoDataGridViewTextBoxColumn.DataPropertyName = "Mesto";
            this.mestoDataGridViewTextBoxColumn.HeaderText = "Mesto";
            this.mestoDataGridViewTextBoxColumn.Name = "mestoDataGridViewTextBoxColumn";
            // 
            // Radnik
            // 
            this.Radnik.DataPropertyName = "Radnik";
            this.Radnik.DataSource = this.radnikBindingSource;
            this.Radnik.DisplayMember = "Ime";
            this.Radnik.HeaderText = "Radnik";
            this.Radnik.Name = "Radnik";
            this.Radnik.ValueMember = "IDRadnik";
            // 
            // radnikBindingSource
            // 
            this.radnikBindingSource.DataMember = "Radnik";
            this.radnikBindingSource.DataSource = this.garazaDataSet;
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataMember = "Auto";
            this.autoBindingSource.DataSource = this.garazaDataSet;
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // vlasnikTableAdapter
            // 
            this.vlasnikTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "izbaci auto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox3);
            this.groupBox1.Controls.Add(this.btnIspisi);
            this.groupBox1.Controls.Add(this.tbPrikaz);
            this.groupBox1.Location = new System.Drawing.Point(13, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 187);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "prikaz";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(7, 47);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(187, 125);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "";
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(113, 18);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(75, 23);
            this.btnIspisi.TabIndex = 2;
            this.btnIspisi.Text = "ispisi";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // tbPrikaz
            // 
            this.tbPrikaz.Location = new System.Drawing.Point(7, 20);
            this.tbPrikaz.Name = "tbPrikaz";
            this.tbPrikaz.Size = new System.Drawing.Size(100, 20);
            this.tbPrikaz.TabIndex = 0;
            // 
            // markaTableAdapter
            // 
            this.markaTableAdapter.ClearBeforeFill = true;
            // 
            // radnikTableAdapter
            // 
            this.radnikTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "prikaz automobila izabrane marke";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(277, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(368, 160);
            this.listBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "podaci izabranog automobila";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 426);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlasnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GarazaDataSet garazaDataSet;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private GarazaDataSetTableAdapters.AutoTableAdapter autoTableAdapter;
        private System.Windows.Forms.BindingSource vlasnikBindingSource;
        private GarazaDataSetTableAdapters.VlasnikTableAdapter vlasnikTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPrikaz;
        private System.Windows.Forms.BindingSource markaBindingSource;
        private GarazaDataSetTableAdapters.MarkaTableAdapter markaTableAdapter;
        private System.Windows.Forms.BindingSource radnikBindingSource;
        private GarazaDataSetTableAdapters.RadnikTableAdapter radnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDautoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Vlasnik;
        private System.Windows.Forms.DataGridViewComboBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Radnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
    }
}