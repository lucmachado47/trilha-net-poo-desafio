namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {   
        private string _modelo;
        private string _imei;
        private int _memoria;

        public string Numero { get; set; }
        private string Modelo { 
            get => _modelo; 

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O valor não pode ser vazio");
                }
                _modelo = value;
            } 
            }
        private string IMEI { 
            get => _imei; 

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O valor não pode ser vazio");
                }
                _imei = value;
            } 
            }
        private int Memoria { 
            get => _memoria; 

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("O valor não pode ser negativo");
                }
                _memoria = value;
            } 
            }
        

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}