﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonModtag
{
    class car
    {
        public string model { get; set; }


        public override string ToString()
        {
            return $"model: {model}";
        }
    }
}
