using Practical_3;

//-------Program-1--------
//Addition a1 = new Addition();
//a1.add(10, 20);
//a1.add(10.5, 20.5);

//-------Program-2--------
//CalculateArea c1 = new CalculateArea();
//Console.WriteLine("Area of Square size = 5 :- " + c1.Area(5));
//Console.WriteLine("Area of Rectangle length = 6.1,width = 8.3 :- " + c1.Area(6.1,8.3));

//------Program-3---------
//RBI r1 = new RBI();
//r1.calculateInterest();
//r1 = new HDFC();
//r1.calculateInterest();
//r1 = new SBI();
//r1.calculateInterest();
//r1 = new ICICI();
//r1.calculateInterest();

//------Program-4--------
//FactDelegate f = new FactDelegate();
//Console.WriteLine("Factorial of 5 :- "+f.factorial(5));

//-------Program-5-------
//Hospital h1 = new Hospital();
//h1.HospitalDetails();
//h1 = new Apollo();
//h1.HospitalDetails();
//h1 = new Wockhardt();
//h1.HospitalDetails();
//h1 = new Gokul_Superspeciality();
//h1.HospitalDetails();

//-------Program-6-------
//CalArea ca = new CalArea();
//Console.WriteLine("Area of Square size=2.6 :- " + ca.Area(2.6));
//Console.WriteLine("Area of Rectangle length=2.6,width=4.3 :- " + ca.Area(2.6,4.3));
//Console.WriteLine("Area of Circle radius=7 :- " + ca.Area(7));

//--------Program-7-------
//TrafficDel td = TrafficSignal.Yellow;
//td();
//td = TrafficSignal.Green;
//td();
//td = TrafficSignal.Red;
//td();

//---------Program-8--------
calculate cal;
int choice = 1;
double a, b;

while(choice <= 6)
{
    Console.Write("Enter A : ");
    a = double.Parse(Console.ReadLine());
    Console.Write("Enter B : ");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine();

    Calculator.Menu();
    Console.WriteLine();
    Console.Write("Enter Choice : ");
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (choice)
    {
        case 1:
            cal = Calculator.Add;
            break;
        case 2:
            cal = Calculator.Subtract;
            break;
        case 3:
            cal = Calculator.Multiply;
            break;
        case 4:
            cal = Calculator.Divide;
            break;
        case 5:
            cal = Calculator.Modulus;
            break;
        default:
            Console.WriteLine("Exiting Programe\n");
            return;
    }

    Console.WriteLine("Answer = " + cal(a, b));
    Console.WriteLine();
}
