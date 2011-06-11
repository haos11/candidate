﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Candidate.Areas.Dashboard.Models
{
    public class JobsSettingsModel
    {
        public JobsSettingsModel()
        {
            Jobs = new List<JobModel>();
        }

        public IList<JobModel> Jobs { get; set; }
    }
}