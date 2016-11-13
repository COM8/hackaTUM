using Ausgaben_Rechner.Classes;
using HackaTUM.Classes.Daten;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackaTUM.Classes
{
    class CalendarHandler
    {
        //--------------------------------------------------------Atribute:-------------------------------------------------------------------\\
        #region --Atribute--
        public static List<StringDataEntity> calendarEntries = new List<StringDataEntity>();

        #endregion
        //--------------------------------------------------------Construktoren:--------------------------------------------------------------\\
        #region --Construktoren--



        #endregion
        //--------------------------------------------------------Set-, Get- Metoden:---------------------------------------------------------\\
        #region --Set-, Get- Metode--



        #endregion
        //--------------------------------------------------------Sonstige Metoden:-----------------------------------------------------------\\
        #region --Sonstige Metoden (Public)--

        public static String getICalUrl()
        {
            return (Convert.ToString(DataStorage.INSTANCE.userData.iCall));
        }

        //private static int getDuration(string xml)
        //{
        //    Boolean theLock = true;
        //    string status = "", duration = "";
        //    string[] lines = xml.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
        //    foreach (string line in lines)
        //    {
        //        if (line.Contains("status"))
        //        {
        //            status = extractValue(line);

        //        }
        //        else if (line.Contains("value") && theLock)
        //        {
        //            duration = extractValue(line);
        //            theLock = false;
        //        }
        //    }
        //    if (status == "OK")
        //    {
        //        return int.Parse(duration);
        //    }
        //    return -1;
        //}


        public static List<StringDataEntity> splitCalendarString(string s)
        {
            string[] lines = s.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            char delimeter = '!';

            for (int line = 0; line < lines.Length; line++)
            {
                string source = lines[line];
                string entry = string.Empty;
                string dateString = string.Empty;
                
                int count = 0;
                for (int i = 0; i < source.Length; i++)
                {
                    if (source[i] != delimeter && count == 1)
                    {
                        entry += source[i];
                    }
                    else if (source[i] != delimeter && count > 2)
                    {
                        dateString += source[i];
                    }
                    else count++;               
                }
                DateTime date = Convert.ToDateTime(dateString);
                calendarEntries.Add(new StringDataEntity(entry, DateTime.Now));     //DateTime.Now durch in Date konvertierter date-String ersetzen
                Debug.WriteLine(entry);
                Debug.WriteLine(date);
            }

            return calendarEntries;
        }

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
