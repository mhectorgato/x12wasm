﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x12interpretor.Models
{
    public class x12lineResult
    {
        public string LineCode { get; set; }
        public string LineDescription { get; set; }
        public int OriginalLineNumber { get; set; }
        public string OriginalValue { get; set; }
        public List<x12fieldResult> Fields { get; set; }        
    }
}