using Phani.StrategyPattern.Enums;

namespace Phani.StrategyPattern.Providers
{
    public class CSharpProvider: IDeveloperProvider
    {
        public LanguageType LanguageType => LanguageType.CSharp;

        public string GetLanguage()
        {
            return "CSharp Language";
        }
    }
}
