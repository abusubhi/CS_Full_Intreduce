/*Variables*/
//datetype name; ----> Declartion 
//datatype name = value  ; ---> Intlization

//Numeric
byte b1;
byte b2 = 5;

short s1;
short s2 = 17;

int i;
int i1 = 952369;

long l1;
long l2 = 258;

float f;
float f1 = 56.2f; //suffix

double d;
double d1 = 23.5;

decimal e1;
decimal e2 = 5.36m;

// Text 
char c1;
char c2 = '1';

string str1; // refence data type
string str2 = "Test"; // refence data type

//Boolean 
bool b3;
bool b4 = false;

/*Casting*/
//Implicit Casting 
byte b1 = 8;
short b2 = b1;
int b3 = b2;
long b4 = b3;
float f = 3.25f;
double d = f;
decimal c = b4; // No Implicit Casting Available From Double --> Decimal

char a = 'A';
int character = a; //each character on computer have an ascii value in decimal (65

//Explicit  Casting 
//1- Partations 
decimal num = 523854135.5468m;
double num2 = (double)num;
float num4 = (float)num;
long num3 = (long)num;
int num5 = (int)num;
short num6 = (short)(int)num;
byte num7 = (byte)(short)(int)num;

char num8 = (char)68; //establish the character debends on decimal Value


// Numeric / Boolena   ----> String 
byte b1 = 85;

string str = b1 + "";  //(byte) + (string )  ---> result (string)

string str2 = b1.ToString();



//From String 

// the Converted (Inserted / Given)  Value Should contains of acceptable character
// From the Targeted Data Type 

// String ----> Integeral (byte / long / short / int) ----> "0-9" Digits only
// String ----> Real (float / double / decimal ) ---> "0-9" OR "0-9.0-9" Digits and floating point
// String ----> Char (char) -----> Just One Symbole / Letter / Digit in the given value "5"
// String ----> Boolean (bool) ---> String ("true"/"True"/"false"/"False");

//From String To Byte  "0-255"
string strbyte = "128";
byte b1 = byte.Parse(strbyte);
byte b2 = Convert.ToByte(strbyte);
byte b3;
byte.TryParse(strbyte, out b3);
//From String To Short  "0-1000"
string strshort = "1280";
short s1 = short.Parse(strshort);
short s2 = Convert.ToInt16(strshort);
short s3;
short.TryParse(strshort, out s3);
//From String To Int  "0-1000000"
string strint = "12850";
int i1 = int.Parse(strint);
int i2 = Convert.ToInt32(strint);
int i3;
int.TryParse(strint, out i3);
//From String To Long  "0-1000000"
string strlong = "1288545250";
long l1 = long.Parse(strlong);
long l2 = Convert.ToInt64(strlong);
long l3;
long.TryParse(strlong, out l3);
//From String To Float
string strfloat = "1288545250.45";
float f1 = float.Parse(strfloat);
float f2 = Convert.ToSingle(strfloat);
float f3;
float.TryParse(strfloat, out f3);
//From String To Double
string strdouble = "1288545250.5252485648745";
double d1 = double.Parse(strdouble);
double d2 = Convert.ToDouble(strdouble);
double d3;
double.TryParse(strdouble, out d3);
//From String To Decimal
string strdecimal = "1288545245248568450.525274457485648745";
decimal dec1 = decimal.Parse(strdecimal);
decimal dec2 = Convert.ToDecimal(strdecimal);
decimal dec3;
decimal.TryParse(strdecimal, out dec3);
//From String To Boolean 
string strbool = "true";
bool bo1 = bool.Parse(strbool);
bool bo2 = Convert.ToBoolean(strbool);
bool bo3;
bool.TryParse(strbool, out bo3);


/*Math Controlling*/
//Shared Class
//Call Class By Thier Names

//Math ----> Provide a Set of Mathmatical Constact and Mathmatical Operation

//Poperty
Console.WriteLine(Math.PI); // 3.14  


//Methods 
Console.WriteLine(Math.Pow(2, 3)); //2 to the power 3  = 8
Console.WriteLine(Math.Sqrt(9)); //sqruare root for 9  = 3
Console.WriteLine(Math.Round(3.256312)); // regular rounding for the given number
Console.WriteLine(Math.Round(3.256312, 3));//roungin after n digits after the floating point
Console.WriteLine(Math.Ceiling(3.256312));//ugrade value to the next integer (4)
Console.WriteLine(Math.Floor(3.256312));//Downgrading value to the pervious integer (3)


