using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmCargarBD : Form
    {
        public frmCargarBD()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsSocios oSocs = new clsSocios();

            #region DNI
            if (cmbSeleccion.Text == "DNI")
            {
                Random random = new Random();

                string stSQL = "select count(IDSocio) from socio";
                int cantSocios = oSocs.CantSocios(stSQL);

                int i = 0;

                while (i <= cantSocios)
                {
                    int dnialeatorio = random.Next(6000000, 53000000);

                    stSQL = "update socio set dni = " + dnialeatorio + " where idsocio = " + i + "";

                    oSocs.ActualizarRegistros(stSQL);

                    i++;
                }
            }
            #endregion

            #region telefono
            if (cmbSeleccion.Text == "Telefono")
            {
                Random random = new Random();

                string stSQL = "select count(IDSocio) from socio";
                int cantSocios = oSocs.CantSocios(stSQL);

                int i = 0;

                while (i <= cantSocios)
                {
                    double telefonoaleatorio = random.Next(100000000, 999999999);

                    stSQL = "update socio set telefono = " + telefonoaleatorio + " where idsocio = " + i + "";

                    oSocs.ActualizarRegistros(stSQL);

                    i++;
                }
            }
            #endregion

            #region tel contacto
            if (cmbSeleccion.Text == "Telefono de Contacto")
            {
                Random random = new Random();

                string stSQL = "select count(IDSocio) from socio";
                int cantSocios = oSocs.CantSocios(stSQL);

                int i = 0;

                while (i <= cantSocios)
                {
                    double telContactoaleatorio = random.Next(100000000, 999999999);

                    stSQL = "update socio set telcontacto = " + telContactoaleatorio + " where idsocio = " + i + "";

                    oSocs.ActualizarRegistros(stSQL);

                    i++;
                }
            }
            #endregion

            #region fecha de alta
            if (cmbSeleccion.Text == "Fecha de Alta")
            {
                Random random = new Random();

                string stSQL = "select count(IDSocio) from socio";
                int cantSocios = oSocs.CantSocios(stSQL);

                String[] fecha = {"1996/01/10","1995/02/11","1994/01/10","1993/10/10","1996/01/02","1980/01/10","1980/10/27","1996/12/25","1976/01/10","1980/05/11","1996/01/10","1980/01/10","1991/01/10","1981/01/10","1982/01/10","1983/01/10",
                                 "1984/01/10","1985/01/10","1986/01/10","1997/01/10","1987/01/10","1988/01/10","1989/01/10","2001/01/10","2002/01/10","2000/01/10","2003/01/10","2004/01/10","2005/01/10","2006/01/10","2007/01/10","2008/01/10",
                                 "2009/01/10","2010/01/10","1971/01/10","1972/01/10","1973/01/10","1974/01/10","1975/01/10","1976/01/10","1977/01/10","1978/01/10","1979/01/10","1996/01/10","1996/01/10","1996/01/10","1996/01/10","1996/01/10",
                                 "1996/01/10"};
                int i = 0;

                while (i <= cantSocios)
                {
                    int j = random.Next(0, fecha.Length);
                    String fechas = fecha[j];

                    stSQL = "update socio set fechaalta = '" + fechas + "' where idsocio = " + i + "";

                    oSocs.ActualizarRegistros(stSQL);

                    i++;
                }
            }
            #endregion

            #region fecha nacimiento
            if (cmbSeleccion.Text == "Fecha de Nacimiento")
            {
                Random random = new Random();

                string stSQL = "select count(IDSocio) from socio";
                int cantSocios = oSocs.CantSocios(stSQL);

                String[] fecha = {"1996/01/10","1995/02/11","1994/01/10","1993/10/10","1996/01/02","1980/01/10","1980/10/27","1996/12/25","1976/01/10","1980/05/11","1996/01/10","1980/01/10","1991/01/10","1981/01/10","1982/01/10","1983/01/10",
                                 "1984/01/10","1985/01/10","1986/01/10","1997/01/10","1987/01/10","1988/01/10","1989/01/10","2001/01/10","2002/01/10","2000/01/10","2003/01/10","2004/01/10","2005/01/10","2006/01/10","2007/01/10","2008/01/10",
                                 "2009/01/10","2010/01/10","1971/01/10","1972/01/10","1973/01/10","1974/01/10","1975/01/10","1976/01/10","1977/01/10","1978/01/10","1979/01/10","1996/01/10","1996/01/10","1996/01/10","1996/01/10","1996/01/10",
                                 "1996/01/10"};
                int i = 0;

                while (i <= cantSocios)
                {
                    int j = random.Next(0, fecha.Length);
                    String fechas = fecha[j];

                    stSQL = "update socio set fechanac = '" + fechas + "' where idsocio = " + i + "";

                    oSocs.ActualizarRegistros(stSQL);

                    i++;
                }
            }
            #endregion

            #region correo electronico
            if (cmbSeleccion.Text == "Correo Electronico")
            {
                Random random = new Random();

                string stSQL = "select count(IDSocio) from socio";
                int cantSocios = oSocs.CantSocios(stSQL);

                String[] correo ={ "juan@gmail.com","marcos@gmail.com","pedro@gmail.com","hernan@yahoo.com","vicki@hotmail.com","florinda@yahoo.com","socio@gmail.com","socio@hotmail.com","josefa@gmail.com",
                               "lola@gmail.com","facu.235@gmail.com","ssocio@gmail.com","soocio@yahoo.com","soccio@gmail.com","dani@gmail.com","socio@hotmail.com","socio@outlook.com","socio@hotmail.com",
                               "mariamaria@hotmail.com","socio@gmail.com","socio@hotmail.com","socios@yahoo.com","parajuy@yahoo.com","santos@yahoo.com","kike@yahoo.com","socio@gmail.com","pablo@yahoo.com",
                               "porotitia@gmail.com","socioclub@gmail.com","socio.futbol@hotmail.com","claudia.voley@gmail.com","olivia@yahoo.com.ar","juana@hotmail.com","juli@hotmail.com","popi@futbol.com","julia@yahoo.com",
                               "petete@yahoo.com","jorge@gmail.com","estelita@yahoo.com","ada@hotmail.com"};
                int i = 0;

                while (i <= cantSocios)
                {
                    int j = random.Next(0, correo.Length);
                    String correos = correo[j];

                    stSQL = "update socio set correoelectronico = '" + correos + "' where idsocio = " + i + "";

                    oSocs.ActualizarRegistros(stSQL);

                    i++;
                }
            }
            #endregion

            #region actividad por socio
            if (cmbSeleccion.Text == "Actividad Por Socio")
            {

                //int id = row.Index + 1;
                //String nombre = Convert.ToString(row.Cells["Nombre"].Value);
                //String letra = nombre.Substring(0, 1);
                //obj.LlenarActividadxSocio(letra, id);


                Random random = new Random();

                string stSQL = "select count(IDSocio) from socio";
                int cantSocios = oSocs.CantSocios(stSQL);

                int i = 0;

                while (i < cantSocios)
                {
                    //int j = random.Next(0, correo.Length);
                    //String correos = correo[j];

                    //i++;

                    stSQL = "select apellido from socio where idsocio = " + (i+1) + "";
                    string stApellidoSocios = oSocs.ApellidoSocios(stSQL);
                    string stLetra = stApellidoSocios.Substring(0, 1);

                    switch (stLetra.ToUpper())
                    {
                        case "A":
                        case "B":
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                            stSQL = "insert into actividadxsocio(idactividad,idsocio) values ('" + 1 + "','" + (i + 1) + "')";
                            oSocs.InsertarRegistros(stSQL);
                            break;                        
                        case "G":
                        case "H":
                        case "I":
                        case "J":
                        case "K":
                            stSQL = "insert into actividadxsocio(idactividad,idsocio) values ('" + 2 + "','" + (i + 1) + "')";
                            oSocs.InsertarRegistros(stSQL);
                            break;
                        case "L":
                        case "M":
                        case "N":
                        case "Ñ":
                        case "O":
                            stSQL = "insert into actividadxsocio(idactividad,idsocio) values ('" + 3 + "','" + (i + 1) + "')";
                            oSocs.InsertarRegistros(stSQL);
                            break;
                        case "P":
                        case "Q":
                        case "R":
                        case "S":
                        case "T":
                            stSQL = "insert into actividadxsocio(idactividad,idsocio) values ('" + 4 + "','" + (i + 1) + "')";
                            oSocs.InsertarRegistros(stSQL);
                            break;
                        case "U":
                        case "V":
                        case "W":
                        case "X":
                        case "Y":
                        case "Z":
                            stSQL = "insert into actividadxsocio(idactividad,idsocio) values ('" + 5 + "','" + (i + 1) + "')";
                            oSocs.InsertarRegistros(stSQL);
                            break;
                    }
                    //stSQL = "update socio set correoelectronico = '" + correos + "' where idsocio = " + i + "";

                    //oSocs.ActualizarRegistros(stSQL);

                    i++;
                }
            }
            #endregion
        }
    }
}
