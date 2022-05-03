using Phani.StrategyPattern.Enums;

namespace Phani.StrategyFactoryPattern.Factory
{
    public interface IDeveloperFactory
    {
        public string Developer(LanguageType languageType);
    }
}
