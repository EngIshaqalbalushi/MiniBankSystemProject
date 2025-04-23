namespace MiniBankSystemProject
{
    internal class Program
    {

       public static Queue<string> recustCreateAccountsInfo = new Queue<string>();





        public static int userCordNumber = 12062000;
        public static int defaultBalances = 5;

        static void Main(string[] args)
        {


            HomePage();



        }

        public static void HomePage()
        {



            Console.WriteLine("**************************************************************\n");

            Console.WriteLine("         Welcome To One Piece Bank System          \n ");

            Console.WriteLine("**************************************************************\n");

            bool Flag = true;

            while (Flag)
            {
                Console.WriteLine("Select One Option");
                Console.WriteLine("1-User ");
                Console.WriteLine("2-Adman");
                Console.WriteLine("3-Exit");

                Console.WriteLine("Enter Number");

                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        UserIU();
                        break;

                    case 2:
                        

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("See Next Time My Black Cat");
                        Flag = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Number Not foun :"+number+"\n");

                        break;
                }




            }

        }



        //++++++++++++++ User Feature++++++++++++++++++++ //

        public static void UserIU()
        {

            Console.Clear();
            Console.WriteLine("**************************************************************\n");

            Console.WriteLine("                          User Page                            \n ");

            Console.WriteLine("**************************************************************\n");



            bool Flag = true;

            while (Flag)
            {
                Console.WriteLine("Select One Option");
                Console.WriteLine("1- Create accounts ");
                Console.WriteLine("2- Deposit Money ");
                Console.WriteLine("3- Withdraw Money ");
                Console.WriteLine("4- View balances");
                Console.WriteLine("5- View transaction history\r\n");
                Console.WriteLine("6- View balances");


                Console.WriteLine("Enter Number");

                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        recustCreateAccounts();
                        break;

                    case 2:


                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("See Next Time My Black Cat");
                        Flag = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Number Not foun :" + number + "\n");

                        break;

                }




            }


        }
        

        // Recust For Create Account 
        public static void  recustCreateAccounts()
        {
            Console.Clear();
            Console.WriteLine("**************************************************************\n");

            Console.WriteLine("                          Recut Create Account Page                            \n ");

            Console.WriteLine("**************************************************************\n");


            Console.Write("Enter Name : ");
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name is empty");


            }

            Console.WriteLine("Enter ID Number  ");

            int idNumber;
            while (!int.TryParse(Console.ReadLine(), out idNumber))
            {
                Console.WriteLine("Invalid input ");
            }


            int nweCredNumber = userCordNumber + 1;

            string userInfo = (name + "|" + idNumber + "|" + nweCredNumber+"|"+ defaultBalances);

            userCordNumber = nweCredNumber;

            recustCreateAccountsInfo.Enqueue(userInfo);

            //foreach(string x in recustCreateAccountsInfo)
            //{
            //    Console.WriteLine(x);
            //}

        }

        public static void depostitMoney()
        {
            Console.Clear();
            Console.WriteLine("**************************************************************\n");

            Console.WriteLine("                          Deposit Page                            \n ");

            Console.WriteLine("**************************************************************\n");





        }




    }
}
