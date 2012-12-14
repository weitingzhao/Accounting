using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FunTest.Database;
using FunTest.Table;
using SpeechLib;

namespace FunTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Morgage

        private void btn_morgageCalcuate_Click(object sender, EventArgs e)
        {
            var loanBalance = (float)Convert.ToDouble(this.txt_TotalAmount.Text);
            var interestRate = (float)Convert.ToDouble(this.txt_Rate.Text) / 100;
            var term = Convert.ToInt32(this.txt_Term.Text) * 12; //Month

            var monthlyPayment = (interestRate / 12 * loanBalance) / (1 - Math.Pow((1 + interestRate / 12), -term));

            this.txt_MonthlyPayment.Text = Math.Round(monthlyPayment, 2).ToString();

            float originalTotalPayment = 0;
            float originalTotalInterest = 0;
            CalcuateOriginalValue(loanBalance, interestRate, monthlyPayment, term,
                                  ref originalTotalPayment, ref originalTotalInterest);

            #region Schedule

            float totalPayment = 0;
            float totalPrincipal = 0;
            float totalInterest = 0;

            float monthlyInterest;
            float monthlyPrincipal;
            float singleExtraPayment = 0;


            var scheduleTable = new DataTable();
            scheduleTable.Columns.Add(new DataColumn("Period", typeof(string)));
            scheduleTable.Columns.Add(new DataColumn("Date", typeof(string)));
            scheduleTable.Columns.Add(new DataColumn("monthly Payment", typeof(float)));
            scheduleTable.Columns.Add(new DataColumn("monthly Interest", typeof(float)));
            scheduleTable.Columns.Add(new DataColumn("monthly Principal", typeof(float)));
            scheduleTable.Columns.Add(new DataColumn("single Extra Payment", typeof(float)));

            scheduleTable.Columns.Add(new DataColumn("loan Balance", typeof(float)));
            scheduleTable.Columns.Add(new DataColumn("total Payment", typeof(float)));
            scheduleTable.Columns.Add(new DataColumn("total Principal", typeof(float)));
            scheduleTable.Columns.Add(new DataColumn("total Interest", typeof(float)));


            for (var i = 0; i <= term; i++)
            {
                var row = scheduleTable.NewRow();

                if (i == 0)
                {
                    row["Period"] = "Initial";
                    row["loan Balance"] = Math.Round(loanBalance, 2).ToString();

                    scheduleTable.Rows.Add(row);
                    continue;
                }
                if (this.dt_start.Value.Year == 2013 && (this.dt_start.Value.Month == 1 || this.dt_start.Value.Month == 2))
                {
                    singleExtraPayment = 1000;
                }
                else
                {
                    singleExtraPayment = 0;
                }

                monthlyInterest = loanBalance * interestRate / 12;
                monthlyPrincipal = (float)(monthlyPayment - monthlyInterest);
                loanBalance = loanBalance - monthlyPrincipal - singleExtraPayment;

                if (loanBalance > 0)
                {

                }
                else
                {
                    monthlyPrincipal = (float)(monthlyPayment - monthlyInterest + loanBalance);
                    monthlyPayment = monthlyPrincipal + monthlyInterest;
                    loanBalance = 0;
                }


                totalPayment = (float)(totalPayment + monthlyPayment + singleExtraPayment);
                totalPrincipal = totalPrincipal + monthlyPrincipal + singleExtraPayment;
                totalInterest = totalInterest + monthlyInterest;

                row["Period"] = i;
                row["Date"] = this.dt_start.Value.ToString("MM/yyyy");

                row["monthly Payment"] = Math.Round(monthlyPayment, 2).ToString();
                row["monthly Interest"] = Math.Round(monthlyInterest, 2).ToString();
                row["monthly Principal"] = Math.Round(monthlyPrincipal, 2).ToString();
                row["single Extra Payment"] = singleExtraPayment;

                row["loan Balance"] = Math.Round(loanBalance, 2).ToString();
                row["total Payment"] = Math.Round(totalPayment, 2).ToString();
                row["total Principal"] = Math.Round(totalPrincipal, 2).ToString();
                row["total Interest"] = Math.Round(totalInterest, 2).ToString();



                this.dt_start.Value = this.dt_start.Value.AddMonths(1);

                scheduleTable.Rows.Add(row);
            }

            var view = new DataView(scheduleTable);
            view.AllowNew = false;
            this.Grid_Schedule.DataSource = view;

            this.Grid_Schedule.Columns[0].Width = 50;
            this.Grid_Schedule.Columns[1].Width = 50;
            this.Grid_Schedule.Columns[2].Width = 50;
            this.Grid_Schedule.Columns[3].Width = 50;
            this.Grid_Schedule.Columns[4].Width = 50;
            this.Grid_Schedule.Columns[5].Width = 80;
            this.Grid_Schedule.Columns[6].Width = 70;
            this.Grid_Schedule.Columns[7].Width = 70;
            this.Grid_Schedule.Columns[8].Width = 70;

            foreach (DataGridViewRow row in this.Grid_Schedule.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    double value;
                    if (double.TryParse(cell.Value.ToString(), out value) && value <= 0)
                    {
                        var CellStyle = new DataGridViewCellStyle();
                        CellStyle.BackColor = Color.DodgerBlue;
                        cell.Style = CellStyle;
                    }
                }
            }

            #endregion

            #region Result

            var resultTable = new DataTable();
            resultTable.Columns.Add(new DataColumn(" "));
            resultTable.Columns.Add(new DataColumn("normal payments"));
            resultTable.Columns.Add(new DataColumn("with entered extra payments"));
            resultTable.Columns.Add(new DataColumn("savings with extra payments"));

            var totalPaymentRecord = resultTable.NewRow();



            totalPaymentRecord[" "] = "total payments paid";
            totalPaymentRecord["normal payments"] = Math.Round(originalTotalPayment, 2).ToString();
            totalPaymentRecord["with entered extra payments"] = Math.Round(totalPayment, 2).ToString();
            totalPaymentRecord["savings with extra payments"] = Math.Round(originalTotalPayment - totalPayment, 2).ToString();

            var totalInterestRecord = resultTable.NewRow();

            totalInterestRecord[" "] = "total interest paid";
            totalInterestRecord["normal payments"] = Math.Round(originalTotalInterest, 2).ToString();
            totalInterestRecord["with entered extra payments"] = Math.Round(totalInterest, 2).ToString();
            totalInterestRecord["savings with extra payments"] = Math.Round(originalTotalInterest - totalInterest, 2).ToString();

            resultTable.Rows.Add(totalPaymentRecord);
            resultTable.Rows.Add(totalInterestRecord);

            this.Grid_Result.DataSource = resultTable;
            this.Grid_Result.ReadOnly = true;
            this.Grid_Result.AllowUserToAddRows = false;

            #endregion
        }


        private void CalcuateOriginalValue(float loanBalance, float interestRate, double monthlyPayment, int term,
            ref float totalPayment, ref float totalInterest)
        {
            float monthlyInterest;
            float monthlyPrincipal;

            for (var i = 0; i < term; i++)
            {
                monthlyInterest = (float)(loanBalance * interestRate / 12);
                monthlyPrincipal = (float)(monthlyPayment - monthlyInterest);
                loanBalance = loanBalance - monthlyPrincipal;

                totalPayment = (float)(totalPayment + monthlyPayment);
                totalInterest = totalInterest + monthlyInterest;
            }
        }

        #endregion


        #region Account Setting


        private void btn_Add_Click(object sender, EventArgs e)
        {
            var descTable = new DescriptionTable();

            var record = descTable.NewRecord();
            record.Category = "Dinner";
            record.Name = "ABC 1";
            descTable.Rows.Add(record);

            record = descTable.NewRecord();
            record.Category = "Dinner2";
            record.Name = "ABC 2";
            descTable.Rows.Add(record);

            EditDB.AddRecords(descTable);
            //EditDB.UpdateRecords(descTable);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select id, desc from mains";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            this.grid_view1.DataSource = DT;
            sql_con.Close(); 
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void SetConnection()
        {
            sql_con = new SQLiteConnection(string.Format(@"Data Source={0};Pooling=False;", SqliteHelper.DefaultDBPath()));
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void btn_Init_Click(object sender, EventArgs e)
        {
            if (SqliteHelper.DBExist)
            {
                var dialogResult = MessageBox.Show(
                    "Database already exist, Conitue initializ will lost all data, still want do that?",
                    "Initial account database", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new InitDB().Init();
                }
            }
            else
            {
                SQLiteConnection.CreateFile(SqliteHelper.DefaultDBPath());
                new InitDB().Init();
            }
            MessageBox.Show("All data removed from database");
        }

        #endregion



        #region try parse

        private static bool TryParseDate(string datapoint, ref DateTime? postDate)
        {
            //1. Try parse time to get post date
            DateTime tryDateTime;
            if (DateTime.TryParse(datapoint, out tryDateTime))
            {
                if (postDate == new DateTime?())
                    postDate = tryDateTime;
                else if (postDate.Value.CompareTo(tryDateTime) > 1)
                    postDate = tryDateTime;

                return true;
            }
            return false;
        }

        private static bool TryParseType(string datapoint, ref string type)
        {
            if (TypeList.ContainsKey(datapoint))
            {
                type = datapoint;
                return true;
            }
            return false;
        }

        private bool TryParseDesc(string datapoint, ref string desc)
        {
            if (string.IsNullOrEmpty(desc) || desc.Length < datapoint.Length)
            {
                desc = datapoint;
                return true;
            }
            return false;
        }

        private bool TryParseAmount(string datapoint, ref float amount)
        {
            return float.TryParse(datapoint.Trim().Replace("$", string.Empty), out amount);
        }

        #endregion

        private static Dictionary<string, string> TypeList = GetAccountType();
        private static Dictionary<string, string> GetAccountType()
        {
            var result = new Dictionary<string, string>
                             {
                                //Credit card
                                {"Sale", ""},
                                {"Return", ""},
                                //Checking
                                {"ATM Transaction", ""},
                                {"Chase QuickPay Credit", ""},
                                {"ACH Credit", ""},
                                {"ATM Deposits", ""},
                                {"Misc. Credit", ""},
                                {"Bill Payment", ""},
                                {"Check", ""}
                             };

            return result;
        }

        private Dictionary<string, string> GetDesc()
        {
            return new Dictionary<string, string>();
        }

        #region Page 1

        private AccountTable AccTable;

        private void btn_ParseData_Click(object sender, EventArgs e)
        {
            this.AccTable = new AccountTable();

            var txt = this.rtb_DataInput.Text;
            var records = txt.Split('\n');

            foreach (var record in records)
            {
                //Value parse should follow below order
                //value 1.
                var postDate = new DateTime?();
                //value 2. (full match)
                string type = string.Empty;
                //value 3. amount
                float amount = 0;
                //value 4. (partial match)
                string desc = string.Empty;

                var datapoints = record.Split('\t');
                foreach (var datapoint in datapoints)
                {
                    #region Get value
                    //1. Try parse time to get post date
                    if (!TryParseDate(datapoint, ref postDate))
                    {
                        //2. Try parse value
                        if (!TryParseType(datapoint, ref type))
                        {
                            //3. try parse amount
                            if (!TryParseAmount(datapoint, ref amount))
                            {
                                //4. Try parse desc
                                TryParseDesc(datapoint, ref desc);
                            }
                        }
                    }
                    #endregion
                }

                if (amount == 7.3)
                {
                    string a = "";
                }
                if (amount != 0)
                {
                    #region parse into data table

                    var row = this.AccTable.NewRecord();
                    row.PostDate = postDate.GetValueOrDefault().ToString("yyyy-MM-dd");
                    row.Type = type;
                    row.Description = desc;
                    row.Amount = amount.ToString();
                    row.Comm = string.Empty;
                    this.AccTable.Rows.Add(row);

                    #endregion
                }

            }

            this.grid_collect.DataSource = this.AccTable;
        }

        private void btn_Save2DB_Click(object sender, EventArgs e)
        {
            if (this.AccTable != null && this.AccTable.Rows.Count > 0)
            {
                EditDB.AddRecords(this.AccTable);
            }
        }

        #endregion



    }
}
