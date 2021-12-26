using Haestad.Framework.Windows.Forms.Resources;
using Haestad.Support.Support;
using OF.IconBrowser.Support;
using System.Collections.Generic;
using System.Drawing;

namespace OF.IconBrowser.FormModel
{
    public class IconBrowserFormModel
    {
        #region Constructor
        public IconBrowserFormModel()
        {
        }
        #endregion

        #region Public Methods
        
        public List<IconResourceModel> Filter(string keyword, bool isEnlarged)
        {
            LoadIcons();

            var iconResources = new List<IconResourceModel>();
            foreach (var resource in IconResources)
            {
                if (resource.Keyword.Contains(keyword.ToLower()) &&
                    resource.IsEnlarged == isEnlarged)
                {
                    resource.IsVisible = true;
                    iconResources.Add(resource);
                }
                else
                {
                    resource.IsVisible = false;
                }
            }

            return iconResources;
        }
        #endregion

        #region Private Methods
        private void LoadIcons()
        {
            if (IconResources.Count > 0)
                return;

            foreach (var field in typeof(StandardGraphicResourceNames).GetFields())
            {
                try
                {

                    var name = field.GetValue(field.Name);
                    if (name != null)
                    {
                        var icon = (Icon)GraphicResourceManager.Current[name.ToString()];
                        if (icon == null)
                            continue;

                        var resource = new IconResourceModel(
                            icon: icon,
                            bitmap: icon.ToBitmap(),
                            name: name.ToString(),
                            label: field.Name,
                            isVisible: false,
                            isEnlarged: false);

                        IconResources.Add(resource);

                        if (icon.Size.Height < 32)
                        {
                            resource = new IconResourceModel(
                            icon: icon,
                            bitmap: new Bitmap(icon.ToBitmap(), new Size(32, 32)),
                            name: name.ToString(),
                            label: field.Name,
                            isVisible: false,
                            isEnlarged: true);

                            IconResources.Add(resource);
                        }
                    }
                }
                catch
                {
                }
            }
        }
        #endregion

        #region Public Properties
        public  List<IconResourceModel> IconResources { get; private set; } = new List<IconResourceModel>();
        #endregion
    }
}
