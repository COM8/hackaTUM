using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ausgaben_Rechner.Classes.Data
{
    [DataContract]
    class UserData
    {
        //--------------------------------------------------------Atribute:-------------------------------------------------------------------\\
        #region --Atribute--
        public const string JSON_FILE_NAME = "userData.json";

        [DataMember]
        public string adressWork;
        [DataMember]
        public string adressHome;
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
            this.adressHome = null;
            this.adressWork = null;
            this.iCall = null;
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
