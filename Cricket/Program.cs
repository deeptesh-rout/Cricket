using System;

class cricketEX
{
    static void Main(string[] args)
    {
        Random random_number = new Random();
        int user_batting;
        int user_balling;

        int user_wicket = 0;
        int System_wicket = 0;
        Console.WriteLine("Ladies and Gentlemen, a great match between the user and the system. Let's see who will win the match");
        Console.WriteLine("How many overs do you want to play?");
        int over = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Total 5 wickets in each team");
        Console.WriteLine("It's toss time. What is your call?");
        Console.Write("Head (0), Tail (1): ");
        int user = Convert.ToInt32(Console.ReadLine());

        int Computer_toss = random_number.Next(2);
        int SystemScore = 0;
        int userScore = 0;
        if (Computer_toss == user)
        {
            Console.WriteLine("Congratulations, you won the toss");
            Console.WriteLine("What do you want to choose, batting or bowling first? [(1): bat or (2): ball]");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("You chose batting first (System will bowl to you)");
                Console.WriteLine("Enter 1: One run, 2: Two runs, 3: Three runs, 4: Four runs, 5: Five runs, 6: Six runs");

                for (int i = 1; i <= over; i++)
                {

                    for (int j = 1; j <= 6; j++)
                    {
                        Console.Write("Bat:");
                        user_batting = Convert.ToInt32(Console.ReadLine());
                        int Computer_bowling = random_number.Next(1, 7);
                        if (user_batting != Computer_bowling)
                        {
                            Console.WriteLine("You hit:" + user_batting + " runs" + ", System chose:" + Computer_bowling);
                            userScore = user_batting + userScore;
                        }
                        else if (user_batting == Computer_bowling)
                        {
                            user_wicket++;
                            Console.WriteLine("Oops, you're out because your choice and the computer's choice are the same. You:" + user_batting + ", System chose:" + Computer_bowling);
                        }
                        else if (user_wicket == 5)
                        {
                            break;
                        }
                        if (j == 6)
                        {
                            if (i > 1 && user_wicket > 1)
                            {
                                Console.WriteLine("After completing " + i + " overs, the score is " + userScore + " runs" + " with the loss of " + user_wicket + " wickets");
                            }
                            else if (i > 1 && user_wicket < 1)
                            {
                                Console.WriteLine("After completing " + i + " over, the score is " + userScore + " runs " + " with the loss of " + user_wicket + " wicket");
                            }
                            else if (i == 1 && user_wicket > 1)
                            {
                                Console.WriteLine("After completing " + i + " over, the score is " + userScore + " runs" + " with the loss of " + user_wicket + " wickets");
                            }
                            else if (i == 1 && user_wicket < 1)
                            {
                                Console.WriteLine("After completing " + i + " over, the score is " + userScore + " runs" + " with the loss of " + user_wicket + " wickets");

                            }
                        }
                    }
                }
                Console.WriteLine("Total score: " + userScore);
                Console.WriteLine("2nd innings start in a few sec,\"now it your turn to bowling and defend your Score\"" + "(Target):" + (userScore + 1) + "\nchoose same number as system choose for taking wicket");
                for (int m = 1; m <= over; m++)
                {

                    for (int n = 1; n <= 6; n++)
                    {
                        Console.Write("Ball:");
                        user_balling = Convert.ToInt32(Console.ReadLine());
                        int Computer_batting = random_number.Next(1, 7);

                        if (user_balling != Computer_batting)
                        {
                            Console.WriteLine("System hit:" + Computer_batting + " runs" + ", You chose:" + user_balling);
                            SystemScore = Computer_batting + SystemScore;
                        }
                        if (user_balling == Computer_batting)
                        {
                            System_wicket++;
                            Console.WriteLine("Yes, you got it," + System_wicket + " wickets gone of System because your choice and the computer's choice are the same. You:" + user_balling + ", System chose:" + Computer_batting);
                        }
                        if (System_wicket == 5)
                        {
                            break;
                        }
                        if (n == 6)
                        {
                            if (m > 1 && System_wicket > 1)
                            {
                                Console.WriteLine("After completing " + m + " overs, the score is " + SystemScore + " runs" + " with the loss of " + System_wicket + " wickets");
                            }
                            else if (m > 1 && System_wicket < 1)
                            {
                                Console.WriteLine("After completing " + m + " over, the score is " + SystemScore + " runs " + " with the loss of " + System_wicket + " wicket");
                            }
                            else if (m == 1 && System_wicket > 1)
                            {
                                Console.WriteLine("After completing " + m + " over, the score is " + SystemScore + " runs" + " with the loss of " + System_wicket + " wickets");
                            }
                            else if (m == 1 && System_wicket < 1)
                            {
                                Console.WriteLine("After completing " + m + " over, the score is " + SystemScore + " runs" + " with the loss of " + System_wicket + " wickets");
                            }

                        }
                    }

                }
                if (userScore > SystemScore)
                {
                    Console.WriteLine("Congratulations! You won the game by: " + (userScore - SystemScore) + " runs");
                }
                if (userScore < SystemScore)
                {
                    Console.WriteLine("You lose the game by: " + (SystemScore - userScore) + " runs, but nice try. Best of luck for the next game!");
                }
                if (userScore == SystemScore)
                {
                    Console.WriteLine("It's a tie! The score is " + userScore + "-" + SystemScore + " runs. Well played by both teams.");
                }

            }
            if (option == 2)
            {
                Console.WriteLine("You chose bowling first (System will bat first...) \nchoose same number as system choose for taking wicket");
                Console.WriteLine("Enter 1: One run, 2: Two runs, 3: Three runs, 4: Four runs, 5: Five runs, 6: Six runs");

                for (int i = 1; i <= over; i++)
                {

                    for (int j = 1; j <= 6; j++)
                    {
                        Console.Write("Ball:");
                        user_balling = Convert.ToInt32(Console.ReadLine());
                        int Computer_batting = random_number.Next(1, 7);

                        if (user_balling != Computer_batting)
                        {
                            Console.WriteLine("System hit:" + Computer_batting + " runs" + ", You chose:" + user_balling);
                            SystemScore = Computer_batting + SystemScore;

                        }

                        if (user_balling == Computer_batting)
                        {
                            System_wicket++;
                            Console.WriteLine("Yes, you got it," + System_wicket + " wickets gone of System because your choice and the computer's choice are the same. You:" + user_balling + ", System chose:" + Computer_batting);
                        }
                        if (System_wicket == 5)
                        {
                            break;
                        }
                        if (j == 6)
                        {
                            if (i > 1 && System_wicket > 1)
                            {
                                Console.WriteLine("After completing " + i + " overs, the score is " + SystemScore + " runs" + " with the loss of " + System_wicket + " wickets");
                            }
                            else if (i > 1 && System_wicket < 1)
                            {
                                Console.WriteLine("After completing " + i + " over, the score is " + SystemScore + " runs " + " with the loss of " + System_wicket + " wicket");
                            }
                            else if (i == 1 && System_wicket > 1)
                            {
                                Console.WriteLine("After completing " + i + " over, the score is " + SystemScore + " runs" + " with the loss of " + System_wicket + " wickets");
                            }
                            else if (i == 1 && System_wicket < 1)
                            {
                                Console.WriteLine("After completing " + i + " over, the score is " + SystemScore + " runs" + " with the loss of " + System_wicket + " wickets");

                            }

                        }
                    }
                }

                Console.WriteLine("Total score: " + SystemScore);
                Console.WriteLine("2nd innings start in a few sec,\"now it your turn to batting and the chasing the Score\"" + "(Target):" + (userScore + 1));
                for (int m = 1; m <= over; m++)
                {

                    for (int n = 1; n <= 6; n++)
                    {
                        Console.Write("Bat:");
                        user_batting = Convert.ToInt32(Console.ReadLine());
                        int Computer_bowling = random_number.Next(1, 7);
                        if (user_batting != Computer_bowling)
                        {
                            Console.WriteLine("You hit:" + user_batting + " runs" + ", System chose:" + Computer_bowling);
                            userScore = user_batting + userScore;
                        }

                        else if (user_batting == Computer_bowling)
                        {
                            user_wicket++;
                            Console.WriteLine("Oops, you're out because your choice and the computer's choice are the same. You:" + user_batting + ", System chose:" + Computer_bowling);
                        }
                        else if (user_wicket == 5)
                        {
                            break;
                        }
                        if (n == 6)
                        {
                            if (n > 1 && user_wicket > 1)
                            {
                                Console.WriteLine("After completing " + m + " overs, the score is " + userScore + " runs" + " with the loss of " + user_wicket + " wickets");
                            }
                            else if (n > 1 && user_wicket < 1)
                            {
                                Console.WriteLine("After completing " + m + " over, the score is " + userScore + " runs " + " with the loss of " + user_wicket + " wicket");
                            }
                            else if (n == 1 && user_wicket > 1)
                            {
                                Console.WriteLine("After completing " + m + " over, the score is " + userScore + " runs" + " with the loss of " + user_wicket + " wickets");
                            }
                            else if (n == 1 && user_wicket < 1)
                            {
                                Console.WriteLine("After completing " + m + " over, the score is " + userScore + " runs" + " with the loss of " + user_wicket + " wickets");
                            }

                        }
                    }
                }
                if (userScore > SystemScore)
                {
                    Console.WriteLine("Congratulations! You won the game by: " + (5 - System_wicket) + " wickets");
                }
                if (userScore < SystemScore)
                {
                    Console.WriteLine("You lose the game by: " + (SystemScore - userScore) + " runs" + ", but nice try. Best of luck for the next game!");
                }
                if (userScore == SystemScore)
                {
                    Console.WriteLine("It's a tie score between You and the System: " + userScore + "-" + SystemScore + " runs. Well played!");
                }
            }
        }
        if (Computer_toss != user)
        {
            Console.WriteLine("O sorry, you lose the toss");
            int Computer_choose = random_number.Next(2);
            if (Computer_choose == 0)
            {
                Console.WriteLine("And the computer won the toss and choose to bat first");
                Console.WriteLine("You do bowling first (System will bat first...) \nchoose same number as system choose for taking wicket");
                Console.WriteLine("Enter 1: One run, 2: Two runs, 3: Three runs, 4: Four runs, 5: Five runs, 6: Six runs");

                for (int i = 1; i <= over; i++)
                {

                    for (int j = 1; j <= 6; j++)
                    {
                        Console.Write("Ball:");
                        user_balling = Convert.ToInt32(Console.ReadLine());
                        int Computer_batting = random_number.Next(1, 7);

                        if (user_balling != Computer_batting)
                        {
                            Console.WriteLine("System hit:" + Computer_batting + " runs" + ", You chose:" + user_balling);
                            SystemScore = Computer_batting + SystemScore;
                        }
                        if (user_balling == Computer_batting)
                        {
                            System_wicket++;
                            Console.WriteLine("Yes, you got it," + System_wicket + " wickets gone of System because your choice and the computer's choice are the same. You:" + user_balling + ", System chose:" + Computer_batting);
                        }
                        if (System_wicket == 5)
                        {
                            break;
                        }
                        if (j == 6)
                        {
                            if (i > 1 && System_wicket > 1)
                            {
                                Console.WriteLine("After completing " + i + " overs, the score is " + SystemScore + " runs" + " with the loss of " + System_wicket + " wickets");
                            }
                            else if (i > 1 && System_wicket < 1)
                            {
                                Console.WriteLine("After completing " + i + " over, the score is " + SystemScore + " runs " + " with the loss of " + System_wicket + " wicket");
                            }
                            else if (i == 1 && System_wicket > 1)
                            {
                                Console.WriteLine("After completing " + i + " over, the score is " + SystemScore + " runs" + " with the loss of " + System_wicket + " wickets");
                            }
                            else if (i == 1 && System_wicket < 1)
                            {
                                Console.WriteLine("After completing " + i + " over, the score is " + SystemScore + " runs" + " with the loss of " + System_wicket + " wickets");

                            }

                        }
                    }
                }
                Console.WriteLine("Total score: " + SystemScore);
                Console.WriteLine("2nd innings start in a few sec,\"now it your turn to batting and the chasing the Score\"" + "(Target):" + (userScore + 1));
                for (int m = 1; m <= over; m++)
                {

                    for (int n = 1; n <= 6; n++)
                    {
                        Console.Write("Bat:");
                        user_batting = Convert.ToInt32(Console.ReadLine());
                        int Computer_bowling = random_number.Next(1, 7);
                        if (user_batting != Computer_bowling)
                        {
                            Console.WriteLine("You hit:" + user_batting + " runs" + ", System chose:" + Computer_bowling);
                            userScore = user_batting + userScore;
                        }
                        else if (user_batting == Computer_bowling)
                        {
                            user_wicket++;
                            Console.WriteLine("Oops, you're out because your choice and the computer's choice are the same. You:" + user_batting + ", System chose:" + Computer_bowling);
                        }
                        else if (user_wicket == 5)
                        {
                            break;
                        }
                        if (n == 6)
                        {
                            if (n > 1 && user_wicket > 1)
                            {
                                Console.WriteLine("After completing " + m + " overs, the score is " + userScore + " runs" + " with the loss of " + user_wicket + " wickets");
                            }
                            else if (n > 1 && user_wicket < 1)
                            {
                                Console.WriteLine("After completing " + m + " over, the score is " + userScore + " runs " + " with the loss of " + user_wicket + " wicket");
                            }
                            else if (n == 1 && user_wicket > 1)
                            {
                                Console.WriteLine("After completing " + m + " over, the score is " + userScore + " runs" + " with the loss of " + user_wicket + " wickets");
                            }
                            else if (n == 1 && user_wicket < 1)
                            {
                                Console.WriteLine("After completing " + m + " over, the score is " + userScore + " runs" + " with the loss of " + user_wicket + " wickets");
                            }

                        }
                    }
                }
                if (userScore > SystemScore)
                {
                    Console.WriteLine("Congratulation you Won the game by:" + (5 - System_wicket) + " wickets");
                }
                if (userScore < SystemScore)
                {
                    Console.WriteLine("You lose the game by:" + (SystemScore - userScore) + " runs" + ", but nice try.Best of Luck for next game");
                }
                if (userScore == SystemScore)
                {
                    Console.WriteLine("Oo it is tie score between You and the System" + userScore + "-" + SystemScore + "runs,Well played");

                }
            }
            if (Computer_choose == 1)
            {
                Console.WriteLine("And the computer won the toss and choose to ball first");
                Console.WriteLine("If your chooce number and System choose number are same then it consider as wicket");
                Console.WriteLine("Enter 1: One run, 2: Two runs, 3: Three runs, 4: Four runs, 5: Five runs, 6: Six runs");

                for (int i = 1; i <= over; i++)
                {

                    for (int j = 1; j <= 6; j++)
                    {
                        Console.Write("Bat:");
                        user_batting = Convert.ToInt32(Console.ReadLine());
                        int Computer_bowling = random_number.Next(1, 7);
                        if (user_batting != Computer_bowling)
                        {
                            Console.WriteLine("You hit:" + user_batting + " runs" + ", System chose:" + Computer_bowling);
                            userScore = user_batting + userScore;
                        }
                        else if (user_batting == Computer_bowling)
                        {
                            user_wicket++;
                            Console.WriteLine("Oops, you're out because your choice and the computer's choice are the same. You:" + user_batting + ", System chose:" + Computer_bowling);
                        }
                        else if (user_wicket == 5)
                        {
                            break;
                        }
                        if (j == 6)
                        {
                            if (i > 1 && user_wicket > 1)
                            {
                                Console.WriteLine("After completing " + i + " overs, the score is " + userScore + " runs" + " with the loss of " + user_wicket + " wickets");
                            }
                            else if (i > 1 && user_wicket < 1)
                            {
                                Console.WriteLine("After completing " + i + " over, the score is " + userScore + " runs " + " with the loss of " + user_wicket + " wicket");
                            }
                            else if (i == 1 && user_wicket > 1)
                            {
                                Console.WriteLine("After completing " + i + " over, the score is " + userScore + " runs" + " with the loss of " + user_wicket + " wickets");
                            }
                            else if (i == 1 && user_wicket < 1)
                            {
                                Console.WriteLine("After completing " + i + " over, the score is " + userScore + " runs" + " with the loss of " + user_wicket + " wickets");

                            }
                        }
                    }
                }
                Console.WriteLine("Total score: " + userScore);
                Console.WriteLine("2nd innings start in a few sec,\"now it your turn to bowling and defend your Score\"" + "(Target):" + (userScore + 1) + "\nchoose same number as system choose for taking wicket");
                for (int m = 1; m <= over; m++)
                {

                    for (int n = 1; n <= 6; n++)
                    {
                        Console.Write("Ball:");
                        user_balling = Convert.ToInt32(Console.ReadLine());
                        int Computer_batting = random_number.Next(1, 7);

                        if (user_balling != Computer_batting)
                        {
                            Console.WriteLine("System hit:" + Computer_batting + " runs" + ", You chose:" + user_balling);
                            SystemScore = Computer_batting + SystemScore;
                        }

                        if (user_balling == Computer_batting)
                        {
                            System_wicket++;
                            Console.WriteLine("Yes, you got it," + System_wicket + " wickets gone of System because your choice and the computer's choice are the same. You:" + user_balling + ", System chose:" + Computer_batting);
                        }
                        if (System_wicket == 5)
                        {
                            break;
                        }
                        if (n == 6)
                        {
                            if (m > 1 && System_wicket > 1)
                            {
                                Console.WriteLine("After completing " + m + " overs, the score is " + SystemScore + " runs" + " with the loss of " + System_wicket + " wickets");
                            }
                            else if (m > 1 && System_wicket < 1)
                            {
                                Console.WriteLine("After completing " + m + " over, the score is " + SystemScore + " runs " + " with the loss of " + System_wicket + " wicket");
                            }
                            else if (m == 1 && System_wicket > 1)
                            {
                                Console.WriteLine("After completing " + m + " over, the score is " + SystemScore + " runs" + " with the loss of " + System_wicket + " wickets");
                            }
                            else if (m == 1 && System_wicket < 1)
                            {
                                Console.WriteLine("After completing " + m + " over, the score is " + SystemScore + " runs" + " with the loss of " + System_wicket + " wickets");
                            }

                        }
                    }
                }
                if (userScore > SystemScore)
                {
                    Console.WriteLine("Congratulations! You won the game by: " + (userScore - SystemScore) + " runs");
                }
                if (userScore < SystemScore)
                {
                    Console.WriteLine("You lose the game by: " + (SystemScore - userScore) + " runs, but nice try. Best of luck for the next game!");
                }
                if (userScore == SystemScore)
                {
                    Console.WriteLine("It's a tie! The score is " + userScore + "-" + SystemScore + " runs. Well played by both teams.");
                }
            }
        }
        Console.ReadKey();
    }
}
