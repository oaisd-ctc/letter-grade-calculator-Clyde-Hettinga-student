public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the number score you have in class.");
        int grade = ScoreInput();
        LetterGrade(grade);
    }

    public static int ScoreInput()
    {
        string input = Console.ReadLine();
        int score = int.Parse(input);
        return score;
    }

    public static void LetterGrade(int numScore)
    {
        if (numScore >= 100)
            Console.WriteLine($"Letter Grade: A+\nWow! {numScore}... That's impressive!");
        else if (numScore >= 90)
            Console.WriteLine("Letter Grade: A\nVery nice!");
        else if (numScore >= 80)
            Console.WriteLine("Letter Grade: B\nKeep it up!");
        else if (numScore >= 70)
            Console.WriteLine("Letter Grade: C\nYou got this, keep working!");
        else if (numScore >= 60)
            Console.WriteLine("Letter Grade: D\nKeep trying!");
        else
            Console.WriteLine("Letter Grade: E\nDon't give up!");
    }
}