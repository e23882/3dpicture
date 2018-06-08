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
        private void gdPicture1_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void gdPicture1_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void gdPicture1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void gdPicture1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        public void ScaleEasingAnimationShow(UIElement element, double from, double to)
        {

            RotateTransform angle = new RotateTransform();  //旋转  
            ScaleTransform scale = new ScaleTransform();   //缩放  



            TransformGroup group = new TransformGroup();
            group.Children.Add(scale);
            group.Children.Add(angle);


            element.RenderTransform = group;
            element.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);//定义圆心位置          
            EasingFunctionBase easeFunction = new PowerEase()
            {
                EasingMode = EasingMode.EaseInOut,
                Power = 2
            };
            DoubleAnimation scaleAnimation = new DoubleAnimation()
            {
                From = from,                                   //起始值  
                To = to,                                     //结束值  
                EasingFunction = easeFunction,                    //缓动函数  
                Duration = new TimeSpan(0, 0, 0, 5, 0),  //动画播放时间  


            };

            DoubleAnimation angleAnimation = new DoubleAnimation()
            {
                From = 0,                                   //起始值  
                To = 360,                                     //结束值  
                EasingFunction = easeFunction,                    //缓动函数  
                Duration = new TimeSpan(0, 0, 0, 5, 0),  //动画播放时间  

            };

            //scaleAnimation.Completed += new EventHandler(scaleAnimation_Completed);  
            //  AnimationClock clock = scaleAnimation.CreateClock();  
            scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
            scale.BeginAnimation(ScaleTransform.ScaleYProperty, scaleAnimation);
            angle.BeginAnimation(RotateTransform.AngleProperty, angleAnimation);
            //}  
        }
        #endregion
    }
}
