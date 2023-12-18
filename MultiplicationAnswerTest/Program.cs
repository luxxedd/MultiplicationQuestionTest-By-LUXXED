using System;
using System.Collections.Generic;

class Program

{

    int num;

    static void Main(string[] args)

    {
        Random rnd = new Random();

        int i = 1;
        int score = 0;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"                                 mm                                            mm                         mm                                                                                          
*@@@@m     m@@@*           @@   @@@                       mm@***@m@          *@@@                       *@@@             @@                             mm@***@m@                                     
  @@@@    @@@@             @@    @@                     m@@*     *@            @@                         @@             @@                           m@@*     *@                                     
  @ @@   m@ @@   m@*@@m  @@@@@@  @@@@@@@m   m@@*@@@     @@*       * m@*@@m     @@   m@@*@@ *@@@  *@@@     @@   m@*@@m  @@@@@@   m@@*@@m *@@@m@@@      @@*       *  m@*@@m  *@@@@@@@@m@@@@@m    mm@*@@ 
  @  @!  @* @@  @@   @@    @@    @@    @@   @@   **     @@         @@   @@     !@  @@*  @@   @@    @@     !@  @@   @@    @@    @@*   *@@  @@* **      @!          @@   @@    @@    @@    @@   m@*   @@
  !  @!m@*  @@   m@@@!@    @@    @@    @!   *@@@@@m     @!m         m@@@!@     !@  @!        !@    @@     !@   m@@@!@    @@    @@     @@  @!          @!m    *@@@@ m@@@!@    !@    @@    @@   !@******
  !  *!@*   @@  @!   !@    @!    @!    @!        @@     *!@m     m*@!   !@     !@  @!m    m  !@    @!     !@  @!   !@    @!    @@     !@  @!          *!@m     @@ @!   !@    !@    !@    @@   !@m    m
  !  !!!!*  !!   !!!!:!    !!    !!    !!   *!   @!     !!!         !!!!:!     !!  !!        !@    !!     !!   !!!!:!    !!    !@     !!  !!          !!!    *!@!! !!!!:!    !!    !!    !!   !!******
  :  *!!*   !!  !!   :!    !!    !:    !:   !!   !!     :!!:     !*!!   :!     :!  !:!    !  !!    !!     :!  !!   :!    !!    !!!   !!!  !:          *:!!     !! !!   :!    :!    :!    !!   :!!     
: ::: :   : ::: :!: : !:   ::: :: :   : : : : :!:         : : : :! :!: : !:  : : :  : : :    :: !: :!:  : : : :!: : !:   ::: :  : : : : : :::           ::: : ::  :!: : !: : :!:  :::   ::!:   : : :: 
                                                                                                                                                                                                      
                                                                                                                                                                                                      
");
        Console.ForegroundColor = ConsoleColor.Green;
        while (i <= 10)
        {
            int num1 = rnd.Next(1, 10);
            int num2 = rnd.Next(1, 10);


            Console.Write("What is " + num1 + " x " + num2 + " =");
            int ans = Convert.ToInt32(Console.ReadLine());

            if (ans == num1 * num2)

            {

                Console.WriteLine("You are correct");

                score = score + 1;

            }

            else

            {

                Console.WriteLine("You are incorrect");

            }
            i = i + 1;
        }

        Console.WriteLine("Score:" + score);

        }
        }

