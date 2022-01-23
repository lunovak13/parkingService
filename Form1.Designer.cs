namespace projekat_pravi
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garazaDataSet = new projekat_pravi.GarazaDataSet();
            this.markaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.markaTableAdapter = new projekat_pravi.GarazaDataSetTableAdapters.MarkaTableAdapter();
            this.autoTableAdapter = new projekat_pravi.GarazaDataSetTableAdapters.AutoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbVlasnik = new System.Windows.Forms.TextBox();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbBoja = new System.Windows.Forms.TextBox();
            this.tbMesto = new System.Windows.Forms.TextBox();
            this.tbRadnik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUbaci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.autoBindingSource, "Marka", true));
            this.comboBox1.DataSource = this.markaBindingSource;
            this.comboBox1.DisplayMember = "Ime_Marke";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IDMarka";
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataMember = "Auto";
            this.autoBindingSource.DataSource = this.garazaDataSet;
            // 
            // garazaDataSet
            // 
            this.garazaDataSet.DataSetName = "GarazaDataSet";
            this.garazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markaBindingSource
            // 
            this.markaBindingSource.DataMember = "Marka";
            this.markaBindingSource.DataSource = this.garazaDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesi marku";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(219, 114);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 2;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // markaTableAdapter
            // 
            this.markaTableAdapter.ClearBeforeFill = true;
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUbaci);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbRadnik);
            this.groupBox1.Controls.Add(this.tbMesto);
            this.groupBox1.Controls.Add(this.tbBoja);
            this.groupBox1.Controls.Add(this.tbMarka);
            this.groupBox1.Controls.Add(this.tbVlasnik);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Location = new System.Drawing.Point(18, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "unesite automobil koji ulazi u garazu";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(122, 19);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(272, 20);
            this.tbID.TabIndex = 0;
            // 
            // tbVlasnik
            // 
            this.tbVlasnik.Location = new System.Drawing.Point(122, 45);
            this.tbVlasnik.Name = "tbVlasnik";
            this.tbVlasnik.Size = new System.Drawing.Size(272, 20);
            this.tbVlasnik.TabIndex = 1;
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(122, 71);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(272, 20);
            this.tbMarka.TabIndex = 2;
            // 
            // tbBoja
            // 
            this.tbBoja.Location = new System.Drawing.Point(122, 97);
            this.tbBoja.Name = "tbBoja";
            this.tbBoja.Size = new System.Drawing.Size(272, 20);
            this.tbBoja.TabIndex = 3;
            // 
            // tbMesto
            // 
            this.tbMesto.Location = new System.Drawing.Point(122, 123);
            this.tbMesto.Name = "tbMesto";
            this.tbMesto.Size = new System.Drawing.Size(272, 20);
            this.tbMesto.TabIndex = 4;
            // 
            // tbRadnik
            // 
            this.tbRadnik.Location = new System.Drawing.Point(122, 149);
            this.tbRadnik.Name = "tbRadnik";
            this.tbRadnik.Size = new System.Drawing.Size(272, 20);
            this.tbRadnik.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "vlasnik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "boja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "mesto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "radnik";
            // 
            // btnUbaci
            // 
            this.btnUbaci.Location = new System.Drawing.Point(319, 185);
            this.btnUbaci.Name = "btnUbaci";
            this.btnUbaci.Size = new System.Drawing.Size(75, 23);
            this.btnUbaci.TabIndex = 12;
            this.btnUbaci.Text = "Ubaci";
            this.btnUbaci.UseVisualStyleBackColor = true;
            this.btnUbaci.Click += new System.EventHandler(this.btnUbaci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPotvrdi;
        private GarazaDataSet garazaDataSet;
        private System.Windows.Forms.BindingSource markaBindingSource;
        private GarazaDataSetTableAdapters.MarkaTableAdapter markaTableAdapter;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private GarazaDataSetTableAdapters.AutoTableAdapter autoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRadnik;
        private System.Windows.Forms.TextBox tbMesto;
        private System.Windows.Forms.TextBox tbBoja;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.TextBox tbVlasnik;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnUbaci;
    }
}

