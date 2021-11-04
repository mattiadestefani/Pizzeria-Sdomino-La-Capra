namespace PizzeriaSdomino.Model
{
    public class Margherita : IBase
    {
        public (decimal Prezzo, string Descrizione) GetBase() => (5, this.GetType().Name);
    }
}
