﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEmployees
{
    public interface IEmployee
    {
        void Accept(IVisitor visitor);
    }
}