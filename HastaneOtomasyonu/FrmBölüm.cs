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
    public partial class FrmBölüm : Form
    {
        public FrmBölüm()
        {
            InitializeComponent();
        }

        SqlConnect bgl = new SqlConnect();
        private void FrmBölüm_Load(object sender, EventArgs e)
        {
           DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;  
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1",TxtBölüm.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtİD.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBölüm.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Branslar where Bransİd=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", TxtBölüm.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Branslar set BransAd=@p1 where Bransİd=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBölüm.Text);
            komut.Parameters.AddWithValue("@p2", TxtBölüm.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
