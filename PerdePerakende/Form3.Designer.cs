namespace PerdePerakende
{
    partial class SellingPage
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
            this.comboBoxMusteriler = new System.Windows.Forms.ComboBox();
            this.Müşteri = new System.Windows.Forms.Label();
            this.comboBoxPerdeler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnAddCustomerPage = new System.Windows.Forms.Button();
            this.btnAddProductPage = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtOlcu = new System.Windows.Forms.TextBox();
            this.dataGridViewSelling = new System.Windows.Forms.DataGridView();
            this.dataGridViewMusteriler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMusteriler
            // 
            this.comboBoxMusteriler.FormattingEnabled = true;
            this.comboBoxMusteriler.Location = new System.Drawing.Point(9, 151);
            this.comboBoxMusteriler.Name = "comboBoxMusteriler";
            this.comboBoxMusteriler.Size = new System.Drawing.Size(120, 21);
            this.comboBoxMusteriler.TabIndex = 0;
            this.comboBoxMusteriler.SelectedIndexChanged += new System.EventHandler(this.comboBoxMusteriler_SelectedIndexChanged);
            // 
            // Müşteri
            // 
            this.Müşteri.AutoSize = true;
            this.Müşteri.Location = new System.Drawing.Point(6, 135);
            this.Müşteri.Name = "Müşteri";
            this.Müşteri.Size = new System.Drawing.Size(62, 13);
            this.Müşteri.TabIndex = 1;
            this.Müşteri.Text = "Müşteri İsmi";
            // 
            // comboBoxPerdeler
            // 
            this.comboBoxPerdeler.FormattingEnabled = true;
            this.comboBoxPerdeler.Location = new System.Drawing.Point(189, 127);
            this.comboBoxPerdeler.Name = "comboBoxPerdeler";
            this.comboBoxPerdeler.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPerdeler.TabIndex = 2;
            this.comboBoxPerdeler.SelectedIndexChanged += new System.EventHandler(this.comboBoxPerdeler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Perde Tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ölçüleri";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(191, 185);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(103, 45);
            this.btnSell.TabIndex = 10;
            this.btnSell.Text = "Satış";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(319, 185);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(103, 45);
            this.btnContinue.TabIndex = 11;
            this.btnContinue.Text = "İptal";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomerPage
            // 
            this.btnAddCustomerPage.Location = new System.Drawing.Point(784, 111);
            this.btnAddCustomerPage.Name = "btnAddCustomerPage";
            this.btnAddCustomerPage.Size = new System.Drawing.Size(98, 38);
            this.btnAddCustomerPage.TabIndex = 12;
            this.btnAddCustomerPage.Text = "Müşteri Ekle";
            this.btnAddCustomerPage.UseVisualStyleBackColor = true;
            this.btnAddCustomerPage.Click += new System.EventHandler(this.btnAddCustomerPage_Click);
            // 
            // btnAddProductPage
            // 
            this.btnAddProductPage.Location = new System.Drawing.Point(784, 192);
            this.btnAddProductPage.Name = "btnAddProductPage";
            this.btnAddProductPage.Size = new System.Drawing.Size(98, 38);
            this.btnAddProductPage.TabIndex = 13;
            this.btnAddProductPage.Text = "Ürün ekle";
            this.btnAddProductPage.UseVisualStyleBackColor = true;
            this.btnAddProductPage.Click += new System.EventHandler(this.btnAddProductPage_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(349, 128);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 20);
            this.txtAdet.TabIndex = 14;
            // 
            // txtOlcu
            // 
            this.txtOlcu.Location = new System.Drawing.Point(488, 127);
            this.txtOlcu.Name = "txtOlcu";
            this.txtOlcu.Size = new System.Drawing.Size(100, 20);
            this.txtOlcu.TabIndex = 15;
            // 
            // dataGridViewSelling
            // 
            this.dataGridViewSelling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSelling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelling.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelling.Location = new System.Drawing.Point(9, 397);
            this.dataGridViewSelling.Name = "dataGridViewSelling";
            this.dataGridViewSelling.Size = new System.Drawing.Size(1082, 150);
            this.dataGridViewSelling.TabIndex = 16;
            this.dataGridViewSelling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSelling_CellContentClick);
            // 
            // dataGridViewMusteriler
            // 
            this.dataGridViewMusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteriler.Location = new System.Drawing.Point(9, 604);
            this.dataGridViewMusteriler.Name = "dataGridViewMusteriler";
            this.dataGridViewMusteriler.Size = new System.Drawing.Size(1082, 150);
            this.dataGridViewMusteriler.TabIndex = 17;
            // 
            // SellingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 766);
            this.Controls.Add(this.dataGridViewMusteriler);
            this.Controls.Add(this.dataGridViewSelling);
            this.Controls.Add(this.txtOlcu);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.btnAddProductPage);
            this.Controls.Add(this.btnAddCustomerPage);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPerdeler);
            this.Controls.Add(this.Müşteri);
            this.Controls.Add(this.comboBoxMusteriler);
            this.Name = "SellingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Yap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Selling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMusteriler;
        private System.Windows.Forms.Label Müşteri;
        private System.Windows.Forms.ComboBox comboBoxPerdeler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnAddCustomerPage;
        private System.Windows.Forms.Button btnAddProductPage;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtOlcu;
        private System.Windows.Forms.DataGridView dataGridViewSelling;
        private System.Windows.Forms.DataGridView dataGridViewMusteriler;
    }
}