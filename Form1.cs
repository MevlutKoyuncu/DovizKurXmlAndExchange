using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DovizKurlariDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Show the loading form
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();

            // Load the data asynchronously
            await Task.Run(() => LoadData());

            // Close the loading form
            loadingForm.Close();
        }

        private void LoadData()
        {
            XDocument kurlar = XDocument.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            XElement rootElement = kurlar.Root;
            DataTable dt = new DataTable();
            dt.Columns.Add("Kod");
            dt.Columns.Add("Isim");
            dt.Columns.Add("Alýþ");
            dt.Columns.Add("Satýþ");
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

            // Update the DataGridView on the UI thread
            Invoke(new Action(() => dgv_kurlar.DataSource = dt));
        }
    }
}
