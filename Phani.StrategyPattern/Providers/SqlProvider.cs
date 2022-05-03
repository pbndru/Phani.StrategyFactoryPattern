using Phani.StrategyPattern.Enums;

namespace Phani.StrategyPattern.Providers
{
    public class SqlProvider : IDeveloperProvider
    {
        public LanguageType LanguageType => LanguageType.Sql;

        public string GetLanguage()
        {
            return "SQL Language";
        }
    }
}
