namespace BancoDeDados {
    internal class Program {
        static void Main(string[] args) {
            string connectionstring = "DESKTOP-CFSSNFE\\SQLEXPRESS;Database=CursoCSharp;User Id=User;Password=123;Encrypt=False; TrustServerCertificate=False;";
            Funcionario funcionario = new Funcionario();
            funcionario.ObterLista();
            //funcionario.ExecutarStoreProcedure(connectionstring, 1);
            //funcionario.ExecutarStoreProcedure(connectionstring, 2);
            //funcionario.ExecutarStoreProcedure(connectionstring, 22);
            //funcionario.InserirDados(connectionstring);
        }
    }
}