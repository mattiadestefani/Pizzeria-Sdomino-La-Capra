namespace PizzeriaSdomino.Model
{
    public static class FactoryImpasto
    {
        public static Impasto ImpastoBuilder(string impasto) => impasto switch
        {
            "Integrale" => new Integrale(),
            _ => new Normale()
        };
    }
}
