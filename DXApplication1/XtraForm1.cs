using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Xml;
using DevExpress.XtraBars.Helpers;

namespace DXApplication1
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Server=tcp:eoto.database.windows.net,1433;Initial Catalog=stok;Persist Security Info=False;User ID=e-oto;Password=demirel-8033;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";

        }
       
        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl1_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (e.Button.Tag.ToString() == "min")
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
                if(XtraMessageBox.Show("Programdan Çıkılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                   {
                    Application.Exit();

                   }
               
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            string bugün = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugün);
            string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            label30.Text = USD;
            string EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            label31.Text = EURO;
            string POUND = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
            label32.Text = POUND;


            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Sharp Plus");


            xtraTabPage3.PageVisible = false;
            xtraTabPage7.PageVisible = true;
            xtraTabPage4.PageVisible = false;
            xtraTabPage5.PageVisible = false;
            xtraTabPage6.PageVisible = false;
            xtraTabPage8.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;

            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from markas",baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["marka"]);
                comboBox3.Items.Add(oku["marka"]);
                comboBox5.Items.Add(oku["marka"]);
                comboBox7.Items.Add(oku["marka"]);
                comboBox9.Items.Add(oku["marka"]);

            }
            baglan.Close();
            label19.Text = DateTime.Now.ToLongDateString();
            label20.Text = DateTime.Now.ToLongTimeString();
            label21.Text = Form1.grsypn;
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("insert into oturumgeçmişi (girişyapan,giriştarihi,girişsaati) values ('" + label21.Text.ToString() + "','" + label19.Text.ToString() + "','" + label20.Text.ToString() + "') ", baglan);
            komut2.ExecuteNonQuery();
            baglan.Close();
            label22.Text = DateTime.Now.ToShortDateString();
        }

        private void xtraTabPage7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label24.Text = DateTime.Now.ToLongTimeString();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage3.PageVisible = false;
            xtraTabPage4.PageVisible = true;
            xtraTabPage7.PageVisible = true;
            xtraTabPage5.PageVisible = false;
            xtraTabPage6.PageVisible = false;
            xtraTabPage8.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabControl2.SelectedTabPage = xtraTabPage4;
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage3.PageVisible = false;
            xtraTabPage4.PageVisible = false;
            xtraTabPage7.PageVisible = true;
            xtraTabPage5.PageVisible = true;
            xtraTabPage6.PageVisible = false;
            xtraTabPage8.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabControl2.SelectedTabPage = xtraTabPage5;
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage3.PageVisible = false;
            xtraTabPage4.PageVisible = false;
            xtraTabPage7.PageVisible = true;
            xtraTabPage5.PageVisible = false;
            xtraTabPage6.PageVisible = true;
            xtraTabPage8.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabControl2.SelectedTabPage = xtraTabPage6;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form1 giris = new Form1();
            this.Hide();
            giris.Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select modelad from modeller where markaid=@p1",baglan);
            komut.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex+1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox2.Items.Add(oku[0].ToString());
            }
            baglan.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from ürünler where model like '" + comboBox2.Text.ToString() + "%' and marka like '"+comboBox1.Text.ToString()+ "%' ", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
            clearall();
        }

        bool durum;

        void tekrar()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from ürünler where marka=@p1 and model=@p2 and ürünad=@p3", baglan);
            komut.Parameters.AddWithValue("@p1", comboBox3.Text);
            komut.Parameters.AddWithValue("@p2", comboBox4.Text);
            komut.Parameters.AddWithValue("@p3", textBox2.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                durum = false;
            }
            else
                durum = true;
            baglan.Close();
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
            if (comboBox3.Text != "" && comboBox4.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox6.Text != "" )
            {
                tekrar();
                if (durum == true)
                {
                    baglan.Open();
                    SqlCommand komut2 = new SqlCommand("insert into ürünler (ürünkod,marka,model,ürünad,stoksayısı,fiyat,eklenme_tarihi) values ('"+textBox11.Text.ToString()+"','" + comboBox3.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text + "','" + textBox6.Text + "','"+DateTime.Now.ToString()+"')", baglan);
                    komut2.ExecuteNonQuery();
                    baglan.Close();
                }
                else
                {
                    baglan.Open();
                    SqlCommand kommut = new SqlCommand("update ürünler set stoksayısı+= '" + textBox3.Text + "' where ürünkod like '" + textBox11.Text + "' ", baglan);
                    kommut.ExecuteNonQuery();
                    baglan.Close();

                }
            }
            
            clearall();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select modelad from modeller where markaid=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", comboBox3.SelectedIndex + 1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox4.Items.Add(oku[0].ToString());
            }
            baglan.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand(" update ürünler set stoksayısı-= '"+textBox4.Text+"' where ürünkod like '" + textBox12.Text + "' ", baglan);
            sil.ExecuteNonQuery();
            baglan.Close();
            clearall();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from ürünler where model like '"+comboBox6.Text.ToString()+"%' and marka like '"+comboBox5.Text.ToString()+"%' ", baglan);
           
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            baglan.Close();
            clearall();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select modelad from modeller where markaid=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", comboBox5.SelectedIndex + 1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox6.Items.Add(oku[0].ToString());
            }
            baglan.Close();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from ürünler where model like '" + comboBox4.Text.ToString() + "%' and marka like '"+comboBox3.Text.ToString()+"%' ", baglan);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglan.Close();
            clearall();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from ürünler where model like '" + comboBox2.Text.ToString() + "%' and ürünad like '"+textBox1.Text.ToString()+"%' ", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
            clearall();
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage3.PageVisible = false;
            xtraTabPage4.PageVisible = false;
            xtraTabPage7.PageVisible = true;
            xtraTabPage5.PageVisible = false;
            xtraTabPage6.PageVisible = false;
            xtraTabPage8.PageVisible = true;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabControl2.SelectedTabPage = xtraTabPage8;
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from ürünler where model like '" + comboBox8.Text.ToString() + "%' and marka like '" + comboBox7.Text.ToString() + "%' ", baglan);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            baglan.Close();
            clearall();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView4.SelectedCells[0].RowIndex;
            
            comboBox7.Text = dataGridView4.Rows[secilen].Cells[2].Value.ToString();
            comboBox8.Text = dataGridView4.Rows[secilen].Cells[3].Value.ToString();
            textBox9.Text = dataGridView4.Rows[secilen].Cells[4].Value.ToString();
            textBox8.Text = dataGridView4.Rows[secilen].Cells[5].Value.ToString();
            textBox7.Text = dataGridView4.Rows[secilen].Cells[6].Value.ToString();
            textBox10.Text = dataGridView4.Rows[secilen].Cells[1].Value.ToString();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            baglan.Open();
            if(comboBox7.Text!="" && comboBox8.Text!="" && textBox7.Text!="" && textBox8.Text!="" && textBox9.Text != "")
            {
                SqlCommand komut = new SqlCommand("update ürünler set marka='" + comboBox7.Text.ToString() + "',model='" + comboBox8.Text.ToString() + "',fiyat='" + textBox7.Text + "',ürünad='" +textBox9.Text.ToString() + "' where ürünkod='" + textBox10.Text.ToString() + "' ", baglan);
                komut.ExecuteNonQuery();
                
                
            }
            clearall();
            baglan.Close();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox8.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select modelad from modeller where markaid=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", comboBox7.SelectedIndex + 1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox8.Items.Add(oku[0].ToString());
            }
            baglan.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void xtraTabPage9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage3.PageVisible = false;
            xtraTabPage4.PageVisible = false;
            xtraTabPage7.PageVisible = true;
            xtraTabPage5.PageVisible = false;
            xtraTabPage6.PageVisible = false;
            xtraTabPage8.PageVisible = false;
            xtraTabPage9.PageVisible = true;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabControl2.SelectedTabPage = xtraTabPage9;
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from oturumgeçmişi ", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView5.DataSource = dt;
            baglan.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }


        private void simpleButton12_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hurriyet.com.tr/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.cnnturk.com/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void simpleButton10_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sabah.com.tr/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void xtraTabPage10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Pumpkin");
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage3.PageVisible = false;
            xtraTabPage4.PageVisible = false;
            xtraTabPage7.PageVisible = true;
            xtraTabPage5.PageVisible = false;
            xtraTabPage6.PageVisible = false;
            xtraTabPage8.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = true;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabControl2.SelectedTabPage = xtraTabPage10;
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Dark");
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Dark"); 
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Blueprint");
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Metropolis Dark");
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Darkroom");
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Sharp Plus");
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand(" update ürünler set stoksayısı+= '" + textBox3.Text + "' where ürünkod like '" + textBox11.Text + "' ", baglan);
            sil.ExecuteNonQuery();
            baglan.Close();
            clearall();
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage3.PageVisible = false;
            xtraTabPage4.PageVisible = false;
            xtraTabPage7.PageVisible = true;
            xtraTabPage5.PageVisible = false;
            xtraTabPage6.PageVisible = false;
            xtraTabPage8.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = true;
            xtraTabPage12.PageVisible = false;
            xtraTabControl2.SelectedTabPage = xtraTabPage11;
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void navBarItem11_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage3.PageVisible = false;
            xtraTabPage4.PageVisible = false;
            xtraTabPage7.PageVisible = true;
            xtraTabPage5.PageVisible = false;
            xtraTabPage6.PageVisible = false;
            xtraTabPage8.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = true;
            xtraTabControl2.SelectedTabPage = xtraTabPage12;
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand(" update ürünler set stoksayısı-= '" + textBox4.Text + "' where ürünkod like '" + textBox12.Text + "' ", baglan);
            sil.ExecuteNonQuery();
            baglan.Close();
            clearall();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox10.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select modelad from modeller where markaid=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", comboBox9.SelectedIndex + 1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox10.Items.Add(oku[0].ToString());
            }
            baglan.Close();
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage3.PageVisible = true;
            xtraTabPage4.PageVisible = false;
            xtraTabPage7.PageVisible = true;
            xtraTabPage5.PageVisible = false;
            xtraTabPage6.PageVisible = false;
            xtraTabPage8.PageVisible = false;
            xtraTabPage9.PageVisible = false;
            xtraTabPage10.PageVisible = false;
            xtraTabPage11.PageVisible = false;
            xtraTabPage12.PageVisible = false;
            xtraTabControl2.SelectedTabPage = xtraTabPage3;
        }
    }
}