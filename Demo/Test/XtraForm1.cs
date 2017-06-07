using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Test
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }
        
        private void fmBeginTime_EditValueChanged(object sender, EventArgs e)
        {
            }
        private void simpleButton1_Click(object sender, EventArgs e){
            this.gridView1.AddNewRow();
            gridView1.OptionsBehavior.Editable = true;
        }
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            DataTable dtTable=new DataTable();
            //dtTable.Columns.Add("Number", typeof(string));dtTable.Columns.Add("Value", typeof(string));
            //for (int i = 0; i < 4; i++)
            //{
            //    dtTable.Rows.Add(i, "v"+i);}
            gridControl1.DataSource = dtTable;}
    }}