using System;


namespace Polymorphism
{
    public abstract class UserErrorClass   // Abstract class
    {
        public abstract string UEMessage();  // Abstract method

    }


    public class NumericInputError : UserErrorClass
    {

        public override string UEMessage()
        {
            string str = "You tried to use numeric input in a text only field. This fired an error!";
          return str;
        }

    }


    public class TextInputError : UserErrorClass
    {

        public override string UEMessage()
        {
            string str = "You tried to use a textinput in a numericonly field. This fired an error!";
            return str;
        }

    }

}