using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParallelAndNarrowChange.Method;

namespace ParallelAndNarrowChange.Tests{
    [TestClass]
    public class AuthenticationServiceTest{
        [TestMethod]
        public void administrator_is_always_authenticated(){
            var service = new AuthenticationService();
            var adminId = 12345;
            Assert.IsTrue(service.IsAuthenticated(adminId));
        }

        [TestMethod]
        public void normalUser_is_not_authenticated_initially(){
            AuthenticationService service = new AuthenticationService();
            int normalUserId = 11111;
            Assert.IsFalse(service.IsAuthenticated(normalUserId));
        }
    }
}
