﻿using System.Collections.Generic;
using Bounce.Framework;
using Candidate.Core.Settings.Model;

namespace Candidate.Core.Setup {
    public class DefaultTargetsObjectBuilder : ITargetsObjectBuilder {
        private readonly ITargetsRetriever _targetsRetriever;
        private readonly IConfigObjectBuilder _configObjectBuilder;
        
        public DefaultTargetsObjectBuilder(ITargetsRetriever targetsRetriever, IConfigObjectBuilder configObjectBuilder) {
            _targetsRetriever = targetsRetriever;
            _configObjectBuilder = configObjectBuilder;
        }

        public IEnumerable<Target> BuildTargetsFromConfig(SiteConfiguration config) {
            var configObject = _configObjectBuilder.CreateConfigObject(config);

            return _targetsRetriever.GetTargetsFromObject(configObject).ToTargets();
        }
    }
}
