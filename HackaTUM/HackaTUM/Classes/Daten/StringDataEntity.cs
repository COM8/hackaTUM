using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackaTUM.Classes.Daten
{
    class StringDataEntity
    {
        public string entry = "";
        public DateTime date = DateTime.Now;

        public StringDataEntity(string entry, DateTime date)
        {
            this.entry = entry;
            this.date = date;
        }
    }
}
