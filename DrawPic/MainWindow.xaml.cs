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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrawPic
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbPic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbPic.SelectedIndex ==0)
                ctContent.Content = new Picture.UcPicture1();
            if (cbPic.SelectedIndex == 1)
                ctContent.Content = new Picture.UcPicture2();
            if (cbPic.SelectedIndex == 2)
                ctContent.Content = new Picture.UcPicture3();
            if (cbPic.SelectedIndex == 3)
                ctContent.Content = new Picture.UcPicture4();
        }

        private void cbPic_Loaded(object sender, RoutedEventArgs e)
        {
            cbPic.Items.Add("Picture1");
            cbPic.Items.Add("Picture2");
            cbPic.Items.Add("Picture3");
            cbPic.Items.Add("Picture4");
            cbPic.SelectedIndex = 0;
        }
    }
}
