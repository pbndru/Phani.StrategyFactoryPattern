using Phani.StrategyPattern.Enums;

namespace Phani.StrategyPattern.Providers
{
    public interface IDeveloperProvider
    {
        public string GetLanguage();
        public LanguageType LanguageType { get; }
    }
}
