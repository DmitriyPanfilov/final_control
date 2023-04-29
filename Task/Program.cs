string Prompt(string message) 
{
    System.Console.Write(message);
    string input = Console.ReadLine();
    return input;
}
void ShowArray(string[] array) 
{
    for (int i = 0; i < array.Length; i++) {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}
string[] StringArray() 
{   
    int count = 0;
    string value = String.Empty;
    string[] secondArray = new string[20];
    System.Console.WriteLine($"Введите 'stop' для завершения ввода");
    for (count = 0; value != "stop"; count++) {
        value = Prompt($"Введите {count+1}-ое значение ");
        if (value != "stop") {
            secondArray[count] = value;
        }
    }
    string[] array = new string[count-1];
    for (int i = 0; i < array.Length; i++) {
         array[i] = secondArray[i];
    }
    return array;
}

string[] array = StringArray();
System.Console.Write("Полученные данные: ");
ShowArray(array);













