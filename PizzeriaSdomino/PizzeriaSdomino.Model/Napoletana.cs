namespace PizzeriaSdomino.Model
{
    public class Napoletana : IBase
    {
        public (decimal Prezzo, string Descrizione) GetBase() => (3,this.GetType().Name);
    }
}
