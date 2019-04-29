# Microsoft-Bot-Framework
<h3> What is a bot?</h3>
<i>->	Bots are apps that interact with users in a conversational format</i><p>
<i>-> Bots can communicate conversationally with text, cards or speech</i></br>
<i>-> Conversation can be designed to be in a free form or to be more guided where users have choices and actions</i></br>
<i>-> It’s a web service </i></br>
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
<h3>Bot working process</h3>
A bot is an app that users interact with in a conversational way, using text, graphics (such as cards or images), or speech. Every interaction between the user and the bot generates an activity. The Bot Framework Service, which is a component of the Azure Bot Service, sends information between the user's bot-connected app (such as Facebook, Skype, Slack, etc. which we call the channel) and the bot. Each channel may include additional information in the activities they send. Before creating bots, it is important to understand how a bot uses activity objects to communicate with its users. 
<img src="https://user-images.githubusercontent.com/45730967/56442006-1c739f00-6300-11e9-974d-e27065e58b37.png" width="690px" height="421x" /> 
Two activity types illustrated here are: <i>conversation update</i> and <i>message</i>.
The Bot Framework Service may send a conversation update when a party joins the conversation. For example, on starting a conversation with the Bot Framework Emulator, you will see two conversation update activities (one for the user joining the conversation and one for the bot joining). The message activity carries conversation information between the parties. Alternatively, the message activity might carry text to be spoken, suggested actions or cards to be displayed.
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
<h3><i>Creating a bot we can also build intelligent algorithms into bots so that they see, hear, speak, and understand user needs through natural methods of communication using <b>Azure Cognitive Services.</b></i></h3>
<h3><b>Azure Cognitive Services</b></h3>
<i>Azure Cognitive Services</i> are APIs, SDKs, and services available to help developers build intelligent applications without having direct AI or data science skills or knowledge. Azure Cognitive Services enable developers to easily add cognitive features such as emotion and video detection; facial, speech, and vision recognition; and speech and language understanding – into their applications. <i>The goal of Azure Cognitive Services</i> is to help developers create applications that can see, hear, speak, understand, and even begin to reason.<p> 
 <ul><i>The categories of cognitive services are:</i>
<li><b>Vision</b> --> Image-processing algorithms to smartly identify, caption, index, and moderate your pictures and videos.</li>
<li><b>Knowledge</b> --> Map complex information and data in order to solve tasks such as intelligent recommendations and semantic search.</li>
<li><b>Language</b> --> Allow your apps to process natural language with pre-built scripts, evaluate sentiment and learn how to recognize what users want.</li>
<li><b>Speech</b> --> Convert spoken audio into text, use voice for verification, or add speaker recognition to your app.</li>
<li><b>Search</b> --> Add Bing Search APIs to your apps and harness the ability to comb billions of webpages, images, videos, and news with a single API call.</li>
<li><b>Anomaly Detection</b> --> Add anomaly detection capabilities to your apps to identify problems as soon as they occur.</li></ul>
<h3><b>Language Understanding Intelligent Service (LUIS)</b></h3>
<b>Language Understanding (LUIS)</b> is a cloud-based API service that applies custom machine-learning intelligence to a user's conversational, natural language text to predict overall meaning, and pull out relevant, detailed information.
LUIS app is also a place for developer to define a custom language model. It offers a fast and effective way of adding language understanding to applications. A client application for LUIS is any conversational application that communicates with a user in natural language to complete a task. Examples of client applications include <i>social media apps, chat bots, and speech-enabled desktop applications.</i>
<img src="https://user-images.githubusercontent.com/45730967/56668257-493d0300-66c0-11e9-92c1-b5c68e8d24a4.png" width="432px" height="227x" /> <p>
LUIS output is a web service with an HTTP endpoint, that you reference from your client application to add natural language understanding to it. So once the <b>LUIS</b> app is published, a client application sends utterances (text) to the LUIS natural language processing endpoint API and receives the results as JSON responses. LUIS gets HTTP request which is user utterance, then turns it to JSON format and gives it to client application. A common client application for LUIS is a chat bot. So LUIS app provides intelligence so the client application can make smart choices. It is important to understand that LUIS doesn't provide those choices.<p>
A LUIS app contains a <i>domain-specific natural language model</i>. You can start the LUIS app with a prebuilt domain model, build your own model, or blend pieces of a prebuilt domain with your own custom information.<p>
LUIS, as a REST API, can be used with any product, service, or framework that makes an HTTP request. The following list contains the top Microsoft products and services used with LUIS.<p>
<ul><i>The top client application for LUIS is:</i>
  <li><b>Web app bot</b> quickly creates a LUIS-enabled chat bot to talk with a user via text input</li></ul>
 <p><ul><i>Tools to quickly and easily use LUIS with a bot:</i>
  <li><b>LUIS CLI</b> The NPM package provides authoring and prediction with as either a stand-alone command line tool or as import.</li>
  <li><b>LUISGen</b> LUISGen is a tool for generating strongly typed C# and typescript source code from an exported LUIS model.</li>
  <li><b>Dispatch</b> allows several LUIS and QnA Maker apps to be used from a parent app using dispatcher model.</li>
  <li><b>LUDown</b> LUDown is a command line tool that helps manage language models for your bot.</li></ul>
<ul><i>Other Cognitive Services used with LUIS:</i>
  <li>QnA Maker allows several types of text to combine into a question and answer knowledge base.</li>
  <li>Bing Spell Check API provides text correction before prediction.</li>
  <li>Speech service converts spoken language requests into text.</li>
  <li>Conversation learner allows you to build bot conversations quicker with LUIS.</li>
  <li>Project personality chat to handle bot small talk.</li></ul>
