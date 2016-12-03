using System.Collections.Generic;
using System.Runtime.Serialization;
using Windows.Devices.Geolocation;

namespace Ausgaben_Rechner.Classes.Data
{
    [DataContract]
    class UserData
    {
        //--------------------------------------------------------Atribute:-------------------------------------------------------------------\\
        #region --Atribute--
        public const string JSON_FILE_NAME = "userData.json";

        [DataMember]
        public Geopoint adressWork;
        [DataMember]
        public Geopoint adressHome;
        [DataMember]
        public string iCall;

        #endregion
        //--------------------------------------------------------Construktoren:--------------------------------------------------------------\\
        #region --Construktoren--
        /// <summary>
        /// Basic Constructor
        /// </summary>
        /// <history>
        /// 11/11/2016  Created [Fabian Sauter]
        /// </history>
        public UserData()
        {
            this.adressHome = new Geopoint(new BasicGeoposition() { Latitude = 48.17482829999999, Longitude = 11.63961310000002 });
            this.adressWork = new Geopoint(new BasicGeoposition() { Latitude = 48.26467100000001, Longitude = 11.671390999999971 });
            this.iCall = "http://com8.no-ip.org/HackaTUM/main.php?key=14E9824B753942E6&pToken=230F341F9AF5DE83F9A4A71C2E4FD28DD47F90040E562F15620E88BE4C3BB107";
        }

        #endregion
        //--------------------------------------------------------Set-, Get- Metoden:---------------------------------------------------------\\
        #region --Set-, Get- Metode--
        
        

        #endregion
        //--------------------------------------------------------Sonstige Metoden:-----------------------------------------------------------\\
        #region --Sonstige Metoden (Public)--
        


        #endregion

        #region --Sonstige Metoden (Private)--
        


        #endregion

        #region --Sonstige Metoden (Protected)--



        #endregion

        //--------------------------------------------------------Events:---------------------------------------------------------------------\\
        #region --Events--



        #endregion
    }
}
