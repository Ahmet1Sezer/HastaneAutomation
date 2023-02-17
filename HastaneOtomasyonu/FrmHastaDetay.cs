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

namespace HastaneOtomasyonu
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;

        SqlConnect bgl = new SqlConnect();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            // Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select HastaAD,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0]+""+dr[1];
            }
            bgl.baglanti().Close();

            // Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc , bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Branşları Çekme

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);  
            }
            bgl.baglanti().Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Bransa Göre Doktor Çekme
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aktif Randevu Ekranı
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBölüm='" + CmbBrans.Text + "'" + "and RandevuDoktor='" + CmbDoktor.Text+"' and RandevuDurum=0",  bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        
        private void LnkBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCno = LblTC.Text;
            fr.Show();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuİd=@p3 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu ALINDI");
            dataGridView1.Refresh();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }      
    }
}
