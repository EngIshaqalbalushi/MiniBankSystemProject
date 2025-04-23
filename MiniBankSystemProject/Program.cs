namespace MiniBankSystemProject
{
    internal class Program
    {

        public static Queue<string> recustCreateAccountsInfo = new Queue<string>();
       public static Queue<string> createAccountRequests = new Queue<string>();
        public  static Stack<string> submetReiew = new Stack<string>();


        static List<int> accountNumbers = new List<int>();
        static List<string> accountNames = new List<string>();
        static List<double> balances = new List<double>();

        public static string pathFile = "GG.txt";
        public static int userCordNumber = 12062000;
        public static int defaultBalances = 5;

        static void Main(string[] args)
        {


            HomePage();



        }

        public static void HomePage()
        {

            LoadReviews();

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
                        admnIU();

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
                Console.WriteLine("0- View balances");


                Console.WriteLine("Enter Number");

                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        recustCreateAccounts();
                        break;

                    case 2:
                        depostitMoney();

                        break;
                    case 3:
                        withdrawMoney();

                        break;
                    case 4:
                        viewBalances();
                        break;
                    case 5:
                        viewTransactionHistory();

                        break;
                    case 6:
                        submitReview();

                        break;

                    case 0:
                        Console.Clear();
                        Flag = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Number Not foun :" + number + "\n");

                        break;

                }




            }


        }


        // Request For Create Account 
        public static void recustCreateAccounts()
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

            Console.Write("Enter ID Number  ");

            int idNumber;
            while (!int.TryParse(Console.ReadLine(), out idNumber))
            {
                Console.WriteLine("Invalid input ");
            }


            string userInfo = (name + "|" + idNumber );
            recustCreateAccountsInfo.Enqueue(userInfo);
            Console.WriteLine(" Your account request has been submitted ");

        
        }
        // Deposit Money
        public static void depostitMoney()
        {
            Console.Clear();
            Console.WriteLine("**************************************************************\n");

            Console.WriteLine("                          Deposit Page                            \n ");

            Console.WriteLine("**************************************************************\n");

            //   Console.Write("Enter Account Number : ");
            int accountNumber;
            while (!int.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Invalid input ");
            }
            Console.Write("Enter Amount to Deposit : ");
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid input ");
            }
            if (accountNumbers.Contains(accountNumber))
            {
                int index = accountNumbers.IndexOf(accountNumber);
                balances[index] += amount;
                Console.WriteLine($"Deposited {amount} to account {accountNumber}. New balance: {balances[index]}");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }





        }
        // Withdraw Money
        public static void withdrawMoney()
        {
            Console.Clear();
            Console.WriteLine("**************************************************************\n");
            Console.WriteLine("                          Withdraw Page                            \n ");
            Console.WriteLine("**************************************************************\n");
            //   Console.Write("Enter Account Number : ");
            int accountNumber;
            while (!int.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Invalid input ");
            }
            Console.Write("Enter Amount to Withdraw : ");
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid input ");
            }
            if (accountNumbers.Contains(accountNumber))
            {
                int index = accountNumbers.IndexOf(accountNumber);
                if (balances[index] >= amount)
                {
                    balances[index] -= amount;
                    Console.WriteLine($"Withdrew {amount} from account {accountNumber}. New balance: {balances[index]}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        public static void viewBalances()

        {

            Console.Clear();
            Console.WriteLine("**************************************************************\n");
            Console.WriteLine("                          View Balances Page                            \n ");
            Console.WriteLine("**************************************************************\n");
            Console.WriteLine("Account Number\tName\tBalance");
            for (int i = 0; i < accountNumbers.Count; i++)
            {
                Console.WriteLine($"{accountNumbers[i]}\t{accountNames[i]}\t{balances[i]}");
            }
            Console.WriteLine("**************************************************************\n");





        }
        //View transaction history
        public static void viewTransactionHistory()
        {
            Console.Clear();
            Console.WriteLine("**************************************************************\n");
            Console.WriteLine("                          Transaction History Page                            \n ");
            Console.WriteLine("**************************************************************\n");
            Console.WriteLine("Account Number\tName\tBalance");
            for (int i = 0; i < accountNumbers.Count; i++)
            {
                Console.WriteLine($"{accountNumbers[i]}\t{accountNames[i]}\t{balances[i]}");
            }
            Console.WriteLine("**************************************************************\n");
        }
        // submit review
        public static void submitReview()
        {
            Console.Clear();
            Console.WriteLine("**************************************************************\n");
            Console.WriteLine("                          Submit Review Page                            \n ");
            Console.WriteLine("**************************************************************\n");
            Console.Write("Enter your review: ");
            string review = Console.ReadLine();
            submetReiew.Push(review);
            SaveReviews();
            Console.WriteLine("Your review has been submitted.");


        }










        //++++++++++++++ admen ++++++++++++++++++++ //



        public static void admnIU()
        {

            Console.Clear();
            Console.WriteLine("**************************************************************\n");

            Console.WriteLine("                          User Page                            \n ");

            Console.WriteLine("**************************************************************\n");



            bool Flag = true;

            while (Flag)
            {
                Console.WriteLine("Select One Option");
                Console.WriteLine("1- View Recuestes  ");
                Console.WriteLine("2- View Accouts  ");
                Console.WriteLine("3- View Reviews ");
                Console.WriteLine("4-process recuest ");
                Console.WriteLine("6- View balances");


                Console.WriteLine("Enter Number");

                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        ProcessNextAccountRequest();
                        break;

                    case 2:
                        ViewAccountRequests();

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











        public  static void ProcessNextAccountRequest()
        {
            if (recustCreateAccountsInfo.Count == 0)
            {
                Console.WriteLine("No pending account requests.");
                return;
            }

            //var (name, nationalID) = createAccountRequests.Dequeue();
            string request = createAccountRequests.Dequeue();

            string[] parts = request.Split('|');
            string name = parts[0];
            string nationalID = parts[1];

            int newAccountNumber = userCordNumber + 1;

            accountNumbers.Add(newAccountNumber);
            accountNames.Add($"{name} ");
            balances.Add(0.0);

            userCordNumber = newAccountNumber;

            Console.WriteLine($"Account created for {name} with Account Number: {newAccountNumber}");
        }



        // vieew recuest
        public static void ViewAccountRequests()
        {
            Console.Clear();
            Console.WriteLine("**************************************************************\n");
            Console.WriteLine("                          Account Requests Page                            \n ");
            Console.WriteLine("**************************************************************\n");
            if (recustCreateAccountsInfo.Count == 0)
            {
                Console.WriteLine("No pending account requests.");
                return;
            }
            foreach (var request in recustCreateAccountsInfo)
            {
                Console.WriteLine(request);
            }

            Console.ReadLine();
        }































        /// Save Reviews to the file.


        public static void SaveReviews()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(pathFile))
                {
                    foreach (var review in recustCreateAccountsInfo)
                    {
                        writer.WriteLine(review);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error saving reviews.");
            }
        }

        /// <summary>
        /// Load Reviews from the file.
        /// </summary>
        static void LoadReviews()
        {
            try
            {
                if (!File.Exists(pathFile)) return;

                using (StreamReader reader = new StreamReader(pathFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        recustCreateAccountsInfo.Enqueue(line);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error loading reviews.");
            }

        }










    }
}
