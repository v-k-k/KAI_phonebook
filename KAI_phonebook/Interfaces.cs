using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAI_phonebook
{
    interface IBase { }
    /// <summary>
    /// Describes required interfaces
    /// </summary>
    interface IHuman : IBase
    {
        string Lname { get; set; }
        string Fname { get; set; }
        string Mname { get; set; }
        string Sex { get; set; }
        string Bdate { get; set; }
    }
    interface IAddress : IBase
    {
        string Street { get; set; }
        string House { get; set; }
        string Flat { get; set; }
    }
    interface IPhone : IBase
    {
        string Number { get; set; }
        string Type { get; set; }
    }
}
