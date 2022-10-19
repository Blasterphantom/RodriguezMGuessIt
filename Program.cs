//Marcel Rodriguez
//10-19-22 4pm
//Mini Challenge 8 - Guess it
// This program will have the user guess numbers until they find the right
//one, while the computer says higher or lower, and keep track of 
//the number of guesses
//Peer review -

Console.Clear();

string end = "yes";

while(end == "yes")
{
    Console.WriteLine("Welcome to Guess It!!");
    Console.WriteLine("Would you like easy, medium, hard, or custom?");
    string unknownDifficulty = Console.ReadLine().ToLower();

    switch(unknownDifficulty)
    {
        case "easy":

        Random rndNum = new Random();
        long num = rndNum.Next(0,10);

        bool isContainer = true;
        bool issaNumber;
        long validForReal = 0;
        int i = 0;

        while(isContainer == true)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Guess a number between 0 and 10: ");
            string easyGuess = Console.ReadLine();
            issaNumber = Int64.TryParse(easyGuess, out validForReal);
            


            if(validForReal >= 0 && validForReal <= 10)
            {
                Console.WriteLine("Your guess is: " +easyGuess);
                isContainer = false;

                if(validForReal == num)
                {
                    if(easyGuess != "0" && validForReal == 0)
                    {
                        Console.WriteLine("Please enter a number and not characters");
                        isContainer = true;
                    }
                    else
                    {
                    i++;
                    Console.WriteLine("Congrats! The number was " + num + "!");
                    Console.WriteLine("It took you " +i+ " guesses lmao");
                    }
                }
                else
                {
                    if(validForReal<num)
                    {
                        if(validForReal == 0)
                        {
                            if(easyGuess != "0")
                            {
                                Console.WriteLine("Please enter a number and not characters");
                                isContainer = true;
                            }
                            else
                            {
                                Console.WriteLine("Try again, your guess was too low");
                                isContainer =true;
                                i++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Try again, your guess was too low");
                            isContainer =true;
                            i++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again, your guess was too high");
                        isContainer =true;
                        i++;
                    }
                }
            }
            else
            {
                Console.WriteLine("That is not a number it could be");
            }
        }


        break;

        case "medium":

        Random rndNum2 = new Random();
        long num2 = rndNum2.Next(0,50);

        bool isContainer2 = true;
        bool issaNumber2;
        long validForReal2 = 0;
        int j = 0;

        while(isContainer2 == true)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Guess a number between 0 and 50: ");
            string easyGuess2 = Console.ReadLine();
            issaNumber2 = Int64.TryParse(easyGuess2, out validForReal2);
            


            if(validForReal2 >= 0 && validForReal2 <= 50)
            {
                Console.WriteLine("Your guess is: " +easyGuess2);
                isContainer2 = false;

                if(validForReal2 == num2)
                {
                    if(easyGuess2 != "0" && validForReal2 == 0)
                    {
                        Console.WriteLine("Please enter a number and not characters");
                        isContainer2 = true;
                    }
                    else
                    {
                        j++;
                        Console.WriteLine("Congrats! The number was " + num2 + "!");
                        Console.WriteLine("It took you " +j+ " guesses lmao");
                    }
                }
                else
                {
                    if(validForReal2<num2)
                    {
                        if(validForReal2 == 0)
                        {
                            if(easyGuess2 != "0")
                            {
                                Console.WriteLine("Please enter a number and not characters");
                                isContainer2 = true;
                            }
                            else
                            {
                                Console.WriteLine("Try again, your guess was too low");
                                isContainer2 =true;
                                j++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Try again, your guess was too low");
                            isContainer2 =true;
                            j++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again, your guess was too high");
                        isContainer2 =true;
                        j++;
                    }
                }
            }
            else
            {
                Console.WriteLine("That is not a number it could be");
            }
        }

        break;

        case "hard":

        Random rndNum3 = new Random();
        long num3 = rndNum3.Next(0,100);

        bool isContainer3 = true;
        bool issaNumber3;
        long validForReal3 = 0;
        int k = 0;

        while(isContainer3 == true)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Guess a number between 0 and 100: ");
            string easyGuess3 = Console.ReadLine();
            issaNumber3 = Int64.TryParse(easyGuess3, out validForReal3);
            


            if(validForReal3 >= 0 && validForReal3 <= 100)
            {
                Console.WriteLine("Your guess is: " +easyGuess3);
                isContainer3 = false;

                if(validForReal3 == num3)
                {
                     if(easyGuess3 != "0" && validForReal3 == 0)
                    {
                        Console.WriteLine("Please enter a number and not characters");
                        isContainer3 = true;
                    }
                    else
                    {
                        k++;
                        Console.WriteLine("Congrats! The number was " + num3 + "!");
                        Console.WriteLine("It took you " +k+ " guesses lmao");
                    }
                }
                else
                {
                    if(validForReal3<num3)
                    {
                        if(validForReal3 == 0)
                        {
                            if(easyGuess3 != "0")
                            {
                                Console.WriteLine("Please enter a number and not characters");
                                isContainer3 = true;
                            }
                            else
                            {
                                Console.WriteLine("Try again, your guess was too low");
                                isContainer3 =true;
                                k++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Try again, your guess was too low");
                            isContainer3 =true;
                            k++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again, your guess was too high");
                        isContainer3 =true;
                        k++;
                    }
                }
            }
            else
            {
                Console.WriteLine("That is not a number it could be");
            }
        }

        break;

        case "custom":

        Console.WriteLine();
        Console.WriteLine("Enter the lowest guess range: ");
        int lowGuess = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Enter the highest guess range: ");
        int highGuess = Convert.ToInt32(Console.ReadLine());

        Random rndNum4 = new Random();
        long num4 = rndNum4.Next(lowGuess,highGuess);

        bool isContainer4 = true;
        bool issaNumber4;
        long validForReal4 = 0;
        int l = 0;

        while(isContainer4 == true)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Guess a number between " + lowGuess + " and " + highGuess + ": ");
            string easyGuess4 = Console.ReadLine();
            issaNumber4 = Int64.TryParse(easyGuess4, out validForReal4);
            


            if(validForReal4 >= lowGuess && validForReal4 <= highGuess)
            {
                Console.WriteLine("Your guess is: " +easyGuess4);
                isContainer4 = false;

                if(validForReal4 == num4)
                {
                    if(easyGuess4 != "0" && validForReal4 == 0)
                    {
                        Console.WriteLine("Please enter a number and not characters");
                        isContainer4 = true;
                    }
                    else
                    {
                    l++;
                    Console.WriteLine("Congrats! The number was " + num4 + "!");
                    Console.WriteLine("It took you " +l+ " guesses lmao");
                    }
                }
                else
                {
                    if(validForReal4<num4)
                    {
                        if(validForReal4 == 0)
                        {
                            if(easyGuess4 != "0")
                            {
                                Console.WriteLine("Please enter a number and not characters");
                                isContainer4 = true;
                            }
                            else
                            {
                                Console.WriteLine("Try again, your guess was too low");
                                isContainer4 =true;
                                l++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Try again, your guess was too low");
                            isContainer4 =true;
                            l++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again, your guess was too high");
                        isContainer4 =true;
                        l++;
                    }
                }
            }
            else
            {
                Console.WriteLine("That is not a number it could be");
            }
        }

        break;

        default:
        
        Console.WriteLine("That is not a game mode");

        break;
    }
    
    Console.WriteLine("");
    Console.WriteLine("Do you want to play again? yes/no?");
    end = Console.ReadLine().ToLower();
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
}