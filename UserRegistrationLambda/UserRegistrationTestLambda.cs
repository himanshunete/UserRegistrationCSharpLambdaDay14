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
        public bool LastName(string patternLastName) => Regex.IsMatch(patternLastName, lastNamePattern);
        public bool MobileNumber(string patternMobileNumber) => Regex.IsMatch(patternMobileNumber, mobileNumberPattern);



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

        /// <summary>
        /// LastName Custom Exception
        /// </summary>
        /// <param name="patternLastName"></param>
        /// <returns></returns>
        public string LastNameLambda(string patternLastName)
        {
            bool result = LastName(patternLastName);
            try
            {
                if (result == false)
                {

                    if (patternLastName.Equals(string.Empty))
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_EMPTY, "LastName should not be empty");
                    }


                    if (patternLastName.Length < 3)
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_LESSTHAN_MINIMUM_LENGTH, "LastName should contains atleast three characters");

                    }

                    if (patternLastName.Any(char.IsDigit))
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_NUMBER, "LastName should not contains number");
                    }
                    if (!char.IsUpper(patternLastName[0]))
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_LOWERCASE, "LastName first letter should not be a lowercase");
                    }
                    if (patternLastName.Any(char.IsLetterOrDigit))
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_SPECIAL_CHARACTER, "LastName should not contains special characters");
                    }

                }
            }

            catch (UserRegistrationTestCustomException exception)
            {
                throw exception;
            }
            return "LastName is not valid";
        }

        /// <summary>
        /// MobileNumber Custom Exception
        /// </summary>
        /// <param name="patternMobileNumber"></param>
        /// <returns></returns>
        public string MobileNumberLambda(string patternMobileNumber)
        {
            bool result = MobileNumber(patternMobileNumber);
            try
            {
                if (result == false)
                {

                    if (patternMobileNumber.Equals(string.Empty))
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_EMPTY, "MobileNumber should not be empty");
                    }


                    if (patternMobileNumber.Length < 3)
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_LESSTHAN_MINIMUM_LENGTH, "MobileNumber should contains atleast three characters");

                    }

                    if (patternMobileNumber.Any(char.IsDigit))
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_NUMBER, "MobileNumber should not contains number");
                    }
                    if (!char.IsUpper(patternMobileNumber[0]))
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_LOWERCASE, "MobileNumber first letter should not be a lowercase");
                    }
                    if (patternMobileNumber.Any(char.IsLetterOrDigit))
                    {
                        throw new UserRegistrationTestCustomException(UserRegistrationTestCustomException.ExceptionType.USER_ENTERED_SPECIAL_CHARACTER, "MobileNumber should not contains special characters");
                    }

                }
            }

            catch (UserRegistrationTestCustomException exception)
            {
                throw exception;
            }
            return "MobileNumber is not valid";
        }



    }
}
