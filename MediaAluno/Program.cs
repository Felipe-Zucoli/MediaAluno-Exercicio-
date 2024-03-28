// See https://aka.ms/new-console-template for more information


using MediaAluno;

class  Exercicio3
{
    static void Main()
    {
        for (int i = 0; i < 2; i++) { 
        DadosAluno dados =new DadosAluno();

        Console.WriteLine("Informe o nome do aluno: ");
        dados.name = Console.ReadLine();

        Console.WriteLine("Informe a primeira nota: ");
        dados.nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota :");
        dados.nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("informe a terceira nota: ");
        dados.nota3 = double.Parse(Console.ReadLine());
        
        if (dados.nota1 >30)
            {
                Console.WriteLine("nota inválida o limite é 30!");
            }
        else
            {
                Console.WriteLine($"Primeira nota: {dados.nota1}");
            }
        if (dados.nota2 >35 && dados.nota3 > 35)
            {
                Console.WriteLine("A algo de errado nas notas, lembre que o máximo é 35!");
            } 
        else
            {
                Console.WriteLine($"Segunda nota: {dados.nota2}");
                Console.WriteLine($"Terceira nota: {dados.nota3}");
            }
            Console.WriteLine($"A média do aluno {dados.name}, foi de {dados.media()}");
            if (dados.media() >= 60) {
                Console.WriteLine("Aluno aprovado");
            } else
            {
                Console.WriteLine("Aluno Reprovado");
            }
        }
    }
}
