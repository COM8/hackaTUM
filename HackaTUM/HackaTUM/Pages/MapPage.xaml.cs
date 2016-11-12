using Ausgaben_Rechner.Classes;
using System;
using System.Collections.Generic;
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
    public sealed partial class MapPage : Page
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
        /// 12/11/2016  Created [Fabian Sauter]
        /// </history>
        public MapPage()
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


        #endregion

        #region --Sonstige Metoden (Protected)--



        #endregion
        //--------------------------------------------------------Events:---------------------------------------------------------------------\\
        #region --Events--
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            populateMap();
        }

        #endregion
    }
}
