namespace PizzeriaSdomino.Model
{
    public class Ananas : IAggiunta
    {
        public (decimal Prezzo, string Descrizione) GetAggiunta() => (0, this.GetType().Name);
    }


}
