using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person_Search
{
    static class Program
    {
        /* 
         * Сотрудник представлен структурой Person с полями: табельный номер, номер отдела, фамилия, оклад, 
         * дата поступления на работу, процент надбавки, подоходный налог, количество отработанных дней в месяце,
         * количество рабочих дней в месяце, начислено, удержано. Организовать поиск по номеру отдела, полу, дате поступления, фамилии.
        */
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
