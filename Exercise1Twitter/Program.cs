// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercise 1 - Twitter");
string? option;

while (true)
{
    try
    {
        Console.WriteLine("\nChoose one of the options:\r\n1 - a rectangular tower\r\n2 - triangular tower\r\n3 - Exit");
        option = Console.ReadLine();

        if (option == "3")
            break;

        if (option != "1" && option != "2")
        {
            Console.WriteLine("Invalid input\n");
            break;
        }

        Console.WriteLine("Tap the height and width of the tower:");
        string? height = Console.ReadLine();
        string? width = Console.ReadLine();

        //מלבן
        if (option == "1")
            RectangularTower(height, width);

        //משולש
        if (option == "2")
            TriangularTower(height, width);
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid input\n");
        throw;
    }
}

void RectangularTower(string? heightS, string? widthS)
{
    int height = Convert.ToInt32(heightS);
    int width = Convert.ToInt32(widthS);

    //אם מרובע או שההפרש בין הצלעות גדול מ5 - הדפסת השטח, אחרת הדפסת היקף
    if (height == width || (height - width > 0 && height - width > 5) || (height - width < 0 && height - width < -5))
        Console.WriteLine($"Area of the rectangle: {height * width}");
    else
        Console.WriteLine($"The scope of the rectangle: {(height + width) * 2}");
}

void TriangularTower(string? heightS, string? widthS)
{
    int height = Convert.ToInt32(heightS);
    int width = Convert.ToInt32(widthS);

    string? optionTri;
    Console.WriteLine("Choose one of the options:\r\n1 - Calculation of the perimeter of the triangle\r\n2 - Printing the triangle");
    optionTri = Console.ReadLine();

    //אם 1 - חישוב היקף המשולש
    if (optionTri == "1")
    {
        Console.WriteLine($"The scope of the Triangular: {height * 2 + width}");
    }

    //אם 2 - הדפסת המשולש
    if (optionTri == "2")
    {
        //אם רוחב המשולש זוגי או שרוחבו יותר מפי 2 מגובהו, אין אפשרות להדפיס
        if ((width % 2) == 0 || width > height * 2)
        {
            Console.WriteLine("The triangle cannot be printed");
            return;
        }

        //מספר השורות שבאמצע
        int lineMiddle = height - 2;

        //מספר סוגי הרוחב של השורות באמצע
        int typeWidthNum = width / 2 - 1;

        for (int i = 1; (i <= height && width > height) || i <= width; i += 2)
        {
            //רץ עבור מספר השורות באמצע לחלק למספר סוגי הרוחב של השורות אם זה הראשון האמצעי לקיחת השארית
            for (int k = 0; (i == 3 && k < (lineMiddle / typeWidthNum + lineMiddle % typeWidthNum)) || (k < lineMiddle / typeWidthNum); k++)
            {
                for (int space = 0; space < (width - i) / 2; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

                if (i == 1 || i == width)
                    break;

            }
        }

    }
}