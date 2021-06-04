using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MobileBEWorkshop.Localization
{
    public static class MobileBEWorkshopLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MobileBEWorkshopConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MobileBEWorkshopLocalizationConfigurer).GetAssembly(),
                        "MobileBEWorkshop.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
