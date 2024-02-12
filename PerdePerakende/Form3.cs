using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PerdePerakende.Models;

namespace PerdePerakende
{
    public partial class SellingPage : Form
    {
        PerdePerakendeDBEntities db = new PerdePerakendeDBEntities();

        public SellingPage()
        {
            InitializeComponent();

        }

        public void refresh()
        {
            List<Musteriler> musteriList = db.Musteriler.ToList();
            comboBoxMusteriler.DataSource = musteriList;
            comboBoxMusteriler.DisplayMember = "AdSoyad";
            comboBoxMusteriler.ValueMember = "ID";

            List<Perdeler> perdeList = db.Perdeler.ToList();
            comboBoxPerdeler.DataSource = perdeList;
            comboBoxPerdeler.DisplayMember = "PerdeAdı";
            comboBoxPerdeler.ValueMember = "PerdeID";

            dataGridViewMusteriler.DataSource = db.Musteriler.ToList();
            dataGridViewSelling.DataSource = db.Satis.ToList();
        }
        private void Selling_Load(object sender, EventArgs e)
        {
            refresh();
        }
        public void RefreshData()
        {
            refresh();

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxMusteriler.SelectedValue != null && comboBoxPerdeler.SelectedValue != null)
                {
                    int secilenMusteriID = (int)comboBoxMusteriler.SelectedValue;
                    int secilenPerdeID = (int)comboBoxPerdeler.SelectedValue;
                    string secilenMusteriAdSoyad = comboBoxMusteriler.Text;
                    string secilenPerdeAdi = comboBoxPerdeler.Text;
                    string secilenAdet = txtAdet.Text;

                    string secilenOlcu = txtOlcu.Text;
                    int en = 0;
                    int boy = 0;

                    string[] boyutlar = secilenOlcu.Split('*');
                    if (boyutlar.Length == 2)
                    {
                        en = Convert.ToInt32(boyutlar[0].Trim());
                        boy = Convert.ToInt32(boyutlar[1].Trim());
                    }
                    else
                    {
                        MessageBox.Show("Uygun formatta veri yok, hata işlemleri yapabilirsiniz.");
                        return;
                    }

                    Satis satis = new Satis();
                    satis.MÜŞTERİID = (int)comboBoxMusteriler.SelectedValue;
                    satis.MÜŞTERİ = comboBoxMusteriler.Text;
                    satis.MİKTAR = txtAdet.Text;
                    satis.EN = Convert.ToString(en);
                    satis.BOY = Convert.ToString(boy);
                    satis.M2 = Convert.ToString(en * boy);
                    string fiyat = db.Perdeler.Where(x => x.PerdeID == secilenPerdeID).Select(x => x.Fiyat).FirstOrDefault();
                    satis.FİYAT = fiyat;


                    db.Satis.Add(satis);
                    db.SaveChanges();
                    dataGridViewSelling.DataSource = db.Satis.ToList();
                    dataGridViewMusteriler.DataSource = db.Musteriler.ToList();
                    MessageBox.Show("Satış başarıyla gerçekleşti.");
                }
                else
                {
                    MessageBox.Show("Lütfen bir müşteri ve perde seçin.");
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
                MessageBox.Show("Validation hatası oluştu. Detayları yukarıda gösterildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void comboBoxPerdeler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewSelling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddCustomerPage_Click(object sender, EventArgs e)
        {
            AddCustomerPage addCustomerPage = new AddCustomerPage();
            addCustomerPage.ShowDialog();



        }

        private void btnAddProductPage_Click(object sender, EventArgs e)
        {
            AddProductPage addProductPage = new AddProductPage();
            addProductPage.ShowDialog();
        }
    }
}
