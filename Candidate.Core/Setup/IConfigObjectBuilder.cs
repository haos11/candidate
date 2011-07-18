﻿using Candidate.Core.Settings.Model;

namespace Candidate.Core.Setup {
    public interface IConfigObjectBuilder {
        ConfigObject CreateConfigObject(JobConfigurationModel config);
    }
}