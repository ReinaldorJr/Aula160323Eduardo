namespace Aula160323
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conta minhaConta1 = new Conta();
            //minhaConta1.codigo = 123;
            //minhaConta1.saldo = 1500.0f;
            //minhaConta1.tipo = "corrente";
            //minhaConta1.dono = "Reinaldo";

            //Conta minhaConta1 = new Conta(123)
            //{

            //};

            Pessoa p1 = new Pessoa("Reinaldo", 38);
            Pessoa p2 = new Pessoa("Henrique");
            
            
           

            p1.imprimirNome();
            p2.imprimirNome();
            p1.imprimirInfos();
            p2.imprimirInfos();

                                       
            

        }
    }
}