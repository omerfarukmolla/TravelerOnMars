using System;

namespace TravelerOnMars
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers help = new Helpers();

            char[] surfaceBoundaries;
            char[] robot1Coordinate;
            char[] robot2Coordinate;
            //string[] robot1Commands;
            //string[] robot2Commands;
            string robot1Cards;
            string robot2Cards;
            string startPlay;

            try
            {
                do
                {

                    do
                    {
                        Console.WriteLine("Please Define The Boundaries Of The Surface ( Enter Only Numeric Expression Eg :5 5)");
                        string surfaceString = Console.ReadLine();
                        surfaceString = surfaceString.Replace(" ", "");
                        surfaceBoundaries = surfaceString.ToCharArray();
                        if (surfaceBoundaries.Length != 2)
                            Console.WriteLine("Min - Max 2 Char!)");

                    } while (surfaceBoundaries.Length != 2 || !int.TryParse(surfaceBoundaries[0].ToString(), out int x) || !int.TryParse(surfaceBoundaries[1].ToString(), out int y));



                    Mars mars = null;
                    mars = new Mars(new Surface(Convert.ToInt32(surfaceBoundaries[0].ToString()), Convert.ToInt32(surfaceBoundaries[1].ToString())));


                    do
                    {
                        Console.WriteLine("Enter the Coordinates of the 1st Robot Found on the Surface (X Coordinates Y Coordinates And Directipn Eg :1 2 N)");
                        string robot1CoordinateString = Console.ReadLine();
                        robot1CoordinateString = robot1CoordinateString.Replace(" ", "");
                        robot1Coordinate = robot1CoordinateString.ToCharArray();
                        if (robot1Coordinate.Length != 3)
                            Console.WriteLine("Min - Max 3 Char");
                    } while (robot1Coordinate.Length != 3 || !Int32.TryParse(robot1Coordinate[0].ToString(), out int x) || !Int32.TryParse(robot1Coordinate[1].ToString(), out int y) || !help.CheckIsAnDirectory(robot1Coordinate[2].ToString()));

                    Robot rb = new Robot(Convert.ToInt32(robot1Coordinate[0].ToString()), Convert.ToInt32(robot1Coordinate[1].ToString()), help.stringToDiraction(robot1Coordinate[2].ToString()));


                    do
                    {
                        Console.WriteLine("Please Enter Letter Cards for Robot 1");
                        robot1Cards = Console.ReadLine();
                        if (!help.IsAviableCards(robot1Cards))
                            Console.WriteLine("The Characters You Enter Can Only Be L - M - R");


                    } while (!help.IsAviableCards(robot1Cards));


                    mars.AddRobot(rb);
                    foreach (var chr in robot1Cards)
                    {
                        Command c = help.chrToCommand(chr);
                        rb.Move(c);
                    }

                    do
                    {
                        Console.WriteLine("Enter the Coordinates of the 2st Robot Found on the Surface (X Coordinates Y Coordinates And Directipn Eg :1 2 N)");
                        string robot2CoordinateString = Console.ReadLine();
                        robot2CoordinateString = robot2CoordinateString.Replace(" ", "");
                        robot2Coordinate = robot2CoordinateString.ToCharArray();
                        if (robot2Coordinate.Length != 3)
                            Console.WriteLine("Min - Max 3 Char!)");
                    } while (robot2Coordinate.Length != 3 || !Int32.TryParse(robot2Coordinate[0].ToString(), out int x) || !Int32.TryParse(robot2Coordinate[1].ToString(), out int y) || !help.CheckIsAnDirectory(robot2Coordinate[2].ToString()));

                    Robot rb2 = new Robot(Convert.ToInt32(robot2Coordinate[0].ToString()), Convert.ToInt32(robot2Coordinate[1].ToString()), help.stringToDiraction(robot2Coordinate[2].ToString()));


                    do
                    {
                        Console.WriteLine("Please Enter Letter Cards for Robot 2");
                        robot2Cards = Console.ReadLine();
                        if (!help.IsAviableCards(robot2Cards))
                            Console.WriteLine("The Characters You Enter Can Only Be L - M - R");


                    } while (!help.IsAviableCards(robot2Cards));


                    mars.AddRobot(rb2);
                    foreach (var chr in robot2Cards)
                    {
                        Command c = help.chrToCommand(chr);
                        rb2.Move(c);
                    }



                    Console.WriteLine("X Position Of First Robot = " + rb.Cordinate.X);
                    Console.WriteLine("Y Position Of First Robot = " + rb.Cordinate.Y);
                    Console.WriteLine("Direction  Of First Robot = " + rb.Diraction);

                    Console.WriteLine("X Position Of Seccond Robot = " + rb2.Cordinate.X);
                    Console.WriteLine("Y Position Of Seccond Robot = " + rb2.Cordinate.Y);
                    Console.WriteLine("Direction  Of Seccond Robot = " + rb2.Diraction);

                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------");


                    Console.WriteLine("Press 0 to start again. Press 1 to finish");
                    startPlay = Console.ReadLine();
                } while (startPlay.Equals("0"));

            }
            catch (Exception exc)
            {

                Console.WriteLine("An Unexpected Error Occurred. Error Code = " + exc.HResult);
            }
            //Console.WriteLine("Enter the Coordinates of the 2st Robot Found on the Surface (X Coordinates Y Coordinates And Directipn Eg :1 2 N)");
            //string robot2String = Console.ReadLine();
            //robot2Coordinate = robot1String.Split(' ');




            //rb.Move(Command.M);
            //rb.Move(Command.M);
            //rb.Move(Command.R);
            //rb.Move(Command.M);
            //rb.Move(Command.M);
            //rb.Move(Command.R);
            //rb.Move(Command.M);
            //rb.Move(Command.R);
            //rb.Move(Command.R);

            //var C = rb.Move(Command.M);

            //mars.AddRobot(new Robot(2, 5, Diraction.N));


            //mars.surface = new int[2,3];
        }
    }
}
