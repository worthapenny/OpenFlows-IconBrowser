using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OF.IconBrowser.UserControlModel
{
    public class IconViewUserControlModel
    {

        #region Constructor
        public IconViewUserControlModel()
        {
        }
        public IconViewUserControlModel(Bitmap bitmap, string name, string label, bool visible, bool isOriginal)
            :this()
        {
            Bitmap = bitmap;
            Name = name;
            Label = label;
            Visible = visible;
            IsOriginal = isOriginal;
        }
        #endregion

        #region Public Properties
        public Bitmap Bitmap { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public bool Visible { get; set; }
        public bool IsOriginal { get; set; } = true;
        #endregion
    }
}
