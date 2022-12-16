
using ControlzEx.Theming;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;

#nullable disable
namespace Aml.Skins
{
    public static class AMLApp
    {
        public static Action<ResourceDictionary> ApplyColors { get; set; }
        public static ResourceDictionary ThemeColors { get; set; }


        public static bool IsDarkMode {get; private set;}

          /// <summary>
        /// Applies the skin to the application
        /// </summary>
        /// <param name="app">The application.</param>
        /// <param name="skinDictionaryUri">The skin dictionary URI.</param>
        public static void ApplySkin(Application app, Uri skinDictionaryUri)
        {
            // ThemeManager.Current.ThemeSyncMode = ThemeSyncMode.

            // Load the ResourceDictionary into memory.
            ResourceDictionary skinDict = Application.LoadComponent(skinDictionaryUri) as ResourceDictionary;

            Collection<ResourceDictionary> mergedDicts = app.Resources.MergedDictionaries;

            var skinSource = @"/Aml.Skins;component/Themes";

            // Remove the existing skin dictionary, if one exists.
            foreach (var dict in mergedDicts.ToList())
            {
                if (dict.Source != null && dict.Source.OriginalString.Contains(skinSource))
                {
                    mergedDicts.Remove(dict);
                }
            }

            // Apply the selected skin so that all elements in the
            // application will honor the new look and feel.
            mergedDicts.Add(skinDict);

            var theme = skinDictionaryUri.OriginalString.Contains ("Dark.Styles") ? "Dark" : "Light";
            ThemeManager.Current.ChangeThemeBaseColor(Application.Current, theme);

            IsDarkMode = theme == "Dark";
            SetColors (theme == "Dark");
        }

        public static void SetColors (bool isDarkMode)
        {
            ThemeColors = (isDarkMode) 
                ? new ResourceDictionary {Source = SkinSource.DarkSkinColors }                
                : new ResourceDictionary {Source =SkinSource.LightSkinColors };
            
            ApplyColors?.Invoke (ThemeColors);
        }

    }
}