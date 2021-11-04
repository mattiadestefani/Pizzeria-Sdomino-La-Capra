namespace PizzeriaSdomino.Model
{
    public class Funghi : IAggiunta
    {
        public (decimal Prezzo, string Descrizione) GetAggiunta() => (2, this.GetType().Name);
    }


}
