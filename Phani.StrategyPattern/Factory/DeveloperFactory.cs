using System;
using System.Collections.Generic;
using System.Linq;
using Phani.StrategyPattern.Enums;
using Phani.StrategyPattern.Providers;

namespace Phani.StrategyFactoryPattern.Factory
{
    public class DeveloperFactory: IDeveloperFactory
    {
        private readonly IEnumerable<IDeveloperProvider> _developerProviders;

        public DeveloperFactory(IEnumerable<IDeveloperProvider> developerProviders)
        {
            _developerProviders = developerProviders;
        }

        public string Developer(LanguageType languageType)
        {
            var provider = _developerProviders.FirstOrDefault(x => x.LanguageType == languageType);
            if(provider == null)
            {
                throw new NotImplementedException();
            }
            return provider.GetLanguage();
        }
    }
}
