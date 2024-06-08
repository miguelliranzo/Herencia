

namespace Herencia.Class
{
    
        public class Comunidad
    {
            //aritucolos
            private string? _nombre;
            private string? _apellido;
        

        //propiedades
        public string Nombre
            {
                get
                {
                    return this._nombre;

                }
                set
                {
                    this._nombre = value;
                }
            }


            public string Apellido
            {
                get
                {
                    return this._apellido;
                }
                set
                {
                    this._apellido = value;
                }
            }

            public string CodigoAdministrativo
            {

                get
                {
                    return this._codigoAdministrativo;
                }
                set
                {
                    this._codigoAdministrativo = value;
                }

            }


            public string CodigoAdministrador
            {

                get
                {
                    return this._codigoAdministrador;
                }
                set
                {
                    this._codigoAdministrador = value;
                }

            }





        }
    }




