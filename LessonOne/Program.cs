Console.WriteLine("Enter Your Age:");

static int GetSum(int num1,int num2)
{
    return num1 + num2;
}
//bool IsActive = true;
//string Name = "Joy";
//int Age = 24; //32 bit 
//long LAge = 24;
//float Height = 5.8F;//32bit 
//double DHeight = 5.8F;

string a = Console.ReadLine();
int num1 = Convert.ToInt32(a);
string b = Console.ReadLine();
int num2 = Convert.ToInt32(b);

var Summation = GetSum(num1, num2);
Console.WriteLine("Summation Is:" + Summation);
//if (age < 18)
//{
//    Console.WriteLine("Your are a: Minor");
//}
//else if (age == 18)
//{
//    Console.WriteLine("Your are an:New Adult");
//}
//else
//{
//    Console.WriteLine("Your are an: Adult");

//}

//switch (age)
//{
//    case < 18:
//        Console.WriteLine("You are a: Minor");
//        break;
//    case 18:
//        Console.WriteLine("You are a: New Adult");
//        break;
//    default:
//        Console.WriteLine("You are an: Adult");
//        break;
//}

Console.ReadLine();

//Type Size	Example

//bool	1 byte	bool isActive = true;
//char    2 bytes	char letter = 'A';
//byte    1 byte	byte age = 25;
//sbyte   1 byte	sbyte temperature = -10;
//short   2 bytes	short height = 160;
//ushort  2 bytes	ushort distance = 500;
//int 4 bytes	int salary = 50000;
//uint    4 bytes	uint population = 1000000;
//long    8 bytes	long worldPopulation = 7800000000;
//ulong   8 bytes	ulong fileSize = 10000000000;
//float   4 bytes	float price = 10.5f;
//double  8 bytes	double pi = 3.1415926535;
//decimal 16 bytes	decimal balance = 1000.99m;