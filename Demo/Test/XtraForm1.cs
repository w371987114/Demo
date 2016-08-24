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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fmBeginTime.Text.ToString());
        }

        private void fmBeginTime_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}