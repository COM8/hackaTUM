using Ausgaben_Rechner.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace HackaTUM.Pages
{
    public sealed partial class MyWayPage : Page
    {
        //--------------------------------------------------------Atribute:-------------------------------------------------------------------\\
        #region --Atribute--



        #endregion
        //--------------------------------------------------------Construktoren:--------------------------------------------------------------\\
        #region --Construktoren--
        /// <summary>
        /// Basic empty Constructor
        /// </summary>
        /// <history>
        /// 11/11/2016  Created [Fabian Sauter]
        /// </history>
        public MyWayPage()
        {
            this.InitializeComponent();
        }

        #endregion
        //--------------------------------------------------------Set-, Get- Metoden:---------------------------------------------------------\\
        #region --Set-, Get- Metode--



        #endregion
        //--------------------------------------------------------Sonstige Metoden:-----------------------------------------------------------\\
        #region --Sonstige Metoden (Public)--



        #endregion

        #region --Sonstige Metoden (Private)--
        private void populateMap()
        {
            Geopoint home = DataStorage.INSTANCE.userData.adressHome;
            Geopoint work = DataStorage.INSTANCE.userData.adressWork;
            if (work != null)
            {
                MapIcon homeIcon = new MapIcon();
                homeIcon.Location = work;
                homeIcon.NormalizedAnchorPoint = new Point(0.5, 1.0);
                homeIcon.Title = "Work Point";
                homeIcon.ZIndex = 0;
                map.MapElements.Add(homeIcon);
                map.Center = work;
                map.ZoomLevel = 14;
            }

            if (home != null)
            {
                MapIcon workIcon = new MapIcon();
                workIcon.Location = home;
                workIcon.NormalizedAnchorPoint = new Point(0.5, 1.0);
                workIcon.Title = "Home Point";
                workIcon.ZIndex = 0;
                map.MapElements.Add(workIcon);
                map.Center = home;
                map.ZoomLevel = 14;
            }
        }

        private void populateAdresses()
        {
            Geopoint home = DataStorage.INSTANCE.userData.adressHome;
            Geopoint work = DataStorage.INSTANCE.userData.adressWork;

            if(home != null)
            {
                latHome_tbx.Text = home.Position.Latitude.ToString();
                lonHome_tbx.Text = home.Position.Longitude.ToString();
            }

            if (work != null)
            {
                latWork_tbx.Text = work.Position.Latitude.ToString();
                lonWork_tbx.Text = work.Position.Longitude.ToString();
            }
        }

        private double doubleTextChanged(TextBox sender)
        {
            double dtemp;
            if (!double.TryParse(sender.Text, out dtemp) && sender.Text != "")
            {
                int pos = sender.SelectionStart - 1;
                sender.Text = sender.Text.Remove(pos, 1);
                sender.SelectionStart = pos;
            }
            return dtemp;
        }

        #endregion

        #region --Sonstige Metoden (Protected)--



        #endregion
        //--------------------------------------------------------Events:---------------------------------------------------------------------\\
        #region --Events--
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            populateMap();
            //populateAdresses();
        }

        private void expandGeneral_btn_Click(object sender, RoutedEventArgs e)
        {
            if (settingsGeneral_sckpl.Visibility == Visibility.Visible)
            {
                expandGeneralSettings_btn.Content = "\xE019";
                settingsGeneral_sckpl.Visibility = Visibility.Collapsed;
            }
            else
            {
                expandGeneralSettings_btn.Content = "\xE018";
                settingsGeneral_sckpl.Visibility = Visibility.Visible;
            }
        }

        private void latHome_tbx_TextChanged(TextBox sender, TextBoxTextChangingEventArgs e)
        {
            double lat = doubleTextChanged(sender);
            double longi = doubleTextChanged(lonHome_tbx);
            DataStorage.INSTANCE.userData.adressHome = new Geopoint(new BasicGeoposition() { Latitude = lat, Longitude = longi });
            DataStorage.INSTANCE.saveUserData();
        }

        private void lonHome_tbx_TextChanged(TextBox sender, TextBoxTextChangingEventArgs e)
        {
            double lat = doubleTextChanged(latHome_tbx);
            double longi = doubleTextChanged(sender);
            DataStorage.INSTANCE.userData.adressHome = new Geopoint(new BasicGeoposition() { Latitude = lat, Longitude = longi });
            DataStorage.INSTANCE.saveUserData();
        }

        private void latWork_tbx_TextChanged(TextBox sender, TextBoxTextChangingEventArgs e)
        {
            double lat = doubleTextChanged(sender);
            double longi = doubleTextChanged(lonWork_tbx);
            DataStorage.INSTANCE.userData.adressWork = new Geopoint(new BasicGeoposition() { Latitude = lat, Longitude = longi });
            DataStorage.INSTANCE.saveUserData();
        }

        private void lonWork_tbx_TextChanging(TextBox sender, TextBoxTextChangingEventArgs e)
        {
            double lat = doubleTextChanged(latWork_tbx);
            double longi = doubleTextChanged(sender);
            DataStorage.INSTANCE.userData.adressWork = new Geopoint(new BasicGeoposition() { Latitude = lat, Longitude = longi });
            DataStorage.INSTANCE.saveUserData();
        }

        #endregion
    }
}
