using Punto2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Punto2.Data
{
    public class EtiquetasAdmin
    {
        public IEnumerable<Etiquetas> Consultar()
        {
            ///<summary>
            /// Consulta todas las etiquetas
            ///</summary>
            ///<returns>Datos de las etiquetas</returns>
            using (Entities contexto = new Entities())
            {
                return contexto.Etiquetas.AsNoTracking().ToList();
            }
        }

        public void Guardar(Etiquetas modelo) {
            ///<summary>
            /// Guarda una Etiqueta en la base de datos
            ///</summary>
            ///<param name="="modelo"></param>
            using (Entities contexto = new Entities())
            {
                contexto.Etiquetas.Add(modelo);
                contexto.SaveChanges();
            }
        }

        public Etiquetas Consultar(int id)
        {
            ///<summary>
            /// Consulta objeto de Etiqueta
            ///</summary>
            ///<param name="="id"></param>
            using (Entities contexto = new Entities())
            {
                return contexto.Etiquetas.FirstOrDefault(e => e.Id == id);
            }
        }

        public void Modificar(Etiquetas modelo)
        {
            ///<summary>
            /// Modifica los datos de la etiqueta
            ///</summary>
            ///<param name="="modelo"></param>
            using (Entities contexto = new Entities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();

            }

        }

        public void Eliminar(Etiquetas modelo)
        {
            using (Entities contexto = new Entities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

    }
}
