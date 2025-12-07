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

    public partial class frmCars : Form
    {

        //the connection string entered as a parameter for conn will need to be changed depending on where the database file is located 
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\awhit\\source\\repos\\OOP_Exam_AndrewWhittle\\OOP_Exam_AndrewWhittle\\bin\\Debug\\Hire.accdb");
        private static int index = 0;
        private int dtCount = 0; //keep track of size of table for "last" button
        public frmCars()
        {
            InitializeComponent();
        }

        private void loadRecord(int i)
        {
            //load data from the specified row into the textboxes
            try
            {
                conn.Open();
                string sql = "select * from tblCar";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                regTextBox.Text = dt.Rows[index]["VehicleRegNo"].ToString();
                makeTextBox.Text = dt.Rows[index]["Make"].ToString();
                engineTextBox.Text = dt.Rows[index]["EngineSize"].ToString();
                dateTextBox.Text = dt.Rows[index]["DateRegistered"].ToString();
                rentTextBox.Text = "£" +dt.Rows[index]["RentalPerDay"].ToString();
                availableChkBox.Checked = bool.Parse(dt.Rows[index]["Available"].ToString());
                recordTextBox.Text = (index + 1) + " of " + dt.Rows.Count;
                dtCount = dt.Rows.Count;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }
        private void runQuery(string sql)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            loadRecord(index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            index = 0;
            loadRecord(index);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the application
            Application.Exit();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //change all the user entry fields to blank
            makeTextBox.Text = "";
            regTextBox.Text = "";
            engineTextBox.Text = "";
            dateTextBox.Text = "";
            rentTextBox.Text = "";
            availableChkBox.Checked = false;
            recordTextBox.Text = "";
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            index = 0;
            loadRecord(index);
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            index = dtCount - 1;
            loadRecord(index);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if(!(index == 0))
            {
                index--;
            }
            else
            {
                MessageBox.Show("Already at the first record");
            }
            loadRecord(index);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (!(index == (dtCount - 1)))
            {
                index++;
            }
            else
            {
                MessageBox.Show("already at the last record");
            }
            loadRecord(index);    
        }
        

        private void searchbutton_Click(object sender, EventArgs e)
        {
            frmSearch subForm = new frmSearch(this);
            subForm.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string sql = "insert into tblCar values('" + regTextBox.Text + "', '" + makeTextBox.Text + "', '" + engineTextBox.Text + "', #" + dateTextBox.Text + "#, " + rentTextBox.Text + ", " + availableChkBox.Checked.ToString() + ")";
            runQuery(sql);
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblCar where VehicleRegNo = '" + regTextBox.Text + "'";
            runQuery(sql);
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            string sql = "update tblCar set Make = '" + makeTextBox.Text + "', EngineSize = '" + engineTextBox.Text + "', DateRegistered = #" + dateTextBox.Text + "#, RentalPerDay = " + rentTextBox.Text + ", Available = " + availableChkBox.Checked.ToString() + " where VehicleRegNo = '" + regTextBox.Text + "'";
            runQuery(sql);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!(index == (dtCount - 1)))
            {
                index++;
            }
            else
            {
                MessageBox.Show("already at the last record");
            }
            loadRecord(index);
        }
    }
}
