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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrawPic.Picture
{
    /// <summary>
    /// UcPicture1.xaml 的互動邏輯
    /// </summary>
    public partial class UcPicture1 : UserControl
    {
        public UcPicture1()
        {
            InitializeComponent();
           
        }

        #region 畫圖相關

        #endregion
        bool isDrag = false;
        double x0 = 0.0;
        double y0 = 0.0;
        private void gdControl_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(gdControl);
            if (x0 > pt.X)
                rotate.Angle -= 10;
            else
                rotate.Angle += 10;
            x0 = pt.X;
        }
        double postDelta = 0.0;
        private void gdControl_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > postDelta)
                camMain.FieldOfView -= 4; 
            else
                camMain.FieldOfView += 4;
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            ambLightMain.Color = (Color)ColorConverter.ConvertFromString((sender as Rectangle).Fill.ToString());
        }
    }
}
