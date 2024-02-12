using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerdePerakende.Models;

namespace PerdePerakende
{
    public partial class AddProductPage : Form
    {

        PerdePerakendeDBEntities db = new PerdePerakendeDBEntities();

        public AddProductPage()
        {
            InitializeComponent();
            FormClosing += AddProductPage_FormClosing;
        }
        private void PerformPostClosingOperations()
        {


            if (Application.OpenForms["SellingPage"] is SellingPage sellingPage)
            {
                sellingPage.RefreshData();
            }
        }



        private void AddProductPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Ürün EKleme",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;


            }
            PerformPostClosingOperations();



        }

        private void DataGridMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PerdeName.Text = dataGridPerdeler.CurrentRow.Cells[1].Value.ToString();
            PerdeM2.Text = dataGridPerdeler.CurrentRow.Cells[2].Value.ToString();
            PerdePrice.Text = dataGridPerdeler.CurrentRow.Cells[3].Value.ToString();
        }

        private void PerdeM2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            dataGridPerdeler.DataSource = db.Perdeler.ToList();

        }

        private void PerdeAdd_Click(object sender, EventArgs e)
        {
            Perdeler perde = new Perdeler();
            try
            {
                perde.PerdeAdı = PerdeName.Text;

                perde.M2 = PerdeM2.Text;
                perde.Fiyat = PerdePrice.Text;
                if (perde.PerdeAdı.Length > 0 && perde.M2.Length > 0 && perde.Fiyat.Length > 0)
                {
                    db.Perdeler.Add(perde);
                    db.SaveChanges();
                    dataGridPerdeler.DataSource = db.Perdeler.ToList();
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
                }   

                MessageBox.Show("Perde Başarıyla Eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Perde Eklenirken Hata Oluştu ");
            }
        }

        private void dataGridPerdeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PerdeName.Text = dataGridPerdeler.CurrentRow.Cells[1].Value.ToString();
            PerdeM2.Text = dataGridPerdeler.CurrentRow.Cells[2].Value.ToString();
            PerdePrice.Text = dataGridPerdeler.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
