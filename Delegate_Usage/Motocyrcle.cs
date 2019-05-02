using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Usage
{
    delegate void MotorcycleNotifyHandler(string message);

    class Motocyrcle
    {
        private int _odometr;
        private MotorcycleNotifyHandler _handler;
        public int Odometr
        {
            get { return _odometr; }
            set { _odometr = value; }
        }

        public void RegisterHandler(MotorcycleNotifyHandler @delegate)
        {
            _handler = @delegate;
        }

        public void Move(int km)
        {
            Odometr += km;

            if (Odometr >= 10000)
            {
                //Console.WriteLine("Go to service");
                _handler("Go to service");
            }
        }
    }
}
