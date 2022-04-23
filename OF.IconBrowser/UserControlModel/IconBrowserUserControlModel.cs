using Haestad.Framework.Windows.Forms.Resources;
using Haestad.Support.Support;
using OF.IconBrowser.Spport;
using OF.IconBrowser.UserControls;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OF.IconBrowser.UserControlModel
{
    public class IconBrowserUserControlModel
    {
        #region Constructor
        public IconBrowserUserControlModel()
        {
        }
        #endregion

        #region Public Methods
        public void LoadGraphics2(DataGridView gridView, int width, string keyword, bool originalSize)
        {
            var filteredIconResources = IconResources.Where(i => i.Keyword.Contains(keyword.ToLower())).ToList();

            int imageWidth = 48 + 2;
            int imageHeigth = imageWidth;
            int columnCount = (int)(width / imageWidth) - 1;

            gridView.Rows.Clear();
            gridView.Columns.Clear();

            // Add columns
            for (int i = 0; i < columnCount; i++)
            {
                var col = new DataGridViewImageColumn();
                col.Width = imageWidth;
                gridView.Columns.Add(col);
            }

            // Add rows
            int rowCount = (int)(filteredIconResources.Count / columnCount) + 1;
            int counter = 0;
            for (int i = 0; i < rowCount; i++)
            {
                gridView.Rows.Add();
                var row = gridView.Rows[i];
                row.Height = imageHeigth;

                for (int j = 0; j < columnCount && filteredIconResources.Count < counter; j++)
                {
                    var iconResource = filteredIconResources[counter];
                    var cell = gridView[j, i];
                    if (iconResource != null)
                    {
                        cell.Value = originalSize ? iconResource.BitmapOriginal : iconResource.Bitmap32;
                        cell.ToolTipText = $"{iconResource.Label} ({iconResource.Name})";
                    }
                    counter++;
                }
            }
        }

        internal List<IconView> GetIconViews()
        {
            LoadIconResouces();
            return IconViewList;
        }

        public void LoadGraphics(DataGridView gridView, int width, string keyword, bool originalSize)
        {
            int imageWidth = 48 + 2;
            int imageHeigth = imageWidth;
            int columnCount = (int)(width / imageWidth) - 1;


            gridView.Rows.Clear();
            gridView.Columns.Clear();



            var graphicCells = new List<DataGridViewImageCell>();
            foreach (var iconMapItem in IconMap)
            {

                if (string.IsNullOrWhiteSpace(keyword) || iconMapItem.Key.ToLower().Contains(keyword.ToLower()))
                {
                    if (iconMapItem.Value == null)
                        continue;

                    var cell = new DataGridViewImageCell();

                    if (!originalSize && iconMapItem.Value.Width < 32)
                    {
                        cell.Value = new Bitmap(iconMapItem.Value.ToBitmap(), new Size(iconMapItem.Value.Width * 2, iconMapItem.Value.Height * 2));
                    }
                    else
                    {
                        cell.Value = iconMapItem.Value;
                    }

                    cell.Description = iconMapItem.Key;
                    cell.ToolTipText = iconMapItem.Key;

                    graphicCells.Add(cell);
                }

            }

            if (graphicCells.Count == 0)
                return;

            // Add columns
            for (int i = 0; i < columnCount; i++)
            {
                var col = new DataGridViewImageColumn();
                col.Width = imageWidth;
                gridView.Columns.Add(col);
            }

            // Add rows
            int rowCount = (int)(graphicCells.Count / columnCount) + 1;
            int counter = 0;
            for (int i = 0; i < rowCount; i++)
            {
                gridView.Rows.Add();
                var row = gridView.Rows[i];
                row.Height = imageHeigth;

                for (int j = 0; j < columnCount; j++)
                {

                    if (counter >= IconMap.Count || graphicCells.Count <= counter)
                        break;


                    gridView[j, i] = graphicCells[counter];
                    counter++;
                }
            }

        }
        #endregion

        #region Private Methods
        private void LoadIconResouces()
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

                        var resource = new IconResource(
                            icon: icon,
                            bitmapOriginal: icon.ToBitmap(),
                            bitmap32: new Bitmap(icon.ToBitmap(), new Size(32, 32)),
                            name: name.ToString(),
                            label: field.Name
                            );

                        IconResources.Add(resource);

                        var iconView = new IconView();
                        iconView.IconViewUserControlModel = new IconViewUserControlModel(icon.ToBitmap(), field.Name, name.ToString(), true, true);
                        IconViewList.Add(iconView);

                        if(icon.Size.Height < 32)
                        {
                            iconView = new IconView();
                            iconView.IconViewUserControlModel = new IconViewUserControlModel(
                                new Bitmap(icon.ToBitmap(), new Size(32,31)), field.Name, name.ToString(), true, false);
                            IconViewList.Add(iconView);
                        }
                    }
                }
                catch
                {
                }
            }
        }
        private Dictionary<string, Icon> LoadIconMapFromAssembly()
        {
            var iconMap = new Dictionary<string, Icon>();

            foreach (var field in typeof(StandardGraphicResourceNames).GetFields())
            {
                try
                {

                    var name = field.GetValue(field.Name);
                    if (name != null)
                        iconMap.Add(field.Name, (Icon)GraphicResourceManager.Current[name.ToString()]);
                }
                catch
                {
                }
            }

            return iconMap;
        }

        private Dictionary<string, DataGridViewImageCell> LoadOriginalGraphicsMapFromAssembly()
        {
            var map = new Dictionary<string, DataGridViewImageCell>();

            foreach (var field in typeof(StandardGraphicResourceNames).GetFields())
            {
                try
                {

                    var name = field.GetValue(field.Name);
                    if (name != null)
                    {
                        var cell = new DataGridViewImageCell();
                        cell.ToolTipText = $"{field.Name}: {name}";
                        cell.Description = cell.ToolTipText;
                        cell.Value = (Icon)GraphicResourceManager.Current[name.ToString()];
                    }

                }
                catch
                {
                }
            }

            return map;
        }
        private Dictionary<string, DataGridViewImageCell> LoadIconEnlargedGraphicsMapFromAssembly()
        {
            var map = new Dictionary<string, DataGridViewImageCell>();

            foreach (var field in typeof(StandardGraphicResourceNames).GetFields())
            {
                try
                {

                    var name = field.GetValue(field.Name);
                    if (name != null)
                    {
                        var cell = new DataGridViewImageCell();
                        cell.ToolTipText = $"{field.Name}: {name}";
                        cell.Description = cell.ToolTipText;
                        var image = (Icon)GraphicResourceManager.Current[name.ToString()];
                        if (image.Size.Width < 32)
                            cell.Value = new Bitmap(image.ToBitmap(), new Size(32, 32));
                        else
                            cell.Value = image;
                    }

                }
                catch
                {
                }
            }

            return map;
        }
        #endregion

        #region Private Properties
        private List<IconResource> IconResources { get; set; } = new List<IconResource>();
        private List<IconView> IconViewList { get; set; } = new List<IconView>();

        private Dictionary<string, Icon> IconMap
        {
            get
            {
                if (iconMap.Count == 0)
                    iconMap = LoadIconMapFromAssembly();
                return iconMap;
            }
        }
        private Dictionary<string, DataGridViewImageCell> OriginalGraphicsMap
        {
            get
            {
                if (originalGraphicsMap.Count == 0)
                    originalGraphicsMap = LoadOriginalGraphicsMapFromAssembly();
                return originalGraphicsMap;
            }
        }



        private Dictionary<string, DataGridViewImageCell> EnlargedGraphicsMap
        {
            get
            {
                if (enlargedGraphicsMap.Count == 0)
                    enlargedGraphicsMap = LoadIconEnlargedGraphicsMapFromAssembly();
                return enlargedGraphicsMap;
            }
        }


        #endregion

        #region Fields
        Dictionary<string, Icon> iconMap = new Dictionary<string, Icon>();
        Dictionary<string, DataGridViewImageCell> originalGraphicsMap = new Dictionary<string, DataGridViewImageCell>();
        Dictionary<string, DataGridViewImageCell> enlargedGraphicsMap = new Dictionary<string, DataGridViewImageCell>();
        #endregion
    }
}
