using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Diagnostics;
using System.Collections.Generic;

namespace Random_Console_App
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            Console.WriteLine("                     Welcome to 2ezlma0's console !!!    " +
                            "\n                                                         " +
                            "\n     1. Random pattern generator                         " +
                            "\n     2. Encryption of a text file with 2ez's encryption  " +
                            "\n     3. Decryption of a text file with 2ez's encryption  " +
                            "\n     4. Sound Player                                     " +
                            "\n     5. Quadratic Solver                                 " +
                            "\n     6. Random number generator                          " +
                            "\n     7. Specfic size file creator                        " +
                            "\n     8. Don't use this one please                        " +
                            "\n     9. Calculator                                       ");
            string num = Console.ReadLine();
            if (num == "1")
            {
                one();
            }
            if (num == "2")
            {
                two();
            }
            if (num == "3")
            {
                three();
            }
            if(num == "4")
            {
                four();
            }
            if(num == "5")
            {
                five();
            }
            if(num == "6")
            {
                six();
            }
            if(num == "7")
            {
                seven();
            }
            if(num == "8")
            {
                eight();
            }
            if(num == "9")
            {
                nine();
            }
        }

        public static void one()
        {
            bool loop = true;
            string a, b, c, d, e, f, g, h, i, j, k, l, m, n, o;

            Console.Clear();
            do
            {
                a = randPattern();
                b = randPattern();
                c = randPattern();
                d = randPattern();
                e = randPattern();
                f = randPattern();
                g = randPattern();
                h = randPattern();

                i = randPattern();
                j = randPattern();
                k = randPattern();
                l = randPattern();
                m = randPattern();
                n = randPattern();
                o = randPattern();
                Console.WriteLine(a + b + c + d + e + f + g + h + i + j + k + l + m + n + o);
            }
            while (loop != false);           
        }

        public static void two()
        {
            Console.Clear();    
            Console.WriteLine("Please write the path of the text file");
            string path = Console.ReadLine();
            string textContents = File.ReadAllText(path).ToLower();
            //Console.WriteLine(textContents);
            //Console.ReadLine();
            string encryptKey = "";
            var rand = new Random();
            string[] textArray = new string[textContents.Length];
            
            /*string debugText = "";
            for (int x = 0; x < textArray.Length; x++)
            {
                debugText += textArray[x];
            }*/

            for (int encrypt = 0; encrypt < textContents.Length; encrypt++)
            {               
                switch (textContents[encrypt])
                {
                    case 'a':
                        textArray[encrypt] = "2";
                        encryptKey += "0";
                        break;
                       
                    case 'b':
                        textArray[encrypt] = "2";
                        encryptKey += "1";
                        break;

                    case 'c':
                        textArray[encrypt] = "o";
                        encryptKey += "0";
                        break;

                    case 'd':
                        textArray[encrypt] = "o";
                        encryptKey += "1";
                        break;
                        
                    case 'e':
                        textArray[encrypt] = "-";
                        encryptKey += "1";
                        break;

                    case 'f':
                        textArray[encrypt] = "-";
                        encryptKey += "0";
                        break;

                    case 'g':
                        textArray[encrypt] = "3";
                        encryptKey += "1";
                        break;

                    case 'h':
                        textArray[encrypt] = "3";
                        encryptKey += "0";
                        break;

                    case 'i':
                        textArray[encrypt] = "'";
                        encryptKey += "0";
                        break;

                    case 'j':
                        textArray[encrypt] = "'";
                        encryptKey += "1";
                        break;
                    
                    case 'k':
                        textArray[encrypt] = "9";
                        encryptKey += "1";
                        break;

                    case 'l':
                        textArray[encrypt] = "9";
                        encryptKey += "0";
                        break;

                    case 'm':
                        textArray[encrypt] = ")";
                        encryptKey += "1";
                        break;

                    case 'n':
                        textArray[encrypt] = ")";
                        encryptKey += "0";
                        break;

                    case 'o':
                        textArray[encrypt] = "<";
                        encryptKey += "0";
                        break;

                    case 'p':
                        textArray[encrypt] = "<";
                        encryptKey += "1";
                        break;

                    case 'q':
                        textArray[encrypt] = "@";
                        encryptKey += "0";
                        break;

                    case 'r':
                        textArray[encrypt] = "@";
                        encryptKey += "1";
                        break;

                    case 's':
                        textArray[encrypt] = "6";
                        encryptKey += "0";
                        break;

                    case 't':
                        textArray[encrypt] = "6";
                        encryptKey += "1";
                        break;

                    case 'u':
                        textArray[encrypt] = "$";
                        encryptKey += "0";
                        break;

                    case 'v':
                        textArray[encrypt] = "$";
                        encryptKey += "1";
                        break;

                    case 'w':
                        textArray[encrypt] = "]";
                        encryptKey += "1";
                        break;

                    case 'x':
                        textArray[encrypt] = "]";
                        encryptKey += "0";
                        break;

                    case 'y':
                        textArray[encrypt] = "£";
                        encryptKey += "1";
                        break;

                    case 'z':
                        textArray[encrypt] = "£";
                        encryptKey += "0";
                        break;

                    case '1':
                        textArray[encrypt] = ":";
                        encryptKey += "0";
                        break;

                    case '2':
                        textArray[encrypt] = ":";
                        encryptKey += "1";
                        break;

                    case '3':
                        textArray[encrypt] = "#";
                        encryptKey += "0";
                        break;

                    case '4':
                        textArray[encrypt] = "#";
                        encryptKey += "1";
                        break;

                    case '5':
                        textArray[encrypt] = "|";
                        encryptKey += "1";
                        break;

                    case '6':
                        textArray[encrypt] = "|";
                        encryptKey += "0";
                        break;

                    case '7':
                        textArray[encrypt] = "i";
                        encryptKey += "0";
                        break;

                    case '8':
                        textArray[encrypt] = "i";
                        encryptKey += "1";
                        break;

                    case '9':
                        textArray[encrypt] = ".";
                        encryptKey += "0";
                        break;

                    case '0':
                        textArray[encrypt] = ".";
                        encryptKey += "1";
                        break;

                    case '?':
                        textArray[encrypt] = "J";
                        encryptKey += "0";
                        break;

                    case '.':
                        textArray[encrypt] = "J";
                        encryptKey += "1";
                        break;

                    case ',':
                        textArray[encrypt] = "1";
                        encryptKey += "1";
                        break;

                    case '!':
                        textArray[encrypt] = "1";
                        encryptKey += "0";
                        break;

                    case '£':
                        textArray[encrypt] = "&";
                        encryptKey += "1";
                        break;

                    case '$':
                        textArray[encrypt] = "&";
                        encryptKey += "0";
                        break;

                    case '/':
                        textArray[encrypt] = "5";
                        encryptKey += "0";
                        break;

                    case '@':
                        textArray[encrypt] = "5";
                        encryptKey += "1";
                        break;

                    case ':':
                        textArray[encrypt] = "M";
                        encryptKey += "0";
                        break;

                    case ';':
                        textArray[encrypt] = "M";
                        encryptKey += "1";
                        break;

                    case ' ':
                        textArray[encrypt] = " ";
                        encryptKey += "2";
                        break;  
                }
            }

            string textToWrite = "";
            for(int x = 0; x < textArray.Length; x++)
            {
                textToWrite += textArray[x];
            }

            string randTitle = Convert.ToString(rand.Next(-400200, 69420));
            string encryptPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), randTitle + "encrypt.txt");
            string encryptKeyPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), randTitle + "encryptKey.txt");
            File.WriteAllText(encryptPath, textToWrite);
            encryptKey += "\n" + encryptPath;
            File.WriteAllText(encryptKeyPath, encryptKey);
            Console.WriteLine("Exported to " + encryptPath + " and " + encryptKeyPath + "\nPress enter to close the console");
            Console.ReadLine();
        }

        public static void three()
        {
            Console.Clear();
            Console.WriteLine("Please enter the path of the text file wanted to be decrypted");
            string path = Console.ReadLine();
            string encryptedText = File.ReadAllText(path);
            string[] textArray = new string[encryptedText.Length];
            Console.WriteLine("Please copy and paste the encryption key here");
            string encryptKeyString = Console.ReadLine();

            for (int encrypt = 0; encrypt < encryptKeyString.Length; encrypt++)
            {
                if (encryptKeyString[encrypt] == '0')
                {
                    switch (encryptedText[encrypt])
                    {
                        case '2':
                            textArray[encrypt] = "a";
                            break;

                        case 'o':
                            textArray[encrypt] = "c";
                            break;

                        case '-':
                            textArray[encrypt] = "f";
                            break;

                        case '3':
                            textArray[encrypt] = "h";
                            break;

                        case '\'':
                            textArray[encrypt] = "i";
                            break;

                        case '9':
                            textArray[encrypt] = "l";
                            break;

                        case ')':
                            textArray[encrypt] = "n";
                            break;

                        case '<':
                            textArray[encrypt] = "o";
                            break;

                        case '@':
                            textArray[encrypt] = "q";
                            break;

                        case '6':
                            textArray[encrypt] = "s";
                            break;

                        case '$':
                            textArray[encrypt] = "u";
                            break;

                        case ']':
                            textArray[encrypt] = "x";
                            break;

                        case '£':
                            textArray[encrypt] = "z";
                            break;

                        case ':':
                            textArray[encrypt] = "1";
                            break;

                        case '#':
                            textArray[encrypt] = "3";
                            break;

                        case '|':
                            textArray[encrypt] = "6";
                            break;

                        case 'i':
                            textArray[encrypt] = "7";
                            break;

                        case '.':
                            textArray[encrypt] = "9";
                            break;

                        case 'J':
                            textArray[encrypt] = "?";
                            break;

                        case '1':
                            textArray[encrypt] = "!";
                            break;

                        case '&':
                            textArray[encrypt] = "$";
                            break;

                        case '5':
                            textArray[encrypt] = "/";
                            break;

                        case 'M':
                            textArray[encrypt] = ":";
                            break;

                        default:
                            textArray[encrypt] = " ";
                            break;
                    }
                }
                else if (encryptKeyString[encrypt] == 2)
                {
                    textArray[encrypt] = " ";
                }
                else
                {
                    switch (encryptedText[encrypt])
                    {
                        case '2':
                            textArray[encrypt] = "b";
                            break;

                        case 'o':
                            textArray[encrypt] = "d";
                            break;

                        case '-':
                            textArray[encrypt] = "e";
                            break;

                        case '3':
                            textArray[encrypt] = "g";
                            break;

                        case '\'':
                            textArray[encrypt] = "j";
                            break;

                        case '9':
                            textArray[encrypt] = "k";
                            break;

                        case ')':
                            textArray[encrypt] = "m";
                            break;

                        case '<':
                            textArray[encrypt] = "p";
                            break;

                        case '@':
                            textArray[encrypt] = "r";
                            break;

                        case '6':
                            textArray[encrypt] = "t";
                            break;

                        case '$':
                            textArray[encrypt] = "v";
                            break;

                        case ']':
                            textArray[encrypt] = "w";
                            break;

                        case '£':
                            textArray[encrypt] = "y";
                            break;

                        case ':':
                            textArray[encrypt] = "2";
                            break;

                        case '#':
                            textArray[encrypt] = "4";
                            break;

                        case '|':
                            textArray[encrypt] = "5";
                            break;

                        case 'i':
                            textArray[encrypt] = "8";
                            break;

                        case '.':
                            textArray[encrypt] = "0";
                            break;

                        case 'J':
                            textArray[encrypt] = ".";
                            break;

                        case '1':
                            textArray[encrypt] = ",";
                            break;

                        case '%':
                            textArray[encrypt] = "£";
                            break;

                        case '5':
                            textArray[encrypt] = "@";
                            break;

                        case 'M':
                            textArray[encrypt] = ";";
                            break;

                        default:
                            textArray[encrypt] = " ";
                            break;
                    }
                }               
            }
            
            string textToWrite = "";
            for (int x = 0; x < textArray.Length; x++)
            {
                textToWrite += textArray[x];
            }
            var rand = new Random();
            string randTitle = Convert.ToString(rand.Next(-400200, 69420));
            string decryptPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), randTitle + "decrypt.txt");
            File.WriteAllText(decryptPath, textToWrite);
            Console.WriteLine("Exported to " + decryptPath + "\nPress enter to close the console");
            Console.ReadLine();
        }

        public static void four()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            bool containsExtension = false;

            Console.Clear();
            Console.WriteLine("Please store the sound file in " + docPath + " before continuing, press enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter the name of the file you want played INCLUDING the file extension (.mp4, .wav etc)");
            string file = Console.ReadLine();
            containsExtension = containsExtensionCheck(file);

            while (!containsExtension)
            {
                Console.WriteLine("\nFile does not contain the extension, or you forgot to put the '.', please re-enter the file name");
                file = Console.ReadLine();
                containsExtension = containsExtensionCheck(file);
            }

            SoundPlayer soundPlayer = new SoundPlayer(Path.Combine(docPath, file));
            Console.WriteLine("Sound player created, press 'p' to play your sound, and press enter to exit the application");
            bool exit = false;
            
            while (!exit)
            {
                if(Console.ReadKey().Key == ConsoleKey.P)
                {
                    soundPlayer.Play();
                }
                
                if(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    exit = true;
                }
            }           
        }

        public static void five()
        {
            Console.Clear();
            Console.WriteLine("This only supports quadratics with the basic format of ax^2+bx+c");
            Console.WriteLine("\nPlease enter the quadratic in the form ax^2+bx+c, make sure all letters have a value \n(e.g. instead of x^2+x+5 write it as 1x^2+1x+5)");
            string quadraticString = Console.ReadLine();
            double[] abc = quadraticABC(quadraticString);
            double a = abc[0];
            double b = abc[1];
            double c = abc[2];
            double temp1 = Math.Pow(b,2);
            double temp2 = 4 * a * c;
            double temp3 = temp1 - temp2;   //b^2-4ac
            double temp4 = Math.Sqrt(temp3); 
            double temp5 = -b + temp4;
            double temp6 = -b - temp4;
            double temp7 = 2 * a; 
            double quadraticAnswer1 = temp5 / temp7;
            double quadraticAnswer2 = temp6 / temp7;
            Console.WriteLine("\n\n\nValues of x are: " + quadraticAnswer1 + " and " + quadraticAnswer2);
            Console.ReadLine();
        }

        public static void six()
        {
            var rand = new Random();
            int output = 0;
            double decOutput = 0;
            double doubleOutput = 0;
            bool finished = false;
            string outputString = "";
            string decOutputString = "";
            string randomFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Random Numbers");

            if (!Directory.Exists(randomFolder))
            {
                Directory.CreateDirectory(randomFolder);
            }
            else
            {
                Console.WriteLine("Random number folder already found, continuing...\n");
            }

            while (!finished)
            {
                bool randDec = false;
                string numbers = "";
                string decNumbers = "";
                Console.WriteLine("\nThis program generates random numbers between two specified whole numbers.");
                Console.WriteLine("If you want to generate random decimals between 0 and 1, please press '1', otherwise press enter");
                string one = Console.ReadLine();
                if (one == "1")
                {
                    randDec = true;
                }
                if (!randDec)
                {
                    Console.WriteLine("\nThis program generates random numbers between two specified whole numbers");
                    Console.WriteLine("Please enter number 1:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter number 2:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many random numbers do you want generated?");
                    int genAmount = Convert.ToInt32(Console.ReadLine());
                    int fileAmount = genAmount;
                    if (num1 > num2)
                    {
                        int num3 = num2;
                        num2 = num1;
                        num1 = num3;
                    }
                    while (genAmount > 0)
                    {
                        output = rand.Next(num1, num2);
                        Console.WriteLine(output);
                        genAmount--;
                        outputString = Convert.ToString(output);
                        numbers += outputString + " ";
                    }
                    Console.WriteLine("Do you want to export as a txt file? Y/N");
                    string yn = Console.ReadLine();
                    if (yn == "Y")
                    {
                        string docs = Path.Combine(randomFolder, fileAmount + " random numbers between " + num1 + " and " + num2 + ".txt");
                        File.WriteAllText(docs, numbers);
                        Console.WriteLine("File created at " + docs);
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        Console.WriteLine("Do you want to open the file? Y/N");
                        string open = Console.ReadLine();
                        if (open == "Y")
                        {
                            Process.Start("notepad.exe", docs);
                        }
                        Console.WriteLine("Do you want to use again? Y/N");
                    }
                    else
                    {
                        Console.WriteLine("Do you want to use again? Y/N");
                    }
                    string rerun = Console.ReadLine();
                    if (rerun == "N")
                    {
                        finished = true;
                    }
                }
                if (randDec)
                {
                    Console.WriteLine("\nThis program generated random decimal numbers between 0 and 1");
                    Console.WriteLine("Please enter how many decimal places are needed:");
                    int decimalPlaces = Convert.ToInt32(Console.ReadLine());
                    double randDecPlaces = Math.Pow(10, decimalPlaces + 1);
                    Console.WriteLine("Please enter how many numbers you want generated:");
                    int decAmount = Convert.ToInt32(Console.ReadLine());
                    int decFileAmount = decAmount;
                    while (decAmount > 0)
                    {
                        decOutput = rand.Next(0, Convert.ToInt32(randDecPlaces));
                        doubleOutput = decOutput / randDecPlaces;
                        Console.WriteLine(doubleOutput);
                        decAmount--;
                        decOutputString = Convert.ToString(doubleOutput);
                        decNumbers += decOutputString + " ";
                    }
                    Console.WriteLine("Do you want to export as a txt file? Y/N");
                    string yn = Console.ReadLine();
                    if (yn == "Y")
                    {
                        string decDocs = Path.Combine(randomFolder, decFileAmount + " random decimals.txt");
                        File.WriteAllText(decDocs, decNumbers);
                        Console.WriteLine("File created at " + decDocs);
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        Console.WriteLine("Do you want to open the file? Y/N");
                        string decOpen = Console.ReadLine();
                        if (decOpen == "Y")
                        {
                            Process.Start("notepad.exe", decDocs);
                        }
                        Console.WriteLine("Do you want to use again? Y/N");
                    }
                    else
                    {
                        Console.WriteLine("Do you want to use again? Y/N");
                    }
                    string rerun = Console.ReadLine();
                    if (rerun == "N")
                    {
                        finished = true;
                    }
                }
            }
        }

        public static void seven()
        {
            Random rand = new Random(); 
            Console.Clear();
            Console.WriteLine("This program creates a file with the specified file size");
            Console.WriteLine("Please enter the size of the file in kb (1000kb = 1mb)");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter the path of the file INCLUDING the name of the file (end it in .txt) or leave blank for it to be stored in documents");
            string path = Console.ReadLine();
            if (path == "")
            {
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), rand.Next() + ".txt");
            }
            size *= 1000;
            File.WriteAllBytes(path, new byte[size]);
            Console.Clear();
            Console.WriteLine("File created at " + path);
            Console.ReadLine();
        }

        public static void eight()
        {
            var rand = new Random();
            bool lol = true;
            string[] path = new string[] { Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) };
            Console.WriteLine("Continuing...");
            while (lol)
            {
                File.WriteAllBytes(Path.Combine(path[rand.Next(0, 4)], Convert.ToString(rand.Next())), new byte[123456789]);
                Console.WriteLine("Created a file somewhere ;3");
            }
        }

        public static void nine()
        {
            Console.Clear();
            Console.WriteLine("Write your equation here (multiply symbol is '*', divide symbol is '/'), end your equation with the character 'E'");
            string equation = Console.ReadLine();
            while (!Char.IsDigit(equation[0]) || equation[equation.Length - 1] != 'E')
            {
                Console.WriteLine("Starting character and/or ending character isnt a number, please enter a valid equation");
                equation = Console.ReadLine();
            }
            int answer = EquationSolver(equation);
            Console.WriteLine("\n" + Convert.ToString(answer));
            Console.Read();
        }

        public static int EquationSolver(string equation)
        {
            List<int> numbers = new List<int>(); //list to store the numbers in the equation
            List<int> symbols = new List<int>(); //list to store the symbols in the equation, stored in BIDMAS order (4 is /, 3 is *, 2 is +, 1 is -)
            string tempNum = "";
            bool isSymbol = false; //default false because first character shouldnt be a number
            
            for(int i = 0; i < equation.Length; i++) //taking and storing the numbers and symbols from the equation
            {
                if(!isSymbol)
                {
                    tempNum += equation[i];
                    if(!Char.IsDigit(equation[i+1]))
                    {
                        numbers.Add(Convert.ToInt32(tempNum));
                        isSymbol = true;
                        tempNum = "";
                    }
                }
                else
                {
                    if(equation[i] == '/')
                        symbols.Add(4);
                    else if (equation[i] == '*')
                        symbols.Add(3);
                    else if (equation[i] == '+')
                        symbols.Add(2);
                    else if (equation[i] == '-')
                        symbols.Add(1);

                    isSymbol = false; //assumes the next character isnt a symbol because it shouldnt be and if it is then they dont know math
                }
            }

            List<int> order = new List<int>(); //to work out the order of operation

            for(int i = 0; i < symbols.Count; i++)
            {
               if(symbols[i] == 4)
               {
                    order.Add(i);
               }
            }

            for (int i = 0; i < symbols.Count; i++)
            {
                if (symbols[i] == 3)
                {
                    order.Add(i);
                }
            }

            for (int i = 0; i < symbols.Count; i++)
            {
                if (symbols[i] == 2)
                {
                    order.Add(i);
                }
            }

            for (int i = 0; i < symbols.Count; i++)
            {
                if (symbols[i] == 1)
                {
                    order.Add(i);
                }
            }

            int answer = 0;
            int tempAnswer = 0;
            bool firstRun = false;
            int tempOrder = -1;
            bool different = false;
            bool end = false;
            int tempEnd = -1;
            for(int i = 0; i < order.Count; i++)
            {
                if (!firstRun)
                {
                    if (symbols[order[i]] == 4)
                    {
                        answer = numbers[order[i]] / numbers[order[i] + 1];
                        firstRun = true;
                        tempOrder = order[i];
                    }
                    if (symbols[order[i]] == 3)
                    {
                        answer = numbers[order[i]] * numbers[order[i] + 1];
                        firstRun = true;
                        tempOrder = order[i];
                    }
                    if (symbols[order[i]] == 2)
                    {
                        answer = numbers[order[i]] + numbers[order[i] + 1];
                        firstRun = true;
                        tempOrder = order[i];
                    }
                    if (symbols[order[i]] == 1)
                    {
                        answer = numbers[order[i]] - numbers[order[i] + 1];
                        firstRun = true;
                        tempOrder = order[i];
                    }
                }
                else if (symbols[order[i]] == 2)
                {
                    if (different && tempOrder - order[i] == 1 || different && order[i] - tempOrder == 1)
                    {
                        if (tempOrder < order[i])
                            tempAnswer = tempAnswer + numbers[order[i] + 1];
                        else
                            tempAnswer = tempAnswer + numbers[order[i]];
                    }
                    else
                    {
                        if (tempOrder < order[i])
                            answer = answer + numbers[order[i] + 1];
                        else
                            answer = answer + numbers[order[i]];
                    }
                }
                else if (symbols[order[i]] == 1)
                {
                    if (different && tempOrder - order[i] == 1 || different && order[i] - tempOrder == 1)
                    {
                        if (tempOrder < order[i])
                            tempAnswer = tempAnswer - numbers[order[i] + 1];
                        else
                            tempAnswer = tempAnswer - numbers[order[i]];
                    }
                    else
                    {
                        if (tempOrder < order[i])
                            answer = answer - numbers[order[i] + 1];
                        else
                            answer = answer - numbers[order[i]];
                    }
                }
                else if (tempOrder - order[i] > 1 || order[i] - tempOrder > 1)
                {
                    if (symbols[order[i]] == 4)
                    {
                        if (tempOrder < order[i])
                            tempAnswer = numbers[order[i]] / numbers[order[i] + 1];
                        else
                            tempAnswer = numbers[order[i - 1]] / numbers[order[i]];
                    }
                    if (symbols[order[i]] == 3)
                    {
                        if (tempOrder < order[i])
                            tempAnswer = numbers[order[i]] * numbers[order[i] + 1];
                        else
                            tempAnswer = numbers[order[i - 1]] * numbers[order[i]];
                    }

                    tempEnd = order[i];
                    different = true;
                    end = true;
                }
                else
                {
                    if (different && tempOrder - order[i] == 1 || different && order[i] - tempOrder == 1)
                    {
                        if (symbols[order[i]] == 4)
                        {
                            if (tempOrder < order[i])
                                tempAnswer = tempAnswer / numbers[order[i] + 1];
                            else
                                tempAnswer = tempAnswer / numbers[order[i]];
                        }
                        if (symbols[order[i]] == 3)
                        {
                            if (tempOrder < order[i])
                                tempAnswer = tempAnswer * numbers[order[i] + 1];
                            else
                                tempAnswer = tempAnswer * numbers[order[i]];
                        }

                        different = false;
                    }
                    else
                    {
                        if (symbols[order[i]] == 4)
                        {
                            if (tempOrder < order[i])
                                answer = answer / numbers[order[i] + 1];
                            else
                                answer = answer / numbers[order[i]];
                        }
                        if (symbols[order[i]] == 3)
                        {
                            if (tempOrder < order[i])
                                answer = answer * numbers[order[i] + 1];
                            else
                                answer = answer * numbers[order[i]];
                        }
                    }

                    tempOrder = order[i];                   
                }
                if(i == order.Count - 1 && end)
                {
                    if (symbols[order[i]] == 4)
                    {
                        if (tempEnd < order[i])
                            answer = tempAnswer / answer;
                        else
                            answer = answer / tempAnswer;
                    }
                    if (symbols[order[i]] == 3)
                    {
                        if (tempEnd < order[i])
                            answer = tempAnswer * answer;
                        else
                            answer = answer * tempAnswer;
                    }
                    if (symbols[order[i]] == 2)
                    {
                        answer += tempAnswer; //addition doesnt matter for what order it is 
                    }
                    if (symbols[order[i]] == 1)
                    {
                        if (tempEnd < order[i])
                            answer = tempAnswer - answer;
                        else
                            answer = answer - tempAnswer;
                    }
                }
            }


            return answer;

            /* Console.Read(); //debug
            return 0; //debug

            bool sorted = false; //assume it isnt sorted into BIDMAS already
            int count = 0; //count of sorts (if the value is 0 by end of for loop then it should be sorted)
            
            (!sorted)
            {
                for (int i = 0; i < symbols.Count - 1; i++) //sorts the lists to fit BIDMAS (this is why we used the numbers for symbols earlier)
                {
                    if (symbols[i] < symbols[i + 1])
                    {
                        int tempSort1 = symbols[i];
                        symbols[i] = symbols[i + 1];
                        symbols[i + 1] = tempSort1; //swapped symbols

                        int tempSort2 = numberIndexes[i];
                        numberIndexes[i] = numberIndexes[i + 1];
                        numberIndexes[i + 1] = tempSort2; //swapped number indexes


                        int tempSort2 = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = numbers[i + 2];
                        numbers[i + 2] = tempSort2; //swapped numbers (example: 3 + 5 / 2, 5 replaces 3, 2 replaces 5 and 3 replaces 2, turns into 5 / 2 + 3)
                        

                        count++; //as we changed something, assume still not sorted until nothing gets changed at all
                    }
                }

                if(count == 0)
                {
                    sorted = true; //if nothing got changed its sorted
                }
                else
                {
                    count = 0; //reset sorting count for next rerun
                }
            }
                

            Console.Read(); //debug 2
            return 0; //debug 2

             count = 0;
            int[] characters = new int[equation.Length];
            int[] symbols = new int[equation.Length];   //1 is -, 2 is +, 3 is *, 4 is /
            for(int i = 0; i < equation.Length; i++)
            {
                if(!Char.IsDigit(equation[i]))
                {
                    characters[count] = i;
                    if (equation[i] == '-')
                        symbols[count] = 1;
                    if (equation[i] == '+')
                        symbols[count] = 2;
                    if (equation[i] == '*')
                        symbols[count] = 3;
                    if (equation[i] == '/')
                        symbols[count] = 4;

                    count++;
                }                
            }
            count--;
            int[] numbers = new int[count + 1];
            int amount = count;
            count = 0;
            string temp = "";
            for (int i = 0; equation[i] != 'E'; i++)
            {
                if (i != 0)
                {
                    if (characters.Contains(i) || equation[i + 1] == 'E')
                    {
                        numbers[count] = Convert.ToInt32(temp);
                        count++;
                        temp = "";
                    }
                }
                
                if(i == 0 || !characters.Contains(i) && equation[i + 1] != 'E')
                {
                    temp += Convert.ToString(equation[i]);
                }
            }
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < amount - 1; i++)
                {
                    if (symbols[i] < symbols[i + 1])
                    {
                        int tmp = symbols[i];
                        int tmp2 = numbers[i + 1];
                        numbers[i + 1] = numbers[i + 2];
                        numbers[i + 2] = tmp2;
                        symbols[i] = symbols[i + 1];
                        symbols[i + 1] = tmp;
                        sorted = false;
                    }
                }
            }
            int answer = 0;
            for(int i = 0; i < amount; i++)
            {
                if (symbols[i] == '4')
                    answer += numbers[i] / numbers[i + 1];
                else if (symbols[i] == '3')
                    answer += numbers[i] * numbers[i + 1];
                else if (symbols[i] == '2')
                    answer += numbers[i] + numbers[i + 1];
                else if (symbols[i] == '1')
                    answer += numbers[i] - numbers[i + 1];
            }

            return answer; */
        }

        public static string randPattern()
        {
            var rand = new Random();
            int determineChar;
            string tempChar = "";
            string string1 = "";
            for (int charLoop = 0; charLoop < 69; charLoop++)
            {
                determineChar = rand.Next(0, 30);
                switch (determineChar)
                {
                    case 1:
                        tempChar = "?";
                        break;
                    case 2:
                        tempChar = "~";
                        break;
                    case 3:
                        tempChar = "!";
                        break;
                    case 4:
                        tempChar = "#";
                        break;
                    case 5:
                        tempChar = "}";
                        break;
                    case 6:
                        tempChar = "{";
                        break;
                    case 7:
                        tempChar = "%";
                        break;
                    case 8:
                        tempChar = "_";
                        break;
                    case 9:
                        tempChar = "@";
                        break;
                    case 10:
                        tempChar = "£";
                        break;
                    case 11:
                        tempChar = "/";
                        break;
                    case 12:
                        tempChar = ",";
                        break;
                    case 13:
                        tempChar = "$";
                        break;
                    case 14:
                        tempChar = "(";
                        break;
                    case 15:
                        tempChar = "-";
                        break;
                    case 16:
                        tempChar = "*";
                        break;
                    case 17:
                        tempChar = "=";
                        break;
                    case 18:
                        tempChar = "]";
                        break;
                    case 19:
                        tempChar = "[";
                        break;
                    case 20:
                        tempChar = "+";
                        break;
                    case 21:
                        tempChar = "(";
                        break;
                    case 22:
                        tempChar = ")";
                        break;
                    case 23:
                        tempChar = "^";
                        break;
                    case 24:
                        tempChar = "&";
                        break;
                    case 25:
                        tempChar = "<";
                        break;
                    case 26:
                        tempChar = ">";
                        break;
                    case 27:
                        tempChar = "|";
                        break;
                    case 28:
                        tempChar = "'";
                        break;
                    case 29:
                        tempChar = ":";
                        break;
                    case 30:
                        tempChar = ";";
                        break;
                }
                string1 += tempChar;
            }
            
            return string1;
        }

        public static bool containsExtensionCheck(string fileName)
        {
            for(int i = 0; i<fileName.Length; i++)
            {
                if(fileName[i] == '.')
                {
                    return true;
                }
            }
            return false;
        }

        public static double[] quadraticABC(string quadraticString)
        {
            char[] numbers = new char[]{'0','1','2','3','4','5','6','7','8','9'};
            int i = 0;
            bool negative = false;
            string tempString = "";
            while(!numbers.Contains(quadraticString[i]))
            {
                if(quadraticString[i] == '-')
                {
                    negative = true;
                }
                i++;
            }
            while(numbers.Contains(quadraticString[i]))
            {
                tempString += quadraticString[i];
                i++;
            }
            double a = Convert.ToDouble(tempString);
            if (negative)
            {
                negative = false;
                a -= 2 * a;
            }
            i += 3;
            tempString = "";
            while(!numbers.Contains(quadraticString[i]))
            {
                if (quadraticString[i] == '-')
                {
                    negative = true;
                }
                i++;
            }
            while(numbers.Contains(quadraticString[i]))
            {
                tempString += quadraticString[i];
                i++;
            }
            double b = Convert.ToDouble(tempString);
            if (negative)
            {
                negative = false;
                b -= 2 * b;
            }
            tempString = "";

            while (!numbers.Contains(quadraticString[i]))
            {
                if (quadraticString[i] == '-')
                {
                    negative = true;
                }
                i++;
            }
            while (i!=quadraticString.Length)
            {
                tempString += quadraticString[i];
                i++;
            }
            double c = Convert.ToDouble(tempString);
            if (negative)
            {
                negative = false;
                c -= 2 * c;
            }
            double[] output = new double[] { a, b, c };
            return output;            
        }
    }
}
