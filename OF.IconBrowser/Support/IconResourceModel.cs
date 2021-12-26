using System.Drawing;

namespace OF.IconBrowser.Support
{

    public class IconResourceModel
    {
        #region Constructor
        public IconResourceModel()
        {
        }
        public IconResourceModel(Icon icon, Bitmap bitmap, string name, string label,bool isVisible, bool isEnlarged)
        {
            Icon = icon;
            Bitmap = bitmap;
            Name = name;
            Label = label;
            IsVisible = isVisible;
            IsEnlarged = isEnlarged;
        }
        #endregion

        #region Public Properties
        public Icon Icon { get; set; }
        public Bitmap Bitmap{ get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public bool IsVisible { get; set; } = false;
        public bool IsEnlarged { get; set; } = false;
        public string Keyword => $"{Name.ToLower()}_{Label.ToLower()}";
        #endregion
    }
}