/*String Operations*/

string s1 = "  Aya      Ziqlam  ";
string s2 = "Jasser Alshaer";
//Property 
Console.WriteLine(s1.Length);
//Operations 
//Formating (string)
Console.WriteLine(s1.ToLower()); // convert all to small letter
Console.WriteLine(s1.ToUpper()); // convert all to captical letter
Console.WriteLine(s1.Trim());//Remove white spaces on left and right 
Console.WriteLine(s1.TrimEnd());//Remove white spaces on right 
Console.WriteLine(s1.TrimStart());//Remove white spaces on left 
Console.WriteLine(s1.Replace('A', 'c'));//Replcae Each A With c in the given string
Console.WriteLine(s1.Replace("com", "jo"));//Replace com with jo
Console.WriteLine(s1.Remove(17)); //remove index 17 and all index after that
Console.WriteLine(s1.Remove(13, 5)); //remove index 13 and 4 index after that
Console.WriteLine(s1.Substring(13));//return new string from 13 to end  
Console.WriteLine(s1.Substring(13, 5));//return new string from 13 and 4 index after that   
//Comparing (bool)
Console.WriteLine(s1.Equals("aya ziqlam"));
Console.WriteLine(s1.Equals("aya ziqlam", StringComparison.OrdinalIgnoreCase));
Console.WriteLine(s1.Contains("zi"));
Console.WriteLine(s1.Contains("zi", StringComparison.OrdinalIgnoreCase));
Console.WriteLine(s1.StartsWith("zi"));
Console.WriteLine(s1.StartsWith("zi", StringComparison.OrdinalIgnoreCase));
Console.WriteLine(s1.EndsWith("zi"));
Console.WriteLine(s1.EndsWith("zi", StringComparison.OrdinalIgnoreCase));
//Searching
Console.WriteLine(s1.IndexOf("A")); // first place for A Capitcal in given string 
Console.WriteLine(s1.LastIndexOf("A")); // last plcae for A Captical in given string 
Console.WriteLine(s1.ElementAt(5)); // give me the charcter in the given index
//Validation
string.IsNullOrEmpty(s1); // return true if the s1 is null or empty 
string.IsNullOrWhiteSpace(s1); // return ture if s1 is null or only contains of white spaces

//Optaional
string.Concat(s1, "Test"); //Contantication



/*Random Controlling*/
//Custom Class 

Random random = new Random(); //--> Genertare Random Values 


//Methods
byte[] testByte = new byte[1024];
random.NextBytes(testByte);//Fill Array of Byte  
Console.WriteLine(random.Next()); //Generate Random Int
Console.WriteLine(random.Next(100));//Generate Random Int From 0-99
Console.WriteLine(random.Next(1, 101));//Genertae Random Int From 1-100
Console.WriteLine(random.NextDouble());//Generate Random Double from 0  and less than 1
Console.WriteLine(random.NextInt64());//Genertate Random Long 
Console.WriteLine(random.NextInt64(100));//Genertate Random Long 0-99
Console.WriteLine(random.NextInt64(15, 1600));//Genertate Random Long From 1599
Console.WriteLine(random.NextSingle());//Generate Random Float from 0  and less than 1

/*String Controlling*/
string i = "Jasser Khaled Alsher";
//Formationg
i = i.ToLower();
i.ToUpper();
i.Replace("J", "Test");
i.Trim();
i.TrimStart();
i.TrimEnd();
i.Remove(2, 5);
i.Remove(2);
i.Reverse();
i.Split(' ');
i.Substring(0, 2);
i.Substring(2);
//Comparing
i.Equals("Jasser", StringComparison.OrdinalIgnoreCase);
i.Contains("as");
i.StartsWith("as");
i.EndsWith("as");
i.ToCharArray();
//Searching 
i.ElementAt(0);
i.IndexOf("er");
i.LastIndexOf("t");
//validation
string.IsNullOrEmpty(i);
string.IsNullOrWhiteSpace(i);

