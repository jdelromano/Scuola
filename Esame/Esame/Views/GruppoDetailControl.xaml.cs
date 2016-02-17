using Esame.ViewModels;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Esame.Views
{
    public sealed partial class GruppoDetailControl : UserControl
    {
        //Questo ci serve per bindare lo userControl con il model
        public static readonly DependencyProperty GruppoProperty =
        DependencyProperty.Register("gruppoDetail",
                typeof(gruppoDetail),
                typeof(GruppoDetailControl),
                new PropertyMetadata(null, GruppoChanged));

        private static void GruppoChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((GruppoDetailControl)d).ViewModel.gruppoDetailChanged((gruppoDetail)e.NewValue);
        }

        public gruppoDetail Gruppo
        {
            get { return (gruppoDetail)this.GetValue(GruppoProperty); }
            set { this.SetValue(GruppoProperty, value); }
        }

        public GruppoDetailControl()
        {
            this.InitializeComponent();
        }
    }
}
