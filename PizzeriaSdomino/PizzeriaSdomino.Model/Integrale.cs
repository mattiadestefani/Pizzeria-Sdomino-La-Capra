namespace PizzeriaSdomino.Model
{
    public class Integrale : IImpasto
    {
        public (decimal Prezzo, string Descrizione) GetImpasto() => (1, this.GetType().Name);
    }
}
