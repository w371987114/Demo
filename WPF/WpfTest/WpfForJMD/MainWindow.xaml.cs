using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Scheduler.UI;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using MouseEventArgs = System.Windows.Input.MouseEventArgs;

namespace WpfForJMD
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        private decimal Rate { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            TextEnd.MaskType=MaskType.Numeric;
            TextEnd.ToolTip = "月末度数";
            TextStart.ToolTip = "月初度数";
            TextWaterCost.ToolTip = "水费";
            Rate = 4m;
            TextEnd.Tag = false;
            TextStart.Tag = false;
            TextEnd.KeyDown += TextStart_KeyDown;
            TextEnd.GotFocus += Text_GotFocus;
            TextStart.GotFocus += Text_GotFocus;
            TextEnd.EditValueChanged += TextEnd_EditValueChanged;
            TextStart.EditValueChanged += TextEnd_EditValueChanged;
            //TextEnd.MouseUp += Text_MouseUp;
            //TextStart.MouseUp += Text_MouseUp;
            var sets = BarMenu.Items[0] as BarSubItem;
            sets.Items.Add(new BarButtonItem() {BarItemName = "电费计算",Content = "电费计算",Name = "Change"});

            BarManager.ItemClick += BarManager_ItemClick;
            EventManager.RegisterClassHandler(typeof(TextEdit), TextEdit.GotFocusEvent, new RoutedEventHandler(TextBox_GotFocus));
            EventManager.RegisterClassHandler(typeof(TextEdit), TextEdit.PreviewMouseDownEvent, new MouseButtonEventHandler(TextBox_PreviewMouseDown));
            //TextEnd.
        }

        private void BarManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.Item as BarButtonItem;
            if (item != null)
            {
                if (item.Name == "Change")
                {
                    item.Content = "电费计算";
                    
                    item.Name = "Changed";
                    Rate = 1.2m;
                    TextWaterCost.NullText = "水费计算";
                }
                else if (item.Name == "Changed")
                {
                    item.Content = "水费计算";
                    item.Name = "Change";
                    Rate = 4m;
                    TextWaterCost.NullText = "电费计算";
                }
                LblRate.Content = Rate;
                if (!string.IsNullOrEmpty(TextEnd.Text) && !string.IsNullOrEmpty(TextStart.Text)) 
                CaculateWaterCost();
            }
            var subItem = e.Item as BarSubItem;
            if (subItem!=null)
            {
                if (subItem.BarItemName=="BarInfo")
                {
                    WPFInfo newForm = new WPFInfo();
                    newForm.ShowDialog(); 
                }
            }
        }
        private void TextEnd_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            CaculateWaterCost();
        }

        void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }

        void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var TextBox = (TextEdit)sender;
            if (!TextBox.IsKeyboardFocusWithin)
            {
                TextBox.Focus();
                e.Handled = true;
            }
        }
        void Text_MouseUp(object sender, MouseEventArgs e)
        {
            var textEdit = sender as TextEdit;
            if(textEdit==null)return;
            //如果鼠标左键操作并且标记存在，则执行全选             
            if (e.LeftButton == MouseButtonState.Pressed && (bool)textEdit.Tag )
            {
                textEdit.SelectAll();
            }

            //取消全选标记              
            textEdit.Tag = false;
        }
        private void Text_GotFocus(object sender, RoutedEventArgs e)
        {
            //if(TextEnd.Text== "月末度数")
            //TextEnd
            var textEdit = sender as TextEdit;
            if (textEdit != null)
            {
                if (string.IsNullOrEmpty(textEdit.Text)||textEdit.Text=="0")
                {
                    //textEdit.Text = 0.00.ToString(CultureInfo.CurrentCulture);
                    textEdit.Tag = true;
                    textEdit.SelectAll();
                }
            }
        }

        private void TextStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                CaculateWaterCost();
            }
        }

        private void CaculateWaterCost()
        {
            if (string.IsNullOrEmpty(TextEnd.Text)) TextEnd.Text = 0.ToString();
            if (string.IsNullOrEmpty(TextStart.Text)) TextStart.Text = 0.ToString();
            TextWaterCost.Text = ((decimal.Parse(TextEnd.Text) - decimal.Parse(TextStart.Text))*Rate).ToString();
        }
    }
}
