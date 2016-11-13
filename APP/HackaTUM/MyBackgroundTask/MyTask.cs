using System;
using Windows.ApplicationModel.Background;

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
            /*MainPage rootPage = null;
            rootPage.NotifyUser("A toast was clicked on with activation arguments: " + arguments, NotifyType.StatusMessage);*/
        }

        #endregion

        #region --Sonstige Metoden (Protected)--



        #endregion
        //--------------------------------------------------------Events:---------------------------------------------------------------------\\
        #region --Events--



        #endregion
    }
}
