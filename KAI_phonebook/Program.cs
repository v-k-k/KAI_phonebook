using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAI_phonebook
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    static class Temporary
    {
        public static string Lname { get; set; }
        public static string Fname { get; set; }
        public static string Mname { get; set; }
        public static string Sex { get; set; }
        public static string Bdate { get; set; }
        public static string Address { get; set; }
        public static string Street { get; set; }
        public static string House { get; set; }
        public static string Flat { get; set; }
        public static string Number { get; set; }
        public static string Type { get; set; }
        public static string Email { get; set; }
        public static string Fio { get; set; }
    }
}
