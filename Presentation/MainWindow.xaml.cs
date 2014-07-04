using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Presentation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SampelVersion1.SampelVersion sample = new SampelVersion1.SampelVersion();
        
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Normal_Call_Method_Click(object sender, RoutedEventArgs e)
        {

            listbox1.ItemsSource = null;
            listbox1.ItemsSource = sample.cacheddatetime;
  
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Normal_Call_Method_Copy_Click(object sender, RoutedEventArgs e)
        {
            Type privatecall = typeof (SampelVersion1.SampelVersion);

            FieldInfo FInfo = privatecall.GetField("_cacheddatetime", BindingFlags.Public | BindingFlags.Instance);
            List<string> typelist = FInfo.GetValue(sample) as List<string>;

            listbox2.ItemsSource = null;
            listbox2.ItemsSource = typelist;

        }
    }
}
