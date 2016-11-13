using Ausgaben_Rechner.Classes;
using HackaTUM.Classes;
using HackaTUM.Classes.Daten;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Threading;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace HackaTUM.Pages
{
    public sealed partial class SmartClockPage : Page
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
        public SmartClockPage()
        {
            this.InitializeComponent();
        }

        #endregion
        //--------------------------------------------------------Set-, Get- Metoden:---------------------------------------------------------\\
        #region --Set-, Get- Metode--
        private DateTime getNextAlarm()
        {
            return DateTime.Now;
        }

        #endregion
        //--------------------------------------------------------Sonstige Metoden:-----------------------------------------------------------\\
        #region --Sonstige Metoden (Public)--



        #endregion

        #region --Sonstige Metoden (Private)--
        private void populateDiagramm(TravelDataEntity data)
        {
            DateTime time = DateTime.Now;
            time = data.startTime.AddMinutes(-4);
            
            startAdress_lbl.Text = data.startAdress;
            targetAdress_lbl.Text = data.targetAdress;
            targetTime_lbl.Text = time.Hour.ToString().PadLeft(2, '0') + ":" + time.Minute.ToString().PadLeft(2, '0');
            time = time.AddMinutes(-data.timeInMinutes);
            startTime_lbl.Text = time.Hour.ToString().PadLeft(2, '0') + ":" + time.Minute.ToString().PadLeft(2, '0');
            timeToGetToWork_lbl.Text = data.timeInMinutes + " Minute(s)";

            time = time.AddMinutes(-45);
            alarm_lbl.Text = time.Hour.ToString().PadLeft(2, '0') + ":" + time.Minute.ToString().PadLeft(2, '0');
        }

        #endregion

        #region --Sonstige Metoden (Protected)--



        #endregion
        //--------------------------------------------------------Events:---------------------------------------------------------------------\\
        #region --Events--
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //CalendarHandler.getCalendarList();
            StringDataEntity data = CalendarHandler.getNextEntry();
            if (data == null)
            {
                return;
            }

            TravelDataEntity entity = TravelDataManager.getTravelData(data.date);
            populateDiagramm(entity);
        }

        #endregion
    }
}
