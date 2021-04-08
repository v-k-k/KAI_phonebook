using System;

namespace KAI_phonebook
{
    /// <summary>
    /// Implements the Assigned Interfaces
    /// </summary>
    [Serializable]
    public class Human : IHuman
    {
        public Human(string lname, string fname, string mname, string sex, string bdate)
        {
            Lname = lname;
            Fname = fname;
            Mname = mname;
            Sex = sex;
            Bdate = bdate;
        }
        public Human()
        { }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Sex { get; set; }
        public string Bdate { get; set; }
    }
    [Serializable]
    public class Address : IAddress
    {
        public Address()
        { }
        public Address(string street, string house, string flat)
        {
            Street = street;
            House = house;
            Flat = flat;
        }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
    }
    [Serializable]
    public class Phone : IPhone
    {
        public Phone()
        { }
        public Phone(string number, string type)
        {
            Number = number;
            Type = type;

        }
        public string Number { get; set; }
        public string Type { get; set; }
    }
    [Serializable]
    public class Data : IHuman, IAddress, IPhone
    {
        public Data()
        { }
        public Data(string lname, string fname, string mname, string sex, string bdate, string street, string house, string flat, string number, string type, string email)
        {
            Lname = lname;
            Fname = fname;
            Mname = mname;
            Sex = sex;
            Bdate = bdate;
            Street = street;
            House = house;
            Flat = flat;
            Address = Street + ' ' + House + ' ' + Flat;
            Number = number;
            Type = type;
            Email = email;
            Fio = Lname + ' ' + Fname + ' ' + Mname;
        }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Sex { get; set; }
        public string Bdate { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
        public string Fio { get; set; }
    }
}
