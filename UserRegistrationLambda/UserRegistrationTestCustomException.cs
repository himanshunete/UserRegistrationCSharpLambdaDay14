using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationLambda
{
    public class UserRegistrationTestCustomException:Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            USER_ENTERED_EMPTY,
            USER_ENTERED_LESSTHAN_MINIMUM_LENGTH,
            USER_ENTERED_NUMBER,
            USER_ENTERED_LOWERCASE,
            USER_ENTERED_SPECIAL_CHARACTER,




        }
        public UserRegistrationTestCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
