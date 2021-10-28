using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore.Helpers
{
    /// <summary>
    /// Статический класс реализует операции с элементами Control
    /// </summary>
    public static class ControlsOperations
    {
        public static void SetComboBoxDropDownWidth(ComboBox comboBox)
        {
            var dropDownMaxLength = 0;

            var g = comboBox.CreateGraphics();
            var font = comboBox.Font;
            foreach (var item in comboBox.Items)
            {
                var width = (int)g.MeasureString(item.ToString(), font).Width;

                if (dropDownMaxLength < width)
                    dropDownMaxLength = width;
            }
            if (dropDownMaxLength == 0) return;
            comboBox.DropDownWidth = dropDownMaxLength;
        }

        public static void AddUniqueStringItemToComboBox(ComboBox comboBox, string item) 
        {
            if (!comboBox.Items.Contains(item))
            {
                comboBox.Items.Add(item);
            }
        }

        public static void DeleteStringItemFromComboBox(ComboBox comboBox, string item)
        {
            if (comboBox.Items.Contains(item))
            {
                comboBox.Items.Remove(item);
            }
        }

        internal static void AddStringItemsInComboBox(ComboBox comboBox, string[] items)
        {
            comboBox.Items.Clear();
            if (items is null || items.Length == 0) 
            {
                comboBox.Text = string.Empty;
                return;
            }
            comboBox.Items.AddRange(items);
            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;
        }
    }
}
