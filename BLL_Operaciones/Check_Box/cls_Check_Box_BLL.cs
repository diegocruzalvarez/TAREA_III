using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Operaciones.Check_Box;
namespace BLL_Operaciones.Check_Box
{
    public class cls_Check_Box_BLL
    {
        
        public void ArregloT(ref cls_Check_Box_DAL Obj_DAL)
        {
            int[]  Arreglo = new int[Obj_DAL.iTamaño_Arreglo];
            Random num = new Random();

            for (int i = 0; i < Obj_DAL.iTamaño_Arreglo; i++)
            {
                Arreglo[i] = num.Next(Obj_DAL.iLimite_Random);


            }
            for (int i = 0; i < Obj_DAL.iTamaño_Arreglo; i++)
            {
                Obj_DAL.iRes_Arreglo = Arreglo[i];

            }


        }
    }
}
