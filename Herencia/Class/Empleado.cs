
using static Herencia.Class.Comunidad;

namespace Herencia.Class
{
    public class Empleado : Comunidad

    {
        private string _puesto;
        private string _supervisor;

        public string puesto { get; set; }
        private string  supervisor { get; set; }

    }
}
