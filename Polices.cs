using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceStation
{
    public partial class Polices : Form
    {
        public Polices()
        {
            InitializeComponent();
            ShowPolice();
            Reset();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=PoliceStationDB;Integrated Security=True");
        private void ShowPolice()
        {
            con.Open();
            string Query = "Select * from Police";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            PoliceDGV.DataSource = ds.Tables[0];
            con.Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Reset()
        {
            AddressOff.Text = "";
            PhoneOff.Text = "";
            DesignationOff.SelectedIndex = -1;
            PasswordOff.Text = "";
            NameOff.Text = "";
            Key = 0;

        }
        private void RecordBtnOff_Click(object sender, EventArgs e)
        {
            if (NameOff.Text == "" || DesignationOff.SelectedIndex == -1 || AddressOff.Text == "" || PhoneOff.Text == "" || PasswordOff.Text == "")
            {
                MessageBox.Show("Missing Information..!!");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into police(EmpName,EmpAddress,EmpPhone,EmpPas,EmpDesignation)values(@EN,@EA,@EP,@EPA,@ED)", con);
                    cmd.Parameters.AddWithValue("@EN", NameOff.Text);
                    cmd.Parameters.AddWithValue("@EA", AddressOff.Text);
                    cmd.Parameters.AddWithValue("@EP", PhoneOff.Text);
                    cmd.Parameters.AddWithValue("@ED", DesignationOff.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EPA", PasswordOff.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Officer Information Recorded..!!");
                    con.Close();
                    ShowPolice();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void PoliceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameOff.Text = PoliceDGV.SelectedRows[0].Cells[1].Value.ToString();
            AddressOff.Text = PoliceDGV.SelectedRows[0].Cells[2].Value.ToString();
            DesignationOff.SelectedItem = PoliceDGV.SelectedRows[0].Cells[3].Value.ToString();
            PasswordOff.Text = PoliceDGV.SelectedRows[0].Cells[4].Value.ToString();
            PhoneOff.Text = PoliceDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (NameOff.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PoliceDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtnOff_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Police Officer..!!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Police where EmpCode = @CKey", con);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Officer Deleted..!!");
                    con.Close();
                    ShowPolice();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void EditBtnOff_Click(object sender, EventArgs e)
        {
            if (NameOff.Text == "" || DesignationOff.SelectedIndex == -1 || AddressOff.Text == "" || PhoneOff.Text == "" || PasswordOff.Text == "")
            {
                MessageBox.Show("Missing Information..!!");
            }
            else
            {
                try
                {



                    con.Open();
                    SqlCommand cmd = new SqlCommand("update police set EmpName=@EN,EmpAddress=@EA,EmpPhone=@EP,EmpPas=@EPA,EmpDesignation=@ED where EmpCode=@PKey", con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.Parameters.AddWithValue("@EN", NameOff.Text);
                    cmd.Parameters.AddWithValue("@EA", AddressOff.Text);
                    cmd.Parameters.AddWithValue("@EP", PhoneOff.Text);
                    cmd.Parameters.AddWithValue("@ED", DesignationOff.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EPA", PasswordOff.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Police Officer Information Recorded..!!");
                    con.Close();
                    ShowPolice();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DASHBOARDPolice_Click(object sender, EventArgs e)
        {
            DashboardPage ff = new DashboardPage();
            this.Hide();
            ff.Show();
        }

        private void CASESPolice_Click(object sender, EventArgs e)
        {
            Cases ff = new Cases();
            this.Hide();
            ff.Show();
        }

        private void CRIMINALSPolice_Click(object sender, EventArgs e)
        {
            Criminals ff = new Criminals();
            this.Hide();
            ff.Show();
        }

        private void CHARGESPolice_Click(object sender, EventArgs e)
        {
            Charges ff = new Charges();
            this.Hide();
            ff.Show();
        }

        private void LOGOUTPolice_Click(object sender, EventArgs e)
        {
            Login ff = new Login();
            this.Hide();
            ff.Show();
        }
    }
}
