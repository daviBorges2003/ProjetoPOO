using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trabalho.interfaces
{
    public interface iAuth
    {
            bool Autenticar(string email, string senha);
    }
}