// See https://aka.ms/new-console-template for more information


class Program
{
    // 1. הדפסת שורה מלאה (לגג, אמצע ובסיס)
    static void PrintFull(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("#");
        }
        Console.WriteLine();
    }

    // 2. הדפסת שני קווים בצדדים (עבור ספרות כמו 8, 0)
    static void PrintSides(int n)
    {
        int height = n / 2;
        for (int i = 0; i < height; i++)
        {
            Console.Write("#"); // צד שמאל
            for (int j = 0; j < n - 2; j++) // רווח באמצע
            {
                Console.Write(" ");
            }
            Console.WriteLine("#"); // צד ימין
        }
    }

    // 3. הדפסת קו בצד ימין בלבד (עבור ספרות כמו 1, 7)
    static void PrintRight(int n)
    {
        int height = n / 2;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("#");
        }
    }

    // 4. הדפסת קו בצד שמאל בלבד (עבור ספרות כמו 5, 2)
    static void PrintLeft(int n)
    {
        int height = n / 2;
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine("#");
        }
    }

    // פעולה שמקבלת תו וגודל ומדפיסה את הספרה המתאימה
    static void DisplayDigit(char digit, int n)
    {
        switch (digit)
        {
            case '0':
                PrintFull(n);       // גג
                PrintSides(n);      // צדדים עליונים
                PrintSides(n);      // צדדים תחתונים (במקום אמצע)
                PrintFull(n);       // בסיס
                break;

            case '1':
                PrintRight(n);      // צד ימין למעלה
                PrintRight(n);      // צד ימין למטה
                break;

            case '2':
                PrintFull(n);       // גג
                PrintRight(n);      // ימין
                PrintFull(n);       // אמצע
                PrintLeft(n);       // שמאל
                PrintFull(n);       // בסיס
                break;

            case '3':
                PrintFull(n);       // גג
                PrintRight(n);      // ימין
                PrintFull(n);       // אמצע
                PrintRight(n);      // ימין
                PrintFull(n);       // בסיס
                break;

            case '4':
                PrintSides(n);      // צדדים (כמו כוס)
                PrintFull(n);       // אמצע
                PrintRight(n);      // ימין בלבד
                break;

            case '5':
                PrintFull(n);       // גג
                PrintLeft(n);       // שמאל
                PrintFull(n);       // אמצע
                PrintRight(n);      // ימין
                PrintFull(n);       // בסיס
                break;

            case '6':
                PrintFull(n);       // גג
                PrintLeft(n);       // שמאל
                PrintFull(n);       // אמצע
                PrintSides(n);      // צדדים
                PrintFull(n);       // בסיס
                break;

            case '7':
                PrintFull(n);       // גג
                PrintRight(n);      // ימין
                PrintRight(n);      // ימין
                break;

            case '8':
                PrintFull(n);       // גג
                PrintSides(n);      // צדדים
                PrintFull(n);       // אמצע
                PrintSides(n);      // צדדים
                PrintFull(n);       // בסיס
                break;

            case '9':
                PrintFull(n);       // גג
                PrintSides(n);      // צדדים
                PrintFull(n);       // אמצע
                PrintRight(n);      // ימין
                PrintFull(n);       // בסיס
                break;

            default:
                Console.WriteLine("קלט לא תקין");
                break;
        }
    }

    static void Main(string[] args)
    {
        // קליטת נתונים לפי דרישות המשימה
        Console.WriteLine("Please enter a number:");
        string input = Console.ReadLine();

        Console.WriteLine("Please enter an odd size (3, 5, 7, 9):");
        int size = int.Parse(Console.ReadLine());

        // מעבר על כל התווים במספר והדפסתם
        foreach (char c in input)
        {
            DisplayDigit(c, size);
            Console.WriteLine(); // רווח קטן בין ספרה לספרה
        }
    }
}