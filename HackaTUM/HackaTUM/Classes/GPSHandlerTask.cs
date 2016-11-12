using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace HackaTUM.Classes
{
    public class GPSHandlerTask
    {
        //--------------------------------------------------------Atribute:-------------------------------------------------------------------\\
        #region --Atribute--
        public static GPSHandlerTask INSTANCE = new GPSHandlerTask();
        private Task t;
        private MainPage rootPage;

        #endregion
        //--------------------------------------------------------Construktoren:--------------------------------------------------------------\\
        #region --Construktoren--
        /// <summary>
        /// Basic empty Constructor
        /// </summary>
        /// <history>
        /// 12/11/2016  Created [Fabian Sauter]
        /// </history>
        public GPSHandlerTask()
        {
            this.rootPage = null;
            this.t = null;
        }

        #endregion
        //--------------------------------------------------------Set-, Get- Metoden:---------------------------------------------------------\\
        #region --Set-, Get- Metode--
        public async static Task<Geoposition> getLocation()
        {
            var accessStatur = await Geolocator.RequestAccessAsync();
            
            if(accessStatur != GeolocationAccessStatus.Allowed)
            {
                throw new Exception();
            }

            Geolocator locator = new Geolocator { DesiredAccuracyInMeters = 0 };
            var pos = await locator.GetGeopositionAsync();
            return pos;
        }


        #endregion
        //--------------------------------------------------------Sonstige Metoden:-----------------------------------------------------------\\
        #region --Sonstige Metoden (Public)--
        public void init(MainPage rootPage)
        {
            this.rootPage = rootPage;
            this.t = initAsync();
        }


        #endregion

        #region --Sonstige Metoden (Private)--
        private async Task initAsync()
        {
            Geoposition pos = await GPSHandlerTask.getLocation();
            Debug.WriteLine(pos.Coordinate.Longitude);

        }

        private void sendToAzure()
        {

        }

        #endregion

        #region --Sonstige Metoden (Protected)--



        #endregion
        //--------------------------------------------------------Events:---------------------------------------------------------------------\\
        #region --Events--



        #endregion
    }
}
