﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Candidate.Areas.Dashboard.Models
{
    public class JobModel
    {
        public string Name { get; set; }
        public DateTime? LastRunTime { get; set; }
        public int Status { get; set; }
    }
}