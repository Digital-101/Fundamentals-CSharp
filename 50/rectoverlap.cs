using System;

class RectangleOverlap
{
    static bool DoRectanglesOverlap(int x1, int y1, int x2, int y2,
                                    int x3, int y3, int x4, int y4)
    {
        // If one rectangle is completely to the left or right of the other
        if (x1 >= x4 || x3 >= x2)
            return false;

        // If one rectangle is completely above or below the other
        if (y1 >= y4 || y3 >= y2)
            return false;

        return true; // Otherwise, they overlap
    }

    static void Main()
    {
        // Rectangle 1 (Bottom-Left: (0, 0), Top-Right: (4, 4))
        int x1 = 0, y1 = 0, x2 = 4, y2 = 4;

        // Rectangle 2 (Bottom-Left: (2, 2), Top-Right: (6, 6))
        int x3 = 2, y3 = 2, x4 = 6, y4 = 6;

        if (DoRectanglesOverlap(x1, y1, x2, y2, x3, y3, x4, y4))
            Console.WriteLine("Rectangles Overlap!");
        else
            Console.WriteLine("Rectangles Do Not Overlap!");
    }
}
