﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public interface IObserver
    {
        void Update(string Title, DateTime dateTime);
    }
}
