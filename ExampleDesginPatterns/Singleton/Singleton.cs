using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDesginPatterns
{
    //Objetivo: Manter apenas uma instancia da classe.
    public sealed class Singleton
    {
        static Singleton _intance;

        //Fazer o construtor padrão privado( proíbe qualquer acesso externo à própria classe, inclusive das classes filhas.)
        //para prevenir que outros objetos usem o operador “new” com a classe singleton.
        private Singleton() { }


        //Metodo estático(não pode ser instanciado) que retorna a instancia do objeto.
        public static Singleton GetInstance()
        {
            if (_intance == null)
                return _intance = new Singleton();
            else
                return _intance;

        }
    }
}
