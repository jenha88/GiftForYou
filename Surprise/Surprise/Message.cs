﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surprise
{
    public class Message
    {
        public string subject { get; set; }
        public List<forYou> messageSelect { get; set; }

        public override string ToString()
        {
            return subject;
        }
    }
    public class forYou
    {
        public string message { get; set; }
        public string img { get; set; }
        public string desc { get; set; }

        public override string ToString()
        {
            return message;
        }
    }
}

