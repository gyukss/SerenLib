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

        /// <summary>
        /// Visual dropdown of options
        /// </summary>
        /// <param name="options">List of strings</param>
        /// <returns>The option selected</returns>
        public static string Dropdown(List<string> options)
        {
            // Stores the initial Y position of the cursor
            int y = Console.CursorTop;
            // Index is used as the identifier for index of the selected option, starting with [0]
            int index = 0;
            // Hides cursor
            Console.CursorVisible = false;

            while (true)
            {
                // Outputs each option
                for (int i = 0; i < options.Count; i++)
                {
                    // If the current option being displayed is the selected one, add an identifier
                    string head = i == index ? "> " : "  ";
                    Console.WriteLine($"{head}{options[i]}");
                }
                // Stores the next key pressed
                ConsoleKeyInfo key = Console.ReadKey(true);
                // If S, selected option is down one, W, up one
                if (key.Key == ConsoleKey.S) index++;
                if (key.Key == ConsoleKey.W) index--;
                // If enter (select) is pressed, break out of loop
                if (key.Key == ConsoleKey.Enter) break;
                // If index exists the confinements of the list, make it wrap around
                if (index >= options.Count()) index = 0;
                if (index < 0) index = options.Count() - 1;
                // Set the cursor back to the start ready for next iteration
                Console.SetCursorPosition(0, y);
            } // After loop exited
            // Restore cursor visibility
            Console.CursorVisible = true;
            // Return option selected
            return options[index];
        }
    }
}
