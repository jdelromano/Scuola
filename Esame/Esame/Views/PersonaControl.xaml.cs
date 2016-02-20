using Esame.Models;
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
    public sealed partial class PersonaControl : UserControl
    {
        public PersonaControl()
        {
            this.InitializeComponent();
        }


        public static readonly DependencyProperty PersonaProperty =
                DependencyProperty.Register("Persona",
                    typeof(TipoPersona),
                    typeof(PersonaControl),
                    new PropertyMetadata(null, PersonaChanged));

        public TipoPersona Persona
        {
            get
            {
                return (TipoPersona)this.GetValue(PersonaProperty);
            }
            set
            {
                this.SetValue(PersonaProperty, value);
            }
        }

        private static void PersonaChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PersonaControl)d).ViewModel.PersonaChanged(e.NewValue);
        }

    }
}
