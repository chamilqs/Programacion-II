using System;

namespace Clase1{
    public abstract class Empleado : MiembroDeLaComunidad
    {
        public String CodigoEmpleado { get; set; }
        public abstract void Trabajar();
        public override void BeberAgua()
        {
            throw new NotImplementedException();
        }
        public override void Caminar()
        {
            throw new NotImplementedException();
        }
        public override void Quejarse()
        {
            throw new NotImplementedException();
        }

            public abstract class Docente : Empleado
        {
            public override abstract void Trabajar();
            public class Maestro : Docente
            {
                public void CubrirAusencia()
                {
                    // Console.WriteLine("Estoy cubriendo una ausencia");
                }

                public override void Trabajar()
                {
                    throw new NotImplementedException();
                }
            }

            public class Administrador : Docente
            {
                public void Enseñar()
                {
                    // Console.WriteLine("Estoy ensenando");
                }

                public override void Trabajar()
                {
                    throw new NotImplementedException();
                }
            }
        }

            public class Administrativo : Empleado
        {
            public void Administrar()
            {
                // Console.WriteLine("Estoy administrando");
            }

            public override void Trabajar()
            {
                throw new NotImplementedException();
            }
        }

    }

}