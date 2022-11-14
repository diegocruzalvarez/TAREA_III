using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Operaciones.Radio_Button;
namespace BLL_Operaciones.Radio_Button
{
   public class cls_Radio_Button_BLL
    {
        public void Sumatoria (ref cls_Radio_Button_DAL Obj_DAL)
        {
            for (int i = 1; i <=  Obj_DAL.iNumero_Limite; i++)
            {
                Obj_DAL.iSumar_todos += i;

                if ((i%2) == 0)
                {
                    Obj_DAL.iSumar_Pares += i;

                }
                else
                {
                    Obj_DAL.iSumarImpares += i;
                }
            }
        }
       
    }
}
