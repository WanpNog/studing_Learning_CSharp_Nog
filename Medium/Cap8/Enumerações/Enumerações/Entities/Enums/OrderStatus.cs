﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes.Entities.Enums
{
     enum OrderStatus : int
    {
        PandingPaymet = 0,
        Processing = 1,
        Shipped =2,
        Delivered =3,
    }
}
