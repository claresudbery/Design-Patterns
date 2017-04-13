using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.FactoryPatterns;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string description = "";
            if (args.Length > 0)
            {
                description = args[0];
            }
            IMachine machine = GetMachine(description);
            machine.TurnOn();
            machine.TurnOff();

            Console.ReadKey();
        }

        private static IMachine GetMachine(string description)
        {
            switch (description)
            {
                case "robot":
                    return new Robot();
                case "car":
                    return new Car();
                default:
                    return new UnknownMachine();
            }
        }

        //static void Main(string[] args)
        //{
        //    string description = "";
        //    if (args.Length > 0)
        //    {
        //        description = args[0];
        //    }
        //    IMachine machine = new MachineFactory().CreateInstance(description);
        //    machine.TurnOn();
        //    machine.TurnOff();

        //    Console.ReadKey();
        //}
    }
}
