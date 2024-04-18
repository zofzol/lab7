using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Diagnostics;
using System.Diagnostics;
using System.Collections.Generic;
using System.Numerics;

namespace lab7.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    public void ButtonClicked(object source, RoutedEventArgs args)
    {

        List<string> lista = new List<string>();
        Dictionary<string, int> licznik = new Dictionary<string, int>();
        Debug.WriteLine("Click!");
        for(int i=0; i<input.Text.Length-4; i++) 
        {
            string czworka="";
             lista.Add(input.Text.Substring(i, 4)); //1 -- poz pocz|| 2 -- ile uciac
            czworka = input.Text.Substring(i, 4);
            
            if (licznik.ContainsKey(czworka))
            {
                licznik[czworka]++;
            }
            else
            {
                licznik.Add(czworka, 1);
            }
         
        }
        output.Text = "CIAG ILOSC \n------------\n";
        foreach (string d in licznik.Keys)
        {
            output.Text+= d + "    "+ licznik[d].ToString();
            output.Text += ("\n");
        }
       

    }
}
