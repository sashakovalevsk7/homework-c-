
/*Console.clear();
Console.Write("Введи трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string x = Convert.ToString(a);
Console.WriteLine("вторая цифра этого числа -> "+x[1]);*/




/*Console.Write("Введи число: ");
int array = Convert.ToInt32(Console.ReadLine());
string a = Convert.ToString(array);
if (a.Length > 2){
  Console.WriteLine("третья цифра - " + a[2]);
}
else {
  Console.WriteLine(" третьей цифры нет");
}*/



Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void a (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("этот день не выходной");
}

a(dayNumber);