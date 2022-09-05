namespace back_tests;

using ang_test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test(Description ="Check of there are contacts in the list")]
    public void Check_Empty_ContactList()
    {
        Assert.IsNotEmpty(Contacts.ContactList);
    }


    [TestCase(2, ExpectedResult = 2,Description ="Check of the list has N contacts")]
    public int Check_If_Has_N_Contacts(int n)
    {
        return Contacts.ContactList.Count();
    }
}
