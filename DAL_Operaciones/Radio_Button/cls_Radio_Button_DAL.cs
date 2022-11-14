using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Operaciones.Radio_Button
{
    public class cls_Radio_Button_DAL
    {
        #region Variables Privadas
        private int _iNumero_Limite,_iSumar_todos,_iSumar_Pares,_iSumarImpares;




        #endregion


        #region Variables Publicas
        public int iNumero_Limite { get => _iNumero_Limite; set => _iNumero_Limite = value; }
        public int iSumar_todos { get => _iSumar_todos; set => _iSumar_todos = value; }
        public int iSumar_Pares { get => _iSumar_Pares; set => _iSumar_Pares = value; }
        public int iSumarImpares { get => _iSumarImpares; set => _iSumarImpares = value; }

        #endregion
    }
}
