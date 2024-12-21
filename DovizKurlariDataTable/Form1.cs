using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DovizKurlariDataTable
{
    public partial class Form1 : Form
    {
        int rowindex = -1;
        public Form1()
        {
            InitializeComponent();
            lbl_secilen.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument kurlar = XDocument.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            XElement rootElement = kurlar.Root;
            DataTable dt = new DataTable();
            dt.Columns.Add("Kod");
            dt.Columns.Add("Isim");
            dt.Columns.Add("Alış");
            dt.Columns.Add("Satış");
            foreach (XElement kur in rootElement.Elements())
            {
                string kod = kur.Attribute("Kod").Value;
                string isim = kur.Element("Isim").Value;
                double satis = 0;
                double alis = 0;
                int unit = Convert.ToInt32(kur.Element("Unit").Value);
                if (!string.IsNullOrEmpty(kur.Element("ForexSelling").Value))
                {
                    string strSatis = kur.Element("ForexSelling").Value.Replace(".", ",");
                    satis = Convert.ToDouble(strSatis) / unit;
                }
                if (!string.IsNullOrEmpty(kur.Element("ForexBuying").Value))
                {
                    string strAlis = kur.Element("ForexBuying").Value.Replace(".", ",");
                    alis = Convert.ToDouble(strAlis) / unit;
                }
                dt.Rows.Add(kod, isim, alis, satis);
            }
            dgv_kurlar.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rowindex >= 0)
            {
                double id = Convert.ToDouble(dgv_kurlar.Rows[rowindex].Cells[3].Value);
                lbl_yapar.Text = (Convert.ToDouble(tb_neKadar.Text) * id).ToString();
            }
        }
        private void dgv_kurlar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rowindex = dgv_kurlar.HitTest(e.X, e.Y).RowIndex;
                if (rowindex != -1)
                {
                    dgv_kurlar.ClearSelection();
                    dgv_kurlar.Rows[rowindex].Selected = true;
                    if (rowindex >= 0)
                    {
                        string id = dgv_kurlar.Rows[rowindex].Cells[1].Value.ToString();
                        lbl_secilen.Text = id;
                        lbl_secilen1.Text = id;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rowindex >= 0)
            {
                double id = Convert.ToDouble(dgv_kurlar.Rows[rowindex].Cells[3].Value);
                lbl_yapar1.Text = (Convert.ToDouble(tb_neKadar1.Text) / id).ToString();
                lbl_yapar1.Text = Math.Round(Convert.ToDouble(lbl_yapar1.Text), 2).ToString();
            }
        }
    }
}
