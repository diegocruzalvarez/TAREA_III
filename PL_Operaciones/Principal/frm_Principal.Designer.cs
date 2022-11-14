
namespace PL_Operaciones.Principal
{
    partial class frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grp_Ecu_Cuadraticas = new System.Windows.Forms.GroupBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_Solucion_II = new System.Windows.Forms.TextBox();
            this.txt_Solucion_I = new System.Windows.Forms.TextBox();
            this.txt_Discriminante = new System.Windows.Forms.TextBox();
            this.lbl_Discriminante = new System.Windows.Forms.Label();
            this.lbl_Solucion_I = new System.Windows.Forms.Label();
            this.lbl_Solucion_II = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.lbl_C = new System.Windows.Forms.Label();
            this.lbl_A = new System.Windows.Forms.Label();
            this.grp_Opciones = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grp_Sumatorias = new System.Windows.Forms.GroupBox();
            this.txt_Resultado_radio = new System.Windows.Forms.TextBox();
            this.txt_Numero_Limite = new System.Windows.Forms.TextBox();
            this.lbl_Sumatoria = new System.Windows.Forms.Label();
            this.lbl_Numero_Limite = new System.Windows.Forms.Label();
            this.grp_Control = new System.Windows.Forms.GroupBox();
            this.rb_Solo_Impares = new System.Windows.Forms.RadioButton();
            this.rb_Solo_Pares = new System.Windows.Forms.RadioButton();
            this.rb_Todos = new System.Windows.Forms.RadioButton();
            this.grp_Opciones_Radio = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar_Radio = new System.Windows.Forms.Button();
            this.btn_Sumar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grp_Arreglo = new System.Windows.Forms.GroupBox();
            this.lbl_Contenido_Arreglo = new System.Windows.Forms.Label();
            this.txt_Res_Arreglo = new System.Windows.Forms.TextBox();
            this.txt_Limite_Arreglo = new System.Windows.Forms.TextBox();
            this.txt_Tamaño_Arreglo = new System.Windows.Forms.TextBox();
            this.lbl_Limite_Arreglo = new System.Windows.Forms.Label();
            this.lbl_Tamaño_Arreglo = new System.Windows.Forms.Label();
            this.btn_Llenar_Arreglo = new System.Windows.Forms.Button();
            this.grp_Opciones_Check = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar_Arreglo = new System.Windows.Forms.Button();
            this.btn_Ver_Arreglo = new System.Windows.Forms.Button();
            this.grp_Control_Check = new System.Windows.Forms.GroupBox();
            this.chk_Remo_Num_Mayor_50 = new System.Windows.Forms.CheckBox();
            this.chk_Remo_Num_Menor_X = new System.Windows.Forms.CheckBox();
            this.chk_Remo_Numeros_Pares = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grp_Cronometro = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Minutos = new System.Windows.Forms.TextBox();
            this.txt_Segundos = new System.Windows.Forms.TextBox();
            this.txt_Milisegundos = new System.Windows.Forms.TextBox();
            this.lbl_MIliesegundos = new System.Windows.Forms.Label();
            this.lbl_Segundos = new System.Windows.Forms.Label();
            this.lbl_Mini = new System.Windows.Forms.Label();
            this.lbl_Minutos = new System.Windows.Forms.Label();
            this.txt_Tiempo = new System.Windows.Forms.TextBox();
            this.lbl_Tiempo = new System.Windows.Forms.Label();
            this.grp_Opciones_Cro = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar_Cro = new System.Windows.Forms.Button();
            this.btn_Detener = new System.Windows.Forms.Button();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.erp_Control_Errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.t_Cronometro = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grp_Ecu_Cuadraticas.SuspendLayout();
            this.grp_Opciones.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grp_Sumatorias.SuspendLayout();
            this.grp_Control.SuspendLayout();
            this.grp_Opciones_Radio.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grp_Arreglo.SuspendLayout();
            this.grp_Opciones_Check.SuspendLayout();
            this.grp_Control_Check.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.grp_Cronometro.SuspendLayout();
            this.grp_Opciones_Cro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Control_Errores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(35, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage1.Controls.Add(this.grp_Ecu_Cuadraticas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ecuaciones Cuadraticas";
            // 
            // grp_Ecu_Cuadraticas
            // 
            this.grp_Ecu_Cuadraticas.Controls.Add(this.txt_A);
            this.grp_Ecu_Cuadraticas.Controls.Add(this.txt_B);
            this.grp_Ecu_Cuadraticas.Controls.Add(this.txt_C);
            this.grp_Ecu_Cuadraticas.Controls.Add(this.txt_Solucion_II);
            this.grp_Ecu_Cuadraticas.Controls.Add(this.txt_Solucion_I);
            this.grp_Ecu_Cuadraticas.Controls.Add(this.txt_Discriminante);
            this.grp_Ecu_Cuadraticas.Controls.Add(this.lbl_Discriminante);
            this.grp_Ecu_Cuadraticas.Controls.Add(this.lbl_Solucion_I);
            this.grp_Ecu_Cuadraticas.Controls.Add(this.lbl_Solucion_II);
            this.grp_Ecu_Cuadraticas.Controls.Add(this.lbl_B);
            this.grp_Ecu_Cuadraticas.Controls.Add(this.lbl_C);
            this.grp_Ecu_Cuadraticas.Controls.Add(this.lbl_A);
            this.grp_Ecu_Cuadraticas.Controls.Add(this.grp_Opciones);
            this.grp_Ecu_Cuadraticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Ecu_Cuadraticas.Location = new System.Drawing.Point(20, 27);
            this.grp_Ecu_Cuadraticas.Name = "grp_Ecu_Cuadraticas";
            this.grp_Ecu_Cuadraticas.Size = new System.Drawing.Size(616, 327);
            this.grp_Ecu_Cuadraticas.TabIndex = 0;
            this.grp_Ecu_Cuadraticas.TabStop = false;
            this.grp_Ecu_Cuadraticas.Text = "Informacion de la Ecuacion";
            // 
            // txt_A
            // 
            this.txt_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_A.Location = new System.Drawing.Point(40, 85);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(48, 28);
            this.txt_A.TabIndex = 1;
            this.txt_A.Text = "0";
            this.txt_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_A.Leave += new System.EventHandler(this.txt_A_Leave);
            // 
            // txt_B
            // 
            this.txt_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_B.Location = new System.Drawing.Point(121, 85);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(48, 28);
            this.txt_B.TabIndex = 2;
            this.txt_B.Text = "0";
            this.txt_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_B.Leave += new System.EventHandler(this.txt_B_Leave);
            // 
            // txt_C
            // 
            this.txt_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C.Location = new System.Drawing.Point(212, 85);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(50, 28);
            this.txt_C.TabIndex = 3;
            this.txt_C.Text = "0";
            this.txt_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_C.Leave += new System.EventHandler(this.txt_C_Leave);
            // 
            // txt_Solucion_II
            // 
            this.txt_Solucion_II.Enabled = false;
            this.txt_Solucion_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Solucion_II.Location = new System.Drawing.Point(194, 255);
            this.txt_Solucion_II.Name = "txt_Solucion_II";
            this.txt_Solucion_II.Size = new System.Drawing.Size(160, 28);
            this.txt_Solucion_II.TabIndex = 10;
            this.txt_Solucion_II.Text = "0";
            this.txt_Solucion_II.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Solucion_I
            // 
            this.txt_Solucion_I.Enabled = false;
            this.txt_Solucion_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Solucion_I.Location = new System.Drawing.Point(194, 202);
            this.txt_Solucion_I.Name = "txt_Solucion_I";
            this.txt_Solucion_I.Size = new System.Drawing.Size(160, 28);
            this.txt_Solucion_I.TabIndex = 9;
            this.txt_Solucion_I.Text = "0";
            this.txt_Solucion_I.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Discriminante
            // 
            this.txt_Discriminante.Enabled = false;
            this.txt_Discriminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Discriminante.Location = new System.Drawing.Point(194, 149);
            this.txt_Discriminante.Name = "txt_Discriminante";
            this.txt_Discriminante.Size = new System.Drawing.Size(160, 28);
            this.txt_Discriminante.TabIndex = 8;
            this.txt_Discriminante.Text = "0";
            this.txt_Discriminante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Discriminante
            // 
            this.lbl_Discriminante.AutoSize = true;
            this.lbl_Discriminante.Location = new System.Drawing.Point(46, 149);
            this.lbl_Discriminante.Name = "lbl_Discriminante";
            this.lbl_Discriminante.Size = new System.Drawing.Size(142, 25);
            this.lbl_Discriminante.TabIndex = 6;
            this.lbl_Discriminante.Text = "Discriminante";
            this.lbl_Discriminante.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Solucion_I
            // 
            this.lbl_Solucion_I.AutoSize = true;
            this.lbl_Solucion_I.Location = new System.Drawing.Point(50, 203);
            this.lbl_Solucion_I.Name = "lbl_Solucion_I";
            this.lbl_Solucion_I.Size = new System.Drawing.Size(108, 25);
            this.lbl_Solucion_I.TabIndex = 5;
            this.lbl_Solucion_I.Text = "Solucion I";
            this.lbl_Solucion_I.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Solucion_II
            // 
            this.lbl_Solucion_II.AutoSize = true;
            this.lbl_Solucion_II.Location = new System.Drawing.Point(46, 258);
            this.lbl_Solucion_II.Name = "lbl_Solucion_II";
            this.lbl_Solucion_II.Size = new System.Drawing.Size(114, 25);
            this.lbl_Solucion_II.TabIndex = 4;
            this.lbl_Solucion_II.Text = "Solucion II";
            this.lbl_Solucion_II.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Location = new System.Drawing.Point(138, 51);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(26, 25);
            this.lbl_B.TabIndex = 3;
            this.lbl_B.Text = "B";
            this.lbl_B.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.Location = new System.Drawing.Point(228, 51);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(28, 25);
            this.lbl_C.TabIndex = 2;
            this.lbl_C.Text = "C";
            this.lbl_C.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Location = new System.Drawing.Point(50, 51);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(27, 25);
            this.lbl_A.TabIndex = 1;
            this.lbl_A.Text = "A";
            this.lbl_A.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grp_Opciones
            // 
            this.grp_Opciones.Controls.Add(this.btn_Limpiar);
            this.grp_Opciones.Controls.Add(this.btn_Calcular);
            this.grp_Opciones.Location = new System.Drawing.Point(446, 62);
            this.grp_Opciones.Name = "grp_Opciones";
            this.grp_Opciones.Size = new System.Drawing.Size(146, 150);
            this.grp_Opciones.TabIndex = 4;
            this.grp_Opciones.TabStop = false;
            this.grp_Opciones.Text = "Opciones";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(19, 87);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(109, 41);
            this.btn_Limpiar.TabIndex = 1;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(19, 34);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(109, 39);
            this.btn_Calcular.TabIndex = 0;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.grp_Sumatorias);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Radio Button";
            // 
            // grp_Sumatorias
            // 
            this.grp_Sumatorias.Controls.Add(this.txt_Resultado_radio);
            this.grp_Sumatorias.Controls.Add(this.txt_Numero_Limite);
            this.grp_Sumatorias.Controls.Add(this.lbl_Sumatoria);
            this.grp_Sumatorias.Controls.Add(this.lbl_Numero_Limite);
            this.grp_Sumatorias.Controls.Add(this.grp_Control);
            this.grp_Sumatorias.Controls.Add(this.grp_Opciones_Radio);
            this.grp_Sumatorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Sumatorias.Location = new System.Drawing.Point(37, 30);
            this.grp_Sumatorias.Name = "grp_Sumatorias";
            this.grp_Sumatorias.Size = new System.Drawing.Size(669, 315);
            this.grp_Sumatorias.TabIndex = 0;
            this.grp_Sumatorias.TabStop = false;
            this.grp_Sumatorias.Text = "Sumatorias";
            // 
            // txt_Resultado_radio
            // 
            this.txt_Resultado_radio.Enabled = false;
            this.txt_Resultado_radio.Location = new System.Drawing.Point(201, 261);
            this.txt_Resultado_radio.Name = "txt_Resultado_radio";
            this.txt_Resultado_radio.Size = new System.Drawing.Size(356, 30);
            this.txt_Resultado_radio.TabIndex = 5;
            this.txt_Resultado_radio.Text = "0";
            this.txt_Resultado_radio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Numero_Limite
            // 
            this.txt_Numero_Limite.Location = new System.Drawing.Point(213, 48);
            this.txt_Numero_Limite.Name = "txt_Numero_Limite";
            this.txt_Numero_Limite.Size = new System.Drawing.Size(197, 30);
            this.txt_Numero_Limite.TabIndex = 1;
            this.txt_Numero_Limite.Text = "0";
            this.txt_Numero_Limite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Numero_Limite.Leave += new System.EventHandler(this.txt_Numero_Limite_Leave);
            // 
            // lbl_Sumatoria
            // 
            this.lbl_Sumatoria.AutoSize = true;
            this.lbl_Sumatoria.Location = new System.Drawing.Point(43, 266);
            this.lbl_Sumatoria.Name = "lbl_Sumatoria";
            this.lbl_Sumatoria.Size = new System.Drawing.Size(108, 25);
            this.lbl_Sumatoria.TabIndex = 3;
            this.lbl_Sumatoria.Text = "Resultado";
            // 
            // lbl_Numero_Limite
            // 
            this.lbl_Numero_Limite.AutoSize = true;
            this.lbl_Numero_Limite.Location = new System.Drawing.Point(43, 48);
            this.lbl_Numero_Limite.Name = "lbl_Numero_Limite";
            this.lbl_Numero_Limite.Size = new System.Drawing.Size(150, 25);
            this.lbl_Numero_Limite.TabIndex = 2;
            this.lbl_Numero_Limite.Text = "Numero Limite";
            // 
            // grp_Control
            // 
            this.grp_Control.Controls.Add(this.rb_Solo_Impares);
            this.grp_Control.Controls.Add(this.rb_Solo_Pares);
            this.grp_Control.Controls.Add(this.rb_Todos);
            this.grp_Control.Location = new System.Drawing.Point(6, 126);
            this.grp_Control.Name = "grp_Control";
            this.grp_Control.Size = new System.Drawing.Size(418, 72);
            this.grp_Control.TabIndex = 2;
            this.grp_Control.TabStop = false;
            this.grp_Control.Text = "Control";
            this.grp_Control.Leave += new System.EventHandler(this.grp_Control_Leave);
            // 
            // rb_Solo_Impares
            // 
            this.rb_Solo_Impares.AutoSize = true;
            this.rb_Solo_Impares.Location = new System.Drawing.Point(254, 37);
            this.rb_Solo_Impares.Name = "rb_Solo_Impares";
            this.rb_Solo_Impares.Size = new System.Drawing.Size(160, 29);
            this.rb_Solo_Impares.TabIndex = 5;
            this.rb_Solo_Impares.TabStop = true;
            this.rb_Solo_Impares.Text = "Solo Impares";
            this.rb_Solo_Impares.UseVisualStyleBackColor = true;
            // 
            // rb_Solo_Pares
            // 
            this.rb_Solo_Pares.AutoSize = true;
            this.rb_Solo_Pares.Location = new System.Drawing.Point(107, 37);
            this.rb_Solo_Pares.Name = "rb_Solo_Pares";
            this.rb_Solo_Pares.Size = new System.Drawing.Size(139, 29);
            this.rb_Solo_Pares.TabIndex = 4;
            this.rb_Solo_Pares.TabStop = true;
            this.rb_Solo_Pares.Text = "Solo Pares";
            this.rb_Solo_Pares.UseVisualStyleBackColor = true;
            // 
            // rb_Todos
            // 
            this.rb_Todos.AutoSize = true;
            this.rb_Todos.Location = new System.Drawing.Point(7, 37);
            this.rb_Todos.Name = "rb_Todos";
            this.rb_Todos.Size = new System.Drawing.Size(94, 29);
            this.rb_Todos.TabIndex = 3;
            this.rb_Todos.TabStop = true;
            this.rb_Todos.Text = "Todos";
            this.rb_Todos.UseVisualStyleBackColor = true;
            // 
            // grp_Opciones_Radio
            // 
            this.grp_Opciones_Radio.Controls.Add(this.btn_Limpiar_Radio);
            this.grp_Opciones_Radio.Controls.Add(this.btn_Sumar);
            this.grp_Opciones_Radio.Enabled = false;
            this.grp_Opciones_Radio.Location = new System.Drawing.Point(519, 63);
            this.grp_Opciones_Radio.Name = "grp_Opciones_Radio";
            this.grp_Opciones_Radio.Size = new System.Drawing.Size(144, 139);
            this.grp_Opciones_Radio.TabIndex = 6;
            this.grp_Opciones_Radio.TabStop = false;
            this.grp_Opciones_Radio.Text = "Opciones";
            // 
            // btn_Limpiar_Radio
            // 
            this.btn_Limpiar_Radio.Location = new System.Drawing.Point(18, 91);
            this.btn_Limpiar_Radio.Name = "btn_Limpiar_Radio";
            this.btn_Limpiar_Radio.Size = new System.Drawing.Size(109, 42);
            this.btn_Limpiar_Radio.TabIndex = 8;
            this.btn_Limpiar_Radio.Text = "Limpiar";
            this.btn_Limpiar_Radio.UseVisualStyleBackColor = true;
            this.btn_Limpiar_Radio.Click += new System.EventHandler(this.btn_Limpiar_Radio_Click);
            // 
            // btn_Sumar
            // 
            this.btn_Sumar.Location = new System.Drawing.Point(18, 21);
            this.btn_Sumar.Name = "btn_Sumar";
            this.btn_Sumar.Size = new System.Drawing.Size(109, 42);
            this.btn_Sumar.TabIndex = 7;
            this.btn_Sumar.Text = "Sumar";
            this.btn_Sumar.UseVisualStyleBackColor = true;
            this.btn_Sumar.Click += new System.EventHandler(this.btn_Sumar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage3.Controls.Add(this.grp_Arreglo);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(726, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Check Box";
            // 
            // grp_Arreglo
            // 
            this.grp_Arreglo.Controls.Add(this.lbl_Contenido_Arreglo);
            this.grp_Arreglo.Controls.Add(this.txt_Res_Arreglo);
            this.grp_Arreglo.Controls.Add(this.txt_Limite_Arreglo);
            this.grp_Arreglo.Controls.Add(this.txt_Tamaño_Arreglo);
            this.grp_Arreglo.Controls.Add(this.lbl_Limite_Arreglo);
            this.grp_Arreglo.Controls.Add(this.lbl_Tamaño_Arreglo);
            this.grp_Arreglo.Controls.Add(this.btn_Llenar_Arreglo);
            this.grp_Arreglo.Controls.Add(this.grp_Opciones_Check);
            this.grp_Arreglo.Controls.Add(this.grp_Control_Check);
            this.grp_Arreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Arreglo.Location = new System.Drawing.Point(6, 17);
            this.grp_Arreglo.Name = "grp_Arreglo";
            this.grp_Arreglo.Size = new System.Drawing.Size(703, 340);
            this.grp_Arreglo.TabIndex = 0;
            this.grp_Arreglo.TabStop = false;
            this.grp_Arreglo.Text = "Arreglo";
            // 
            // lbl_Contenido_Arreglo
            // 
            this.lbl_Contenido_Arreglo.AutoSize = true;
            this.lbl_Contenido_Arreglo.Location = new System.Drawing.Point(33, 307);
            this.lbl_Contenido_Arreglo.Name = "lbl_Contenido_Arreglo";
            this.lbl_Contenido_Arreglo.Size = new System.Drawing.Size(187, 25);
            this.lbl_Contenido_Arreglo.TabIndex = 8;
            this.lbl_Contenido_Arreglo.Text = "Contenido Arreglo";
            // 
            // txt_Res_Arreglo
            // 
            this.txt_Res_Arreglo.Location = new System.Drawing.Point(238, 307);
            this.txt_Res_Arreglo.Name = "txt_Res_Arreglo";
            this.txt_Res_Arreglo.Size = new System.Drawing.Size(215, 30);
            this.txt_Res_Arreglo.TabIndex = 7;
            this.txt_Res_Arreglo.Text = "0";
            this.txt_Res_Arreglo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Limite_Arreglo
            // 
            this.txt_Limite_Arreglo.Location = new System.Drawing.Point(189, 81);
            this.txt_Limite_Arreglo.Name = "txt_Limite_Arreglo";
            this.txt_Limite_Arreglo.Size = new System.Drawing.Size(143, 30);
            this.txt_Limite_Arreglo.TabIndex = 6;
            this.txt_Limite_Arreglo.Text = "0";
            this.txt_Limite_Arreglo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Limite_Arreglo.Leave += new System.EventHandler(this.txt_Limite_Arreglo_Leave);
            // 
            // txt_Tamaño_Arreglo
            // 
            this.txt_Tamaño_Arreglo.Location = new System.Drawing.Point(189, 36);
            this.txt_Tamaño_Arreglo.Name = "txt_Tamaño_Arreglo";
            this.txt_Tamaño_Arreglo.Size = new System.Drawing.Size(143, 30);
            this.txt_Tamaño_Arreglo.TabIndex = 5;
            this.txt_Tamaño_Arreglo.Text = "0";
            this.txt_Tamaño_Arreglo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Tamaño_Arreglo.Leave += new System.EventHandler(this.txt_Tamaño_Arreglo_Leave);
            // 
            // lbl_Limite_Arreglo
            // 
            this.lbl_Limite_Arreglo.AutoSize = true;
            this.lbl_Limite_Arreglo.Location = new System.Drawing.Point(18, 75);
            this.lbl_Limite_Arreglo.Name = "lbl_Limite_Arreglo";
            this.lbl_Limite_Arreglo.Size = new System.Drawing.Size(142, 25);
            this.lbl_Limite_Arreglo.TabIndex = 4;
            this.lbl_Limite_Arreglo.Text = "Limite arreglo";
            // 
            // lbl_Tamaño_Arreglo
            // 
            this.lbl_Tamaño_Arreglo.AutoSize = true;
            this.lbl_Tamaño_Arreglo.Location = new System.Drawing.Point(6, 36);
            this.lbl_Tamaño_Arreglo.Name = "lbl_Tamaño_Arreglo";
            this.lbl_Tamaño_Arreglo.Size = new System.Drawing.Size(164, 25);
            this.lbl_Tamaño_Arreglo.TabIndex = 3;
            this.lbl_Tamaño_Arreglo.Text = "Tamaño arreglo";
            // 
            // btn_Llenar_Arreglo
            // 
            this.btn_Llenar_Arreglo.Location = new System.Drawing.Point(347, 63);
            this.btn_Llenar_Arreglo.Name = "btn_Llenar_Arreglo";
            this.btn_Llenar_Arreglo.Size = new System.Drawing.Size(161, 37);
            this.btn_Llenar_Arreglo.TabIndex = 2;
            this.btn_Llenar_Arreglo.Text = "Llenar Arreglo";
            this.btn_Llenar_Arreglo.UseVisualStyleBackColor = true;
            this.btn_Llenar_Arreglo.Click += new System.EventHandler(this.btb_Llenar_Arreglo_Click);
            // 
            // grp_Opciones_Check
            // 
            this.grp_Opciones_Check.Controls.Add(this.btn_Limpiar_Arreglo);
            this.grp_Opciones_Check.Controls.Add(this.btn_Ver_Arreglo);
            this.grp_Opciones_Check.Location = new System.Drawing.Point(507, 113);
            this.grp_Opciones_Check.Name = "grp_Opciones_Check";
            this.grp_Opciones_Check.Size = new System.Drawing.Size(187, 156);
            this.grp_Opciones_Check.TabIndex = 1;
            this.grp_Opciones_Check.TabStop = false;
            this.grp_Opciones_Check.Text = "Obciones";
            // 
            // btn_Limpiar_Arreglo
            // 
            this.btn_Limpiar_Arreglo.Location = new System.Drawing.Point(27, 98);
            this.btn_Limpiar_Arreglo.Name = "btn_Limpiar_Arreglo";
            this.btn_Limpiar_Arreglo.Size = new System.Drawing.Size(136, 43);
            this.btn_Limpiar_Arreglo.TabIndex = 1;
            this.btn_Limpiar_Arreglo.Text = "Limpiar";
            this.btn_Limpiar_Arreglo.UseVisualStyleBackColor = true;
            this.btn_Limpiar_Arreglo.Click += new System.EventHandler(this.btn_Limpiar_Arreglo_Click);
            // 
            // btn_Ver_Arreglo
            // 
            this.btn_Ver_Arreglo.Location = new System.Drawing.Point(27, 29);
            this.btn_Ver_Arreglo.Name = "btn_Ver_Arreglo";
            this.btn_Ver_Arreglo.Size = new System.Drawing.Size(136, 43);
            this.btn_Ver_Arreglo.TabIndex = 0;
            this.btn_Ver_Arreglo.Text = "Ver Arreglo";
            this.btn_Ver_Arreglo.UseVisualStyleBackColor = true;
            this.btn_Ver_Arreglo.Click += new System.EventHandler(this.btn_Ver_Arreglo_Click);
            // 
            // grp_Control_Check
            // 
            this.grp_Control_Check.Controls.Add(this.chk_Remo_Num_Mayor_50);
            this.grp_Control_Check.Controls.Add(this.chk_Remo_Num_Menor_X);
            this.grp_Control_Check.Controls.Add(this.chk_Remo_Numeros_Pares);
            this.grp_Control_Check.Location = new System.Drawing.Point(6, 141);
            this.grp_Control_Check.Name = "grp_Control_Check";
            this.grp_Control_Check.Size = new System.Drawing.Size(396, 138);
            this.grp_Control_Check.TabIndex = 0;
            this.grp_Control_Check.TabStop = false;
            this.grp_Control_Check.Text = "Controles";
            // 
            // chk_Remo_Num_Mayor_50
            // 
            this.chk_Remo_Num_Mayor_50.AutoSize = true;
            this.chk_Remo_Num_Mayor_50.Location = new System.Drawing.Point(6, 99);
            this.chk_Remo_Num_Mayor_50.Name = "chk_Remo_Num_Mayor_50";
            this.chk_Remo_Num_Mayor_50.Size = new System.Drawing.Size(348, 29);
            this.chk_Remo_Num_Mayor_50.TabIndex = 2;
            this.chk_Remo_Num_Mayor_50.Text = "Remover Numeros Mayores a 50";
            this.chk_Remo_Num_Mayor_50.UseVisualStyleBackColor = true;
            // 
            // chk_Remo_Num_Menor_X
            // 
            this.chk_Remo_Num_Menor_X.AutoSize = true;
            this.chk_Remo_Num_Menor_X.Location = new System.Drawing.Point(6, 64);
            this.chk_Remo_Num_Menor_X.Name = "chk_Remo_Num_Menor_X";
            this.chk_Remo_Num_Menor_X.Size = new System.Drawing.Size(349, 29);
            this.chk_Remo_Num_Menor_X.TabIndex = 1;
            this.chk_Remo_Num_Menor_X.Text = "Remover Numeros Menores a 10";
            this.chk_Remo_Num_Menor_X.UseVisualStyleBackColor = true;
            // 
            // chk_Remo_Numeros_Pares
            // 
            this.chk_Remo_Numeros_Pares.AutoSize = true;
            this.chk_Remo_Numeros_Pares.Location = new System.Drawing.Point(6, 29);
            this.chk_Remo_Numeros_Pares.Name = "chk_Remo_Numeros_Pares";
            this.chk_Remo_Numeros_Pares.Size = new System.Drawing.Size(273, 29);
            this.chk_Remo_Numeros_Pares.TabIndex = 0;
            this.chk_Remo_Numeros_Pares.Text = "Remover Numeros Pares";
            this.chk_Remo_Numeros_Pares.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage4.Controls.Add(this.grp_Cronometro);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(726, 379);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Timer";
            // 
            // grp_Cronometro
            // 
            this.grp_Cronometro.Controls.Add(this.label3);
            this.grp_Cronometro.Controls.Add(this.label1);
            this.grp_Cronometro.Controls.Add(this.txt_Minutos);
            this.grp_Cronometro.Controls.Add(this.txt_Segundos);
            this.grp_Cronometro.Controls.Add(this.txt_Milisegundos);
            this.grp_Cronometro.Controls.Add(this.lbl_MIliesegundos);
            this.grp_Cronometro.Controls.Add(this.lbl_Segundos);
            this.grp_Cronometro.Controls.Add(this.lbl_Mini);
            this.grp_Cronometro.Controls.Add(this.lbl_Minutos);
            this.grp_Cronometro.Controls.Add(this.txt_Tiempo);
            this.grp_Cronometro.Controls.Add(this.lbl_Tiempo);
            this.grp_Cronometro.Controls.Add(this.grp_Opciones_Cro);
            this.grp_Cronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Cronometro.Location = new System.Drawing.Point(6, 41);
            this.grp_Cronometro.Name = "grp_Cronometro";
            this.grp_Cronometro.Size = new System.Drawing.Size(703, 314);
            this.grp_Cronometro.TabIndex = 0;
            this.grp_Cronometro.TabStop = false;
            this.grp_Cronometro.Text = "Cronometro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = ":";
            // 
            // txt_Minutos
            // 
            this.txt_Minutos.Enabled = false;
            this.txt_Minutos.Location = new System.Drawing.Point(51, 253);
            this.txt_Minutos.Name = "txt_Minutos";
            this.txt_Minutos.Size = new System.Drawing.Size(100, 30);
            this.txt_Minutos.TabIndex = 9;
            this.txt_Minutos.Text = "0";
            this.txt_Minutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Segundos
            // 
            this.txt_Segundos.Enabled = false;
            this.txt_Segundos.Location = new System.Drawing.Point(179, 253);
            this.txt_Segundos.Name = "txt_Segundos";
            this.txt_Segundos.Size = new System.Drawing.Size(100, 30);
            this.txt_Segundos.TabIndex = 8;
            this.txt_Segundos.Text = "0";
            this.txt_Segundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Milisegundos
            // 
            this.txt_Milisegundos.Enabled = false;
            this.txt_Milisegundos.Location = new System.Drawing.Point(312, 253);
            this.txt_Milisegundos.Name = "txt_Milisegundos";
            this.txt_Milisegundos.Size = new System.Drawing.Size(100, 30);
            this.txt_Milisegundos.TabIndex = 7;
            this.txt_Milisegundos.Text = "0";
            this.txt_Milisegundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_MIliesegundos
            // 
            this.lbl_MIliesegundos.AutoSize = true;
            this.lbl_MIliesegundos.Enabled = false;
            this.lbl_MIliesegundos.Location = new System.Drawing.Point(307, 286);
            this.lbl_MIliesegundos.Name = "lbl_MIliesegundos";
            this.lbl_MIliesegundos.Size = new System.Drawing.Size(139, 25);
            this.lbl_MIliesegundos.TabIndex = 6;
            this.lbl_MIliesegundos.Text = "Milisegundos";
            // 
            // lbl_Segundos
            // 
            this.lbl_Segundos.AutoSize = true;
            this.lbl_Segundos.Enabled = false;
            this.lbl_Segundos.Location = new System.Drawing.Point(174, 286);
            this.lbl_Segundos.Name = "lbl_Segundos";
            this.lbl_Segundos.Size = new System.Drawing.Size(110, 25);
            this.lbl_Segundos.TabIndex = 5;
            this.lbl_Segundos.Text = "Segundos";
            // 
            // lbl_Mini
            // 
            this.lbl_Mini.AutoSize = true;
            this.lbl_Mini.Enabled = false;
            this.lbl_Mini.Location = new System.Drawing.Point(56, 286);
            this.lbl_Mini.Name = "lbl_Mini";
            this.lbl_Mini.Size = new System.Drawing.Size(88, 25);
            this.lbl_Mini.TabIndex = 4;
            this.lbl_Mini.Text = "Minutos";
            // 
            // lbl_Minutos
            // 
            this.lbl_Minutos.AutoSize = true;
            this.lbl_Minutos.Location = new System.Drawing.Point(232, 70);
            this.lbl_Minutos.Name = "lbl_Minutos";
            this.lbl_Minutos.Size = new System.Drawing.Size(87, 25);
            this.lbl_Minutos.TabIndex = 3;
            this.lbl_Minutos.Text = "minutos";
            // 
            // txt_Tiempo
            // 
            this.txt_Tiempo.Location = new System.Drawing.Point(105, 67);
            this.txt_Tiempo.Name = "txt_Tiempo";
            this.txt_Tiempo.Size = new System.Drawing.Size(121, 30);
            this.txt_Tiempo.TabIndex = 1;
            this.txt_Tiempo.Text = "0";
            this.txt_Tiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Tiempo.Leave += new System.EventHandler(this.txt_Tiempo_Leave);
            // 
            // lbl_Tiempo
            // 
            this.lbl_Tiempo.AutoSize = true;
            this.lbl_Tiempo.Location = new System.Drawing.Point(15, 70);
            this.lbl_Tiempo.Name = "lbl_Tiempo";
            this.lbl_Tiempo.Size = new System.Drawing.Size(91, 25);
            this.lbl_Tiempo.TabIndex = 1;
            this.lbl_Tiempo.Text = "Tiempo:";
            // 
            // grp_Opciones_Cro
            // 
            this.grp_Opciones_Cro.Controls.Add(this.btn_Limpiar_Cro);
            this.grp_Opciones_Cro.Controls.Add(this.btn_Detener);
            this.grp_Opciones_Cro.Controls.Add(this.btn_Iniciar);
            this.grp_Opciones_Cro.Enabled = false;
            this.grp_Opciones_Cro.Location = new System.Drawing.Point(416, 29);
            this.grp_Opciones_Cro.Name = "grp_Opciones_Cro";
            this.grp_Opciones_Cro.Size = new System.Drawing.Size(196, 185);
            this.grp_Opciones_Cro.TabIndex = 0;
            this.grp_Opciones_Cro.TabStop = false;
            this.grp_Opciones_Cro.Text = "Opciones";
            // 
            // btn_Limpiar_Cro
            // 
            this.btn_Limpiar_Cro.Location = new System.Drawing.Point(23, 130);
            this.btn_Limpiar_Cro.Name = "btn_Limpiar_Cro";
            this.btn_Limpiar_Cro.Size = new System.Drawing.Size(145, 49);
            this.btn_Limpiar_Cro.TabIndex = 2;
            this.btn_Limpiar_Cro.Text = "Limpiar";
            this.btn_Limpiar_Cro.UseVisualStyleBackColor = true;
            this.btn_Limpiar_Cro.Click += new System.EventHandler(this.btn_Limpiar_Cro_Click);
            // 
            // btn_Detener
            // 
            this.btn_Detener.Location = new System.Drawing.Point(23, 83);
            this.btn_Detener.Name = "btn_Detener";
            this.btn_Detener.Size = new System.Drawing.Size(145, 41);
            this.btn_Detener.TabIndex = 1;
            this.btn_Detener.Text = "Detener";
            this.btn_Detener.UseVisualStyleBackColor = true;
            this.btn_Detener.Click += new System.EventHandler(this.btn_Detener_Click);
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(23, 29);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(145, 48);
            this.btn_Iniciar.TabIndex = 0;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btb_Iniciar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(596, 444);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(130, 41);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // erp_Control_Errores
            // 
            this.erp_Control_Errores.ContainerControl = this;
            // 
            // t_Cronometro
            // 
            this.t_Cronometro.Interval = 10;
            this.t_Cronometro.Tick += new System.EventHandler(this.t_Cronometro_Tick);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 497);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_Principal";
            this.Text = "frm_Principal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grp_Ecu_Cuadraticas.ResumeLayout(false);
            this.grp_Ecu_Cuadraticas.PerformLayout();
            this.grp_Opciones.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grp_Sumatorias.ResumeLayout(false);
            this.grp_Sumatorias.PerformLayout();
            this.grp_Control.ResumeLayout(false);
            this.grp_Control.PerformLayout();
            this.grp_Opciones_Radio.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.grp_Arreglo.ResumeLayout(false);
            this.grp_Arreglo.PerformLayout();
            this.grp_Opciones_Check.ResumeLayout(false);
            this.grp_Control_Check.ResumeLayout(false);
            this.grp_Control_Check.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.grp_Cronometro.ResumeLayout(false);
            this.grp_Cronometro.PerformLayout();
            this.grp_Opciones_Cro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erp_Control_Errores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grp_Ecu_Cuadraticas;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.TextBox txt_Solucion_II;
        private System.Windows.Forms.TextBox txt_Solucion_I;
        private System.Windows.Forms.TextBox txt_Discriminante;
        private System.Windows.Forms.Label lbl_Discriminante;
        private System.Windows.Forms.Label lbl_Solucion_I;
        private System.Windows.Forms.Label lbl_Solucion_II;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label lbl_C;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.GroupBox grp_Opciones;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.GroupBox grp_Sumatorias;
        private System.Windows.Forms.TextBox txt_Resultado_radio;
        private System.Windows.Forms.TextBox txt_Numero_Limite;
        private System.Windows.Forms.Label lbl_Sumatoria;
        private System.Windows.Forms.Label lbl_Numero_Limite;
        private System.Windows.Forms.GroupBox grp_Control;
        private System.Windows.Forms.RadioButton rb_Solo_Impares;
        private System.Windows.Forms.RadioButton rb_Solo_Pares;
        private System.Windows.Forms.RadioButton rb_Todos;
        private System.Windows.Forms.GroupBox grp_Opciones_Radio;
        private System.Windows.Forms.Button btn_Limpiar_Radio;
        private System.Windows.Forms.Button btn_Sumar;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.ErrorProvider erp_Control_Errores;
        private System.Windows.Forms.GroupBox grp_Arreglo;
        private System.Windows.Forms.GroupBox grp_Control_Check;
        private System.Windows.Forms.CheckBox chk_Remo_Num_Mayor_50;
        private System.Windows.Forms.CheckBox chk_Remo_Num_Menor_X;
        private System.Windows.Forms.CheckBox chk_Remo_Numeros_Pares;
        private System.Windows.Forms.Label lbl_Contenido_Arreglo;
        private System.Windows.Forms.TextBox txt_Res_Arreglo;
        private System.Windows.Forms.TextBox txt_Limite_Arreglo;
        private System.Windows.Forms.TextBox txt_Tamaño_Arreglo;
        private System.Windows.Forms.Label lbl_Limite_Arreglo;
        private System.Windows.Forms.Label lbl_Tamaño_Arreglo;
        private System.Windows.Forms.Button btn_Llenar_Arreglo;
        private System.Windows.Forms.GroupBox grp_Opciones_Check;
        private System.Windows.Forms.Button btn_Limpiar_Arreglo;
        private System.Windows.Forms.Button btn_Ver_Arreglo;
        private System.Windows.Forms.GroupBox grp_Cronometro;
        private System.Windows.Forms.GroupBox grp_Opciones_Cro;
        private System.Windows.Forms.Button btn_Limpiar_Cro;
        private System.Windows.Forms.Button btn_Detener;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.TextBox txt_Minutos;
        private System.Windows.Forms.TextBox txt_Segundos;
        private System.Windows.Forms.TextBox txt_Milisegundos;
        private System.Windows.Forms.Label lbl_MIliesegundos;
        private System.Windows.Forms.Label lbl_Segundos;
        private System.Windows.Forms.Label lbl_Mini;
        private System.Windows.Forms.Label lbl_Minutos;
        private System.Windows.Forms.TextBox txt_Tiempo;
        private System.Windows.Forms.Label lbl_Tiempo;
        private System.Windows.Forms.Timer t_Cronometro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}