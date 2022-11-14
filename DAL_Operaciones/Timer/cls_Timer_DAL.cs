using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Operaciones.Timer
{
    public class cls_Timer_DAL
    {
        #region Variables Privadas
        private byte _bMinutos,_bSegundos,_bTiempo;
        private int _iMilisegundos;

        #endregion


        #region Variables Publicas
        public byte bMinutos { get => _bMinutos; set => _bMinutos = value; }
        public byte bSegundos { get => _bSegundos; set => _bSegundos = value; }
        public byte bTiempo { get => _bTiempo; set => _bTiempo = value; }
        public int iMilisegundos { get => _iMilisegundos; set => _iMilisegundos = value; }



        #endregion
    }
}
