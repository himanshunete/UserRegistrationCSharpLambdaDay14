using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace UserRegistrationLambda
{
    public class UserRegistrationTestLambda
    {
        string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";
        string emailPattern = "^[0-9a-zA-Z]+([._+-]?[0-9a-zA-Z]+)*@[0-9A-Za-z]+.([c]{1}[o]{1}[m]{1})*([n]{1}[e]{1}[t]{1})*[,]*([.][a]{1}[u]{1})*([.][c]{1}[o]{1}[m]{1})*$";
        string mobileNumberPattern = "^[9]{1}[1]{1}[ ][0-9]{10}$";
        string passwordPattern = "^[A-Z]{1}[a-zA-Z]{7,}([0-9]+)[@#$%^&*+-_]{1}$";

        public bool FirstName(string patternFirstName) => Regex.IsMatch(patternFirstName, firstNamePattern);


        /// <summary>
        /// FirstName Custom Exception
        /// </summary>
        /// <param name="patternFirstName"></param>
        /// <returns></returns>
        public string FirstNameLambda(string patternFirstName)
        {
            bool result = FirstName(patternFirstName);
            try
            {
                if (result == false)
                {

                    if (patternFirstName.Equals(string.Empty))
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_EMPTY, "FirstName should not be empty");
                    }
         

                    if (patternFirstName.Length < 3)
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_LESSTHAN_MINIMUM_LENGTH, "FirstName should contains atleast three characters");
                    
                    }

                    if (patternFirstName.Any(char.IsDigit))
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_NUMBER, "FirstName should not contains number");
                    }
                    if (!char.IsUpper(patternFirstName[0]))
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_LOWERCASE, "FirstName first letter should not be a lowercase");
                    }
                    if (patternFirstName.Any(char.IsLetterOrDigit))
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_SPECIAL_CHARACTER, "FirstName should not contains special characters");
                    }

                }
            }
            catch (UserRegistrationTestCustomException exception)
            {
                throw exception;
            }
            return "FirstName is not valid";



        }

    }
}
