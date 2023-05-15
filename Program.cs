namespace ConsoleApp1
{
    internal class Program
    {

        delegate void Hellowde(string msg);
        static void Main(string[] args)
        {

            List<LearnVip> listlearnvip = new()
            {
                new LearnVip() { Id = 1, Name = "a1", price = 444 },
                new LearnVip() { Id = 2, Name = "a2", price = 555 },
                new LearnVip() { Id = 3, Name = "a3", price = 666 },
                new LearnVip() { Id = 4, Name = "a4", price = 777 },
                new LearnVip() { Id = 5, Name = "a5", price = 888 }
            };


            listlearnvip.Where(x => x.price >= 600).ToList().ForEach(x => Console.WriteLine(x.Name + " 是VIP"));
        }



    }

    class LearnVip
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int price { get; set; }
        public static void JisuanVip(List<LearnVip> Vips)
        {
            foreach (var vip in Vips)
            {
                if (vip.price >= 600)
                {
                    Console.WriteLine(vip.Name + " 是VIP");
                }
            }
        }
    }
}