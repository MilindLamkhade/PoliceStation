using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceStation
{
    public partial class Cases : Form
    {
        public Cases()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Cases_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RecordBtnC_Click(object sender, EventArgs e)
        {

        }

        private void DASHBOARDCase_Click(object sender, EventArgs e)
        {
            DashboardPage ff = new DashboardPage();
            this.Hide();
            ff.Show();
        }

        private void CRIMINALSCase_Click(object sender, EventArgs e)
        {
            Criminals ff = new Criminals();
            this.Hide();
            ff.Show();
        }

        private void OFFICERCase_Click(object sender, EventArgs e)
        {
            Polices ff = new Polices();
            this.Hide();
            ff.Show();
        }

        private void CHARGESCase_Click(object sender, EventArgs e)
        {
            Charges ff = new Charges();
            this.Hide();
            ff.Show();
        }

        private void LOGOUTCase_Click(object sender, EventArgs e)
        {
            Login ff = new Login();
            this.Hide();
            ff.Show();
        }
    }
}
