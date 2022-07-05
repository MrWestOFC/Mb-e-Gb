namespace MbParaGb {
    
    class Program {
        static int mb(int mb) {
            return mb * 1024;
        }
        
        static void Main(String[] ars) {
            int x;
            
            Console.Write("Digite um valor >> ");
            x = int.Parse(Console.ReadLine());

            while (x != 0) {
                Console.WriteLine("Valor em Megabytes " + mb(x) + "Mib");
                Console.WriteLine("Valor em Gigabytes " + x + "Gib");
                Console.Write(">> ");
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}