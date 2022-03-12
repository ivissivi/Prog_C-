using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parts_Dealership
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Client client = new Client();
            RegularClient regularClient = new RegularClient();

            if (regularClient.hasVisitedWithinTheLastYear == true)
            {
                Console.WriteLine("Yes");
            }

            if (regularClient.hasDiscountCard == true)
            {
                Console.WriteLine("Yes");
            }

            if (regularClient.isRegularClient == true)
            {
                Console.WriteLine("Yes");
            }

        }
    }
}
