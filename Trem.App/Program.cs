namespace Train.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os comandos de movimento (ESQUERDA ou DIREITA) separados por espaços:");
            string? input = Console.ReadLine() ?? "";

            List<string> comandos = new List<string>(input.Split(' ', StringSplitOptions.RemoveEmptyEntries));

            Train train = new Train();
            train.DoTask(comandos);

            Console.WriteLine($"Posição final do trem: {train.Position}");
        }
    }
}
