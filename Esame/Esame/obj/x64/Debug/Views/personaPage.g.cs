﻿#pragma checksum "C:\Users\José\Documents\GitHub\Scuola\Esame\Esame\Views\personaPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "695CC17CAFD77ACC495F004ACF4392D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Esame.Views
{
    partial class personaPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Template10_Controls_PageHeader_Frame(global::Template10.Controls.PageHeader obj, global::Windows.UI.Xaml.Controls.Frame value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Controls.Frame) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Controls.Frame), targetNullValue);
                }
                obj.Frame = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class personaPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IpersonaPage_Bindings
        {
            private global::Esame.Views.personaPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Template10.Controls.PageHeader obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;
            private global::Windows.UI.Xaml.Controls.TextBlock obj11;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;

            private personaPage_obj1_BindingsTracking bindingsTracking;

            public personaPage_obj1_Bindings()
            {
                this.bindingsTracking = new personaPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7:
                        this.obj7 = (global::Template10.Controls.PageHeader)target;
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 11:
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 12:
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IpersonaPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // personaPage_obj1_Bindings

            public void SetDataRoot(global::Esame.Views.personaPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Esame.Views.personaPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Frame(obj.Frame, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_personaView(obj.personaView, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_personaView(phase);
                    }
                }
            }
            private void Update_Frame(global::Windows.UI.Xaml.Controls.Frame obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Template10_Controls_PageHeader_Frame(this.obj7, obj, null);
                }
            }
            private void Update_personaView(global::Esame.ViewModels.personaViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_personaView(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_personaView_Nome(obj.Nome, phase);
                        this.Update_personaView_Cognome(obj.Cognome, phase);
                        this.Update_personaView_Telefono(obj.Telefono, phase);
                        this.Update_personaView_Nascita(obj.Nascita, phase);
                        this.Update_personaView_Gruppo(obj.Gruppo, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_personaView_Nome(phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_personaView_Cognome(phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_personaView_Telefono(phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_personaView_Nascita(phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_personaView_Gruppo(phase);
                    }
                }
            }
            private void Update_personaView_Nome(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                }
            }
            private void Update_personaView_Cognome(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj, null);
                }
            }
            private void Update_personaView_Telefono(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                }
            }
            private void Update_personaView_Nascita(global::System.DateTime obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj.ToString(), null);
                }
            }
            private void Update_personaView_Gruppo(global::Esame.ViewModels.gruppoDetail obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_personaView_Gruppo_Nome(obj.Nome, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_personaView_Gruppo_Nome(phase);
                    }
                }
            }
            private void Update_personaView_Gruppo_Nome(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj, null);
                }
            }

            private void UpdateFallback_personaView(int phase)
            {
                this.UpdateFallback_personaView_Nome(phase);
                this.UpdateFallback_personaView_Cognome(phase);
                this.UpdateFallback_personaView_Telefono(phase);
                this.UpdateFallback_personaView_Nascita(phase);
                this.UpdateFallback_personaView_Gruppo(phase);
            }

            private void UpdateFallback_personaView_Nome(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, "_Nome", null);
                }
            }

            private void UpdateFallback_personaView_Cognome(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, "_Cognome", null);
                }
            }

            private void UpdateFallback_personaView_Telefono(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, "_Telefono", null);
                }
            }

            private void UpdateFallback_personaView_Nascita(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, "_Nascita", null);
                }
            }

            private void UpdateFallback_personaView_Gruppo(int phase)
            {
                this.UpdateFallback_personaView_Gruppo_Nome(phase);
            }

            private void UpdateFallback_personaView_Gruppo_Nome(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, "_gruppo", null);
                }
            }

            private class personaPage_obj1_BindingsTracking
            {
                global::System.WeakReference<personaPage_obj1_Bindings> WeakRefToBindingObj; 

                public personaPage_obj1_BindingsTracking(personaPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<personaPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_personaView(null);
                }

                public void PropertyChanged_personaView(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    personaPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Esame.ViewModels.personaViewModel obj = sender as global::Esame.ViewModels.personaViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_personaView_Nome(obj.Nome, DATA_CHANGED);
                                    bindings.Update_personaView_Cognome(obj.Cognome, DATA_CHANGED);
                                    bindings.Update_personaView_Telefono(obj.Telefono, DATA_CHANGED);
                                    bindings.Update_personaView_Nascita(obj.Nascita, DATA_CHANGED);
                                    bindings.Update_personaView_Gruppo(obj.Gruppo, DATA_CHANGED);
                            }
                            else
                            {
                                bindings.UpdateFallback_personaView_Nome(DATA_CHANGED);
                                bindings.UpdateFallback_personaView_Cognome(DATA_CHANGED);
                                bindings.UpdateFallback_personaView_Telefono(DATA_CHANGED);
                                bindings.UpdateFallback_personaView_Nascita(DATA_CHANGED);
                                bindings.UpdateFallback_personaView_Gruppo(DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Nome":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_personaView_Nome(obj.Nome, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_personaView_Nome(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Cognome":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_personaView_Cognome(obj.Cognome, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_personaView_Cognome(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Telefono":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_personaView_Telefono(obj.Telefono, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_personaView_Telefono(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Nascita":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_personaView_Nascita(obj.Nascita, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_personaView_Nascita(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Gruppo":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_personaView_Gruppo(obj.Gruppo, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_personaView_Gruppo(DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Esame.ViewModels.personaViewModel cache_personaView = null;
                public void UpdateChildListeners_personaView(global::Esame.ViewModels.personaViewModel obj)
                {
                    if (obj != cache_personaView)
                    {
                        if (cache_personaView != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_personaView).PropertyChanged -= PropertyChanged_personaView;
                            cache_personaView = null;
                        }
                        if (obj != null)
                        {
                            cache_personaView = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_personaView;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.ThisPage = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2:
                {
                    this.personaView = (global::Esame.ViewModels.personaViewModel)(target);
                }
                break;
            case 3:
                {
                    this.AdaptiveVisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4:
                {
                    this.VisualStateNarrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.VisualStateNormal = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.VisualStateWide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    personaPage_obj1_Bindings bindings = new personaPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

