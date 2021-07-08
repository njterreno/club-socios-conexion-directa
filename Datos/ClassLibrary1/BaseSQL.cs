using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//DEBO AGREGAR ESTOS "USING" PARA PODER CONECTARME A LA BASE DE DATOS.
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


namespace BaseDatos
{
    public class BaseSQL
    {
        //"Data Source= Servidor ; Initial Catalog= Base ; Integrated Security=true; ";
        private string stConexion = "Data Source=DESKTOP-HKCMBGR; Initial Catalog=BDClubSocios; Integrated Security=true";

        public SqlCommand MiSqlCommand;

        private SqlConnection mConnection;

        public SqlConnection Connection
        {
            get { return mConnection; }
            set { mConnection = value; }
        }
        
        public BaseSQL()
        {
        }

        //pregunta si el lenguaje del sql es español, sino lo cambia
        private void ChequeaLang()
        {
             SqlCommand oCommand = new SqlCommand("select name from sys.syslanguages");
             string name = oCommand.ExecuteScalar().ToString();
             if(name != "Español") this.ExecuteNoQuery("set languages español");
        }

        public void Open()
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-AR");
                mConnection = new SqlConnection(stConexion);
                mConnection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Close()
        {
            try
            {
                Connection.Close();
                mConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecuteCommando(SqlCommand sSQL)
        {
            try
            {
                if (Connection.State == ConnectionState.Closed) { Open(); }
                SqlCommand oCommand = sSQL;                  
                int Id =Convert.ToInt32( oCommand.ExecuteScalar());
                mConnection.Close();
                return Id;
            }
            catch (Exception)
            {
                mConnection.Close();
                return -1;
            }
        }

        public int ExecuteNoQuery(string sSQL)
        {
            try
            {
                Open(); 
                SqlCommand oCommand = new SqlCommand(sSQL, mConnection);
                int Id = oCommand.ExecuteNonQuery();
                mConnection.Close();
                return Id;
            }
            catch (Exception ex)
            {
                mConnection.Close();
                throw ex;
            }
        }

        public DataTable ExecuteDataTable(string strSQL)
        {
            DataTable functionReturnValue = null;
            Open(); 
             
            DataSet oData = new DataSet();
            try
            {
                SqlDataAdapter oAdap = new SqlDataAdapter(strSQL, mConnection);
                oAdap.Fill(oData, "Registros");
                mConnection.Close();
                functionReturnValue = oData.Tables[0];
            }
            catch (Exception ex)
            {
                mConnection.Close();
                throw ex;
            }
            return functionReturnValue;
        }

        public object ExecuteScalar(string strSQL)
        {
            object functionReturnValue = null;
            try
            {
                Open();
                SqlCommand oCommand = new SqlCommand(strSQL, mConnection);
                functionReturnValue =oCommand.ExecuteScalar();
                mConnection.Close();
            }
            catch (Exception ex)
            {
                mConnection.Close();
                throw ex;
            }
            return functionReturnValue;
        }
   
        public  SqlDataReader Executereader(string sSQL) 
        {
            try
            {
                Open();
                SqlCommand oCommand = new SqlCommand(sSQL, mConnection);
                SqlDataReader reader = oCommand.ExecuteReader();
                reader.Close();
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

