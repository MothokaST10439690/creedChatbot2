 # creedChatbot2

 creedChatbot2

creedChatbot2 is a console-based application designed to educate users about cybersecurity best practices. Through an engaging and interactive experience, users can learn about various online safety topics.

Features

Interactive Console Interface – Engage with the chatbot in a user-friendly terminal environment.

Cybersecurity Information – Get answers to common cybersecurity questions.

Typing Simulation – Experience a realistic interaction with simulated typing effects.

Audio Greeting – Enjoy a welcoming audio greeting on startup.

Prerequisites

Before running the chatbot, ensure you have the following:

.NET Framework: Version 4.5 or higher

IDE: Visual Studio or any C#-compatible IDE

Audio File: welcome.wav must be located in the project directory

Installation & Setup

1. Open the Project

Load the project in Visual Studio or your preferred C# IDE.

2. Add the Sound File

Ensure welcome.wav is in the project directory. You can create or download an audio file as needed.

3. Build the Project

Compile the project to confirm there are no errors.

Running the Application

1. Start the Application

Run the application from your IDE or execute the compiled .exe file from the bin/Debug or bin/Release folder.

2. Interact with the Chatbot

Greet the Bot – The chatbot will greet you and ask for your name.

Ask Questions – Choose from a menu of cybersecurity-related questions or type your own.

Receive Answers – Get informative responses based on your input.

Return to Menu – Press any key to return to the main menu after receiving a response.

Exit – Type exit at any prompt to close the application.

Available Topics

The chatbot can answer questions on topics such as:

General inquiries (e.g., "How are you?", "What is your purpose?", "What can I ask you?")

Password Safety

Phishing

Safe Browsing

Two-Factor Authentication

Malware Protection

Social Engineering

Data Privacy Protection

General Cybersecurity Tips

Code Overview

Program Class – Entry point of the application (Main method).

DisplayLogo Method – Displays an ASCII art logo.

PlayGreeting Method – Plays the audio greeting.

GreetUser Method – Prompts the user for their name and welcomes them.

UserInput Method – Handles user input and provides responses.

WaitForUserInput Method – Waits for user interaction before returning to the main menu.

TypingDelay Method – Simulates typing by printing characters one at a time with a delay.

Contributing

If you’d like to contribute to creed_Chatbot, feel free to submit pull requests or report issues.

License

This project is licensed under MIT License.
