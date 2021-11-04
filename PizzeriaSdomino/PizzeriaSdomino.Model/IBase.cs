using System;

namespace PizzeriaSdomino.Model
{
    public interface IBase
    {
        (decimal Prezzo,string Descrizione) GetBase();
    }
}
