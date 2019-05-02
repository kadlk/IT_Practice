using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            Motocyrcle motocyrcle = new Motocyrcle();
            MotorcycleNotifyHandler notifyHandler = new MotorcycleNotifyHandler(ShowMessage);
            motocyrcle.RegisterHandler(notifyHandler);

            motocyrcle.Move(1000);
            motocyrcle.Move(19500);

            Console.Read();
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
