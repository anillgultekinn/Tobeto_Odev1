namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker() ,
                new Manager(),
                new Robot() ,
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager(),
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void Salary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("abc");
        }

        public void Salary()
        {
            Console.WriteLine("abc");
        }

        public void Work()
        {
            Console.WriteLine("abc");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("abc");
        }

        public void Salary()
        {
            Console.WriteLine("abc");
        }

        public void Work()
        {
            Console.WriteLine("abc");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("abc");
        }
    }
}