using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDatos;

namespace Negocio
{
    public class clsSocios
    {

        public class Socio
        {
            private int _idSocio;
            private string _nombre;
            private string _apellido;
            private int _DNI;
            private DateTime _fechaAlta;
            private DateTime _fechaNac;
            private double _telefono;
            private string _correoElectronico;
            private double _telContacto;
            private int _activo;
            private string _direccion;

            public string Direccion
            {
                get { return _direccion; }
                set { _direccion = value; }
            }

            public int Activo
            {
                get { return _activo; }
                set { _activo = value; }
            }

            public double TelContacto
            {
                get { return _telContacto; }
                set { _telContacto = value; }
            }

            public string CorreoElectronico
            {
                get { return _correoElectronico; }
                set { _correoElectronico = value; }
            }

            public double Telefono
            {
                get { return _telefono; }
                set { _telefono = value; }
            }

            public DateTime FechaAlta
            {
                get { return _fechaAlta; }
                set { _fechaAlta = value; }
            }

            public int DNI
            {
                get { return _DNI; }
                set { _DNI = value; }
            }

            public DateTime FechaNac
            {
                get { return _fechaNac; }
                set { _fechaNac = value; }
            }

            public string Apellido
            {
                get { return _apellido; }
                set { _apellido = value; }
            }

            public string Nombre
            {
                get { return _nombre; }
                set { _nombre = value; }
            }

            public int IdSocio
            {
                get { return _idSocio; }
                set { _idSocio = value; }
            }
        }


        //public List<Socio> SelectAll( string stFiltro ="" )
        //{
        //    BaseSQL BD = new BaseSQL();
        //    System.Data.DataTable dat =  BD.ExecuteDataTable ( "Select nombre, apellido, dni, fechanac, direccion, fechaalta, " 
        //    + "telefono, correoelectronico, telefonocontacto, activo from socio");

        //    List<Socio> lstSocio = new List<Socio>();
        //    foreach (System.Data.DataRow item in dat.Rows)
        //    {
        //        Socio osoc = new Socio();
        //        osoc.IdSocio = Convert.ToInt32(item[0].ToString());
        //        osoc.Nombre = item[1].ToString();
        //        osoc.Apellido = item[2].ToString();
        //        osoc.DNI = Convert.ToInt32(item[3]);
        //        osoc.FechaAlta = Convert.ToDateTime(item[4].ToString());
        //        osoc.FechaNac = Convert.ToDateTime(item[5].ToString());
        //        osoc.Telefono = Convert.ToDouble(item[6]);
        //        osoc.CorreoElectronico = item[7].ToString();
        //        osoc.TelContacto = Convert.ToDouble(item[8]);
        //        osoc.Activo = Convert.ToInt32(item[9]);
        //        osoc.Direccion = item[10].ToString();

        //        lstSocio.Add(osoc);
        //    }
        //    return lstSocio;
        //}

        //HACER UN METODO QUE RECIBA EL DATAGRIDVIEW LO LLENE Y LO DEVUELVA A FRMBUSCARSOCIOS
        

        public List<Socio> Consultar(string Filtro)
        {
            BaseSQL BD = new BaseSQL();
            string stSQL = "select * from socio " + Filtro + "";

            System.Data.DataTable dat = BD.ExecuteDataTable(stSQL);

            List<Socio> lstSocio = new List<Socio>();
            foreach (System.Data.DataRow item in dat.Rows)
            {
                Socio osoc = new Socio();

                osoc.IdSocio = Convert.ToInt32(item[0]);                

                osoc.Nombre = item[2].ToString();
                
                osoc.Apellido = item[3].ToString();
                
                osoc.DNI = Convert.ToInt32(item[4]);

                osoc.FechaAlta = Convert.ToDateTime(item[5]);

                osoc.FechaNac = Convert.ToDateTime(item[6]);
                
                osoc.Telefono = Convert.ToDouble(item[7]);
                
                osoc.CorreoElectronico = item[8].ToString();
                
                osoc.TelContacto = Convert.ToDouble(item[9]);

                osoc.Activo = Convert.ToInt32(item[10]);

                osoc.Direccion = item[11].ToString();

                lstSocio.Add(osoc);
            }

            return lstSocio;
        }

        public void Guardar(Socio obj)
        {
            try
            {
                string stSQL = "";
                if (obj.IdSocio == 0)
                {
                    stSQL = "INSERT INTO Socio(nombre,apellido,DNI,fechaalta,fechanac,telefono,correoelectronico,telcontacto,activo,direccion) values ('" + obj.Nombre + "','" + obj.Apellido + "','" + obj.DNI + "' , '" + obj.FechaAlta + "','" + obj.FechaNac + "','" + obj.Telefono + "','" + obj.CorreoElectronico + "','" + obj.TelContacto + "','" + obj.Activo + "','" + obj.Direccion + "')";
                    Insert(stSQL);
                }
                else
                {
                    stSQL = "update socio set nombre='" + obj.Nombre + "',apellido='" + obj.Apellido + "',dni='" + obj.DNI + "',fechaalta ='" + obj.FechaAlta + "',Fechanac='" + obj.FechaNac + "',Telefono='" + obj.Telefono + "',correoelectronico='" + obj.CorreoElectronico + "',telcontacto='" + obj.TelContacto + "',Direccion='" + obj.Direccion + "' where IDSocio='" + obj.IdSocio + "'";

                    Update(stSQL);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public void ActualizarSocio(Socio obj)
        //{
        //    BaseSQL BD = new BaseSQL();
        //    string stSQL = "update socio set nombre='" + obj.Nombre + "',apellido='" + obj.Apellido + "',dni='" + obj.DNI + "',fechaalta ='" + obj.FechaAlta + "',Fechanac='" + obj.FechaNac + "',Telefono='" + obj.Telefono + "',correoelectronico='" + obj.CorreoElectronico + "',telcontacto='" + obj.TelContacto + "',Direccion='" + obj.Direccion + "' where IDSocio='" + obj.IdSocio + "'";
        //    BD.ExecuteNoQuery(stSQL);
        //}

        public void ActualizarRegistros(string stSQL)
        {
            Update(stSQL); 
        }

        public void InsertarRegistros(string stSQL)
        {
            Insert(stSQL);
        }

        #region Metodos para cargar la base de datos

        public int CantSocios(string stSQL)
        {
            BaseSQL BD = new BaseSQL();
            int cant = Convert.ToInt32(BD.ExecuteScalar(stSQL));
            return cant;
        }

        public string ApellidoSocios(string stSQL)
        {
            BaseSQL BD = new BaseSQL();
            string stApellidosSocios = BD.ExecuteScalar(stSQL).ToString();
            return stApellidosSocios;
        }
        
        #endregion

        public int DNISocio(string stSQL)
        {
            BaseSQL BD = new BaseSQL();
            int DNI = Convert.ToInt32(BD.ExecuteScalar(stSQL));
            return DNI;
        }

        public int IDSocio(string stSQL)
        {
            BaseSQL BD = new BaseSQL();
            int ID = Convert.ToInt32(BD.ExecuteScalar(stSQL));
            return ID;
        }

        private int Insert(string sql)
        {
            BaseSQL BD = new BaseSQL();
            return BD.ExecuteNoQuery(sql);
        }

        private int Update(string sql)
        {
            BaseSQL BD = new BaseSQL();
            return BD.ExecuteNoQuery(sql);
        }
    }
}
