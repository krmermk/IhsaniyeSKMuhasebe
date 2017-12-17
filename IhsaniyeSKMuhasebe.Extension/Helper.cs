using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IhsaniyeSKMuhasebe.Extension
{
    public static class Helper
    {
        public static void BindComboBox<T>(ICollection<T> _myList, ComboBox _comboBox, string _displayMember, string _valueMember)
        {
            _comboBox.DataSource = _myList;
            _comboBox.DisplayMember = _displayMember;
            _comboBox.ValueMember = _valueMember;
        }
        public static void BindDataGridView<T>(ICollection<T> _myList, DataGridView _dataGridView)
        {
            _dataGridView.DataSource = _myList;
        }
        public static bool NullableControl(params string[] _deger)
        {
            bool control = true;

            foreach (string item in _deger)
            {
                if (String.IsNullOrEmpty(item))
                {
                    control = false;
                }
            }
            return control;
        }
        public static void Clears(Control.ControlCollection _controller)
        {
            foreach (var item in _controller)
            {
                if (item is Panel)
                {
                    Panel pnl = (Panel)item;
                    Clears(pnl.Controls);
                }
                else if (item is TabControl)
                {
                    TabControl tc = (TabControl)item;
                    Clears(tc.Controls);
                }
                else if (item is GroupBox)
                {
                    Clears(((GroupBox)item).Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    Clears(((FlowLayoutPanel)item).Controls);
                }
                else if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Text = "";
                }
                else if (item is ListBox)
                {
                    ((ListBox)item).Items.Clear();
                }
                else if (item is DataGridView)
                {
                    ((DataGridView)item).DataSource = null;
                }
                else if (item is ListView)
                {
                    ((ListView)item).Items.Clear();
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                else if (item is MetroTextBox)
                {
                    ((MetroTextBox)item).Text = "";
                }
            }
        }
    }
}
