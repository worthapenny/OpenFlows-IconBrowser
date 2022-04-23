using System.Drawing;

namespace OF.IconBrowser.Spport
{
    public class IconResource
    {
        #region Constructor
        public IconResource()
        {
        }

        public IconResource(Icon icon, Bitmap bitmapOriginal, Bitmap bitmap32, string name, string label)
        {
            Icon = icon;
            BitmapOriginal = bitmapOriginal;
            Bitmap32 = bitmap32;
            Name = name;
            Label = label;
        }

        #endregion

        #region Public Properties
        public Icon Icon { get; set; }
        public Bitmap BitmapOriginal { get; set; }
        public Bitmap Bitmap32 { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public bool Visible { get; set; } = true;
        public string Keyword => $"{Name.ToLower()}_{Label.ToLower()}";
        #endregion
    }
}
