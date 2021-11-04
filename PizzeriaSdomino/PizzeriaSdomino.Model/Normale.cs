namespace PizzeriaSdomino.Model
{
    public class Normale : IImpasto
    {
        public (decimal Prezzo, string Descrizione) GetImpasto() => (0, this.GetType().Name);
    }
}
