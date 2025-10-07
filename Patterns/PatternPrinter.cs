using System;

class PatternPrinter
{
    static void Main()
    {
        Console.WriteLine("Choose a pattern to print:");
        Console.WriteLine("1. Right-Angled Triangle");
        Console.WriteLine("2. Pyramid");
        Console.WriteLine("3. Diamond");
        Console.WriteLine("4. Number Triangle");
        Console.WriteLine("5. Hollow Square");
        
        int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());
        
        switch (choice)
        {
            case 1: RightTriangle(size); break;
            case 2: Pyramid(size); break;
            case 3: Diamond(size); break;
            case 4: NumberTriangle(size); break;
            case 5: HollowSquare(size); break;
            default: Console.WriteLine("Invalid choice!"); break;
        }
    }
    
    // Include the pattern methods here...
    static void RightTriangle(int n) { /* implementation */ }
    static void Pyramid(int n) { /* implementation */ }
    // ... other methods
}
