// See https://aka.ms/new-console-template for more information
Console.Write("введите имя пользователя: ");

string username = Console.ReadLine();

if (username.ToLower() =="маша"){
    Console.WriteLine("ура, этоже " + username);
}
else{
    Console.WriteLine("привет " + username);
}