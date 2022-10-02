﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Ebenal
{
    enum DeliveryType
    {
        [Description("3 Day Shipping")]
        ThreeDay = 60,
        [Description("5 Day Shipping")]
        FiveDay = 40,
        [Description("7 Day Shipping")]
        SevenDay = 30,
        [Description("Standard Shipping")]
        FourteenDay = 0
    }

    internal class DeskQuote
    {
    }
}
