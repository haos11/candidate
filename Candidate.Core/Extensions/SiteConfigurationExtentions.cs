﻿using System.Linq;
using Candidate.Core.Configurations.Helpers;
using Candidate.Core.Configurations.Parts;

namespace Candidate.Core.Extensions
{
    public static class SiteConfigurationExtentions
    {
        public static string GetSiteUrl(this Iis config)
        {
            if (config == null)
                return null;

            if (!string.IsNullOrEmpty(config.SiteName))
            {
                if (config.Port == 0 || config.Port == 80)
                {
                    return string.Format("http://{0}", config.SiteName);
                }
                
                return string.Format("http://{0}:{1}", config.SiteName, config.Port);
            }

            if (!string.IsNullOrEmpty(config.Bindings))
            {
                var bindingParser = new BindingParser();
                var binding = bindingParser.Parse(config.Bindings).FirstOrDefault();

                return string.Format("{0}://{1}:{2}", binding.Protocol, binding.SiteName, binding.Port);
            }

            return null;
        }
    }
}