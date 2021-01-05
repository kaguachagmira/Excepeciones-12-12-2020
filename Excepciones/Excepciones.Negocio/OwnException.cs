using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones.Negocio
{
    public class OwnExceptionRange : Exception
    {
        public OwnExceptionRange()
        {
        }

        public OwnExceptionRange(string message)
            : base(String.Format("La longuitud del string sobrepasa el permitido"))
        {

        }

    }

}
