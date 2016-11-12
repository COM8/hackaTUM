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

        public static String getConnectionInfo(DateTime DestinationTime)
        {
           return(getConnectionInfo(DataStorage.INSTANCE.userData.adressHome, DataStorage.INSTANCE.userData.adressWork, DestinationTime));
        }
        public static String getConnectionInfo(String startAdress, String Destination, DateTime DestinationTime)
        {
            //DataStorage.INSTANCE.userData.adressHome
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + startAdress + "&destinations=" + Destination + "&mode=transit&arrival_time="+Convert.ToString((DateTime.UtcNow - DestinationTime).TotalMilliseconds)+"&key=AIzaSyCrBZT_RgE-4Pks55IG3dOceTq4pyUQGfo").Result;

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
        public static void getneededTime(DateTime DestinationTime)
        {
            getDuration(getConnectionInfo(DestinationTime));
        }
        private static int getDuration(string xml)
        {
            Boolean theLock = true;
            string status = "", duration = "";
            string[] lines = xml.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                if (line.Contains("status"))
                {
                    status = extractValue(line);

                }
                else if (line.Contains("value") && theLock)
                {
                    duration = extractValue(line);
                    theLock = false;
                }
            }
            if (status == "OK")
            {
                return int.Parse(duration);
            }
            return -1;
        }
        private static String extractValue(string line)
        {
            String Value = "";
            int phase = 0;
            char[] charArray = line.ToCharArray();
            foreach (char didgit in charArray)
            {
                if (phase == 0 && didgit == '>')
                {
                    phase++;
                }
                else if (phase == 1 && didgit != '<')
                {
                    Value += didgit;
                }
                else if (didgit == '<' && phase == 1)
                {
                    phase++;
                }
            }
            return Value;
        }
            #region --Sonstige Metoden (Protected)--



            #endregion
            //--------------------------------------------------------Events:---------------------------------------------------------------------\\
            #region --Events--



            #endregion
        }
}
