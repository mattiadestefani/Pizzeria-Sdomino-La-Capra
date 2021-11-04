namespace PizzeriaSdomino.Model
{
    public class Crudo : IAggiunta
    {
        public (decimal Prezzo, string Descrizione) GetAggiunta() => (2, this.GetType().Name);
    }


}
