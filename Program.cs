using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace creedChatbot2
{
    class Program
    {

        static void Main(string[] args)
        {
            DisplayLogo();
            GreetingMessage();
            string userName = GreetUser();
            UserInput(userName);


        }

        static void DisplayLogo()
        {
            string logo = @"
   ______                   __                                           
  / ____/_______  ___  ____/ /                                            
 / /   / ___/ _ \/ _ \/ __  /                                             
/ /___/ /  /  __/  __/ /_/ /                                              
\____/_/_  \___/\___/\__,_/   _       __                _                
  / ____/_  __/ /_  ___  ____| |     / /___ ___________(_)___  __________
 / /   / / / / __ \/ _ \/ ___/ | /| / / __ `/ ___/ ___/ / __ \/ ___/ ___/
/ /___/ /_/ / /_/ /  __/ /   | |/ |/ / /_/ / /  / /  / / /_/ / /  (__  ) 
\____/\__, /_.___/\___/_/    |__/|__/\__,_/_/  /_/  /_/\____/_/  /____/  
    _/____/     __                                                       
   / __ )____  / /_                                                      
  / __  / __ \/ __/                                                      
 / /_/ / /_/ / /_                                                        
/_____\/____/\__/";
            Console.WriteLine(logo);
        }

        static void GreetingMessage()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("welcome.wav");
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing the greeting: " + ex.Message);
            }
        }

        static string GreetUser()
        {
            Console.WriteLine("What's your name? ");
            var userName = Console.ReadLine();
            TypingDelay($"\nHello, {userName}! Welcome to the Creed CyberWorrias Bot, where we keep you protected and informed about the online world.");
            return userName;
        }

        static void UserInput(string userName)
        {
            while (true)
            {
                Console.WriteLine($"\nWhat can I help you with, {userName}? NOTE If you need guidance, enter 'Help' to get a full view of the types of questions to ask or exit to leave.");
                string input = Console.ReadLine().Trim().ToLower();
                if (input == "exit") break;

                switch (input)
                {
                    case "how are you?":
                        TypingDelay("I'm just a bot, but I'm here to help you stay safe online!");
                        break;
                    case "what is your purpose?":
                        TypingDelay("My purpose is to educate you about cybersecurity best practices.");
                        break;
                    case "what can i ask you?":
                        TypingDelay("You can ask me about password safety, phishing, safe browsing, and more.");
                        break;
                    case "password safety":
                        TypingDelay("Use strong, unique passwords and enable two-factor authentication.");
                        break;
                    case "phishing":
                        TypingDelay("Be cautious of suspicious emails and links. Always verify the sender's identity.");
                        break;
                    case "safe browsing":
                        TypingDelay("Use HTTPS, avoid public Wi-Fi for sensitive tasks, and keep your browser updated.");
                        break;
                    case "help":
                        TypingDelay("\nWhat would you like to know? Type your question from below:");
                        Console.WriteLine("\"How are you?\"\n\"What is your purpose?\"\n\"What can I ask you?\"\n\"Password Safety\"\n\"Phishing\"\n\"Safe Browsing\"\n\"Help\"\n\"What is Two-Factor Authentication?\"\n\"How can I protect against malware?\"\n\"What is social engineering?\"\n\"How can I protect my data privacy?\"\n\"What are some general cybersecurity tips?\"");
                        break;
                    case "what is two-factor authentication?":
                        TypingDelay("Two-factor authentication adds an extra layer of security to your accounts.");
                        break;
                    case "how can i protect against malware?":
                        TypingDelay("Keep your antivirus software updated and avoid downloading unknown files.");
                        break;
                    case "what is social engineering?":
                        TypingDelay("Be wary of unsolicited requests for personal information. Verify before sharing.");
                        break;
                    case "how can i protect my data privacy?":
                        TypingDelay("Limit the personal information you share online to protect your privacy.");
                        break;
                    case "what are some general cybersecurity tips?":
                        TypingDelay("Regularly update your software and be cautious of suspicious links.");
                        break;
                    default:
                        TypingDelay("I didn't quite understand that. Could you rephrase?");
                        break;
                }
            }
        }

        static void TypingDelay(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine("\n");
        }
    }
}
