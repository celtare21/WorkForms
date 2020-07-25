using System;

namespace WindowsFormsApp1
{
    public class WorkStuff
    {
        public string id;
        public string day;
        public string start_hour;
        public string stop_hour;
        public string principal_hours;
        public string secundar_hours;
        public string pregatire_hours;
        public string total_hours;
        public string observatii;

        public WorkStuff(string id, string day, string start_hour, string stop_hour, string principal_hours, string secundar_hours, string pregatire_hours, string total_hours, string observatii)
        {
            this.id = id;
            this.day = day;
            this.start_hour = start_hour;
            this.stop_hour = stop_hour;
            this.principal_hours = principal_hours;
            this.secundar_hours = secundar_hours;
            this.pregatire_hours = pregatire_hours;
            this.total_hours = total_hours;
            this.observatii = observatii;
        }
    }
}
