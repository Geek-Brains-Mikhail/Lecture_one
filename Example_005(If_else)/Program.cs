Console.Write("Введите имя пользователя:");
string user_name = Console.ReadLine();
if (user_name.ToLower() == "маша"){
    Console.WriteLine("Ура, это же МАША!");
}
else{
    Console.Write("Привет, ");
    Console.WriteLine(user_name);
}