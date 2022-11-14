using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Operaciones.Ecuaciones_Cuadraticas
{
    public class cls_Ecu_Cuadraticas_DAL
    {
        #region Variables Privadas
        private float _fA, _fB, _fC, _fResulatado, _fDiscriminate, _fSolucion,_fSolucion_I, _fSolucionII;
        private double _dDiscriminanteR;


        #endregion


        #region Variables Publicas
        public float fA { get => _fA; set => _fA = value; }
        public float fB { get => _fB; set => _fB = value; }
        public float fC { get => _fC; set => _fC = value; }
        public float fResulatado { get => _fResulatado; set => _fResulatado = value; }
        public float fDiscriminate { get => _fDiscriminate; set => _fDiscriminate = value; }
        public float fSolucion_I { get => _fSolucion_I; set => _fSolucion_I = value; }
        public float fSolucionII { get => _fSolucionII; set => _fSolucionII = value; }
        public float fSolucion { get => _fSolucion; set => _fSolucion = value; }
        public double dDiscriminanteR { get => _dDiscriminanteR; set => _dDiscriminanteR = value; }

        #endregion
    }
}
