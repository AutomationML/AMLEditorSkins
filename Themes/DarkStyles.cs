using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Aml.Skins.Themes
{
    public partial class DarkStyles
    {
        void CheckBoxChecked (object sender, EventArgs e)
        {
            var rb = CheckBoxHelper.GetCheckGlyphForegroundChecked(sender as DependencyObject);
            CheckBoxHelper.SetCheckGlyphForegroundChecked (sender as DependencyObject, Brushes.White);
            var h = CheckBoxHelper.CheckGlyphForegroundCheckedProperty;
        }
    }
}
