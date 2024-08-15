using Practical_2;
//--------Program-1--------
//try
//{
//    int num = 10;
//    int result = num / 0;
//    Console.WriteLine(result);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Cannot devide by Zero");
//}

//--------Program-2--------
//try
//{
//    int[] a = new int[5];
//    for(int i=0; i<=5; i++)
//    {
//        Console.Write("Enter a[{0}] : ",i);
//        a[i] = Convert.ToInt32(Console.ReadLine());
//    }
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine("Array out of Bound Exception");
//}

//--------Program-3--------

//Calculate c1 = new Calculate();
//Console.WriteLine("SumOfTwo : " + c1.SumOfTwo(10, 20));
//Console.WriteLine("SumOfThree : " + c1.SumOfThree(10, 20,30));

//--------Program-4--------

//Result r1 = new Result();
//Console.WriteLine("Addition (10 + 20) : " + r1.Addition(10, 20));
//Console.WriteLine("Subtraction (20 - 10)  : " + r1.Subtraction(20, 10));

//--------Programe-5----------


//string name1 = "University";
//string name = "Darshan";
//Console.WriteLine($"name : {name}\n");
//Console.WriteLine($"name1 : {name1}\n");
//int len = name.Length;
//Console.WriteLine($"name.Length : {len}\n");

//string joined = string.Concat(name, name1);
//Console.WriteLine($"string.Concat(name, name1) : {joined} \n");

//Boolean result = name.Equals(name1);
//Console.WriteLine($"name.Equals(name1) : {result}\n");

//string str = "This is the \"String\" Class";
//Console.WriteLine($"str : {str} \n");

//string toLower = name.ToLower();
//Console.WriteLine($"name.ToLower() : {toLower}\n");

//string toUpper = name.ToUpper();
//Console.WriteLine($"name.ToUpper() : {toUpper} \n");

//bool check = name.Contains("shan");
//Console.WriteLine($"name.Contains(\"shan\") : {check}\n");

//string res = name.Substring(2);
//Console.WriteLine($"name.Substring(2) : {res}\n");

//string res1 = name.Substring(0, 4);
//Console.WriteLine($"name.Substring(0,4) : {res1}\n");

//int compare = String.Compare(name, name1);
//Console.WriteLine($"String.Compare(name, name1) : {compare}\n");

//string newstr = name.Insert(0, "Demo ");
//Console.WriteLine($"name.Insert(0, \"Demo \") : {newstr}\n");

//int lastIndex = name.LastIndexOf("a");
//Console.WriteLine($"name.LastIndexOf(\"a\") : {lastIndex}\n");

//string removed = name.Remove(3);
//Console.WriteLine($"name.Remove(3) : {removed}\n");

//string replaced = name.Replace("a", "A");
//Console.WriteLine($"name.Replace(\"a\", \"A\") : {replaced}\n");

//var clon = name.Clone();
//Console.WriteLine($"name.Clone() : {clon}\n");

//var CompareTo = name.CompareTo(name1);
//Console.WriteLine($"name.CompareTo(name1) : {CompareTo}\n");

//var EndsWith = name.EndsWith("n");
//Console.WriteLine($"name.EndsWith(\"n\") : {EndsWith}\n");

//var indexOf = name.IndexOf("a");
//Console.WriteLine($"name.IndexOf(\"a\") : {indexOf}\n");

//var startWith = name.StartsWith("D");
//Console.WriteLine($"name.StartsWith(\"D\") : {startWith}\n");

//var trim = name.Trim();
//Console.WriteLine($"name.Trim() : {trim}\n");

//--------Programe-6--------

//Console.Write("Enter A String With Uppercase and Lowercase Letters : ");
//string str1 = Console.ReadLine();
//string str2 = "";

//foreach(var s in str1)
//{
//    if (s >= 'A' && s <= 'Z')
//        str2 += char.ToLower(s);
//    else if (s >= 'a' && s <= 'z')
//        str2 += char.ToUpper(s);
//    else
//        str2 += s;
//}
//Console.WriteLine(str2);

//----------Practical-7-----------
//CalculateArea ca = new CalculateArea();
//Console.WriteLine("Circle r=7 : "+ca.Circle(7));
//Console.WriteLine("Triangle base=7 height=3 : "+ca.Triangle(7,3));
//Console.WriteLine("Square width=7 height=3 : "+ca.Square(7,3));

//----------Practical-8-----------
//try
//{
//    Console.Write("Enter a number : ");
//    int num = Convert.ToInt32(Console.ReadLine());

//    if (num%2 != 0)
//        throw new Exception("Number is not Even");
//    else
//        Console.WriteLine("Number is Even");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//-------Programe-9---------

//Console.Write("Enter an Sentence : ");

//string input = Console.ReadLine();
//string[] words = input.Split(' ');

//string longestWord = "";

//foreach (string word in words)
//    if (word.Length > longestWord.Length)
//        longestWord = word;

//Console.WriteLine("The longest word is: " + longestWord);

//---------Programe-10----------
//Console.Write("Enter an Character : ");
//char c = Console.ReadKey().KeyChar;

//char res = char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);

//Console.WriteLine($"\nChanged Character : {res}");