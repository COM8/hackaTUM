using Ausgaben_Rechner.Classes;
using HackaTUM.Classes;
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
        private void setNextWakeUpTime(TravelDataEntity data)
        {
            DateTime time = data.startTime.AddMinutes(-45);
            alarm_lbl.Text = time.Hour.ToString().PadLeft(2, '0') + ":" + time.Minute.ToString().PadLeft(2, '0');
        }

        private void populateDiagramm(TravelDataEntity data)
        {
            DateTime time = DateTime.Now;
            startAdress_lbl.Text = data.startAdress;
            targetAdress_lbl.Text = data.targetAdress;
            time = data.startTime;
            startTime_lbl.Text = time.Hour.ToString().PadLeft(2, '0') + ":" + time.Minute.ToString().PadLeft(2, '0');
            time = time.AddMinutes(data.timeInMinutes);
            targetTime_lbl.Text = time.Hour.ToString().PadLeft(2, '0') + ":" + time.Minute.ToString().PadLeft(2, '0');
            timeToGetToWork_lbl.Text = data.timeInMinutes + " Minute(s)";
        }

        #endregion

        #region --Sonstige Metoden (Protected)--



        #endregion
        //--------------------------------------------------------Events:---------------------------------------------------------------------\\
        #region --Events--
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime startTime = DateTime.Now;
            TravelDataEntity data = TravelDataManager.getTravelData(startTime);
            setNextWakeUpTime(data);
            populateDiagramm(data);
        }

        #endregion
    }
}
