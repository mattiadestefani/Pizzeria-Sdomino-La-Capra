using System;

namespace PizzeriaSdomino.Model
{
    public static class FactoryAggiunta
    {
        public static Aggiunta AggiuntaBuilder(string aggiunta) => aggiunta switch
        {
            "Prosciutto Cotto" => new Cotto(),
            "Funghi" => new Funghi(),
            "Crudo" => new Crudo(),
            "Ananas" => new Ananas(),
            _ => throw new Exception("Nessuna aggiunta rimasta")
        };
    }
}
