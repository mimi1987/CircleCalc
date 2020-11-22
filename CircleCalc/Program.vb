Imports System

Module Program
    Sub Main(args As String())
        '1. Declarations
        Dim Radius, Area, Circumference As Decimal
        Const Pi As Decimal = Math.PI

        '2. Store User Input
        Console.WriteLine("Please provide the value for the circle radius.")
        Console.WriteLine("Radius: ")
        Radius = Console.ReadLine()

        '3. Calculate The Area
        Area = Pi * Math.Pow(Radius, 2)

        '4. Calculate The Circumference
        Circumference = 2 * Pi * Radius

        '5. Output The Area, Circumference
        Console.WriteLine("The area of the circle is: " & Math.Round(Area, 2))
        Console.WriteLine("The circumference of the circle is: " & Math.Round(Circumference, 2))

        'Prevent Console Closing
        Console.ReadKey()

    End Sub
End Module
