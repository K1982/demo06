using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CarCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void trucksButton_Click(object sender, RoutedEventArgs e)
        {
            //haetaan käyttöliittymästä trucksTextBlockin sisältämä teksti
            string trucksString = trucksTextBlock.Text;
            int trucks = int.Parse(trucksString); // 0
            // kuorma-autoja yksi enemmän
            trucks++;
            //näytetään uusi lukumäärä näytöllä
            trucksTextBlock.Text = trucks.ToString();
        }

        private void carsButton_Click(object sender, RoutedEventArgs e)
        {
            string carsString = carsTextBlock.Text;
            int cars = int.Parse(carsString);
            cars++;
            carsTextBlock.Text = cars.ToString();
        }
    }
}
