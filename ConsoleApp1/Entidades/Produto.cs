using System.Globalization;


namespace ConsoleApp1 {
    class Produto {
        // bloquear o public para usar o encapsulamento e tornar os atributos private
        // public string Nome;
        // public double Preco;
        // public int Quantidade; 
        private string _nome;  // atributos private ficam com andescor e primeira letra minúscula
        private double _preco;
        private int _quantidade;

        public string GetNome() { // criado metodo get para obter conteudo das variaveis private
            return _nome;
        }
        public double GetPreco() {
            return _preco;
        }
        public int GetQtde() {
            return _quantidade;
        }
        public void SetNome(string nome) { // criado metodo set para atribuir valor à uma variavel private -  void porque não dá retorno
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }
        public void SetPreco(double preco) { // criado metodo set para atribuir valor à uma variavel private
            _preco = preco;
        }
        public void SetQtde(int quantidade) { // criado metodo set para atribuir valor à uma variavel private
            _quantidade = quantidade;
        }

        public string Nome { // properties - tem o metodo get e set
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) { // value é usado para Fazer referencia ao atributo de entrada
                    _nome = value;
                }
            }
        }
        // public double Preco { get; private set; } // auto properties porque não precisa de logica dentro dele
        // Se colocar o private antes do set no program.cs não poderá usar p1.Preco = "tv"
        public double Preco { get { return _preco; } set { _preco = value; } } // auto properties porque não precisa de logica dentro dele
        public int Qtde { get { return _quantidade; } set { _quantidade = value; } } // auto properties porque não precisa de logica dentro dele

        // public Produto(string nome, double preco, int quantidade) { // construtor para inicializar as variáveis da classe
        public Produto(string nome, double preco) : this()  { // construtor para inicializar as variáveis da classe
                                                                        // construtor precisa ter o mesmo nome da classe
            this._nome = nome; // usado para forçar recebimento se o nome for igual , mesmo com minusculas
            this._preco = preco; // se Preço fosse começado com minuscula para não confundir com o atribudo da instância
          //  Quantidade = quantidade;
        }

        public Produto() { // criado um construtor padrão como sobrecarga para aceitar instanciamento nulo
            _quantidade = 0;
        }

        public Produto(string nome, double preco, int quantidade) : this (nome,preco) { // reutilisando o construtor de dois parametros
            _quantidade = quantidade;
        
        }

            public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidadeEnt) { // void quando não retorna parametro
            _quantidade += quantidadeEnt; // operação de adicionar quantidadeEnt ao campo Quantidade do objeto P
        }
        public void RemoverProdutos(int quantidadeEnt) {
            _quantidade -= quantidadeEnt; // operação de diminuir quantidadeEnt do campo Quantidade do objeto P
        }
        public override string ToString() { // override indica que a operação veio de outra classe - string é a saida
            return _nome  // indica a transformação do objeto em string no retorno
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
