
namespace SealedClass
{
    sealed class SealdClass //isko koi inharite nahi kar sakta 
    // it's totlly oposite to abstrect class
    {

        public void Commenting()
        {
            Console.WriteLine("Ye dekhte hai ye chl raha hai ki nahi");
        }

        //public abstract void Run(); //ye bhi nahi bana sakte due to seald class ko koi inharit nahi karenga to iski properties kaha denge ham 

    }
}
