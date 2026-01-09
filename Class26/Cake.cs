namespace Class27
{
    public class Cake
    {
        public string Flavor;
        public string Filling;
        public string Coverage;
        public int Layers;
        public string Size;

        public Cake()
        {
            Flavor = "Chocolate";
            Filling = "Coconut";
            Coverage = "Chocolate";
            Layers = 3;
            Size = "Medium";
        }

        public void Show()
        {
            Console.WriteLine($"Flavor: {Flavor}");
            Console.WriteLine($"Filling: {Filling}");
            Console.WriteLine($"Coverage: {Coverage}");
            Console.WriteLine($"Layers: {Layers}");
            Console.WriteLine($"Size: {Size}");
        }
    }
}