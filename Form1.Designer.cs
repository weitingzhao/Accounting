namespace FunTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_1 = new System.Windows.Forms.TabPage();
            this.tab_2 = new System.Windows.Forms.TabPage();
            this.Grid_Result = new System.Windows.Forms.DataGridView();
            this.Grid_Schedule = new System.Windows.Forms.DataGridView();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Term = new System.Windows.Forms.TextBox();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.txt_MonthlyPayment = new System.Windows.Forms.TextBox();
            this.txt_TotalAmount = new System.Windows.Forms.TextBox();
            this.btn_morgageCalcuate = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Init = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.grid_view1 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rtb_DataInput = new System.Windows.Forms.RichTextBox();
            this.btn_Save2DB = new System.Windows.Forms.Button();
            this.btn_ParseData = new System.Windows.Forms.Button();
            this.grid_collect = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab_1.SuspendLayout();
            this.tab_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Schedule)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_collect)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_1);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tab_2);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_1
            // 
            this.tab_1.Controls.Add(this.grid_collect);
            this.tab_1.Controls.Add(this.btn_Save2DB);
            this.tab_1.Controls.Add(this.btn_ParseData);
            this.tab_1.Controls.Add(this.rtb_DataInput);
            this.tab_1.Location = new System.Drawing.Point(4, 22);
            this.tab_1.Name = "tab_1";
            this.tab_1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_1.Size = new System.Drawing.Size(810, 436);
            this.tab_1.TabIndex = 1;
            this.tab_1.Text = "Account";
            this.tab_1.UseVisualStyleBackColor = true;
            // 
            // tab_2
            // 
            this.tab_2.Controls.Add(this.Grid_Result);
            this.tab_2.Controls.Add(this.Grid_Schedule);
            this.tab_2.Controls.Add(this.dt_start);
            this.tab_2.Controls.Add(this.label4);
            this.tab_2.Controls.Add(this.label5);
            this.tab_2.Controls.Add(this.label3);
            this.tab_2.Controls.Add(this.label2);
            this.tab_2.Controls.Add(this.label1);
            this.tab_2.Controls.Add(this.txt_Term);
            this.tab_2.Controls.Add(this.txt_Rate);
            this.tab_2.Controls.Add(this.txt_MonthlyPayment);
            this.tab_2.Controls.Add(this.txt_TotalAmount);
            this.tab_2.Controls.Add(this.btn_morgageCalcuate);
            this.tab_2.Location = new System.Drawing.Point(4, 22);
            this.tab_2.Name = "tab_2";
            this.tab_2.Padding = new System.Windows.Forms.Padding(3);
            this.tab_2.Size = new System.Drawing.Size(810, 436);
            this.tab_2.TabIndex = 0;
            this.tab_2.Text = "Home Mortgage";
            this.tab_2.UseVisualStyleBackColor = true;
            // 
            // Grid_Result
            // 
            this.Grid_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Result.Location = new System.Drawing.Point(308, 3);
            this.Grid_Result.Name = "Grid_Result";
            this.Grid_Result.Size = new System.Drawing.Size(497, 101);
            this.Grid_Result.TabIndex = 18;
            // 
            // Grid_Schedule
            // 
            this.Grid_Schedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Schedule.Location = new System.Drawing.Point(0, 108);
            this.Grid_Schedule.Name = "Grid_Schedule";
            this.Grid_Schedule.Size = new System.Drawing.Size(805, 328);
            this.Grid_Schedule.TabIndex = 19;
            // 
            // dt_start
            // 
            this.dt_start.Location = new System.Drawing.Point(96, 54);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(196, 20);
            this.dt_start.TabIndex = 17;
            this.dt_start.Value = new System.DateTime(2009, 10, 1, 15, 32, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "First payment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Term(year):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Interest(%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Initial Balance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Monthly payment:";
            // 
            // txt_Term
            // 
            this.txt_Term.Location = new System.Drawing.Point(96, 28);
            this.txt_Term.Name = "txt_Term";
            this.txt_Term.Size = new System.Drawing.Size(30, 20);
            this.txt_Term.TabIndex = 10;
            this.txt_Term.Text = "30";
            // 
            // txt_Rate
            // 
            this.txt_Rate.Location = new System.Drawing.Point(226, 5);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(30, 20);
            this.txt_Rate.TabIndex = 11;
            this.txt_Rate.Text = "4.5";
            // 
            // txt_MonthlyPayment
            // 
            this.txt_MonthlyPayment.Location = new System.Drawing.Point(96, 80);
            this.txt_MonthlyPayment.Name = "txt_MonthlyPayment";
            this.txt_MonthlyPayment.Size = new System.Drawing.Size(82, 20);
            this.txt_MonthlyPayment.TabIndex = 9;
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.Location = new System.Drawing.Point(96, 3);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.Size = new System.Drawing.Size(56, 20);
            this.txt_TotalAmount.TabIndex = 8;
            this.txt_TotalAmount.Text = "294400";
            // 
            // btn_morgageCalcuate
            // 
            this.btn_morgageCalcuate.Location = new System.Drawing.Point(217, 77);
            this.btn_morgageCalcuate.Name = "btn_morgageCalcuate";
            this.btn_morgageCalcuate.Size = new System.Drawing.Size(75, 23);
            this.btn_morgageCalcuate.TabIndex = 7;
            this.btn_morgageCalcuate.Text = "Calculate";
            this.btn_morgageCalcuate.UseVisualStyleBackColor = true;
            this.btn_morgageCalcuate.Click += new System.EventHandler(this.btn_morgageCalcuate_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.grid_view1);
            this.tabPage1.Controls.Add(this.btn_Init);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btn_Delete);
            this.tabPage1.Controls.Add(this.btn_Update);
            this.tabPage1.Controls.Add(this.btn_Add);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(810, 436);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Init
            // 
            this.btn_Init.Location = new System.Drawing.Point(713, 2);
            this.btn_Init.Name = "btn_Init";
            this.btn_Init.Size = new System.Drawing.Size(75, 23);
            this.btn_Init.TabIndex = 9;
            this.btn_Init.Text = "Init";
            this.btn_Init.UseVisualStyleBackColor = true;
            this.btn_Init.Click += new System.EventHandler(this.btn_Init_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(576, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(495, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(414, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // grid_view1
            // 
            this.grid_view1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view1.Location = new System.Drawing.Point(4, 111);
            this.grid_view1.Name = "grid_view1";
            this.grid_view1.Size = new System.Drawing.Size(243, 322);
            this.grid_view1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(426, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 322);
            this.dataGridView1.TabIndex = 11;
            // 
            // rtb_DataInput
            // 
            this.rtb_DataInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_DataInput.Location = new System.Drawing.Point(0, 3);
            this.rtb_DataInput.Name = "rtb_DataInput";
            this.rtb_DataInput.Size = new System.Drawing.Size(804, 88);
            this.rtb_DataInput.TabIndex = 1;
            this.rtb_DataInput.Text = "";
            // 
            // btn_Save2DB
            // 
            this.btn_Save2DB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save2DB.Location = new System.Drawing.Point(725, 97);
            this.btn_Save2DB.Name = "btn_Save2DB";
            this.btn_Save2DB.Size = new System.Drawing.Size(79, 31);
            this.btn_Save2DB.TabIndex = 3;
            this.btn_Save2DB.Text = "Save into DB";
            this.btn_Save2DB.UseVisualStyleBackColor = true;
            this.btn_Save2DB.Click += new System.EventHandler(this.btn_Save2DB_Click);
            // 
            // btn_ParseData
            // 
            this.btn_ParseData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ParseData.Location = new System.Drawing.Point(640, 97);
            this.btn_ParseData.Name = "btn_ParseData";
            this.btn_ParseData.Size = new System.Drawing.Size(79, 31);
            this.btn_ParseData.TabIndex = 4;
            this.btn_ParseData.Text = "Parse Data";
            this.btn_ParseData.UseVisualStyleBackColor = true;
            this.btn_ParseData.Click += new System.EventHandler(this.btn_ParseData_Click);
            // 
            // grid_collect
            // 
            this.grid_collect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_collect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_collect.Location = new System.Drawing.Point(0, 134);
            this.grid_collect.Name = "grid_collect";
            this.grid_collect.Size = new System.Drawing.Size(807, 302);
            this.grid_collect.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 467);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tab_1.ResumeLayout(false);
            this.tab_2.ResumeLayout(false);
            this.tab_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Schedule)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_collect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_2;
        private System.Windows.Forms.DataGridView Grid_Result;
        private System.Windows.Forms.DataGridView Grid_Schedule;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Term;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.TextBox txt_MonthlyPayment;
        private System.Windows.Forms.TextBox txt_TotalAmount;
        private System.Windows.Forms.Button btn_morgageCalcuate;
        private System.Windows.Forms.TabPage tab_1;
        private System.Windows.Forms.DataGridView grid_collect;
        private System.Windows.Forms.Button btn_Save2DB;
        private System.Windows.Forms.Button btn_ParseData;
        private System.Windows.Forms.RichTextBox rtb_DataInput;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView grid_view1;
        private System.Windows.Forms.Button btn_Init;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;

    }
}

