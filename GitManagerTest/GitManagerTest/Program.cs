using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;

namespace GitManagerTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new BaseForm());
            //Application.Run(new MainForm());
            //Application.Run(new ClientInfoForm ());
            //Application.Run(new QueClientInfoForm());
            //Application.Run(new AddClientForm());
            //Application.Run(new StorehouseForm());
            //Application.Run(new SetHighValueForm());
            //Application.Run(new StoreInForm1());
            //Application.Run(new NewStoInForm());
            //Application.Run(new SITJForm());
            //Application.Run(new SOForm());
            //Application.Run(new ProductInfo());
            //Application.Run(new ClientInfo());
            //Application.Run(new BuyerInfoForm());



            
        }
    }
}
