using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_Статистика
{
    class Player
    {
        public int dd
        {
            get { return 0; }
            set
            {
                if (dd <=31 && dd > 0)
                    this.dd = dd;
            }
        }
        public int mm
        {
            get { return 0; }
            set
            {
                if (mm > 0 && mm <= 12)
                    this.mm = mm;
            }
        }
        public int year
        {
            get { return 0; }
            set
            {
                if (year < 1998 && year > 1950)
                    this.year = year;
            }
        }
    }
}
