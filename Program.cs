namespace Struct_home_work
{
    public enum Category { Food, Electronics, Clothing, Household, Other }

    internal class Program
    {
        static void Main(string[] args)
        {
           Product product = new Product();
           Check check = new Check ();
           check.AddToCheck(product);
           check.Show();
        }
    }
}
