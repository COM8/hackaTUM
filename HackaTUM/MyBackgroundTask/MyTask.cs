using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.UI.Notifications;
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.QueryStringDotNET;

namespace MyBackgroundTask
{
    public sealed class MyTask : IBackgroundTask
    {
        //--------------------------------------------------------Atribute:-------------------------------------------------------------------\\
        #region --Atribute--
        BackgroundTaskDeferral _deferral;

        #endregion
        //--------------------------------------------------------Construktoren:--------------------------------------------------------------\\
        #region --Construktoren--
        /// <summary>
        /// Basic empty Constructor
        /// </summary>
        /// <history>
        /// 12/11/2016  Created [Fabian Sauter]
        /// </history>
        public MyTask()
        {

        }

        #endregion
        //--------------------------------------------------------Set-, Get- Metoden:---------------------------------------------------------\\
        #region --Set-, Get- Metode--



        #endregion
        //--------------------------------------------------------Sonstige Metoden:-----------------------------------------------------------\\
        #region --Sonstige Metoden (Public)--
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            _deferral = taskInstance.GetDeferral();
            //Code RUN
            _deferral.Complete();
        }

        #endregion

        #region --Sonstige Metoden (Private)--
        private void createPush(String s)
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
