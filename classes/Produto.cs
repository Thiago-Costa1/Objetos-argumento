namespace Nova_pasta.classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set;}
        public float Preco { get; set; }    
        
        // Primeiro método construtor
        public Produto(){

        }

        // Segundo método contrutor, que recebe o valor como argumento e 
        public Produto(int _codigo, string _nome, float _preco){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }   
    }
}