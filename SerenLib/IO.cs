namespace SerenLib.IO
{
   
    public static class IO
    {
        /// <summary>
        /// Animates the typewriter effect
        /// </summary>
        /// <param name="message">Message to be displayed</param>
        /// <param name="delay">Delay in ms between each letter</param>
        public static void Out(string message, int delay = 50, bool newLine = true)
        {
            // Each character in the string
            foreach(char i in message)
            {
                // Output and wait before next character
                Console.Write(i);
                Thread.Sleep(delay);
            }
            // Create new line once done IF newLine = true
            if(newLine)Console.WriteLine();
        }

        /// <summary>
        /// Gets valid input from user from an array of strings
        /// </summary>
        /// <param name="data">Array of strings</param>
        /// <returns>Valid user input</returns>
        public static string GetValidInput(string[] data, string errorMessage = null)
        {
            string input = "";
            while (!data.Contains(input))
            {
                input = Console.ReadLine().ToLower().Trim();

                if(errorMessage != null && !data.Contains(input))
                {
                    Out(errorMessage);
                }
            }
            return input;
        }

        public static bool YesNo(string question)
        {
            string input = "";
            string[] optionsYes = new string[] { "yes", "y" };
            string[] optionsNo = new string[] { "no", "n" };
            while (!optionsYes.Contains(input) && !optionsNo.Contains(input))
            {
                Console.WriteLine(question);
                input = Console.ReadLine().ToLower().Trim();
            }
            return optionsYes.Contains(input);
        }

        public static bool TypeYesNo(string question, int delay = 60)
        {
            string input = "";
            string[] optionsYes = new string[] { "yes", "y" };
            string[] optionsNo = new string[] { "no", "n" };
            while (!optionsYes.Contains(input) && !optionsNo.Contains(input))
            {
                Out(question, delay);
                input = Console.ReadLine().ToLower().Trim();
            }
            return optionsYes.Contains(input);
        }
    }
}
