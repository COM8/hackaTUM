using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HackaTUM.Classes.Utillities;

namespace HackaTUM.Classes
{
    class TravelDataEntity
    {
        //--------------------------------------------------------Atribute:-------------------------------------------------------------------\\
        #region --Atribute--
        public string targetAdress;
        public string startAdress;
        public DateTime startTime;
        public int timeInMinutes;
        public TransportationDevices device;

        #endregion
        //--------------------------------------------------------Construktoren:--------------------------------------------------------------\\
        #region --Construktoren--
        /// <summary>
        /// Basic empty Constructor
        /// </summary>
        /// <history>
        /// 13/11/2016  Created [Fabian Sauter]
        /// </history>
        public TravelDataEntity(string startAdress, string targetAdress, DateTime startTime, int timeInMinutes, TransportationDevices device)
        {
            this.startAdress = startAdress;
            this.targetAdress = targetAdress;
            this.startTime = startTime;
            this.timeInMinutes = timeInMinutes;
            this.device = device;
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
