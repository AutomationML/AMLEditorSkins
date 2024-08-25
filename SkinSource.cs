// Copyright (c) 2017 AutomationML e.V.
using System;

namespace Aml.Skins;

/// <summary>
///     The skin source.
/// </summary>
public class SkinSource
{
    /// <summary>
    ///     Prevents a default instance of the <see cref="SkinSource" /> class from being created.
    /// </summary>
    private SkinSource()
    {
    }

    public static SkinSource Instance { get; } = new();
    public static Uri DarkSkin { get; } = new("/Aml.Skins;component/Themes/Dark.Styles.xaml", UriKind.Relative);
    public static Uri LightSkin { get; } = new("/Aml.Skins;component/Themes/Light.Styles.xaml", UriKind.Relative);

    public static Uri DarkSkinColors { get; } =
        new("/Aml.Skins;component/Themes/Dark.Theme.Colors.xaml", UriKind.Relative);

    public static Uri LightSkinColors { get; } =
        new("/Aml.Skins;component/Themes/Light.Theme.Colors.xaml", UriKind.Relative);
}