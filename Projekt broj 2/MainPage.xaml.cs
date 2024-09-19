using System.Collections.Generic;

namespace Projekt_broj_2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            list.Add(Color.FromRgba("#198cb8"));
            list.Add(Color.FromRgba("#d9eef3"));
            list.Add(Color.FromRgba("#fbe4b0"));
            list.Add(Color.FromRgba("#A325BE"));
            list.Add(Color.FromRgba("#AEBE25"));
        }
        private void OnValueChange(object sender, ValueChangedEventArgs e)
        { 
        
        }
        private void OnValueChange(object sender, EventArgs e) 
        {
        count++;
            if (count == 4) { count = 0; }
            text1.TextColor = list[count];
            text2.TextColor = list[count];
            text3.TextColor = list[count];
        }
    }
}