/*Array 1D Controlling*/
//Array 1D
//datatype names = 
int[] ints;
int[] numbers = { 78, 86, 79, 61, 59 }; //static inlization 
int[] ints1 = new int[5];
int[] numbers3 = new int[5] { 11, 12, 13, 14, 19 }; //Hybrid Model

//Read
//A- Input for Method
Console.WriteLine(numbers3[3]);
//B- Calaculation
int x = numbers3[0];
//C- Intlization For New Var 
ints1[4] = numbers3[1];
//Reassign
numbers3[3] = 24;

/*Array 2D Controlling*/
//Array of 4 Row and 6 column of type double
double[,] numbers = new double[4, 6];
Random random = new Random();
//Fill the First and Third Row Static
numbers[0, 1] = 14;
numbers[0, 2] = 14;
numbers[0, 3] = 14;
numbers[0, 4] = 14;
numbers[0, 5] = 14;
numbers[0, 0] = 14;
numbers[2, 0] = 14;
numbers[2, 1] = 14;
numbers[2, 2] = 14;
numbers[2, 3] = 14;
numbers[2, 4] = 14;
numbers[2, 5] = 14;
//Fill the Seoned Row With Random Value
numbers[1, 0] = random.Next(1, 100);
numbers[1, 1] = random.Next(1, 100);
numbers[1, 2] = random.Next(1, 100);
numbers[1, 3] = random.Next(1, 100);
numbers[1, 4] = random.Next(1, 100);
numbers[1, 5] = random.Next(1, 100);

//Fill the Forth Row From User
numbers[3, 0] = Convert.ToDouble(Console.ReadLine());
numbers[3, 1] = Convert.ToDouble(Console.ReadLine());
numbers[3, 2] = Convert.ToDouble(Console.ReadLine());
numbers[3, 3] = Convert.ToDouble(Console.ReadLine());
numbers[3, 4] = Convert.ToDouble(Console.ReadLine());
numbers[3, 5] = Convert.ToDouble(Console.ReadLine());

/*LinkedList Controlling*/
//declarion null linkedlist 
LinkedList<long> longs2;
LinkedList<long> longs3 = new LinkedList<long>();// empty
LinkedList<long> longs = new LinkedList<long>(new long[] { 11, 25, 35, 25 }); //static


//Read 
Console.WriteLine(longs.First.Value); // Return the value of the first index
Console.WriteLine(longs.Last.Value); // Return the value of the last index 
Console.WriteLine(longs.Find(25)); // Return the first node that holde the given element
Console.WriteLine(longs.FindLast(25)); // Return the last node that holde the given element
Console.WriteLine(longs.ElementAt(0));
//Insert 
longs.AddFirst(25); //Add New Value At the tOp / First of list
longs.AddLast(25); // Add tthe element at the bootom / last of colleaction  
longs.AddAfter(longs.Find(16), 17);
longs.AddBefore(longs.Find(11), 17);
//Update - Reassign 
longs.Last.Value = 15;
//Operations 
longs.Clear();


/*List Controlling*/
List<double> random = new List<double> { 1.8, 0.15, 0.25, 0.35 };
List<double> random1 = new List<double>(); //empty List
List<int> ints = new List<int> { 1, 2, 3, 4 };

//Insert Element 
Console.WriteLine("Before Add" + ints.Count);
ints.Add(1);
Console.WriteLine("Before Append" + ints.Count);
ints = ints.Append(2).ToList();
Console.WriteLine("Before Insert " + ints.Count);
ints.Insert(6, 9);
Console.WriteLine("Final Count" + ints.Count);

// Add Multiple Element To The List 
random1.Add(0.10);
random1.AddRange(random);
random1.InsertRange(2, new List<double> { 0.18, 0.65, 0.75 });

//Read Values 
Console.WriteLine(random1[0]);
Console.WriteLine(random1.ElementAt(5));

//Reassign (Update)
random1[0] = 1.8;

//Remove Single Value
random1.RemoveAt(0);

//Remove Multi Value 
random1.Clear(); // Remove All Element  in the list
random1.RemoveRange(2, 3);

//search


/*Queue Controlling*/

Queue<int> ints2; // null queue
Queue<int> ints = new Queue<int>(); // empty Queue
Queue<int> ints3 = new Queue<int>
    (new int[] { 14, 15, 16 });//{14,15,16,5}

