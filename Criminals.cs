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

namespace PoliceStation
{
    public partial class Criminals : Form
    {
        public Criminals()
        {
            InitializeComponent();
            ShowCriminals();

        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=PoliceStationDB;Integrated Security=True");
        private void ShowCriminals()
        {
            con.Open();
            string Query = "Select CrCode as Code, CrName as CriminalName ,CrAddress as CriminalAddress, CrActivities as CriminalActivities from Criminal";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            CrDGV.DataSource = ds.Tables[0];
            con.Close();

        }

        private void RecordBtnCr_Click(object sender, EventArgs e)
        {
            if (NameCr.Text == "" || AddressCr.Text == "" || ActivitiesInvolvedCr.Text == "")
            {
                MessageBox.Show("Missing Information..!!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into criminal(CrName,CrAddress,CrActivities)values(@CrName,@CrAdd,@CrAct)", con);
                    cmd.Parameters.AddWithValue("CrName", NameCr.Text);
                    cmd.Parameters.AddWithValue("CrAdd", AddressCr.Text);
                    cmd.Parameters.AddWithValue("CrAct", ActivitiesInvolvedCr.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Criminal Information Recorded..!!");
                    con.Close();
                    ShowCriminals();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        int Key = 0;
        private void CriminalDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameCr.Text = CrDGV.SelectedRows[0].Cells[1].Value.ToString();
            AddressCr.Text = CrDGV.SelectedRows[0].Cells[2].Value.ToString();
            ActivitiesInvolvedCr.Text = CrDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (NameCr.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CrDGV.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        private void EditBtnCr_Click(object sender, EventArgs e)
        {
            if (NameCr.Text == "" || AddressCr.Text == "" || ActivitiesInvolvedCr.Text == "")
            {
                MessageBox.Show("Missing Information..!!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update criminal set CrName=@CrName,CrAddress=@CrAdd,CrActivities=@CrAct where CrCode=@CKey", con);
                    cmd.Parameters.AddWithValue("CKey", Key);
                    cmd.Parameters.AddWithValue("CrName", NameCr.Text);
                    cmd.Parameters.AddWithValue("CrAdd", AddressCr.Text);
                    cmd.Parameters.AddWithValue("CrAct", ActivitiesInvolvedCr.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Criminal Information Recorded..!!");
                    con.Close();
                    ShowCriminals();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }



        }


        private void Reset()
        {
            NameCr.Text = "";
            AddressCr.Text = "";
            ActivitiesInvolvedCr.Text = "";
            Key = 0;
        }
        private void CancelBtnCr_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Criminal..!!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from criminal where CrCode = @CKey", con);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Criminal Deleted..!!");
                    con.Close();
                    ShowCriminals();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CrDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameCr.Text = CrDGV.SelectedRows[0].Cells[1].Value.ToString();
            AddressCr.Text = CrDGV.SelectedRows[0].Cells[2].Value.ToString();
            ActivitiesInvolvedCr.Text = CrDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (NameCr.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CrDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DASHBOARDCriminal_Click(object sender, EventArgs e)
        {
            DashboardPage ff = new DashboardPage();
            this.Hide();
            ff.Show();
        }

        private void CASESCriminal_Click(object sender, EventArgs e)
        {
            Cases ff = new Cases();
            this.Hide();
            ff.Show();
        }

        private void OFFICERCriminal_Click(object sender, EventArgs e)
        {
            Polices ff = new Polices();
            this.Hide();
            ff.Show();
        }

        private void CHARGESCriminal_Click(object sender, EventArgs e)
        {
            Charges ff = new Charges();
            this.Hide();
            ff.Show();
        }

        private void LOGOUTCriminal_Click(object sender, EventArgs e)
        {
            Login ff = new Login();
            this.Hide();
            ff.Show();
        }
    }
}
