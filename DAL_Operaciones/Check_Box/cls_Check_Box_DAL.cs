using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Operaciones.Check_Box
{
    public class cls_Check_Box_DAL
    {
        #region Variables Privadas
        
        private int _iLimite_Random, _iRes_Arreglo,_iTamaño_Arreglo;


        #endregion


        #region Variables Publicas
        public int iLimite_Random { get => _iLimite_Random; set => _iLimite_Random = value; }
        public int iRes_Arreglo { get => _iRes_Arreglo; set => _iRes_Arreglo = value; }
        public int iTamaño_Arreglo { get => _iTamaño_Arreglo; set => _iTamaño_Arreglo = value; }
        #endregion
    }
}
