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
using Esame.Models;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Esame.Views
{
    public sealed partial class GruppoControl : UserControl
    {
        public GruppoControl()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty GruppoProperty =
                DependencyProperty.Register("Gruppo",
                    typeof(TipoGruppo),
                    typeof(GruppoControl),
                    new PropertyMetadata(null, GruppoChanged));

        public TipoGruppo Gruppo
        {
            get
            {
                return (TipoGruppo)this.GetValue(GruppoProperty);
            }
            set
            {
                this.SetValue(GruppoProperty, value);
            }
        }

        private static void GruppoChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((GruppoControl)d).ViewModel.GruppoChanged(e.NewValue);
        }
        
    }
}
