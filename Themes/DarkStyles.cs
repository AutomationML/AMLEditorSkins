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
            if (sender is not DependencyObject dpo)
            {
                return;
            }
            _ = CheckBoxHelper.GetCheckGlyphForegroundChecked(dpo);
            CheckBoxHelper.SetCheckGlyphForegroundChecked(dpo, Brushes.White);
            _ = CheckBoxHelper.CheckGlyphForegroundCheckedProperty;
        }
    }
}
