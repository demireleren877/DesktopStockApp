using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string grsypn = "";
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "e_oto" && textBox3.Text == "8033")
            {
                grsypn = textBox2.Text;
                XtraForm1 anasayfa = new XtraForm1();
                anasayfa.Show();
                this.Hide();

            }
            else
                label6.Visible = true;
            textBox2.Clear();
            textBox3.Clear();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
