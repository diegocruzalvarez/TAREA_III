using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Operaciones.Timer;
namespace BLL_Operaciones.Timer
{
    public class cls_Timer_BLL
    {
        public void Timer(cls_Timer_DAL Obj_DAL)
        {
            Obj_DAL.iMilisegundos = Convert.ToInt32(Obj_DAL.iMilisegundos + 1);

            if (Obj_DAL.iMilisegundos > 100)
            {
                Obj_DAL.bSegundos = Convert.ToByte(Obj_DAL.bSegundos + 1);

                Obj_DAL.iMilisegundos = 0;

            }
            if (Obj_DAL.bSegundos > 59)
            {
                Obj_DAL.bMinutos = Convert.ToByte(Obj_DAL.bMinutos + 1);

                Obj_DAL.bSegundos = 0;

            }

        }
    }
}