using Ausgaben_Rechner.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Windows.Data.Xml.Dom;
using System.Diagnostics;

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
        public static TravelDataEntity getTravelData(DateTime destinationTime)
        {
            TravelDataEntity data = null;
            try
            {
                string xml = getConnectionInfo(destinationTime);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xml);
                if (isOk(xmlDoc.SelectSingleNode("/DistanceMatrixResponse/status")))
                {
                    string startA = xmlDoc.SelectSingleNode("/DistanceMatrixResponse/origin_address").InnerText;
                    string targetA = xmlDoc.SelectSingleNode("/DistanceMatrixResponse/destination_address").InnerText;
                    int duration = int.Parse(xmlDoc.SelectSingleNode("/DistanceMatrixResponse/row/element/duration/value").InnerText) / 60;
                    data = new TravelDataEntity(startA, targetA, destinationTime, duration, Utillities.TransportationDevices.PublicTransport);
                    return data;
                }
            }
            catch
            {
                
            }
            data = new TravelDataEntity("start", "target", DateTime.Now, -1, Utillities.TransportationDevices.PublicTransport);
            return data;
        }

        #endregion

        #region --Sonstige Metoden (Private)--
        private static bool isOk(IXmlNode node)
        {
            if(node != null)
            {
                if (node.NodeName.Equals("status") && node.InnerText.ToString().Equals("OK"))
                {
                    return true;
                }
            }
            return false;
        }

        private static String getConnectionInfo(DateTime DestinationTime)
        {
            return (getConnectionInfo(Convert.ToString(DataStorage.INSTANCE.userData.adressHome.Position.Latitude.ToString().Replace(',', '.') + "," + DataStorage.INSTANCE.userData.adressHome.Position.Longitude.ToString().Replace(',', '.')), Convert.ToString(DataStorage.INSTANCE.userData.adressWork.Position.Latitude.ToString().Replace(',', '.') + "," + DataStorage.INSTANCE.userData.adressWork.Position.Longitude.ToString().Replace(',', '.')), DestinationTime));
        }

        private static String getConnectionInfo(String startAdress, String destination, DateTime DestinationTime)
        {

            using (var client = new HttpClient())
            {
                Int32 arrivalTime = (Int32)(DestinationTime.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                string s = "https://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + startAdress + "&destinations=" + destination + "&arrivaltime="+arrivalTime+"&mode=transit&key=AIzaSyCrBZT_RgE-4Pks55IG3dOceTq4pyUQGfo";
                var response = client.GetAsync(s).Result;

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

        #endregion

        #region --Sonstige Metoden (Protected)--



        #endregion
        //--------------------------------------------------------Events:---------------------------------------------------------------------\\
        #region --Events--



        #endregion
    }
}
