﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroccoliSchemer.Entities
{
    public class BrcTextBox : BaseComponent, IListable
    {
        public BrcTextBox(string name, int height, int width) : base(name, height, width) 
        {

        }
        public string Placeholder { get; set; }
    }
}
