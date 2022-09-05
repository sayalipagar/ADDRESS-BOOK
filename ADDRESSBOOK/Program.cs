namespace ADDRESSBOOK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact()
            {
                FirstName = "Sayali",
                LastName = "Nikam",
                Address = "Pune",
                City ="pune",
                State = "Maharastra",
                Zip = 411061,
                PhoneNo="879595869",
                Email = "sayalipagar@gmail.com"

            };
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNo + "\n" + contact.Email);
        }
    }
}