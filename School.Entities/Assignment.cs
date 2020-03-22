﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
    public class Assignment
    {
            public int AssignmentId { get; set; }
            public string Title { get; set; }

        public virtual Subject Subject { get; set; }

    }
}
