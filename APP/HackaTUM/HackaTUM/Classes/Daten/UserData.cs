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
            this.iCall = "http://smartalarm.cloudapp.net/main.php?key=24E1C8AC9B2BAE0E&pToken=921724D0891C3CFB31CAED7DA7AEF76926653A3C6BAE37E0176C4FE32CCB4E48";
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
