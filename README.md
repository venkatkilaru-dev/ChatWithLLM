ChatWithLLM
A simple Blazor Server application that lets you chat with an LLM (Groq API).
Messages appear in the UI during the session, and chat history is saved locally on the user’s machine.

check the published website : [https://chatwithllm-1r97.onrender.com/](url)

🚀 Features
Chat with an LLM using Groq’s API

Clean chat UI with bubbles and timestamps

Auto‑scroll and input focus

Session‑only chat display (refresh clears UI)

Local chat history saved to wwwroot/chatHistory.json

No secrets stored in Git history

📦 Requirements
Before running the project, install:

.NET 9 SDK

Git

A Groq API Key (you will add this locally — not in GitHub)

🛠️ How to Download and Run the Project Locally
1. Clone the repository
bash
git clone https://github.com/venkatkilaru-dev/ChatWithLLM.git
cd ChatWithLLM
2. Create your local appsettings.json
This file is ignored by Git for security.

Create a file named:

appsettings.json
Paste this inside:

json
{
  "GroqApiKey": "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"
}
Replace YOUR_API_KEY_HERE with this sample key.

3. Restore dependencies
bash
dotnet restore
4. Run the application
bash
dotnet run
The app will start at:

https://localhost:5001
or

http://localhost:5000
💬 How Chat History Works
Messages appear in the UI during the session

When you refresh the page, the UI clears

A full history is still saved locally at:

wwwroot/chatHistory.json
This file is ignored by Git so it never leaks.

🔐 Security Notes
appsettings.json is not committed to Git

bin/, obj/, and history files are ignored

No API keys or secrets are stored in the repository

📁 Project Structure
ChatWithLLM/
│
├── Pages/
├── Components/
├── wwwroot/
│   └── chatHistory.json (local only, ignored by Git)
│
├── Program.cs
├── ChatWithLLM.csproj
└── appsettings.json (local only)
