using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hygge_imaotai.Domain {
    public class Config
    {

        public bool AutoStart { get; set; } = true;

        public bool AutoBuy { get; set; } = true;

        public string BuyStartHour { get; set; } = "9";

        public string BuyStartMinute { get; set; } = "5";

        public string BuyStartSecond { get; set; } = "0";
    }
}
