using System.Windows.Markup;
using MahApps.Metro.IconPacks;

namespace WpfAppMahAppsIconPacks.CustomIcons
{
    [MarkupExtensionReturnType(typeof(PackIconCustomIcons))]
    public class CustomIconsExtension : PackIconExtension<PackIconCustomIcons, PackIconCustomIconsKind>
    {
        public CustomIconsExtension()
        {
        }

        public CustomIconsExtension(PackIconCustomIconsKind kind) : base(kind)
        {
        }
    }
}