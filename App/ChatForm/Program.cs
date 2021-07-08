using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatLogger;
using BusinessClass;
using Unity;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace ChatForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Unity
            UnityContainer container = new UnityContainer();
            container.RegisterType<ILoggingService, Logger>();
            container.RegisterType<IMessaging, TaskHandler>();

            // Castle Windsor
            //var container = new WindsorContainer();
            // register interfaces and their implementation
            //container.Register(Component.For<Form1>());
            //container.Register(Component.For<ILoggingService>().ImplementedBy<Logger>());
            //container.Register(Component.For<IMessaging>().ImplementedBy<TaskHandler>());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<Form1>());
            //Application.Run(container.Resolve<Form1>());
        }
    }
}
