namespace Test
{
    partial class XtraForm1
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
            this.fmBeginTime = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fmBeginTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmBeginTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fmBeginTime
            // 
            this.fmBeginTime.EditValue = null;
            this.fmBeginTime.Location = new System.Drawing.Point(46, 60);
            this.fmBeginTime.Name = "fmBeginTime";
            this.fmBeginTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fmBeginTime.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.fmBeginTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fmBeginTime.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.fmBeginTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fmBeginTime.Size = new System.Drawing.Size(100, 20);
            this.fmBeginTime.TabIndex = 9;
            this.fmBeginTime.EditValueChanged += new System.EventHandler(this.fmBeginTime_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(170, 57);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.fmBeginTime);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.fmBeginTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmBeginTime.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit fmBeginTime;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}