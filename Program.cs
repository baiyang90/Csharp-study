using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ServiceCollection serviceDescriptors = new();
            serviceDescriptors.AddTransient<Human1>();
            serviceDescriptors.AddTransient<Human2>();
            Human1 humantt;
            using(ServiceProvider sp1 = serviceDescriptors.BuildServiceProvider())
            {
                var humana = sp1.GetService<Human1>();
                humana.Name = "张三";
                humana.Say();
                var humanb = sp1.GetService<Human2>();
                humanb.Name = "张4";
                humanb.Say();
                humantt = humana;
                Console.WriteLine(object.ReferenceEquals(humantt, humanb));
            }
            using(ServiceProvider sp2 = serviceDescriptors.BuildServiceProvider())
            {
                Human1 humana = sp2.GetService<Human1>();
                humana.Name = "张三2";
                humana.Say();
                Human1 humanb = sp2.GetService<Human1>();
                humanb.Name = "张42";
                humanb.Say();
                Console.WriteLine(object.ReferenceEquals(humantt, humana));
            }
        }
    }

    internal interface IHuman
    {
        public string Name
        {
            get; set;
        }

        void Say();
    }

    internal class Human1 : IHuman
    {
        public string Name
        {
            get
            {
                if(Name != null)
                    return Name;
                return "null";
            }
            set
            {
                Name = value;
            }
        }

        public void Say()
        {
            Console.WriteLine("Hello,My name is " + Name);
        }
    }

    internal class Human2 : IHuman
    {
        public string Name
        {
            get
            {
                if(Name != null)
                    return Name;
                return "null";
            }
            set
            {
                Name = value;
            }
        }

        public void Say()
        {
            Console.WriteLine("Hello,My pig is " + Name);
        }
    }
}