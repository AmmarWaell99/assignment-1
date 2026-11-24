using System;

//Q1
object obj = new Book { Title = "ketab", Pages = 464 };
Console.WriteLine(obj);


//Q2
Book book = new Book { Title = "ketab", Pages = 464 };
Console.WriteLine(book.ToString());
Console.WriteLine(book.Equals(book));
Console.WriteLine(book.GetHashCode());
Console.WriteLine(book.GetType());

//Q3
int pages = 464;
Console.WriteLine(pages);

//Q4
try
{
    int zero = 0; 
    int result = 10 / zero;
    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}

//Q5
int pagesInt = 300;
double pagesDouble = pagesInt;
Console.WriteLine(pagesDouble);

//Q6
double price = 49.99;
int priceInt = (int)price;
Console.WriteLine(priceInt);

//Q7
string pagesText = "464";
int pagesFromText = Convert.ToInt32(pagesText);
Console.WriteLine(pagesFromText);

//Q8
string yearText = "2023";
int year = int.Parse(yearText);
Console.WriteLine(year);

string badText = "abc";
if (int.TryParse(badText, out int number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Invalid number");
}

//Q9
int pages2 = 464;
string pagesString = pages2.ToString();
Console.WriteLine(pagesString);
Console.WriteLine(pagesString.GetType());

//Q10
int copies = 100;
object boxed = copies;
int unboxed = (int)boxed;
Console.WriteLine(boxed);
Console.WriteLine(unboxed);


class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
}
