﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class MarkEventArgs : EventArgs
    {
        public List<int> _Marks { get; set; }
        public String StudentName { get; set; }
    }
}
