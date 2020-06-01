using System;

namespace POO07Capsula
{
    class Program
    {
        static void Main(string[] args)
        {
           aelo aelo1 = new aelo();
           aelo1.ValoraDaCompra = 57f;
           aelo1.saldo = 60f;

           if(aelo1.ValoraDaCompra > aelo1.saldo){
            System.Console.WriteLine("saldo insuficiente");
           }else{
            System.Console.WriteLine("Compra realizada com sucesso");
           }
           
           aelo1.ValidarSenha();

        }
    }
}
