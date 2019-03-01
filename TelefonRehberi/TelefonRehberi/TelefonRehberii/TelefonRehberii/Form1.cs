using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TelefonRehberii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        void KisiGetir()
        {
            baglanti = new SqlConnection("Data Source = DESKTOP-I0MPVU6\\SQLEXPRESS; Initial Catalog = RehberDB;trusted_connection=true;"); /*User Id = sa; password = 1234;*/
            baglanti.Open();
            da = new SqlDataAdapter("Select * from tbl_Kisiler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisiGetir();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into tbl_Kisiler(Ad,Soyad,Telefon)values(@Ad,@Soyad,@Telefon)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Ad", text_Adi.Text);
            komut.Parameters.AddWithValue("@Soyad", text_Soyadi.Text);
            komut.Parameters.AddWithValue("@Telefon", text_Numara.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text_Soyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            text_Numara.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete from tbl_Kisiler where KisiID=@Id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Id", Convert.ToInt32(text_id.Text));
          

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiGetir();
        }

        private void text_Arama_TextChanged(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("Select *from tbl_Kisiler where ad like '" + text_Arama.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "tbl_Kisiler");
            dataGridView1.DataSource = ds.Tables["tbl_Kisiler"];
            baglanti.Close();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "Update tbl_Kisiler Set Ad=@Ad,Soyad=@Soyad,Telefon=@Telefon Where Ad=@Ad";
            komut = new SqlCommand(sorgu, baglanti);
            
            komut.Parameters.AddWithValue("@Ad", text_Adi.Text);
            komut.Parameters.AddWithValue("@Soyad", text_Soyadi.Text);
            komut.Parameters.AddWithValue("@Telefon", text_Numara.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiGetir();
        }
    }
}
