namespace SerenLib.IO
{
   
    public static class IO
    {
        /// <summary>
        /// Animates typewriter effect
        /// </summary>
        /// <param name="message">Message to be displayed</param>
        /// <param name="delay">Delay in ms between each letter</param>
        public static void Out(string message, int delay = 50)
        {
            // Each character in the string
            foreach(char i in message)
            {
                // Output and wait before next character
                Console.Write(i);
                Thread.Sleep(delay);
            }
            // Create new line once done
            Console.WriteLine();
        }
    }
}
