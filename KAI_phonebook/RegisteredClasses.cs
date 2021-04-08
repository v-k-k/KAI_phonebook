using System;
using System.Collections.Generic;

namespace KAI_phonebook
{
    /// <summary>
    /// Contains collection of main structures
    /// </summary>
    public enum ObjectType
    {
        Data, Human, Address, Phone
    }
    public class Registered
    { 
        public static readonly List<Type> classes = new List<Type>()
        { new Data().GetType(), new Human().GetType(), new Address().GetType(), new Phone().GetType() };
    }
}
