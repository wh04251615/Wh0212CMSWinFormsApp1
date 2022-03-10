﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp1
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cMSDBDataSet.tb1Worker”中。您可以根据需要移动或移除它。
            this.tb1WorkerTableAdapter.Fill(this.cMSDBDataSet.tb1Worker);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.cMSDBDataSet.tb1Worker.Clear();
            sqlDataAdapter1.Fill(this.cMSDBDataSet.tb1Worker);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(this.cMSDBDataSet.tb1Worker);
            MessageBox.Show("The Worker Table is updated");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cMSDBDataSet.tb1Worker.Clear();
            sqlDataAdapter1.Fill(this.cMSDBDataSet.tb1Worker);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }
    }
}
