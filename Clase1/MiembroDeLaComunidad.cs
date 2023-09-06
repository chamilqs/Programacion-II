using System;

namespace Clase1{

    public abstract class MiembroDeLaComunidad : IMiembroDeLaComunidad{

        public virtual void Saludar(){
            // Console.WriteLine("Hola, soy un miembro de la comunidad");
        }

        public abstract  void Quejarse();

        public abstract void Caminar();

        public abstract void BeberAgua();
    }

}