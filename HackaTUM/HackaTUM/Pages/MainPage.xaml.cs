using HackaTUM.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static HackaTUM.Classes.Utilities;

// Die Vorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 dokumentiert.

namespace HackaTUM
{
    public sealed partial class MainPage : Page
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
        public MainPage()
        {
            this.InitializeComponent();
        }

        #endregion
        //--------------------------------------------------------Set-, Get- Metoden:---------------------------------------------------------\\
        #region --Set-, Get- Metode--



        #endregion
        //--------------------------------------------------------Sonstige Metoden:-----------------------------------------------------------\\
        #region --Sonstige Metoden (Public)--
        private void navigateToSelectedPage()
        {
            if (mainFrame == null || !splitViewIcons_lb.IsEnabled)
            {
                return;
            }
            switch (splitViewIcons_lb.SelectedIndex)
            {
                case 0:
                    pageName_tbl.Text = "Home";
                    mainFrame.Navigate(typeof(HomePage));
                    break;

                case 1:
                    pageName_tbl.Text = "SmartClock";
                    mainFrame.Navigate(typeof(SmartClockPage));
                    break;

                case 2:
                    pageName_tbl.Text = "MyWay";
                    mainFrame.Navigate(typeof(MyWayPage));
                    break;

                case 3:
                    pageName_tbl.Text = "Settings";
                    mainFrame.Navigate(typeof(SettingsPage));
                    break;

                default:
                    break;
            }
        }

        public void navigateToPage(EnumPage page)
        {
            splitViewIcons_lb.SelectedIndex = (int)page;
            navigateToSelectedPage();
        }

        public void enableBurgerMenue()
        {
            splitViewIcons_lb.IsEnabled = true;
        }

        public void disableBurgerMenue()
        {
            splitViewIcons_lb.IsEnabled = false;
        }

        #endregion

        #region --Sonstige Metoden (Private)--



        #endregion

        #region --Sonstige Metoden (Protected)--



        #endregion
        //--------------------------------------------------------Events:---------------------------------------------------------------------\\
        #region --Events--
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            /*if (!DataStorage.INSTANCE.dataInitiallyLoaded)
            {
                await DataStorage.INSTANCE.loadAllDataTaskAsync();
                DataStorage.INSTANCE.dataInitiallyLoaded = true;
            }

            if (DataStorage.INSTANCE.settingsData.initialRun)
            {
                mainFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                navigateToSelectedPage();
            }*/
        }

        private void openSplitView_hbtn_Click(object sender, RoutedEventArgs e)
        {
            mainPage_spv.IsPaneOpen = !mainPage_spv.IsPaneOpen;
        }

        private void splitViewIcons_lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            navigateToSelectedPage();
        }

        private void goBackRequest(object sender, BackRequestedEventArgs e)
        {
            if (mainFrame.CanGoBack && splitViewIcons_lb.IsEnabled)
            {
                mainFrame.GoBack();
            }
        }

        #endregion
    }
}
