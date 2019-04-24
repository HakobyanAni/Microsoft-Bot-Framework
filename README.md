# Microsoft-Bot-Framework
<h3> What is a bot?</h3>
<b>Bots</b> provide an experience that feels less like using a computer and more like dealing with a person - or at least an intelligent robot. They can be used to shift simple, repetitive tasks, such as taking a dinner reservation or gathering profile information, on to automated systems that may no longer require direct human intervention. <b>Bots</b> are a lot like modern web applications, living on the internet and use APIs to send and receive messages. Bots can do the same things other types of software can do - read and write files, use databases and APIs, and do the regular computational tasks. What makes bots unique is their use of mechanisms generally reserved for human-to-human communication.</br><p>
<b>Azure Bot Service</b> provides tools to build, test, deploy, and manage intelligent bots all in one place. Through the use of modular and extensible framework provided by the SDK, tools, templates, and AI services developers can create <i>bots that use speech, understand natural language, handle questions and answers, and more.</i> <i>Creating a bot</i> with Azure Bot Service and creating a bot locally are independent, parallel ways to create a bot.</p>
<ul><b>Azure Bot Service offers:</b>
  <li>Bot Framework SDK for developing bots</li>
  <li>Bot Framework Tools to cover end-to-end bot development workflow</li>
  <li>Bot Framework Service (BFS) to send and receive messages and events between bots and channels</li>
  <li>Bot deployment and channel configuration in Azure</li></ul>
<ul><i>Additionally, bots may use other Azure services, such as:</i>
  <li>Azure Cognitive Services to build intelligent applications</li>
<li>Azure Storage for cloud storage solution</li></ul>
<h3>Plan</h3>
Before writing code, review the bot design guidelines for best practices and identify the needs for your bot. You can create a simple bot or include more sophisticated capabilities such as speech, natural language understanding, and question answering.
<h3>Build</h3>

Your bot is a web service that implements a conversational interface and communicates with the Bot Framework Service to send and receive messages and events. Bot Framework Service is one of the components of the Azure Bot Service. You can create bots in any number of environments and languages. You can start your bot development in the Azure portal, or use (C#, JavaScript) templates for local development.
<h3>Test</h3>
Bots are complex apps, with a lot of different parts working together. Like any other complex app, this can lead to some interesting bugs or cause your bot to behave differently than expected. Before publishing, test your bot. We provide 2 ways to test bots before they are released for use: test your bot locally with the emulator. The Bot Framework Emulator, or test your bot on the web in Azure portal. 
<h3>Publish</h3>
When you are ready for your bot to be available on the web, publish your bot to Azure or to your own web service or data center. Having an address on the public internet is the first step to your bot coming to life on your site, or inside chat channels.
<h3>Connect</h3>
Connect your bot to channels such as Facebook, Messenger, Kik, Skype, Slack, Microsoft Teams, Telegram, text/SMS, Twilio, Cortana, and Skype. Bot Framework does most of the work necessary to send and receive messages from all of these different platforms - your bot application receives a unified, normalized stream of messages regardless of the number and type of channels it is connected to. 
<h3>Evaluate</h3>
Use the data collected in Azure portal to identify opportunities to improve the capabilities and performance of your bot. You can get service-level and instrumentation data like traffic, latency, and integrations. Analytics also provides conversation-level reporting on user, message, and channel data.
<h3>Bot working process</h3>
A bot is an app that users interact with in a conversational way, using text, graphics (such as cards or images), or speech. Every interaction between the user and the bot generates an activity. The Bot Framework Service, which is a component of the Azure Bot Service, sends information between the user's bot-connected app (such as Facebook, Skype, Slack, etc. which we call the channel) and the bot. Each channel may include additional information in the activities they send. Before creating bots, it is important to understand how a bot uses activity objects to communicate with its users. 
<img src="https://user-images.githubusercontent.com/45730967/56442006-1c739f00-6300-11e9-974d-e27065e58b37.png" width="690px" height="421x" /> 
Two activity types illustrated here are: <i>conversation update</i> and <i>message</i>.
The Bot Framework Service may send a conversation update when a party joins the conversation. For example, on starting a conversation with the Bot Framework Emulator, you will see two conversation update activities (one for the user joining the conversation and one for the bot joining). The message activity carries conversation information between the parties. Alternatively, the message activity might carry text to be spoken, suggested actions or cards to be displayed.

<h3><i>Creating a bot we can also build intelligent algorithms into bots so that they see, hear, speak, and understand user needs through natural methods of communication using <b>Azure Cognitive Services.</b></i></h3>

<h3><b>Azure Cognitive Services</b></h3>



<h3><b>Language Understanding Intelligent Service (LUIS)</b></h3>

<b>Language Understanding (LUIS)</b> is a cloud-based API service that applies custom machine-learning intelligence to a user's conversational, natural language text to predict overall meaning, and pull out relevant, detailed information.

LUIS app is also a place for developer to define a custom language model. 
A client application for LUIS is any conversational application that communicates with a user in natural language to complete a task. Examples of client applications include social media apps, chat bots, and speech-enabled desktop applications.
LUIS output is a web service with an HTTP endpoint, that you reference from your client application to add natural language understanding to it.

LUIS gets HTTP request which is user utterance, then turns it to JSON format and gives it to client app. So LUIS app provides intelligence so the Client app can make smart choices. It is important to understand that LUIS doesn't provide those choices.
