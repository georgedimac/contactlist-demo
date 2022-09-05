namespace ang_test;

public class Contact
{
    public string Name { get; set; }
    public string Address { get; set; }   
}

public class Contacts
{


   public static List<Contact> ContactList = new List<Contact>
    {
        new Contact { Name = "Contact1", Address="Address1" },
        new Contact { Name = "Contact2", Address="Address2" },
        new Contact { Name = "Contact3", Address="Address3" }
    };


}
