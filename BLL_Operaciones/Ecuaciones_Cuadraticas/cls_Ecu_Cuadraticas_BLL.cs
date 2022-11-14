using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Operaciones.Ecuaciones_Cuadraticas;
namespace BLL_Operaciones.Ecuaciones_Cuadraticas
{
    public class cls_Ecu_Cuadraticas_BLL
    {

        public void Discriminante(ref cls_Ecu_Cuadraticas_DAL Obj_DAL)
        {
           
           Obj_DAL.fDiscriminate= Convert.ToSingle(Math.Pow(Obj_DAL.fB, 2)) - 4 * (Obj_DAL.fA * Obj_DAL.fC);
        }
        public void Operacion_Mayor(ref cls_Ecu_Cuadraticas_DAL Obj_DAL)
        {
            Obj_DAL.dDiscriminanteR =Math.Sqrt(Obj_DAL.fDiscriminate);
            Obj_DAL.fSolucion_I = (- Obj_DAL.fB + Convert.ToSingle(Obj_DAL.dDiscriminanteR)) / (2 * Obj_DAL.fA);
            Obj_DAL.fSolucionII= (- Obj_DAL.fB - Convert.ToSingle(Obj_DAL.dDiscriminanteR)) / (2 * Obj_DAL.fA);
        }
        public void Operacion_Igual(ref cls_Ecu_Cuadraticas_DAL Obj_DAL)
        {
            Obj_DAL.fSolucion = (- Obj_DAL.fB) / (2 * Obj_DAL.fA);

        }

    }
}
