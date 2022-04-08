//Libreria del programa.
using System;
//Libreria del programa.
using System.Collections.Generic;
//Libreria del programa.
using System.ComponentModel;
//Libreria del programa.
using System.Data;
//Libreria del programa.
using System.Drawing;
//Libreria del programa.
using System.Linq;
//Libreria del programa.
using System.Text;
//Libreria del programa.
using System.Threading.Tasks;
//Libreria del programa.
using System.Windows.Forms;

//Controla el alcance de las clases y métodos.
namespace FormularioBecas
{//Se abre espacio.
    //Esta es una clase.
    public partial class Form1 : Form
    {//Se abre espacio.

        public Form1()
        {//Se abre espacio.

            InitializeComponent();

            this.Load += new System.EventHandler(Form1_Load);

        }//Cierra el espacio.

        private void Form1_Load(object sender, EventArgs e)
        {//Se abre espacio.
            //Cambiamos el color del form.
            BackColor = Color.White;
            //Instanciamos un PictureBox
            PictureBox FotoAMLO = new PictureBox();
            //Coordenada en Y.
            FotoAMLO.Top = 239;
            //Coordenada en X.
            FotoAMLO.Left = 373;
            //Agregamos las medidas del tamño.
            FotoAMLO.Size = new Size(117, 133);
            //Cambiamos de color de fondo del PictureBox.
            FotoAMLO.BackColor = Color.White;
            //Ajustamos el tamaño de la imagen.
            FotoAMLO.SizeMode = PictureBoxSizeMode.Zoom;
            //Agregamos la imagen.
            FotoAMLO.Image = FormularioBecas.Properties.Resources.AMLO;
            //Añadimos el PictoreBox al Form1.
            this.Controls.Add(FotoAMLO);

            //Instanciamos un Label.
            Label lblRegistro = new Label();
            //Asignamos el texto.
            lblRegistro.Text = "Registro";
            //Asignamos el nombre.
            lblRegistro.Name = "lblRegistro";
            //Coordenada en Y.
            lblRegistro.Top = 26;
            //Coordenada en X.
            lblRegistro.Left = 245;
            //Añadimos el Label al Form1.
            this.Controls.Add(lblRegistro);

            //Instanciamos un Label.
            Label lblNombre = new Label();
            //Asigamos que este label tenga un tamaño automático.
            lblNombre.AutoSize = true;
            //Asignamos el texto.
            lblNombre.Text = "Nombre";
            //Asignamos el nombre.
            lblNombre.Name = "lblNombre";
            //Coordenada en Y.
            lblNombre.Top = 56;
            //Coordenada en X.
            lblNombre.Left = 14;
            //Añadimos el Label al Form1.
            this.Controls.Add(lblNombre);

            //Instanciamos un Label.
            Label lblCURP = new Label();
            //Asigamos que este label tenga un tamaño automático.
            lblCURP.AutoSize = true;
            //Asignamos el texto.
            lblCURP.Text = "CURP";
            //Asignamos el nombre.
            lblCURP.Name = "lblCURP";
            //Coordenada en Y.
            lblCURP.Top = 89;
            //Coordenada en X.
            lblCURP.Left = 14;
            //Añadimos el Label al Form1.
            this.Controls.Add(lblCURP);

            //Instanciamos un Label.
            Label lblDireccion = new Label();
            //Asigamos que este label tenga un tamaño automático.
            lblDireccion.AutoSize = true;
            lblDireccion.Text = "Dirección";
            //Asignamos el nombre.
            lblDireccion.Name = "lblDireccion";
            //Coordenada en Y.
            lblDireccion.Top = 122;
            //Coordenada en X.
            lblDireccion.Left = 14;
            //Añadimos el Label al Form1.
            this.Controls.Add(lblDireccion);

            //Instanciamos un Label.
            Label lblEscuela = new Label();
            //Asigamos que este label tenga un tamaño automático.
            lblEscuela.AutoSize = true;
            //Asignamos el texto.
            lblEscuela.Text = "Escuela";
            //Asignamos el nombre.
            lblEscuela.Name = "lblEscuela";
            //Coordenada en Y.
            lblEscuela.Top = 164;
            //Coordenada en X.
            lblEscuela.Left = 14;
            //Añadimos el Label al Form1.
            this.Controls.Add(lblEscuela);

            //Instanciamos un Label.
            Label lblSemestre = new Label();
            //Asigamos que este label tenga un tamaño automático.
            lblSemestre.AutoSize = true;
            //Asignamos el texto.
            lblSemestre.Text = "Semestre";
            //Asignamos el nombre.
            lblSemestre.Name = "lblSemestre";
            //Coordenada en Y.
            lblSemestre.Top = 207;
            //Coordenada en X.
            lblSemestre.Left = 14;
            //Añadimos el Label al Form1.
            this.Controls.Add(lblSemestre);

            //Instanciamos un Label.
            Label lblEstado = new Label();
            //Asigamos que este label tenga un tamaño automático.
            lblEstado.AutoSize = true;
            //Asignamos el texto.
            lblEstado.Text = "Estado";
            //Asignamos el nombre.
            lblEstado.Name = "lblEstado";
            //Coordenada en Y.
            lblEstado.Top = 242;
            //Coordenada en X.
            lblEstado.Left = 14;
            //Añadimos el Label al Form1.
            this.Controls.Add(lblEstado);

            //Instanciamos un TexBox.
            TextBox txtNombre = new TextBox();
            //Asignamos un tamaño.
            txtNombre.Size = new Size(251, 20);
            //Asignamos un nombre.
            txtNombre.Name = "txtNombre";
            //Coordenada en Y.
            txtNombre.Top = 51;
            //Coordenada en X.
            txtNombre.Left = 89;
            //Añadimos el TexBox al Form1.
            this.Controls.Add(txtNombre);

            //Instanciamos un TexBox.
            TextBox txtCURP = new TextBox();
            //Asignamos un tamaño.
            txtCURP.Size = new Size(251, 20);
            //Asignamos un nombre.
            txtCURP.Name = "txtCURP";
            //Coordenada en Y.
            txtCURP.Top = 84;
            //Coordenada en X.
            txtCURP.Left = 89;
            //Añadimos el TexBox al Form1.
            this.Controls.Add(txtCURP);

            //Instanciamos un TexBox.
            TextBox txtDireccion = new TextBox();
            //Asignamos un tamaño.
            txtDireccion.Size = new Size(251, 20);
            //Asignamos un nombre.
            txtDireccion.Name = "txtDireccion";
            //Coordenada en Y.
            txtDireccion.Top = 119;
            //Coordenada en X.
            txtDireccion.Left = 90;
            //Añadimos el TexBox al Form1.
            this.Controls.Add(txtDireccion);

            //Instanciamos un TexBox.
            TextBox txtEscuela = new TextBox();
            //Asignamos un tamaño.
            txtEscuela.Size = new Size(251, 20);
            //Asignamos un nombre.
            txtEscuela.Name = "txtEscuela";
            //Coordenada en Y.
            txtEscuela.Top = 157;
            //Coordenada en X.
            txtEscuela.Left = 90;
            //Añadimos el TexBox al Form1.
            this.Controls.Add(txtEscuela);

            //Instanciamos un ComboBox.
            ComboBox CbSemestre = new ComboBox();
            //Asignamos un tamaño.
            CbSemestre.Size = new Size(60, 20);
            //Asignamos un nombre.
            CbSemestre.Name = "CbSemestre";
            //Coordenada en Y.
            CbSemestre.Top = 199;
            //Coordenada en X.
            CbSemestre.Left = 89;
            //Añadimos contenido dentro del ComboBox.
            CbSemestre.Items.Add("1");
            //Añadimos contenido dentro del ComboBox.
            CbSemestre.Items.Add("2");
            //Añadimos contenido dentro del ComboBox.
            CbSemestre.Items.Add("3");
            //Añadimos contenido dentro del ComboBox.
            CbSemestre.Items.Add("4");
            //Añadimos contenido dentro del ComboBox.
            CbSemestre.Items.Add("5");
            //Añadimos contenido dentro del ComboBox.
            CbSemestre.Items.Add("6");
            //Añadimos contenido dentro del ComboBox.
            CbSemestre.Items.Add("7");
            //Añadimos contenido dentro del ComboBox.
            CbSemestre.Items.Add("8");
            //Añadimos contenido dentro del ComboBox.
            CbSemestre.Items.Add("9");
            //Añadimos contenido dentro del ComboBox.
            CbSemestre.Items.Add("10");
            //Añadimos contenido dentro del ComboBox.
            CbSemestre.Items.Add("11");
            //Añadimos contenido dentro del ComboBox.
            CbSemestre.Items.Add("12");
            //Añadimos el ComboBox al Form1.
            this.Controls.Add(CbSemestre);

            //Instanciamos un ComboBox.
            ComboBox CbEstados = new ComboBox();
            //Asignamos un nombre.
            CbEstados.Name = "CbEstados";
            //Coordenada en Y.
            CbEstados.Top = 239;
            //Coordenada en X.
            CbEstados.Left = 88;
            //Asignamos un tamaño.
            CbEstados.Size = new Size(150, 20);
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Aguascalientes");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Baja California");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Baja Califorrnia Sur");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Campeche");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Coahuila de Zaragoza");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Colima");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Chiapas");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Chihuahua");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Ciudad de México");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Durango");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Guanajuato");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Guerrero");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Hidalgo");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Jalisco");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Michoacán");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Morelos");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Nayarit");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Nuevo León");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Oaxaca");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Puebla");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Querétaro");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Quintara Roo");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("San Luis Potosí");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Sinaloa");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Sonora");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Tabasco");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Tamaulipas");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Tlaxcala");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Veracruz");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Yucatán");
            //Añadimos contenido dentro del ComboBox.
            CbEstados.Items.Add("Zacatecas");
            //Añadimos el ComboBox al Form1.
            this.Controls.Add(CbEstados);

            //Instanciamos un GroupBox.
            GroupBox GbSexo = new GroupBox();
            //Asignamos un nombre.
            GbSexo.Name = "GbSexo";
            //Asignamos texto.
            GbSexo.Text = "Sexo";
            //Coordenada en Y.
            GbSexo.Top  = 51;
            //Coordenada en X.
            GbSexo.Left = 365;
            //Asigamos que este GroupBox tenga un tamaño automático.
            GbSexo.AutoSize = true;
            //Añadimos el GroupBox al Form1.
            this.Controls.Add(GbSexo);

            //Se instancia la clase radiobutton para cargar en memoria el control.
            RadioButton OpcMasculino = new RadioButton();
            //Se instancia la clase radiobutton para cargar en memoria el control.
            RadioButton OpcFemenino = new RadioButton();
            //Control masculino
            //Establece el texto del control, lo que se muestra en pantalla
            OpcMasculino.Text = "Masculino";
            //Establece la posicion en "Y" donde se motrara el control
            OpcMasculino.Top = 19;
            //Establece la posicion en "X" donde se mostrara el control
            OpcMasculino.Left = 15;
            
            //Control femenino
            //Establece el texto del control, lo que se muestra en pantalla
            OpcFemenino.Text = "Femenino";
            //Establece la posicion en "Y" donde se mostrara el control
            OpcFemenino.Top = 36;
            //Establece la posicion en "X"
            OpcFemenino.Left = 15;
            //Añadimos el RadioButton al GroupBox.
            GbSexo.Controls.Add(OpcMasculino);
            //Añadimos el RadioButton al GroupBox.
            GbSexo.Controls.Add(OpcFemenino);

            //Instanciamos un GroupBox.
            GroupBox GbFecha = new GroupBox();
            //Asignamos un nombre.
            GbFecha.Name = "GbFecha";
            //Asignamos texto.
            GbFecha.Text = "Fecha de nacimiento";
            //Coordenada en Y.
            GbFecha.Top = 282;
            //Coordenada en X.
            GbFecha.Left = 87;
            //Asigamos que este GroupBox tenga un tamaño automático.
            GbFecha.AutoSize = true;
            //Añadimos el GroupBox al Form1.
            this.Controls.Add(GbFecha);

            //Instanciamos un ComboBox.
            ComboBox CbDia = new ComboBox();
            //Asignamos un nombre.
            CbDia.Name = "CbDia";
            //Coordenada en Y.
            CbDia.Top = 29;
            //Coordenada en X.
            CbDia.Left = 6;
            //Asignamos un tamaño.
            CbDia.Size = new Size(55, 21);
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("1");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("2");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("3");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("4");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("5");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("6");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("7");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("8");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("9");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("10");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("11");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("12");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("13");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("14");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("15");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("16");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("17");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("18");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("19");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("20");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("21");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("22");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("23");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("24");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("25");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("26");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("27");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("28");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("29");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("30");
            //Añadimos contenido dentro del ComboBox.
            CbDia.Items.Add("31");
            //Añadimos el ComboBox al GroupBox.
            GbFecha.Controls.Add(CbDia);

            //Instanciamos un ComboBox.
            ComboBox CbMes = new ComboBox();
            //Asignamos un nombre.
            CbMes.Name = "CbMes";
            //Coordenada en Y.
            CbMes.Top = 29;
            //Coordenada en X.
            CbMes.Left = 67;
            //Asignamos un tamaño.
            CbMes.Size = new Size(88, 21);
            //Añadimos contenido dentro del ComboBox.
            CbMes.Items.Add("Enero");
            //Añadimos contenido dentro del ComboBox.
            CbMes.Items.Add("Febrero");
            //Añadimos contenido dentro del ComboBox.
            CbMes.Items.Add("Marzo");
            //Añadimos contenido dentro del ComboBox.
            CbMes.Items.Add("Abril");
            //Añadimos contenido dentro del ComboBox.
            CbMes.Items.Add("Mayo");
            //Añadimos contenido dentro del ComboBox.
            CbMes.Items.Add("Junio");
            //Añadimos contenido dentro del ComboBox.
            CbMes.Items.Add("Julio");
            //Añadimos contenido dentro del ComboBox.
            CbMes.Items.Add("Agosto");
            //Añadimos contenido dentro del ComboBox.
            CbMes.Items.Add("Septiembre");
            //Añadimos contenido dentro del ComboBox.
            CbMes.Items.Add("Octubre");
            //Añadimos contenido dentro del ComboBox.
            CbMes.Items.Add("Noviembre");
            //Añadimos contenido dentro del ComboBox.
            CbMes.Items.Add("Diciembre");
            //Añadimos el ComboBox al GroupBox.
            GbFecha.Controls.Add(CbMes);

            //Instanciamos un ComboBox.
            ComboBox CbAos = new ComboBox();
            //Asignamos un nombre.
            CbAos.Name = "CbAos";
            //Coordenada en Y.
            CbAos.Top = 29;
            //Coordenada en X.
            CbAos.Left = 161;
            //Asignamos un tamaño.
            CbAos.Size = new Size(60, 21);
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1985");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1986");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1987");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1988");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1989");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1990");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1991");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1992");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1993");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1994");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1995");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1996");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1997");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1998");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("1999");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("2000");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("2001");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("2002");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("2003");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("2004");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("2005");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("2006");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("2007");
            //Añadimos contenido dentro del ComboBox.
            CbAos.Items.Add("2008");
            //Añadimos el ComboBox al GroupBox.
            GbFecha.Controls.Add(CbAos);

        }//Cierra el espacio.
    }//Cierra el espacio.
}//Cierra el espacio.
