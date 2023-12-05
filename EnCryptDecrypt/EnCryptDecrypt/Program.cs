namespace EnCryptDecrypt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter The Password : ");
            string inputPassword = Console.ReadLine();
            string EncryptedPassword = "";
            int[] DecrptyPassword = new int[inputPassword.Length];
            if (inputPassword.Length >0)
            {
                
                for(int i=0;i< inputPassword.Length; i++)
                {
                    int a = Convert.ToInt32(inputPassword[i]);
                    DecrptyPassword[i] = a;
                    EncryptedPassword = EncryptedPassword + a;
                }
                Console.WriteLine(EncryptedPassword);

            }
            else
            {
                Console.WriteLine("PLESE ENTER THE VALIDE PASSWORD");
            }


            foreach(int i in DecrptyPassword)
            {
                //Console.WriteLine(i);
                int asciiValue = i; // ASCII value for i
                char character = Convert.ToChar(asciiValue);
                Console.Write(character);
            }

            Console.ReadLine();
            

        }
    }
}