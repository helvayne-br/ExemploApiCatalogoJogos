using System;

namespace ExemploApiCatalogoJogos.Exceptions
{
    public class JogoNaoCadastradoException: Exception
    {
        public JogoNaoCadastradoException()
            :base("This game is not registered")
        {}
    }
}
