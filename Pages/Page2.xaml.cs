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

namespace WpfAppToolBar.Pages
{
    public partial class Page2 : Page
    {
         //Erzeuge Bauteil-Liste
        List<Gewicht> gewichtListe = new List<Gewicht>();
    
        public Page2()
        {
            InitializeComponent();

        //Verbinde ItemsControl mit der Liste! 
        GewichtBauteil1.ItemsSource = gewichtListe;

        //Befülle Liste mit Objekten 
        gewichtListe.Add(new Gewicht("Hauptträger"));
       

    }
              
        private void GewichtBauteil1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Gewicht item = GewichtBauteil1.SelectedItem as Gewicht;
            GewichtBauteil.Content = item.Kg + "Test123"; 
        }
    }

public class Gewicht
{
    public string Kg { get; set; }

    public Gewicht(string _kg)
    {
        Kg = _kg;
    }
}
}
