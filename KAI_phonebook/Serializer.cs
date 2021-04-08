using System.IO;
using System.ComponentModel;
using System.Xml.Serialization;

namespace KAI_phonebook
{
    public class Formatter
    {
        /// <summary>
        /// Implements class to operate the target XML data
        /// </summary>
        private XmlSerializer _formatter;

        public Formatter(ObjectType _type)
        {
            switch (_type)
            {
                case ObjectType.Human:
                    _formatter = new XmlSerializer(typeof(BindingList<Human>));
                    break;
                case ObjectType.Phone:
                    _formatter = new XmlSerializer(typeof(BindingList<Phone>));
                    break;
                case ObjectType.Address:
                    _formatter = new XmlSerializer(typeof(BindingList<Address>));
                    break;
                default:
                    _formatter = new XmlSerializer(typeof(BindingList<Data>));
                    break;
            }
        }

        public void Serialize(object obj, string source)
        {
            using (FileStream fs = new FileStream(source, FileMode.OpenOrCreate))
            {
                _formatter.Serialize(fs, obj);
            }
        }
        public object Deserialize(string source)
        {
            using (FileStream fs = new FileStream(source, FileMode.OpenOrCreate))
            {
                return _formatter.Deserialize(fs);
            }
        }
    }
}
