using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Translation.V2;

namespace TranslatorAssistantBot.GoogleAssistant
{
    public class GoogleTranslator
    {
        public string TranslateText(string wordToTranslate, string targetLang, string sourceLang)
        {
            var credential = GoogleCredential.FromJson(System.IO.File.ReadAllText(@"D:\Annie\Programming\GoogleTranslator\GoogleTranslatorAPI\Google\GT_credentials.json"));
            TranslationClient client = TranslationClient.Create(credential);
            var response = client.TranslateText(
                text: $"{wordToTranslate}",
                targetLanguage: "arm",  // Armenian
                sourceLanguage: "en");  // English
            return response.TranslatedText;
        }
    }
}
