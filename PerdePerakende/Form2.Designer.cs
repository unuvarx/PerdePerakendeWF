namespace PerdePerakende
{
    partial class AddProductPage
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
            this.label4 = new System.Windows.Forms.Label();
            this.PerdeAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PerdePrice = new System.Windows.Forms.TextBox();
            this.label2313 = new System.Windows.Forms.Label();
            this.PerdeM2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PerdeName = new System.Windows.Forms.TextBox();
            this.dataGridPerdeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerdeler)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(389, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "ÜRÜN EKLEME";
            // 
            // PerdeAdd
            // 
            this.PerdeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PerdeAdd.BackColor = System.Drawing.Color.Blue;
            this.PerdeAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PerdeAdd.Location = new System.Drawing.Point(395, 471);
            this.PerdeAdd.Name = "PerdeAdd";
            this.PerdeAdd.Size = new System.Drawing.Size(310, 45);
            this.PerdeAdd.TabIndex = 21;
            this.PerdeAdd.Text = "Perde Ekle";
            this.PerdeAdd.UseVisualStyleBackColor = false;
            this.PerdeAdd.Click += new System.EventHandler(this.PerdeAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fiyat";
            // 
            // PerdePrice
            // 
            this.PerdePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PerdePrice.Location = new System.Drawing.Point(395, 414);
            this.PerdePrice.Name = "PerdePrice";
            this.PerdePrice.Size = new System.Drawing.Size(310, 20);
            this.PerdePrice.TabIndex = 17;
            // 
            // label2313
            // 
            this.label2313.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2313.AutoSize = true;
            this.label2313.Location = new System.Drawing.Point(392, 329);
            this.label2313.Name = "label2313";
            this.label2313.Size = new System.Drawing.Size(22, 13);
            this.label2313.TabIndex = 16;
            this.label2313.Text = "M2";
            // 
            // PerdeM2
            // 
            this.PerdeM2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PerdeM2.Location = new System.Drawing.Point(395, 345);
            this.PerdeM2.Name = "PerdeM2";
            this.PerdeM2.Size = new System.Drawing.Size(310, 20);
            this.PerdeM2.TabIndex = 15;
            this.PerdeM2.TextChanged += new System.EventHandler(this.PerdeM2_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Perde Adı";
            // 
            // PerdeName
            // 
            this.PerdeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PerdeName.Location = new System.Drawing.Point(395, 274);
            this.PerdeName.Name = "PerdeName";
            this.PerdeName.Size = new System.Drawing.Size(310, 20);
            this.PerdeName.TabIndex = 13;
            // 
            // dataGridPerdeler
            // 
            this.dataGridPerdeler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPerdeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPerdeler.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridPerdeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPerdeler.Location = new System.Drawing.Point(12, 559);
            this.dataGridPerdeler.Name = "dataGridPerdeler";
            this.dataGridPerdeler.Size = new System.Drawing.Size(1038, 150);
            this.dataGridPerdeler.TabIndex = 23;
            this.dataGridPerdeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPerdeler_CellContentClick);
            // 
            // AddProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 721);
            this.Controls.Add(this.dataGridPerdeler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PerdeAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PerdePrice);
            this.Controls.Add(this.label2313);
            this.Controls.Add(this.PerdeM2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PerdeName);
            this.Name = "AddProductPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerdeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PerdeAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PerdePrice;
        private System.Windows.Forms.Label label2313;
        private System.Windows.Forms.TextBox PerdeM2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PerdeName;
        private System.Windows.Forms.DataGridView dataGridPerdeler;
    }
}