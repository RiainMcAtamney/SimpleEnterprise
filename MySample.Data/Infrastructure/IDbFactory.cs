﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample.Data.Infrastructure
{
    public interface IDbFactory
    {
        MySampleContext Init();
    }
}
