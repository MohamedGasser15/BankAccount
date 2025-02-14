using System;
using static System.Console;
using System.Media;


Console.WriteLine("Do You Support Nazi Empire? [y/n]");
string ans = ReadLine();
if (ans == "y")
{
    Nazi(args);
    Console.WriteLine("Welocme to Our Nazi Community");
    Console.WriteLine("Heil Nazi Deutschland !!!!!!");
    Console.WriteLine("Do You Love hitler? [y/n]");
    string ans2 = ReadLine();
    if (ans2 == "y")
    {
        Console.WriteLine("Heil Hitlerrrrrr");
        hitler();
    }
    else
    {
        Console.WriteLine("Fuck You");
    }
}
//======================================================================================================
else if (ans == "n")
{
    Console.WriteLine("Do You Support Soviet Union? [y/n]");
    string ans3 = ReadLine();
    if (ans3 == "y")
    {
        Soviet(args);
        Console.WriteLine("Welcome to Our Communist community");
        Console.WriteLine("Priveeeeet brooooooo !!!!!!");
        Console.WriteLine("Do You Love Stalin? [y/n]");
        string ans4 = ReadLine();
        if (ans4 == "y")
        {
            Console.WriteLine("Hell Yeahhhh");
        }
        else
        {
            Console.WriteLine("Fuck You");
        }
    }
    //======================================================================================================

    else if (ans3 == "n")
    {
        Console.WriteLine("Do You Support British empire? [y/n]");
        string ans5 = ReadLine();
        if (ans5 == "y")
        {
            British(args);
            Console.WriteLine("Welcome To Our British Comunity");
            Console.WriteLine("Do You Love Queen Elizabeth? [y/n]");
            string ans6 = ReadLine();
            if (ans6 == "y")
            {
                Console.WriteLine("Hell Yeah");
            }
            else
            {
                Console.WriteLine("Go To The Hell");
            }
        }
    }
}
else
{
    Console.WriteLine("Fuck Your Self ");
}
static void Nazi(string[] args)
{
    if (OperatingSystem.IsWindows())
    {
        SoundPlayer SpookPlayer = new SoundPlayer("German.wav");
        SpookPlayer.PlayLooping();
    }
    Console.OutputEncoding = System.Text.Encoding.UTF8;


    ForegroundColor = ConsoleColor.White;
    WriteLine(@"
                       ⣿⣿⣿⣿⣿⣿⣿⣿⠟⠛⠉⣩⣍⠉⠛⠻⣿⣿⣿⣿⣿⣿⣿
                       ⣿⣿⣿⣿⣿⠋⠀⠀⣠⣾⣿⠟⠁⠀⠀⠀⠙⣿⣿⣿⣿⣿⣿ 
                       ⣿⣿⣿⣿⠁⠀⠀⢾⣿⣟⠁⠀⣠⣾⣷⣄⠀⠘⣿⣿⣿⣿⣿ 
                       ⣿⣿⣿⡇⣠⣦⡀⠀⠙⢿⣷⣾⡿⠋⠻⣿⣷⣄⢸⣿⣿⣿⣿ 
                       ⣿⣿⣿⡇⠙⢿⣿⣦⣠⣾⡿⢿⣷⣄⠀⠈⠻⠋⢸⣿⣿⣿⣿ 
                       ⣿⣿⣿⣿⡀⠀⠙⢿⡿⠋⠀⢀⣽⣿⡷⠀⠀⢠⣿⣿⣿⣿⣿ 
                       ⣿⣿⣿⣿⣿⣄⠀⠀⠀⢀⣴⣿⡿⠋⠀⠀⣠⣿⣿⣿⣿⣿⣿ 
                       ⣿⣿⣿⣿⣿⣿⣿⣦⣤⣀⣙⣋⣀⣤⣴⣿⣿⣿⣿⣿⣿⣿⣿ 

            ");
    ForegroundColor = ConsoleColor.DarkRed;
}
static void hitler()
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;


    ForegroundColor = ConsoleColor.White;
    WriteLine(@"
                       ⣿⣿⣿⣿⣿⣿⣿⣿⠟⠛⠉⣩⣍⠉⠛⠻⣿⣿⣿⣿⣿⣿⣿
                       ⣿⣿⣿⣿⣿⠋⠀⠀⣠⣾⣿⠟⠁⠀⠀⠀⠙⣿⣿⣿⣿⣿⣿ 
                       ⣿⣿⣿⣿⠁⠀⠀⢾⣿⣟⠁⠀⣠⣾⣷⣄⠀⠘⣿⣿⣿⣿⣿ 
                       ⣿⣿⣿⡇⣠⣦⡀⠀⠙⢿⣷⣾⡿⠋⠻⣿⣷⣄⢸⣿⣿⣿⣿ 
                       ⣿⣿⣿⡇⠙⢿⣿⣦⣠⣾⡿⢿⣷⣄⠀⠈⠻⠋⢸⣿⣿⣿⣿ 
                       ⣿⣿⣿⣿⡀⠀⠙⢿⡿⠋⠀⢀⣽⣿⡷⠀⠀⢠⣿⣿⣿⣿⣿ 
                       ⣿⣿⣿⣿⣿⣄⠀⠀⠀⢀⣴⣿⡿⠋⠀⠀⣠⣿⣿⣿⣿⣿⣿ 
                       ⣿⣿⣿⣿⣿⣿⣿⣦⣤⣀⣙⣋⣀⣤⣴⣿⣿⣿⣿⣿⣿⣿⣿ 

            ");
    ForegroundColor = ConsoleColor.DarkRed;
}
static void Soviet(string[] args)
{
    if (OperatingSystem.IsWindows())
    {
        SoundPlayer soviet = new SoundPlayer("C:\\Users\\HiTecH\\source\\repos\\ConsoleApp1\\ConsoleApp1\\soviet.wav");
        soviet.PlayLooping();
    }
    ForegroundColor = ConsoleColor.White;
    WriteLine(@"
                                                          ,           ^'^  _
                                                          )               (_) ^'^
                     _/\_                    .---------. ((        ^'^
                     (('>                    )`'`'`'`'`( ||                 ^'^
                _    /^|                    /`'`'`'`'`'`\||           ^'^
                =>--/__|m---               /`'`'`'`'`'`'`\|
                     ^^           ,,,,,,, /`'`'`'`'`'`'`'`\      ,
                                 .-------.`|`````````````|`  .   )
                                / .^. .^. \|  ,^^, ,^^,  |  / \ ((
                               /  |_| |_|  \  |__| |__|  | /,-,\||
                    _         /_____________\ |')| |  |  |/ |_| \|
                   (')         |  __   __  |  '==' '=='  /_______\     _
                  (' ')        | /  \ /  \ |   _______   |,^, ,^,|    (')
                   \  \        | |--| |--| |  ((--.--))  ||_| |_||   (' ')
                 _  ^^^ _      | |__| |('| |  ||  |  ||  |,-, ,-,|   /  /
               ,' ',  ,' ',    |           |  ||  |  ||  ||_| |_||   ^^^
            .,,|RIP|,.|RIP|,.,,'==========='==''=='==''=='=======',,....,,,,.,ldb

            ");
    ForegroundColor = ConsoleColor.White;
}
static void British(string[] args)
{
    if (OperatingSystem.IsWindows())
    {
        SoundPlayer british = new SoundPlayer("C:\\Users\\HiTecH\\source\\repos\\ConsoleApp1\\ConsoleApp1\\British.wav");
        british.PlayLooping();
        ForegroundColor = ConsoleColor.Blue;
        WriteLine(@"
                                                          ,           ^'^  _
                                                          )               (_) ^'^
                     _/\_                    .---------. ((        ^'^
                     (('>                    )`'`'`'`'`( ||                 ^'^
                _    /^|                    /`'`'`'`'`'`\||           ^'^
                =>--/__|m---               /`'`'`'`'`'`'`\|
                     ^^           ,,,,,,, /`'`'`'`'`'`'`'`\      ,
                                 .-------.`|`````````````|`  .   )
                                / .^. .^. \|  ,^^, ,^^,  |  / \ ((
                               /  |_| |_|  \  |__| |__|  | /,-,\||
                    _         /_____________\ |')| |  |  |/ |_| \|
                   (')         |  __   __  |  '==' '=='  /_______\     _
                  (' ')        | /  \ /  \ |   _______   |,^, ,^,|    (')
                   \  \        | |--| |--| |  ((--.--))  ||_| |_||   (' ')
                 _  ^^^ _      | |__| |('| |  ||  |  ||  |,-, ,-,|   /  /
               ,' ',  ,' ',    |           |  ||  |  ||  ||_| |_||   ^^^
            .,,|RIP|,.|RIP|,.,,'==========='==''=='==''=='=======',,....,,,,.,ldb

            ");
        ForegroundColor = ConsoleColor.Blue;
    }
}