// Property (Read The Current Length)
Console.WriteLine(ints.Count);
Console.WriteLine(ints3.Count);

//Insert Value 
ints3.Enqueue(5);

//Read
Console.WriteLine(ints3.Peek()); //Read The First Value on The Queue // 14
Console.WriteLine(ints3.ElementAt(2));//Read The value in the given index //16
Console.WriteLine(ints3.Dequeue());//Read The First Value on The Queue & Remove the First Element From the queue //14

//Remove
ints3.Clear(); // remove all element in queue 

//Search 
ints3.Contains(5);


/*Stack Conrolling*/
Stack<int> ints2; // null queue
Stack<int> ints = new Stack<int>(); // empty Stack
Stack<int> ints3 = new Stack<int>
    (new int[] { 14, 15, 16 });//{14,15,16,5}

// Property (Read The Current Length)
Console.WriteLine(ints.Count);
Console.WriteLine(ints3.Count);

//Insert Value 
ints3.Push(5);

//Read
Console.WriteLine(ints3.Peek()); //Read The First Value on The Stack // 14
Console.WriteLine(ints3.ElementAt(2));//Read The value in the given index //16
Console.WriteLine(ints3.Pop());//Read The First Value on The Stack & Remove the First Element From the queue //14

//Remove
ints3.Clear(); // remove all element in queue 

//Search 
ints3.Contains(5);


/*Prompt Message*/
//Propmt Message 
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Please Enter Your Name");
Console.ForegroundColor = ConsoleColor.White;
string name = Console.ReadLine();
//Out put
//Console.WriteLine(name); //dynmic 
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("The End");//Static

// Contactination Dynamic / Static 
string phone = "07877008333";
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Hello  " + name);//Concating
Console.WriteLine("Hello {0} Your Phone is {1}", name, phone);//Placeholder
Console.WriteLine($"Hello {name} Your Phone is {phone}");//Interpoulations
Console.ForegroundColor = ConsoleColor.White;


/*Method*/
Calculator(ReadIntegerValueFromUser(), ReadIntegerValueFromUser());

int ReadIntegerValueFromUser()
{
    int num1;
    Console.Write("Please Enter Number : ");
    if (int.TryParse(Console.ReadLine(), out num1))
    {
        return num1;
    }
    else
    {
        ShowErrorMessage("Number  Value Was In Wrong Format Please Try Again");
        return ReadIntegerValueFromUser();
    }
}
bool IsInScope(int num)
{
    //(condition) ? true value : false value ; 
    return num > 0 && num <= 100; //? true : false;
}
void Calculator(int num1, int num2)
{

    if (IsInScope(num1) && IsInScope(num2))
    {
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
    }
    else
    {
        ShowErrorMessage("One Of Value is out of Scope");
    }
}

void ShowErrorMessage(string error)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(error);
    Console.ForegroundColor = ConsoleColor.White;
}

/*enum & switch*/
//Switch (Selcation Structure)

//Support Values No Compersion / Eexcuteation Dynamic (Pre Determined Cases)
//Less Complex Than If and More Readable 
//Support Break Statement and default statment
//Can Move Betwwen Flows
//Support Enums 
Console.WriteLine("Please Select One of The Following Services");
Console.WriteLine("1- Pay_Invoice");
Console.WriteLine("2- Recharge_Credit");
Console.WriteLine("3- Quires");
Console.WriteLine("4- New_Purches");
Console.Write("Enter The Service Number :  ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        Console.Write("Please Enter Invoice Id : ");
        Console.ReadLine();
        goto case 8525;
    case 2:
        Console.Write("Please Enter Mobile Number: ");
        Console.ReadLine();
        Console.Write("Please Enter Recharge Amount: ");
        Console.ReadLine();
        goto case 8525;
    case 3:
        Console.WriteLine("Sorry This Services Unavuilable");
        break;
    case 4:
        Console.Write("Please Enter Service Type : ");
        Console.ReadLine();
        Console.WriteLine("Price Is 10 Jd Did You Want to Proced ? ");
        Console.ReadLine();
        Console.WriteLine($"Here You Invoice Id : {new Random().Next()}");
        goto case 8525;
    case 8525:
        GetPaymentInfoFromUser();
        break;
    default:
        Console.WriteLine("Invalid Service Number");
        break;
}

