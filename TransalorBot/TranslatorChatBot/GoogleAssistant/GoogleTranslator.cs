using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Translation.V2;

namespace TranslatorBot.GoogleAssistant
{
    public static class GoogleTranslator
    {
        public static string TranslateText(string textToTranslate, string targetLang, string sourceLang)
        {
            var credential = GoogleCredential.FromJson(System.IO.File.ReadAllText(@"D:\Annie\Programming\GoogleTranslator\GoogleTranslatorAPI\Google\GT_credentials.json"));
            TranslationClient client = TranslationClient.Create(credential);
            var response = client.TranslateText(
                text: $"{textToTranslate}",
                targetLanguage: "arm",  // Armenian
                sourceLanguage: "en");  // English
            return response.TranslatedText;
        }
    }
}
