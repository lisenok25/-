

string? yesNo = "";
while (yesNo.ToLower() != "1" && yesNo.ToLower() != "2")
{
  Console.Write("Хотите ввести данныемассива самостоятельно?\nда-нажмите - 1,\nнет-нажмите - 2- "); //(yes/no):
  yesNo = Console.ReadLine();
}

string[] array = new string[]  {};

if (yesNo.ToLower() == "1") {
Console.Write("Сколько элементов массива вы хотите ввести?  ");
int n = Convert.ToInt32(Console.ReadLine());

  array = new string[n];
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"Введите элемент № {i+1}: ");
    array[i] = Console.ReadLine();
  }
}
else 
{
  array = new string[]  {"888888", "9999999", "444444", "-6"};
}


int lengthLimit = 3;

int elements = CheckArray(array, lengthLimit);

string[] newArray = new string[elements];


FillNewArray(array, newArray, lengthLimit);


void FillNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
  int j = 0;
  for (int i = 0; i < oldArray.Length; i++)
  {
    if (oldArray[i].Length <= lengthLimit)
    {
      newArray[j] = oldArray[i];
      j++;
    }
  }
}

int CheckArray(string[] array, int lengthLimit)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= lengthLimit) result++;
  }
  return result;
}

string ShowArray(string[] array)
{ 
  string result = string.Empty;
  result = "[ ";
  for (int i = 0; i < array.Length; i++)
  {
    result += $"{array[i],1}";
    if (i < array.Length - 1) result += ", ";
  }
  result += " ]";
  return result;
}

Console.WriteLine($"{ShowArray(array)} -> {ShowArray(newArray)}");