using System;
using System.CodeDom;
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

    public partial class AddCustomerPage : Form
    {
        PerdePerakendeDBEntities db = new PerdePerakendeDBEntities();

        public AddCustomerPage()
        {
            InitializeComponent();
            FormClosing += AddCustomerPage_FormClosing;
        }

        private void PerformPostClosingOperations()
        {


            if (Application.OpenForms["SellingPage"] is SellingPage sellingPage)
            {
                sellingPage.RefreshData();
            }
        }

        private void AddCustomerPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Müşteri Ekleme",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;


            }
            PerformPostClosingOperations();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridMusteriler.DataSource = db.Musteriler.ToList();
        }

        private void DataGridMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            NameSurname.Text = DataGridMusteriler.CurrentRow.Cells[1].Value.ToString();
            PhoneNumber.Text = DataGridMusteriler.CurrentRow.Cells[2].Value.ToString();
            Email.Text = DataGridMusteriler.CurrentRow.Cells[3].Value.ToString();
            Adress.Text = DataGridMusteriler.CurrentRow.Cells[4].Value.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NameSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerAdd_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            try
            {
                musteri.AdSoyad = NameSurname.Text;
                musteri.Tel = PhoneNumber.Text;
                musteri.EMail = Email.Text;
                musteri.Adress = Adress.Text;

                if (musteri.AdSoyad.Length > 0 && musteri.Tel.Length > 0 && musteri.EMail.Length > 0 && musteri.Adress.Length > 0)
                {
                    db.Musteriler.Add(musteri);
                    db.SaveChanges();
                    DataGridMusteriler.DataSource = db.Musteriler.ToList();

                    NameSurname.Text = "";
                    PhoneNumber.Text = "";
                    Email.Text = "";
                    Adress.Text = "";
                    MessageBox.Show("Müşteri başarıyla eklendi.");
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                }
            }
            catch
            {
                MessageBox.Show("Müşteri eklenirken bir hata oluştu.");
            }
        }


    }
}