void GetPaymentInfoFromUser()
{
    Console.Write("Please Enter Credit Card Number : ");
    Console.ReadLine();
    Console.Write("Please Enter Credit Card CVV2 Code : ");
    Console.ReadLine();
    Console.WriteLine("Thank You");
}
enum Services
{
    Pay_Invoice,
    Recharge_Credit,
    Quires,
    New_Purches
}

/*IF*/
//If Statement (Decsion Strcuture)
Console.WriteLine("Please Enter Total Price");
float totalPrice = Convert.ToSingle(Console.ReadLine());
if (totalPrice > 100)
{
    Console.WriteLine("Get Promation");
}
Console.WriteLine("Thank You , Please Come Again");\


/*IF ELSE*/
//If -- Else

===================================================================
Console.Write("Please Enter Mark : ");
float mark = Convert.ToSingle(Console.ReadLine());
bool isPassed = false;
if (mark >= 50) { 
    isPassed =  true;
}

Console.WriteLine($"Is Passed ? {isPassed}");


===================================================================
Console.Write("Please Enter Mark : ");
float mark = Convert.ToSingle(Console.ReadLine());
if (mark >= 50) {
    Console.WriteLine($" Passed ");
}
if (mark < 50)
{
    Console.WriteLine($" Failed ");
}
/*If ELSE IF ELSE*/

Console.Write("Please Enter Mark : ");
float mark = Convert.ToSingle(Console.ReadLine());
//68
if(mark < 50)
{
    Console.WriteLine("Failed");
}
else if (mark >= 50 && mark < 69)
{
    Console.WriteLine("Poor");
}
else if(mark >=69 && mark < 74)
{
    Console.WriteLine("Good");
}
else if(mark >= 74 &&  mark < 84)
{
    Console.WriteLine("Very Good");
}
else if(mark >=84 && mark<=100)
{
    Console.WriteLine("Excellent");
}


/*for*/
//InitalPoint , condition , stepper (not required)
//(1) ---> (10) , dont print grater than 30  , +1 
//Print Multiplication Table For Number 3 
int start;
for(start = 1; start<=10; ++start)
{
    Console.WriteLine($" 3 * {start}  = {(3 * start)}");
}
Console.WriteLine(start);


