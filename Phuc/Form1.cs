using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Sql;

namespace Phuc

{
    public partial class f1 : Form
    {

        public f1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            dataGridView1.Rows.Clear();
            try
            {
                
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"D:\source\Phuc\Phuc\bin\Debug\Sinhvien.xml");
                DataTable dt = new DataTable();
                dt = dataSet.Tables["Sinhvien"];
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = dr["xID"].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dr["xTenSV"].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dr["xMaSv"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dr["xLop"].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dr["xPhone"].ToString();
                    i++;
                }
            }
            catch (Exception)
            {

            }
            dataGridView1.Refresh();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument testXML = XDocument.Load(@"D:\source\Phuc\Phuc\bin\Debug\Sinhvien.xml");
                XElement newSinhvien = new XElement("sinhvien", new XAttribute("xID", Idtxt.Text),
                new XElement("xTenSV", Tentxt.Text),
                new XElement("xMaSv", Matxt.Text),
                new XElement("xLop", Loptxt.Text),
                new XElement("xPhone", Phonetxt.Text));

                //var lastStudent = testXML.Descendants("sinhvien").Last();

                testXML.Element("Sinhvien").Add(newSinhvien);
                testXML.Save(@"D:\source\Phuc\Phuc\bin\Debug\Sinhvien.xml");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            loaddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            suadata();
        }
        private void suadata()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\source\Phuc\Phuc\bin\Debug\Sinhvien.xml");
            XPathNavigator nav = doc.CreateNavigator();
            XPathNavigator sinhvien = nav.SelectSingleNode("Sinhvien/sinhvien[@xID='" + Idtxt.Text + "']");
            sinhvien.SelectSingleNode("xTenSV").SetValue(Tentxt.Text);
            sinhvien.SelectSingleNode("xMaSv").SetValue(Matxt.Text);
            sinhvien.SelectSingleNode("xLop").SetValue(Loptxt.Text);
            sinhvien.SelectSingleNode("xPhone").SetValue(Phonetxt.Text);
            doc.Save(@"D:\source\Phuc\Phuc\bin\Debug\Sinhvien.xml");
            loaddata();

        }
        private void xoadata()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\source\Phuc\Phuc\bin\Debug\Sinhvien.xml");
            XPathNavigator nav = doc.CreateNavigator();
            XPathNavigator sinhvien = nav.SelectSingleNode("Sinhvien/sinhvien[@xID='" + Idtxt.Text + "']");
            sinhvien.DeleteSelf();
            doc.Save(@"D:\source\Phuc\Phuc\bin\Debug\Sinhvien.xml");
            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xoadata();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Idtxt.Text = dataGridView1.SelectedRows[0].Cells["xID"].Value.ToString();
            Tentxt.Text = dataGridView1.SelectedRows[0].Cells["xTenSV"].Value.ToString();
            Matxt.Text = dataGridView1.SelectedRows[0].Cells["xMaSv"].Value.ToString();
            Loptxt.Text = dataGridView1.SelectedRows[0].Cells["xLop"].Value.ToString();
            Phonetxt.Text = dataGridView1.SelectedRows[0].Cells["xPhone"].Value.ToString();
        }

        //SqlConnection connect = new SqlConnection(@"Data Source = ADMIN\SQLEXPRESS; Initial Catalog = SinhVien; Persist Security Info=True;User ID = sa");

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = ConnectData.DataConnection())
            {
                int rows = dataGridView1.Rows.Count;
                for(int i = 0; i< rows; ++i)        
                {
                    SqlCommand dCmd = new SqlCommand("Delete ThongTin",cnn);
                    string oString = @"Insert into ThongTin Values(@xID,@xName,@xAge,@xSchool,@xPhone)";
                    SqlCommand oCmd = new SqlCommand(oString, cnn);
                    oCmd.Parameters.AddWithValue("@xTenSV", dataGridView1.Rows[i].Cells["xTenSv"].Value.ToString());
                    oCmd.Parameters.AddWithValue("@xID", dataGridView1.Rows[i].Cells["xID"].Value.ToString());
                    oCmd.Parameters.AddWithValue("@xMaSV", dataGridView1.Rows[i].Cells["xMaSV"].Value.ToString());
                    oCmd.Parameters.AddWithValue("@xLop", dataGridView1.Rows[i].Cells["xLop"].Value.ToString());
                    oCmd.Parameters.AddWithValue("@xPhone", dataGridView1.Rows[i].Cells["xPhone"].Value.ToString());
                    cnn.Open(); 
                    if (i == 0) dCmd.ExecuteNonQuery();
                    oCmd.ExecuteNonQuery();
                    cnn.Close();
                }
                MessageBox.Show("Updated");
            }
        }
    }
}
