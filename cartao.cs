namespace POO07Capsula
{
    public class cartao
    {
        public string numero { get; set; }
        
        private string numeroCartao { get; set; }
        protected string senha { get; set; }
        

        public string ValidarSenha(){
            if( senha != "" ){
                return "senha validada" ;
            }
            return "senha invalida";
            
        }
        
        
        
    }
}