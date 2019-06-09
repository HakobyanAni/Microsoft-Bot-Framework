using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Translation.V2;
using Google.Api.Gax.Rest;

namespace TranslatorBot.GoogleAssistant
{
    public static class GoogleTranslator
    {
        public static string TranslateText(string textToTranslate, string sourceLanguage)
        {
            //  The Application Default Credentials are available if running in Google Compute Engine.
            // Otherwise, the environment variable GOOGLE_APPLICATION_CREDENTIALS must be defined pointing to a file defining the credentials.
            // See https://developers.google.com/accounts/docs/application-default-credentials for more information.
            
            var credential = GoogleCredential.FromJson(System.IO.File.ReadAllText(@"D:\Annie\Programming\GoogleTranslator\GoogleTranslatorAPI\Google\GT_credentials.json"));
            TranslationClient client = TranslationClient.Create(credential);

            string targetLanguage = client.DetectLanguage(textToTranslate).ToString();
            
            TranslationResult response = client.TranslateText(
                text: $"{textToTranslate}",
                targetLanguage: $"{targetLanguage}",  
                sourceLanguage: $"{sourceLanguage}");  

            return response.TranslatedText;
        }
    }
}