/*while*/
//while 
//Execute Operation  Depends on Condition
//Guess The Stored Number 
int number = new Random().Next(1, 101);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(number);
Console.ForegroundColor= ConsoleColor.White;
Console.Write("Please Guess Number Between 1 - 100 : ");
int value = Convert.ToInt32(Console.ReadLine());
while (value != number)//boolean value ---> 
{
    Console.Write("Again , Guess Number Between 1 - 100 : ");
    value = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Correct");


/*Dowhile*/
//Do While ... Perform Operation At Least one time

//Guess The Stored Number 
int number = new Random().Next(1, 101);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(number);
Console.ForegroundColor = ConsoleColor.White;
int value;
do
{
    Console.Write("Please Guess Number Between 1 - 100 : ");
    value = Convert.ToInt32(Console.ReadLine());
} while (value != number); // Code Restructuring
Console.WriteLine("Correct");


/*foreach*/
//for each ......> enhance for 
//loop through data collecation
List<int> numbers = new List<int> { 1, 2, 3,5,6,9,12,18 };


//Print List Item (for loop)
for(int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

//foreach 
// foreach int position in numbers colleaction
foreach (int num in numbers) // To Read Values only for collecation
    Console.WriteLine(num);


/*File*/

//For Read
var filePath = @"C:\Users\C-ROAD\OneDrive - Dragonsoft\Desktop\Marks.txt";
//For Write/Create
var filePath2 = @"C:\Users\C-ROAD\OneDrive - Dragonsoft\Desktop\Names.txt";
//For Update
var filePath3 = @"C:\Users\C-ROAD\OneDrive - Dragonsoft\Desktop\Names.txt";
//For Copy
var filePath4 = @"C:\Users\C-ROAD\OneDrive - Dragonsoft\Desktop\Students.txt";
// 1- specify the path for file 

//using FileStream fs = File.OpenRead(filePath);
//using var sr = new StreamReader(fs);

//string line;

//while ((line = sr.ReadLine()) != null)
//{
//    Console.WriteLine(line);
//}

// 2- Create File

//using FileStream fs2 = File.Create(filePath2);
//using var sw = new StreamWriter(fs2);
//sw.WriteLine("Jasser");
//sw.WriteLine("Ahmad");
//sw.WriteLine("Khaled");
//sw.WriteLine("Marwa");

// Update
//for(int i = 9; i > 0; i--)
//{
//    File.AppendAllText(filePath3, Console.ReadLine()+"\n");
//}

//Copy
//using var fs4 = new FileStream(filePath4, FileMode.OpenOrCreate);//des
//using var fs = new FileStream(filePath, FileMode.Open);//sourceFile
//using var fs2 = new FileStream(filePath2, FileMode.Open);//sourceFile

//fs.CopyTo(fs4);
//fs2.CopyTo(fs4);

//Delete 
//File.Delete(filePath);
//File.Delete(filePath2);


Code 

- Read int List From User 

- Print The Source List on File 

- Print MAx on the same File 

- Print Min on The Same File 

- Print Sum on The Same File 



//Files  .txt   (Read - Write - Copy - Delete - Update)

// (Path) ---  (Name) ---- (Length / Size)  ------( Extension )

//Read  ---> Proceess of fetch all stored data in file
// Find Location ( Path ) ContinaerDirecotory ---> Name ----> Extenttions 
// Understand The Properties 
List<int> numbers = new List<int>();
for (int i = 0; i < 5; i++)
{
    Console.Write("Please Enter A Number : ");
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
string path = @"C:\Users\USER\Desktop\numbers.txt";
//Create
var fsForWrite = File.Create(path);
var stream = new StreamWriter(fsForWrite);
stream.WriteLine("The Inserted Source ");
stream.Write("[ ");
for (int i = 0; i < 5; i++)
{
    stream.Write(numbers[i]+" ,");
    if(i == 4)
    {
        stream.Write(numbers[i]);
    }
  
}
stream.Write("] ");
stream.WriteLine($"The Max Value =  {numbers.Max()}");
stream.WriteLine($"The Min Value =  {numbers.Min()}");
stream.WriteLine($"The Summation of Values =  {numbers.Sum()}");
stream.Dispose();
stream.Close();
fsForWrite.Dispose();
fsForWrite.Close();




/*LINQ*/
List<int> numbers = new List<int>() ;
int[] arraye=new int[10] ;
Array.Fill(arraye, new Random().Next(1, 81));
for (int i = 0; i < 40; i++)
{
    numbers.Add(new Random().Next(1, 81));
}
//Fillteration 


numbers.Where(x=> x%3==0); //return IEmunurable of elements that matched the condition  
numbers.Any(x => x == 17); //return bool value to determine if there any value matched the given condition
numbers.Find(x=>x == 5); // reuturn the first element that matched the condition otherwise return the deafult of selected data type 
numbers.Distinct();//return the given list with out dublicate
numbers.DistinctBy(x=>x);//reutrn the given list after /fillter depends on the given key (property)

//Ordering - Sorting 
numbers.Order();//return element in asending order
numbers.OrderBy(x=>x);//return element in asending order depends on given key / property
numbers.OrderDescending();//return element in desinging order
numbers.OrderByDescending(x=>x); //return element in desinging order depends on given key / property

//Selecation 
//Exttract Colleaction 
arraye.ToList(); // convert the given dataset to List of the same type 
numbers.ToArray(); //convert the given dataset to Array of the same type 
int t=0 ;
arraye.ToDictionary(x => $"Key {t++}"); //convert the given dataset to Dictionry with value  of the same type but you need to pass the key 

//Get - Extract One Eelemnt 
numbers.First(); // return the first element of the given collection - error (sequence contains no element)
numbers.FirstOrDefault();// return the first element of the given collection - the default value of given collection 
numbers.Single();//return the only one existing element on collection - error (sequence contains no element) - - error (sequence contains more than one  element)
numbers.SingleOrDefault(); //return the only one existing element on collection  - error(sequence contains more than one  element)
numbers.Last();// return the last element of the given collection - error (sequence contains no element)
numbers.LastOrDefault();// return the last element of the given collection - the default value of given collection 

//Aggeragtion Selection
numbers.Count(); // the number of element in given collecation 
numbers.Sum(); // return the summation of all element in given numeric collection 
numbers.Average();// return the aggregation of all element in given numeric collection 
numbers.Max();//return the maximum value in collecation
numbers.Min();//return the minumum value in colleaction

//Pagianation Selection 
numbers.Take(5); // get at maximum the first top  5 element in collection 
numbers.TakeLast(5); // get at maximum the last 5 element in collection 
numbers.TakeWhile(x=>x%3==0);//get element depends on given condition 


numbers.Skip(5); // ignore at maximum the first top  5 element in collection 
numbers.SkipLast(5); // ignore at maximum the last 5 element in collection 
numbers.SkipWhile(x => x % 3 == 0);//ignore element depends on given condition 


/*OOP*/

1- Define Scope 

Scope : Set of Object Intractes with each other with specific 
Operation For Each Kind of object and Specific Proprty to 
Describe each one of them 

2- Define The Mandontry Object (اركان النظام الاساسية التي لايمكن ان يعمل بدونها )


3- Determine The Software Type 

   A- Customized Software 
   B- Genernlized Software 

4- OOP 

  ----> Principles 
      
1- Abstraction (التجريد )اظهار المكون او شيء ما بابسط صورة ممكنه 
   a- Summrize the objects (ايجاد قالب عام يضم او يوصف مجموعه من الكائنات )  
      1- Rerepresent the system object using template (class)     
         (Admin , Employee , Car , Client , Contract , Insurance , Invoices,Rating)
      2- Define Property For Each Template (Class) 
          -Admin  (Name , Email , Password)
          -Client  
          -Employee (Name , Email , Password,Phone,NationalId,Signuture,Postion,Permission)
          -Car (Platno , Brand, Modle , MY , Color )
          -Contract (StartDate, EndDate)
          -Insureance(Type,Amount, Description , StartDate, End Date)
          -Invoice(Amount,Tax,Discount)
          -Rating(Comment , StartAmount)
   b- Define the object Behaviour 
      a- Actor (active users on the system - make changes)  ----> Hummman 99%  , AI / System 1%
      b- Object (Car  , Contract,Insurance,Invoice,Rating)
      c- Lookup  
      
     ----> Determine The Opertions for Each Actor / Each Class / Each Services 
           -----> Determine Return DataType , NameofOperation , Inputs for This Opertation 

   c-  Generlization & Speclization (Restucturing)
        2- Inherintance 
          ----> Determine Relationships between Classes (Assoication , Inhertinace , Composition / Aggergration )
        3- Ploymorephism 
          ----> Implementation With Diffenet Ways (Overload / Override)
        4- Encapsulation 
           ----> Mange The Access Level for Project Components  



/*Exception*/

using static System.Runtime.InteropServices.JavaScript.JSType;
int[] numbers = { 107, 33, 44, 96, 85 };
throw new Exception("Please Try Another Number");
try
{
	int x = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine(numbers[x]);
	if (x == 0)
	{   
		throw new Exception("Please Try Another Number");
		//Console.WriteLine("Please Try Another Number");
	}
	int y = 70 / x;
}
catch (FormatException ex)
{
	Console.WriteLine(ex.Message + "\t Please Enter An Number");

}
catch (IndexOutOfRangeException ex)
{
	Console.WriteLine(ex.Message + "\t Index Must be Less than {0}", numbers.Length);
}
catch (DivideByZeroException ex)
{
	Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
finally {
	Console.WriteLine("Program Complete");
}


/*Async*/
class Program { static async Task Main(string[] args) { Console.WriteLine("جاري استرجاع البيانات..."); string result = await GetDataAsync(); Console.WriteLine(result); } public static async Task<string> GetDataAsync() { await Task.Delay(3000); // محاكاة عملية طويلة return "تم استرجاع البيانات بنجاح!"; } }


/*Generic*/

T GetValueFromUser<T> () {
Object temp = "";
T result;
Console.WriteLine("Please Enter a value :");
String value = Console.ReadLine();
if(typeof(T) == typeof(int))
{
Temp = Convert.ToInt32(value);
}
else if(typeof(T) == typeof(long))
{
Temp = Convert.ToInt64(value);
}
else if(typeof(T) == typeof(string))
{
Temp = Convert.ToString(value);
}
return (T)temp;
}

