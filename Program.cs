using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
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
    
    static void TypingDelay(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(50); // Adjust the delay as needed
            }
            Console.WriteLine();
        }
    }
}
