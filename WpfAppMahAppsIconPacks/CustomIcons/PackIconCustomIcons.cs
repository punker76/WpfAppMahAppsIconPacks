using System.Windows;
using MahApps.Metro.IconPacks;

namespace WpfAppMahAppsIconPacks.CustomIcons
{
    /// <summary>
    /// CustomIcons Icons
    /// </summary>
    public class PackIconCustomIcons : PackIconControl<PackIconCustomIconsKind>
    {
        static PackIconCustomIcons()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PackIconCustomIcons), new FrameworkPropertyMetadata(typeof(PackIconCustomIcons)));
        }

        public PackIconCustomIcons() : base(PackIconCustomIconsDataFactory.Create)
        {
        }
    }
}