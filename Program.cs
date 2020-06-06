using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /* for adding film names as variables */

                string[] filmname;
                int i = 0;
                int nowplaying;
                Console.WriteLine("HELLO...WELCOME TO OUR MULTIPLEX");

                do
                {
                    try
                    {
                        Console.Write("ENTER THE NUMBER OF FILM MULTIPLEX IS CURRENTLY SHOWING "); 
                        
                        // GETTING INPUT FROM EMPLOYEE

                        nowplaying = int.Parse(Console.ReadLine());
                        if (nowplaying < 1) 
                            
                            // CHECKS THE VALIDATION

                        {

                            // FOR ERROR MESSAGE

                            Console.WriteLine("ENTER VALID NUMBER"); 
                        }
                    }

                    catch (Exception e)
                    {
                        // HANDLES THE EXCEPTION

                        Console.WriteLine(e.Message + "ENTER VALID FILM NUMBER !!"); 
                        nowplaying = 0;
                    }

                }

                while (nowplaying < 1);

                filmname = new string[nowplaying];

                do

                {

                    // FOR TAKING INPUT FROM USER OR EMPLOYEE

                    Console.Write(" ENTER THE FILM NAME " + (i + 1) + ":"); 
                    string film = Console.ReadLine();
                    film = film.ToUpper();

                    // COMPARES THE INPUT

                    if (film.EndsWith("(18)") || 
                       film.EndsWith("(15)") ||
                         film.EndsWith("(12A)") ||
                        film.EndsWith("(U)"))
                    {
                        filmname[i] = film;
                        i++;
                    }

                    else
                    {

                        // CHECKING THE INPUT AND VALIDATIONS

                        Console.WriteLine("ALL FILM ENDS WITH (18) or (12A) or (U) or (15) ONLY SO PLEASE ENTER ACCORDINGLY.");  
                        continue;
                    }

                }

                while (i < nowplaying);
                
                string GoRoundAgain = "";
                do
                {
                    Console.WriteLine("HELLO! WELCOME TO UCINEMA");
                    Console.WriteLine("WE ARE CURRENTLY SHOWING :");


                    for (int j = 0; j < nowplaying; j++)
                    {
                        Console.WriteLine((j + 1) + "." + " " + filmname[j]);
                    }

                    int film, age;

                    do
                    {

                        // FOR ACCEPTING INPUT FROM USERS

                        Console.Write("PLEASE ENTER THE MOVIE NUMBER FROM THE ABOVE LIST WHICH YOU WANT TO SEE" + " "); 
                        film = int.Parse(Console.ReadLine());

                        if ((film < 1) || (film > nowplaying))
                        {

                            // IT WILL CHECK USER'S INPUT AND SHOW ERROR MESSAGE

                            Console.WriteLine("OOPS! INVALID NUMBER. PLEASE ENTER NUMBER AGAIN."); 
                        }


                    } while ((film < 1) || (film > nowplaying));

                    Boolean cage = false;


                    do
                    {

                        // VALIDATION FOR AGE

                        Console.Write("PLEASE ENTER YOUR AGE:" + " "); 
                        age = int.Parse(Console.ReadLine());

                        // CHECKING AGE RANGE AND PRINTING MESSAGES

                        if ((age < 5) || (age > 120)) 
                        {
                            Console.WriteLine("YOUR AGE SHOULD BE BETWEEN 5 TO 120");
                            cage = false;
                        }
                        else
                        {
                            cage = true;

                        }

                    } while (cage == false);

                    if ((filmname[film - 1].EndsWith("(15)") && age >= 15))

                    {
                        Console.WriteLine("CONGRATULATIONS! YOU ARE ALLOWED TO WATCH " + filmname[film - 1] );
                    }

                    else if (filmname[film - 1].EndsWith("(18)") && age >= 18)
                    {
                        Console.WriteLine("CONGRATULATIONS! YOU ARE ALLOWED TO WATCH " + filmname[film - 1]);
                    }

                    else if (filmname[film - 1].EndsWith("(U)") && age >= 5)
                    {
                        Console.WriteLine("CONGRATULATIONS! YOU ARE ALLOWED TO WATCH " + filmname[film - 1] );
                    }

                    else if (filmname[film - 1].EndsWith("(12A)") && age >= 5)
                    {
                        Console.WriteLine("CONGRATULATION! YOU ARE ALLOWED TO WATCH " + filmname[film - 1] );
                    }

                    else
                    {
                        Console.WriteLine("OOOPS! YOU ARE NOT ALLOWED TO WATCH THAT MOVIE AS YOU ARE TOO YOUNG"); 
                    }

                    Boolean flag = false;
                    do
                    {

                        // IF THERE IS NEW CUSTOMER THE PROCESS WILL BE REPEATED

                        Console.Write("TYPE YES TO WATCH NEW MOVIE" + " "); 
                        GoRoundAgain = Console.ReadLine();
                        if (GoRoundAgain.ToUpper() == "YES" || GoRoundAgain.ToUpper() == "Y")
                        {
                            flag = true;

                        }
                        else if(GoRoundAgain.ToUpper() == "")
                        {
                            Environment.Exit(1);


                        }
                        else
                        {
                            Console.WriteLine("PLEASE ENTER YES ");
                            Console.WriteLine("");
                            flag = false;



                        }
                    } while (flag == false);
                } while (GoRoundAgain.ToUpper() == "YES" || GoRoundAgain.ToUpper() == "Y");
            }
            catch (FormatException)
            {

                // VALIDATION TO CONTROL USER INPUT

                Console.WriteLine("PLEASE INPUT VALID MOVIE AND OR AGE");    
            }
            Console.Read();
        }
    }
}
