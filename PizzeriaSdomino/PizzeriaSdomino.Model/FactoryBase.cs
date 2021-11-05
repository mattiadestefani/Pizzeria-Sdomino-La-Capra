namespace PizzeriaSdomino.Model
{
    public static class FactoryBase
    {
        public static Base BaseBuilder(string tipoBase) => tipoBase switch
        {
            "Pepperoni" => new Pepperoni(),
            "Napoletana" => new Napoletana(),
            _ => new Margherita()
        };
    }
}