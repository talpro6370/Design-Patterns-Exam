﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_emp
{
    public interface IProto<T>
    {
        T Clone();
    }
}
