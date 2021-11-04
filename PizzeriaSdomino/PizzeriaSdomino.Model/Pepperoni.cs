namespace PizzeriaSdomino.Model
{
    public class Pepperoni : IBase
    {
        public (decimal Prezzo, string Descrizione) GetBase() => (7, this.GetType().Name);
    }
}
