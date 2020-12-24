using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestClass]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void TestCreateNewContact()
        {
            OpenPage(baseURL);
            Login(new AccountData("admin", "secret"));
            GoToAddNewContactPage();
            ContactData contact = new ContactData("1","1");
            FillInContactInfo(contact);
            SubmitAction();
            ReturnToHomePage();
        }
    }
}
