using Ausgaben_Rechner.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace HackaTUM.Classes
{
    class TravelDataManager
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
        public TravelDataManager()
        {

        }
        #endregion
        //--------------------------------------------------------Set-, Get- Metoden:---------------------------------------------------------\\
        #region --Set-, Get- Metode--



        #endregion
        //--------------------------------------------------------Sonstige Metoden:-----------------------------------------------------------\\
        #region --Sonstige Metoden (Public)--



        #endregion

        public static String getConnectionInfo()
        {
           return(getConnectionInfo(DataStorage.INSTANCE.userData.adressHome, DataStorage.INSTANCE.userData.adressWork));
        }
        public static String getConnectionInfo(String startAdress, String Destination)
        {
            //DataStorage.INSTANCE.userData.adressHome
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + startAdress + "&destinations=" + Destination + "&mode=transit&key=AIzaSyCrBZT_RgE-4Pks55IG3dOceTq4pyUQGfo").Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;

                    string responseString = responseContent.ReadAsStringAsync().Result;

                    return (responseString);
                }
                else
                {
                    return (null);
                }
            }
        }
        public static void getneededTime()
        {

        }
        public static int parseNeededTime(String theOutput)
        {

        }
        #region --Sonstige Metoden (Protected)--



        #endregion
        //--------------------------------------------------------Events:---------------------------------------------------------------------\\
        #region --Events--



        #endregion
    }
}
