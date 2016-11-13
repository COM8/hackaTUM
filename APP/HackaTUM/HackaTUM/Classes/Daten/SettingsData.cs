using System;
using System.Runtime.Serialization;

namespace Ausgaben_Rechner.Classes.Data
{
    [DataContract]
    class SettingsData
    {
        //--------------------------------------------------------Atribute:-------------------------------------------------------------------\\
        #region --Atribute--
        public const string JSON_FILE_NAME = "settingsData.json";

        [DataMember]
        public bool initialRun;
        [DataMember]
        public bool enabled;
        [DataMember]
        public bool privateMode;
        [DataMember]
        public bool smartMode;
        [DataMember]
        public bool powerSaverMode;
        [DataMember]
        public DateTime bufferTime;
        [DataMember]
        public bool latestRingTimeEnabled;
        [DataMember]
        public DateTime latestRingTime;
        [DataMember]
        public bool gpsEnabled;
        [DataMember]
        public bool steptackingEnabled;

        #endregion
        //--------------------------------------------------------Construktoren:--------------------------------------------------------------\\
        #region --Construktoren--
        /// <summary>
        /// Basic Constructor
        /// </summary>
        /// <history>
        /// 11/11/2016  Created [Fabian Sauter]
        /// </history>
        public SettingsData()
        {
            this.initialRun = true;
            this.enabled = true;
            this.privateMode = false;
            this.smartMode = false;
            this.powerSaverMode = false;
            this.bufferTime = DateTime.Now;
            this.latestRingTime = DateTime.Now;
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
