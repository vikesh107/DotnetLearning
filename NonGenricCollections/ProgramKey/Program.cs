namespace ProgramKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter The Password : ");
            string inputPassword = Console.ReadLine();
            Console.WriteLine("Plese Enter The Key....");
            int key = Int32.Parse(Console.ReadLine());
            string EncryptedPassword = "";
            int[] DecrptyPassword = new int[inputPassword.Length];
            if (inputPassword.Length > 0)
            {

                for (int i = 0; i < inputPassword.Length; i++)
                {
                    int a = Convert.ToInt32(inputPassword[i]) + key;
                    DecrptyPassword[i] = a;
                    EncryptedPassword = EncryptedPassword + a;
                }
                Console.WriteLine(EncryptedPassword);

            }
            else
            {
                Console.WriteLine("PLESE ENTER tHE VALIDE PASSWORD");
            }


            foreach (int i in DecrptyPassword)
            {
                //Console.WriteLine(i);
                int asciiValue = i - key; // ASCII value for i
                char character = Convert.ToChar(asciiValue);
                Console.Write(character);
            }

            Console.ReadLine();


        }
    }
}