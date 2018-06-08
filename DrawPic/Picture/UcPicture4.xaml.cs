using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrawPic.Picture
{
    /// <summary>
    /// UcPicture4.xaml 的互動邏輯
    /// </summary>
    public partial class UcPicture4 : UserControl
    {
        public UcPicture4()
        {
            InitializeComponent();
            ObjReader CurrentHelixObjReader = new ObjReader();
            Model3DGroup MyModel = CurrentHelixObjReader.Read(@".\3dModel\earth.obj");
            model.Content = MyModel;
        }
    }
}
