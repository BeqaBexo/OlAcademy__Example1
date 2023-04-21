/*დავალება 1: სახელი და პაროლის შეყვანა და სისწორის ვალიდაცია*/

string username, password;
int ctr = 0;
Console.Write("-----------------------------------------------------\n");
Console.Write("-----------------------------------------------------\n");
Console.Write("-----------------------------------------------------\n");

do
{
    Console.Write("Sheiyvane momxmareblis saxeli: ");
    username = Console.ReadLine();

    Console.Write("sheiyvane paroli: ");
    password = Console.ReadLine();

    if (username != "beka" || password != "1111")
        ctr++;
    else
        ctr = 1;

}
while ((username != "beka" || password != "1111") && (ctr != 5));

if (ctr == 5)
    Console.Write($"\n Momkhmareblis sakheli: '{username}' an paroli: '{password}' _is mnishvneloba aris araswori !\n\n");
else
    Console.Write($"\n sheyvanili monacemebi sworia :)\n\n");
