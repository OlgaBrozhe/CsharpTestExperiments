using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestClass]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestCreateNewGroup()
        {
            OpenPage(baseURL);
            Login(new AccountData("admin","secret"));
            GoToGroupsPage();
            SelectNewGroup();
            GroupData group = new GroupData("1");
            FillInGroupInfo(group);
            SubmitAction();
            ReturnToHomePage();
        }
    }
}
