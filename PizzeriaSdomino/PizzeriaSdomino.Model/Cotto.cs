namespace PizzeriaSdomino.Model
{
    public class Cotto : IAggiunta
    {
        public (decimal Prezzo, string Descrizione) GetAggiunta() => (1, this.GetType().Name);
    }


}
