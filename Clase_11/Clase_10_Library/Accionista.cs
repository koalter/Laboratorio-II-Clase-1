using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Library
{
  public class Accionista : Persona
  {
      int _porcionAccionaria;

      public Accionista(string nombre, string apellido, int porcionAccionaria)
            : base(nombre, apellido)
      {
          this.PorcionAccionaria = porcionAccionaria;
      }

      public int PorcionAccionaria
      {
          get
          {
              return this._porcionAccionaria;
          }
          set
          {
              // Esto despues lo arreglaremos con Excepciones
              if (value > 100 || value < 0)
              {
                  this._porcionAccionaria = 0;
              }
              else
              {
                this._porcionAccionaria = value;
              }
          }
      }

      public override string PosicionSocietaria()
      {
          return "Accionista con el " + this.PorcionAccionaria + " % de la porción accionaria";
      }

      public static bool operator ==(Accionista a1, Accionista a2)
      {
          if (!object.ReferenceEquals(a1, null) && !object.ReferenceEquals(a2, null))
          {
              if (a1.Nombre == a2.Nombre && a1.Apellido == a2.Apellido && a1.PorcionAccionaria == a2.PorcionAccionaria)
              {
                  return true;
              }
          }
          return false;
      }
      public static bool operator !=(Accionista a1, Accionista a2)
      {
          return !(a1 == a2);
      }
  }
}
