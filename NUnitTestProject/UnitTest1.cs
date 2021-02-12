using NUnit.Framework;
using UserRegistrationLambda;

namespace NUnitTestProject
{
    public class Tests
    {

        UserRegistrationTestLambda userRegistration;
        [SetUp]
        public void Setup()
        {
            userRegistration = new UserRegistrationTestLambda();
        }

        /// <summary>
        /// TC-1 Throw Custom Exception for Invalid FirstName
        /// </summary>
        [TestCase("Himanshu")]
        [TestCase("Ne")]
        public void Given_FirstName_Expecting_ThrowCustomException(string firstName)
        {
            string actual = " " ;
            try
            {
                actual = userRegistration.FirstNameLambda(firstName);
            }
            catch(UserRegistrationTestCustomException exception)
            {
                Assert.AreEqual("FirstName should contains atleast three characters", exception.Message);
            }
        }

        /// <summary>
        /// TC-2 Throw Custom Exception for Invalid LastName
        /// </summary>
        [TestCase("Nete")]
        [TestCase("Ka")]
        public void Given_LastName_Expecting_ThrowCustomException(string lastName)
        {
            string actual = " ";
            try
            {
                actual = userRegistration.LastNameLambda(lastName);
            }
            catch (UserRegistrationTestCustomException exception)
            {
                Assert.AreEqual("LastName should contains atleast three characters", exception.Message);
            }
        }

    }
}