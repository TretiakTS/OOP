using MoneyConvertation;
Console.WriteLine("Enter amount of hryvnia");
double hryvnia = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the dollar Rate");
Decimal dollarRate = Decimal.Parse(Console.ReadLine());

Console.WriteLine("Enter the euro Rate");
Decimal euroRate = Decimal.Parse(Console.ReadLine());

Console.WriteLine("Write the amount of dollars");
double dollar = Double.Parse(Console.ReadLine());

Console.WriteLine("Write the amount of euros");
Double euro = Double.Parse(Console.ReadLine());

Converter converter = new Converter(dollarRate, euroRate);

string result = string.Format("{0:f2}", converter.ConvertHryvniaToDollar(hryvnia));
Console.WriteLine("Hryvnia to dollar " + result);

result = string.Format("{0:f2}", converter.ConvertHryvniaToEuro(hryvnia));
Console.WriteLine("Hryvnia to euro " + result);

result = string.Format("{0:f2}", converter.ConvertDollarToHryvnia(dollar));
Console.WriteLine("Dollar to hryvnia" + result);

result = string.Format("{0:f2}", converter.ConvertEuroToHryvnia(euro));
Console.WriteLine("Euro to hryvnia" + result);
