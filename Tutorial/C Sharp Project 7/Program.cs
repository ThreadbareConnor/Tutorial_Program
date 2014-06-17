using System; // Namespace declaration (collection of classes, interfaces, structs, enums, delegates and other namespaces)
public class Employee
{
    public string firstName;
    public string lastName;
    public string email;
    public void PrintFullName()
    {

    }
}
public class FullTimeEmployee : Employee
{
    public double yearlySalery;
}
public class PartTimeEmployee : Employee
{
    public float hourlyRate;
}
class Program // Class creation, any piece of code you write should be in a class
{// Brackets indicate what is inside the class and are used to contain functions.
    static void Main()// Method. These do the acctual work in a program.
    {// This is the start of the program and is indicated by the "Main" method which is ALWAYS the entry point to your application 
        Console.WriteLine("Welcome to Crane Style Labs");
        Main1();
    }
    static void Main1()
    {
        Console.WriteLine("Welcome to C# training");
        Console.WriteLine("Please enter your first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please enter you last name");
        string lastName = Console.ReadLine();
        Console.WriteLine("\n Hello {0} {1}", firstName, lastName);
        Selection();
    }
    static void Selection()
    {
        Console.WriteLine("\n Please select a lesson \n 1-Readline: Concatinate and Placeholder Syntax \n 2-Types \n 3-Escape Sequences \n 4-Int and Bool \n 5-If \n 6-Do While \n 7-Switch \n 8-Switch continued");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                ReadandWrite();
                break;
            case 2:
                Types();
                break;
            case 3:
                Escapes();
                break;
            case 4:
                IntandBool();
                break;
            case 5:
                If();
                break;
            case 6:
                While();
                break;
            case 7:
                Switch();
                break;
            case 8:
                SwitchContd();
                break;
            default:
                Console.WriteLine("THIS NUMBER IN NOT ON THE LIST! TRY AGAIN.");
                Selection();
                break;
        }
    }
    static void ReadandWrite()
    {
        Console.WriteLine("Welcome to Crane Style Labs C# training\n");
        Console.WriteLine("To write to the console use the command \"Console.WriteLine(\"placeholder\")\". \nThis is how you will communicate to your user\n");
        Console.WriteLine("\nPrompt for the user to enter their name");
        Console.WriteLine("Please enter your first name\n");
        string firstName = Console.ReadLine();
        Console.WriteLine("\nRead the name entered in the console");
        Console.WriteLine("\nTo read from the console use the command \"Console.ReadLine().\" \n");

        Console.WriteLine("Please enter your last name\n");

        string lastName = Console.ReadLine();
        Console.WriteLine("one method of printing to the console from a stored string variable is \nPlaceholder syntax ex. \"Hello {0} {1}\", firstName, lastName -Preferred method");
        Console.WriteLine("\nHello {0} {1}\n", firstName, lastName);
        Console.WriteLine("Another method is to concatenate a string variable with \"Hello\" and print\n ex. \"Hello \" + username");
        string username = firstName + lastName;
        Console.WriteLine("\nHello " + username);
        Selection();
    }
    static void IntandBool()
    {
        bool b = false;

        Console.WriteLine("Bools can only hold true and false values");

        int i = 0;

        Console.WriteLine("int can hold whole numbers with a min = {0}", int.MinValue);
        Console.WriteLine("int can hold whole numbers with a max = {0}", int.MaxValue);

        double doub = 1.123456;
        Console.WriteLine("Floats can hold decimals ex. {0}", doub);

        decimal dec = .23456789987654321M;
        Console.WriteLine("Decimals are much more precise than floats but they use more memory ex. {0}", dec);
        Selection();
    }
    static void Escapes()
    {
        {
            //Strings values are usually enclosed in double quotes
            string Name = "\"Connor\"";
            Console.WriteLine(Name);
            Console.WriteLine("Escape sequence is backslash. This allows you to print double quotes by telling \nthe program to print whatever comes after it even if it has special \nmeaning within the language. \nA backslash is needed before every special meaning character ");

            // Escape sequence is backslash. This allows you to print double quotes by telling the program to print whatever comes after it even if it has special meaning within the language
            // A backslash is needed before every special meaning character  
            Selection();
        }
    }
    static void Types()
    {

        int i = 100;
        // No loss of information
        float f = i;

        Console.WriteLine(f);

        // this is an example of implicit conversion no action is necessary because the conversion is from a smaller data type to a larger one
        // when converting a float to an int you loose some of the data in the form of the fractional part of the float
        // this makes it an explicit coversion. For explicit conversion you use the cast operator or the convert class in c#


        // cast operator example
        float nf = 123.13245F;
        int ni = (int)nf;
        Console.WriteLine(ni);

        // convert class example
        float ff = 22.3456F;
        int fi = Convert.ToInt32(ff);
        Console.WriteLine(fi);

        // THE DIFFERENCE
        // using the typecast opereator will not throw an exception if the larger data doesnt fit in the smaller data type
        // using the covert class will throw an exception

        // example using a string
        string strNumber = "100";
        // int i = strNumber will not work because an explicit conversion is necessary
        int si = int.Parse(strNumber);
        // only works with strings containing only numbers
        Console.WriteLine(si);

        //TryParse method example
    TryParse:
        Console.WriteLine("Please enter some data to test");
        string strNumber2 = Console.ReadLine();
        int result = 0;
        bool isConversionSuccessful = int.TryParse(strNumber2, out result);
        // the result of the TryParse method is acctually booleen 
        if (isConversionSuccessful)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("TryPrase unsuccessful");
            goto TryParse;
        }
        Selection();



    }
    static void If()
    {

        Console.WriteLine("please enter an even number");
        string input = Console.ReadLine();
        int newInt = int.Parse(input);

        if (newInt % 2 == 0)
        {
            Console.WriteLine("good job");
        }
        else if (newInt % 2 != 0)
        {
            Console.WriteLine("NO");
            If();
        }
        Selection();

    }
    static void While()
    {
        string userChoice = "";
        do
        {
            Console.WriteLine("Please enter a target number");
            int targetNumber = int.Parse(Console.ReadLine());
            int start = 0;

            while (start <= targetNumber)
            {
                Console.Write(start + " ");
                start = start + 2;
            }

            do
            {
                Console.WriteLine("Do you want to continue? - Yes or No?");
                userChoice = Console.ReadLine().ToUpper();
                if (userChoice != "YES" && userChoice != "NO")
                {
                    Console.WriteLine("Invalid choice, Please say Yes or No");
                }
            } while (userChoice != "YES" && userChoice != "NO");
        } while (userChoice == "YES");
        Selection();
    }
    static void Switch()
    {
        Console.WriteLine("Please enter a number");
        int userNumber = int.Parse(Console.ReadLine());

        switch (userNumber)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your number is {0}", userNumber);
                Selection();
                break;
            default:
                Console.WriteLine("Your number is not ten, twenty, or thirty");
                Switch();
                break;
        }

    }
    static void SwitchContd()
    {
        int totalCoffeeCost = 0;
    Start:
        Console.WriteLine("Please select your coffee size : 1 - Small, 2 - Medium, 3 - Large,");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                totalCoffeeCost += 1;
                break;
            case 2:
                totalCoffeeCost += 2;
                break;
            case 3:
                totalCoffeeCost += 3;
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid", userChoice);
                goto Start;

        }
    Checkout:
        Console.WriteLine("Do you with to check out? - Y or N?");
        string continueShopping = Console.ReadLine().ToUpper();
        switch (continueShopping)
        {
            case "Y":

                break;
            //a label can be used to jump to using the "goto" command. A marker in the code
            case "N":
                goto Start;
            default:
                Console.WriteLine("Your choice is invalid. Please try again");
                goto Checkout;



        }
        Console.WriteLine("Thanks for shopping Gnarbucks coffee");
        Console.WriteLine("Bill amount = {0}", totalCoffeeCost);

        Selection();
    }
    static void ForEach()
    {
        int[] numbers = new int[3];
        numbers[0] = 101;
        numbers[1] = 102;
        numbers[2] = 103;


        foreach (int k in numbers)
        {
            Console.WriteLine(k);
        }



        for (int j = 0; j < numbers.Length; j++)
        {
            Console.WriteLine(numbers[j]);
        }



        int i = 0;
        while (i < numbers.Length)
        {
            Console.WriteLine(numbers[i]);
            i++;
        }



        for (int d = 0; d <= 20; d++)
        {
            if (d % 2 == 1)
                continue;
            Console.WriteLine(d);
        }



        for (int z = 1; z <= 10; z++)
        {
            Console.WriteLine(z);
            if (z == 10)
                break;
            //break is used to end the loop in for loops
        }
        Selection();
    }
    static void Inheritance()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.firstName = "Connor";
        FTE.lastName = "Fitzgerrell";
        FTE.email = "Connor@threadbaregames,com";
        FTE.yearlySalery = 3000.00;
        Console.WriteLine("Hello {0} {1}");
        
       Selection();
    }
}