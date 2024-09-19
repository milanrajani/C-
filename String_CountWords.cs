 static void numberofwordsinstring()

        {

            Console.Write("Enter the string : ");

            string inputString = Console.ReadLine();

            int result = 0;

 

            //Trim whitespace from beginning and end of string

            inputString = inputString.Trim();

 

            //Necessary because foreach will execute once with empty string returning 1

            if (inputString == "")

                Console.WriteLine(0);

 

            //Ensure there is only one space between each word in the passed string

            while (inputString.Contains("  "))

                inputString = inputString.Replace("  ", " ");

 

            //Count the words

            foreach (string y in inputString.Split(' '))

                result++;

 

            Console.WriteLine("Number of words is : " +result);

            Console.ReadLine();

        }