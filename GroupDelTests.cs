using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestClass]
    public class GroupDelTests : TestBase
    {
        [Test]
        public void TestDelGroup()
        {
            OpenPage(baseURL);
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            SelectGroup(1);
            SubmitGroupDel();
            ReturnToGroupsPage();
        }
    }
}
