class Program2
{
    public void HomeworkExtra()
    {
        DateTime date = DateTime.Today;
        int daysInYear = DateTime.IsLeapYear(date.Year) ? 366 : 365;
        int daysLeftInYear = daysInYear - date.DayOfYear;
        int daysRightInYear = daysInYear - daysLeftInYear;
       
        Console.WriteLine($"Цього року в році: {daysInYear} днів");
        Console.WriteLine($"До нового року залишилось: {daysLeftInYear}");
        Console.WriteLine($"Від нового року минуло: {daysRightInYear}");
    }
}