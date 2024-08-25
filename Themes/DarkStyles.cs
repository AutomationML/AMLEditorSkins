// Copyright (c) 2017 AutomationML e.V.
using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Media;

namespace Aml.Skins.Themes
{
    public partial class DarkStyles
    {
        private void CheckBoxChecked(object sender, EventArgs e)
        {
            var rb = CheckBoxHelper.GetCheckGlyphForegroundChecked(sender as DependencyObject);
            CheckBoxHelper.SetCheckGlyphForegroundChecked(sender as DependencyObject, Brushes.White);
            var h = CheckBoxHelper.CheckGlyphForegroundCheckedProperty;
        }
    }
}
