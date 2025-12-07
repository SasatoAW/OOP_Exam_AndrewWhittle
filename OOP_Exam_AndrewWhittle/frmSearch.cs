using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Exam_AndrewWhittle
{
    //Name: Andrew Whittle
    //C&G reg: *******

    public partial class frmSearch : Form
    {
        frmCars mainForm;
        
        //the connection string entered as a parameter for conn will need to be changed depending on where the database file is located 
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\awhit\\source\\repos\\OOP_Exam_AndrewWhittle\\OOP_Exam_AndrewWhittle\\bin\\Debug\\Hire.accdb");

        private void runQuery(string sql)
        {
            try
            {
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tblCarDGV.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        public frmSearch(frmCars inForm)
        {
            InitializeComponent();
            mainForm = inForm;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            cboField.Items.Add("Make");
            cboField.Items.Add("EngineSize");
            cboField.Items.Add("RentalPerDay");
            cboField.Items.Add("Available");
            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrEmpty(cboField.Text)) && !(string.IsNullOrEmpty(cboOperator.Text)) && !(string.IsNullOrEmpty(valueTextBox.Text)))
            {
                string sql = "";
                if (cboField.Text == "Make" || cboField.Text == "EngineSize")
                {
                    sql = "SELECT * FROM tblCar WHERE " + cboField.Text + " " + cboOperator.Text + " '" + valueTextBox.Text + "'";
                }
                else
                {
                    sql = "SELECT * FROM tblCar WHERE " + cboField.Text + " " + cboOperator.Text + " " + valueTextBox.Text;
                }
                
                runQuery(sql);
            }
            else
            {
                string sql = "select * from tblCar where VehicleRegNo is null";
                runQuery(sql);
                MessageBox.Show("must select a field, an operator and enter a value to search");

            }
        }
    }
}
