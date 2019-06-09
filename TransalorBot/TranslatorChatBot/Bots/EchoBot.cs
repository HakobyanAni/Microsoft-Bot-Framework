using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Newtonsoft.Json;
using TranslatorBot.GoogleAssistant;

namespace TranslatorChatBot.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            string sourceLanguage = "en";
            string botResponse = GoogleTranslator.TranslateText(turnContext.Activity.Text, sourceLanguage);
            await turnContext.SendActivityAsync(MessageFactory.Text(botResponse), cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    var welcomeCard = CreateAdaptiveCardAttachment();
                    var response = CreateResponse(turnContext.Activity, welcomeCard);
                    await turnContext.SendActivityAsync(response, cancellationToken);
                }
            }
        }

        // Create an attachment message response.
        private Activity CreateResponse(IActivity activity, Attachment attachment)
        {
            var response = ((Activity)activity).CreateReply();
            response.Attachments = new List<Attachment>() { attachment };
            return response;
        }

        // Load attachment from file.
        private Attachment CreateAdaptiveCardAttachment()
        {
            string[] paths = { ".", "Cards", "welcomeCard.json" };
            string fullPath = Path.Combine(paths);
            var adaptiveCard = File.ReadAllText(fullPath);
            return new Attachment()
            {
                ContentType = "application/vnd.microsoft.card.adaptive",
                Content = JsonConvert.DeserializeObject(adaptiveCard),
            };
        }
    }
}
