using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
#region Using DAL Y BLL
using DAL_Operaciones.Check_Box;
using DAL_Operaciones.Ecuaciones_Cuadraticas;
using DAL_Operaciones.Radio_Button;
using DAL_Operaciones.Timer;
using BLL_Operaciones.Ecuaciones_Cuadraticas;
using BLL_Operaciones.Check_Box;
using BLL_Operaciones.Radio_Button;
using BLL_Operaciones.Timer;

#endregion
namespace PL_Operaciones.Principal
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        #region VALIDACION DE TEXTOS
        private void Validacion_de_Textos(TextBox Obj_Cajas_De_Texto)
        {
            if (Obj_Cajas_De_Texto.Text == String.Empty)
            {
                grp_Opciones_Cro.Enabled = false;
                erp_Control_Errores.Clear();
                Obj_Cajas_De_Texto.Focus();
            }

            else
            {
                float fDato = 0;
                if (Single.TryParse(Obj_Cajas_De_Texto.Text.Trim(), out fDato))
                {
                    btn_Llenar_Arreglo.Enabled = true;

                    grp_Opciones_Cro.Enabled = true;
                    grp_Opciones.Enabled = true;
                    grp_Opciones_Radio.Enabled = true;

                    erp_Control_Errores.Clear();
                    Obj_Cajas_De_Texto.Text = fDato.ToString();
                }
                else
                {
                    btn_Llenar_Arreglo.Enabled = false;
                    grp_Opciones_Radio.Enabled = false;
                    grp_Opciones_Cro.Enabled = false;
                    grp_Opciones.Enabled = false;
                    erp_Control_Errores.SetError(Obj_Cajas_De_Texto, "Los datos ingresados son invalidos");
                    erp_Control_Errores.Clear();
                    Obj_Cajas_De_Texto.Focus();

                }

            }

        }
        #endregion


      

        #region Ecuaciones
    private void txt_A_Leave(object sender, EventArgs e)
        {
            btn_Calcular.Enabled = true;
            Validacion_de_Textos(txt_A);
    }
        private void txt_B_Leave(object sender, EventArgs e)
        {
         
            Validacion_de_Textos(txt_B);
        }
        private void txt_C_Leave(object sender, EventArgs e)
            {
           
            Validacion_de_Textos(txt_C);

        }
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            txt_A.Enabled = false;
            txt_B.Enabled = false;
            txt_C.Enabled = false;

            cls_Ecu_Cuadraticas_BLL Obj_BLL = new cls_Ecu_Cuadraticas_BLL();
            cls_Ecu_Cuadraticas_DAL Obj_DAL = new cls_Ecu_Cuadraticas_DAL();


            Obj_DAL.fA = Convert.ToSingle(txt_A.Text.Trim());
            Obj_DAL.fB = Convert.ToSingle(txt_B.Text.Trim());
            Obj_DAL.fC = Convert.ToSingle(txt_C.Text.Trim());

            Obj_BLL.Discriminante(ref Obj_DAL);
            txt_Discriminante.Text = Obj_DAL.fDiscriminate.ToString();
            if (Obj_DAL.fDiscriminate == 0)
            {
                MessageBox.Show("La ecuacion tiene Una soluciones", "Ecuacion Cuadratica"
                      );
                Obj_BLL.Operacion_Igual(ref Obj_DAL);
                txt_Solucion_I.Text = Obj_DAL.fSolucion.ToString();
            }

            else if (Obj_DAL.fDiscriminate > 0)
                
            {
                MessageBox.Show("La ecuacion tiene dos soluciones", "Ecuacion Cuadratica"
                      );
                Obj_BLL.Operacion_Mayor(ref Obj_DAL);
                txt_Solucion_I.Text = Obj_DAL.fSolucion_I.ToString();
                txt_Solucion_II.Text = Obj_DAL.fSolucionII.ToString();

            }
            else
            {
                MessageBox.Show("La ecuacion no tiene solucion","Ecuacion Cuadratica"
                    );
                txt_Solucion_I.Text = "{}";

            }
        }



        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_A.Clear();
            txt_B.Clear();
            txt_C.Clear();
            txt_Discriminante.Clear();
            txt_Solucion_I.Clear();
            txt_Solucion_II.Clear();
            txt_A.Enabled = true;
            txt_B.Enabled = true;
            txt_C.Enabled = true;
            btn_Calcular.Enabled = false;

        }
        #endregion

        #region Radio Buttons
        private void btn_Sumar_Click(object sender, EventArgs e)
        {
            txt_Numero_Limite.Enabled = false;
            grp_Control.Enabled = false;
            cls_Radio_Button_DAL Obj_DAL = new cls_Radio_Button_DAL();
            cls_Radio_Button_BLL Obj_BLL = new cls_Radio_Button_BLL();
            Obj_DAL.iNumero_Limite = Convert.ToInt32(txt_Numero_Limite.Text);
            Obj_BLL.Sumatoria(ref Obj_DAL);
            if (rb_Todos.Checked == true)
            {
                txt_Resultado_radio.Text = Obj_DAL.iSumar_todos.ToString();
            }
             if(rb_Solo_Pares.Checked == true){
                txt_Resultado_radio.Text = Obj_DAL.iSumar_Pares.ToString();

            }
            if(rb_Solo_Impares.Checked == true)
            {
                txt_Resultado_radio.Text = Obj_DAL.iSumarImpares.ToString();
                 
            }
        }
        private void grp_Control_Leave(object sender, EventArgs e)
        {
            if (rb_Solo_Impares.Checked || rb_Solo_Pares.Checked || rb_Todos.Checked == true)
            {
                grp_Opciones_Radio.Enabled = true;
            }
            else { grp_Opciones_Radio.Enabled = false; }
        }

        private void btn_Limpiar_Radio_Click(object sender, EventArgs e)
        {
            txt_Numero_Limite.Enabled = true;
            grp_Control.Enabled = true;
            txt_Numero_Limite.Clear();
            txt_Resultado_radio.Clear();
        }

        private void txt_Numero_Limite_Leave(object sender, EventArgs e)
        {
            Validacion_de_Textos(txt_Numero_Limite);
        }
        #endregion

        #region CheckBox

        private void btb_Llenar_Arreglo_Click(object sender, EventArgs e)
        {
            
            cls_Check_Box_DAL Obj_DAL = new cls_Check_Box_DAL();
            cls_Check_Box_BLL Obj_BLL = new cls_Check_Box_BLL();
            Obj_DAL.iTamaño_Arreglo = Convert.ToInt32(txt_Tamaño_Arreglo.Text.Trim());
            Obj_DAL.iLimite_Random = Convert.ToInt32(txt_Limite_Arreglo.Text.Trim());

            Obj_BLL.ArregloT(ref Obj_DAL);
            txt_Res_Arreglo.Text = Obj_DAL.iRes_Arreglo.ToString();
        }
        private void btn_Ver_Arreglo_Click(object sender, EventArgs e)
        {
            cls_Check_Box_DAL Obj_DAL = new cls_Check_Box_DAL();
      
            txt_Res_Arreglo.Text = Obj_DAL.iRes_Arreglo.ToString();

        }
        private void btn_Limpiar_Arreglo_Click(object sender, EventArgs e)
        {
            txt_Limite_Arreglo.Clear();
            txt_Res_Arreglo.Clear();
            txt_Tamaño_Arreglo.Clear();
        }

        private void txt_Tamaño_Arreglo_Leave(object sender, EventArgs e)
        {
            Validacion_de_Textos(txt_Tamaño_Arreglo);
        }

        private void txt_Limite_Arreglo_Leave(object sender, EventArgs e)
        {
            Validacion_de_Textos(txt_Limite_Arreglo);
        }
        #endregion

        #region Timer
        private void btb_Iniciar_Click(object sender, EventArgs e)
        { 
            txt_Tiempo.Enabled = false;
            btn_Limpiar_Cro.Enabled = false;
            t_Cronometro.Start();
        
        }
        private void btn_Detener_Click(object sender, EventArgs e)
        {
            btn_Limpiar_Cro.Enabled = true;
            t_Cronometro.Stop();
           
        }
        private void btn_Limpiar_Cro_Click(object sender, EventArgs e)
        {
            txt_Tiempo.Enabled = true;
            btn_Detener.Enabled = true;
            btn_Iniciar.Enabled = true;
            txt_Tiempo.Clear();
            txt_Minutos.Text = "00";
            txt_Segundos.Text = "00";
            txt_Milisegundos.Text = "00";
        }
        private void t_Cronometro_Tick(object sender, EventArgs e)
        {
            cls_Timer_BLL Obj_BLL = new cls_Timer_BLL();
            cls_Timer_DAL Obj_DAL = new cls_Timer_DAL();

            Obj_DAL.bTiempo = Convert.ToByte(txt_Tiempo.Text.Trim());
            Obj_DAL.bSegundos = Convert.ToByte(txt_Segundos.Text.Trim());
            Obj_DAL.iMilisegundos = Convert.ToInt32(txt_Milisegundos.Text.Trim());
            Obj_DAL.bMinutos     = Convert.ToByte(txt_Minutos.Text.Trim());

            Obj_BLL.Timer(Obj_DAL);
            

            txt_Milisegundos.Text = Obj_DAL.iMilisegundos.ToString();
            txt_Segundos.Text = Obj_DAL.bSegundos.ToString();
            txt_Milisegundos.Text = Obj_DAL.iMilisegundos.ToString();
            txt_Minutos.Text = Obj_DAL.bMinutos.ToString();
            txt_Segundos.Text = Obj_DAL.bSegundos.ToString();

            if (Obj_DAL.bMinutos == Obj_DAL.bTiempo)
            {
                t_Cronometro.Stop();
                btn_Detener.Enabled = false;
                btn_Iniciar.Enabled = false;
                btn_Limpiar_Cro.Enabled = true;
            }



        }
        private void txt_Tiempo_Leave(object sender, EventArgs e)
        {
            grp_Opciones_Cro.Enabled = false;

            if (txt_Tiempo.Text == String.Empty)
            {
                grp_Opciones_Cro.Enabled = false;
               txt_Tiempo.Focus();
            }


            float fDato = 0;
                if (Single.TryParse(txt_Tiempo.Text.Trim(), out fDato))
                {
                    grp_Opciones_Cro.Enabled = true;

                    txt_Tiempo.Text = fDato.ToString();
                }
                else
                {   grp_Opciones_Cro.Enabled = false;                  
                    erp_Control_Errores.SetError(txt_Tiempo, "Los datos ingresados son invalidos");
                    erp_Control_Errores.Clear();
                    txt_Tiempo.Focus();

                }

            /* if (Convert.ToInt32(txt_Tiempo.Text) > 5)
       {
           MessageBox.Show("El tiempo debe de ser menor o igual a 5", "Tiempo");
           txt_Minutos.Focus();

       }*/

        }


        #endregion




        private void btn_Salir_Click(object sender, EventArgs e)
        {
          
            Application.Exit();
        }

       
    }
}
