namespace userinput
{
    public static class UserInput
    {
        public static string getInputString(string message)
        {
            Console.Write(message);
            String? input = null;
            do
            {
                if (input != null)
                {
                    Console.WriteLine("Neplatná hodnota!");
                }
                input = Console.ReadLine();

            } while (input != null && input.GetType() != typeof(string) && input.Length > 0);

            return input;
        }

        public static char getInputChar(string message)
        {
            Console.Write(message);
            string? input = null;
            do
            {
                if (input != null)
                {
                    Console.WriteLine("Neplatná hodnota!");
                }
                input = Console.ReadLine();

            } while (input != null && input.Length != 1);

            return input.ToCharArray()[0];
        }

        public static int getInputInt(string message)
        {
            Console.Write(message);
            int result = 0;
            String? input = null;
            do
            {
                if (input != null)
                {
                    Console.WriteLine("Neplatná hodnota!");
                }
                input = Console.ReadLine();

            } while (input != null && !int.TryParse(input, out result));

            return result;
        }
    }
}