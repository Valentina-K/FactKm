using System;
using System.Collections.Generic;
using System.Text;

namespace Пробег_по_депо
{
    public class Param
    {
        public int depo { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public string typecar { get; set; }
        public int countdaysmonth { get; set; }
        public string pe { get; set; }
        public DateTime dateB { get; set; }
        public int repair { get; set; }//то-2:0, сред:1, кап:2
        public int idTypeCar { get; set; }
        public string nameTyre { get; set; }
        public string typeTyre { get; set; }
        public int idTyre { get; set; }
    }
}
