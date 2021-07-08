using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Interfaz
{
    public partial class frmBuscarSocios : Form
    {
        public frmBuscarSocios()
        {
            InitializeComponent();
            cbxActivo.Text = "SI";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string stFiltro = "";

            if (cmbSeleccionFiltro.Text == "DNI")
            {
                stFiltro = "where dni like '%" + txtFiltro.Text + "%'";
            }
            else if (cmbSeleccionFiltro.Text == "Nombre")
            {
                stFiltro = "where nombre like '%" + txtFiltro.Text + "%'";
            }
            else if (cmbSeleccionFiltro.Text == "Apellido")
            {
                stFiltro = "where apellido like '%" + txtFiltro.Text + "%'";
            }
            else
            {
                stFiltro = "";
            }

            clsSocios oSocs = new clsSocios();

            dgvSocios.DataSource = oSocs.Consultar(stFiltro);

            dgvSocios.Columns["IDSocio"].Visible = false;
            dgvSocios.Columns["FechaAlta"].Visible = false;
            dgvSocios.Columns["Activo"].Visible = false;
            dgvSocios.Columns["Direccion"].Visible = false;
            dgvSocios.Columns["FechaNac"].Visible = false;

            dgvSocios.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
            dgvSocios.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
            dgvSocios.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
            dgvSocios.Columns[3].SortMode = DataGridViewColumnSortMode.Automatic;
            dgvSocios.Columns[4].SortMode = DataGridViewColumnSortMode.Automatic;
            dgvSocios.Columns[5].SortMode = DataGridViewColumnSortMode.Automatic;
            //dgvSocios.Columns. = "Nombre, Apelldo, DNI, Telefono, CorreoElectronico, TelContacto ASC";
        }

        private void btnCargarBD_Click(object sender, EventArgs e)
        {
            frmCargarBD CargarBD = new frmCargarBD();
            CargarBD.ShowDialog();
        }

        private void dgvSocios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsSocios.Socio obj = new clsSocios.Socio();

            txtIDSocio.Text = Convert.ToInt32(dgvSocios.Rows[e.RowIndex].Cells["idsocio"].Value).ToString();
            txtNombre.Text = dgvSocios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgvSocios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            txtDNI.Text = dgvSocios.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
            txtFechaNac.Text = Convert.ToDateTime(dgvSocios.Rows[e.RowIndex].Cells["Fechanac"].Value).ToString("dd/MM/yyyy");
            txtDireccion.Text = dgvSocios.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            txtTelefono.Text = dgvSocios.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            txtTelContacto.Text = dgvSocios.Rows[e.RowIndex].Cells["Telcontacto"].Value.ToString();
            txtCorreoElectronico.Text = dgvSocios.Rows[e.RowIndex].Cells["CorreoElectronico"].Value.ToString();
            txtFechaAlta.Text = Convert.ToDateTime(dgvSocios.Rows[e.RowIndex].Cells["FechaAlta"].Value).ToString("dd/MM/yyyy");
            if (Convert.ToInt32(dgvSocios.Rows[e.RowIndex].Cells["Activo"].Value) == 1)
                cbxActivo.Text = "SI";
            else
                cbxActivo.Text = "NO";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDNI.Text == "" || txtFechaAlta.Text == "" || txtFechaNac.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtTelContacto.Text == "" || txtCorreoElectronico.Text == "" || cbxActivo.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos", "ALERTA");
            }
            else
            {
                if (!txtCorreoElectronico.Text.Contains("@") || !txtCorreoElectronico.Text.Contains(".com"))
                {
                    MessageBox.Show("Correo electrónico inválido", "ALERTA");
                }
                else
                {

                    clsSocios obj = new clsSocios();
                    clsSocios.Socio objsocio = new clsSocios.Socio();

                    if (txtIDSocio.Text == "")//Insertar
                    {
                        string stSQL = "select dni from socio where dni = " + txtDNI.Text + "";
                        int DNI = obj.DNISocio(stSQL);

                        if (txtDNI.Text == DNI.ToString())
                        {
                            MessageBox.Show("El socio ya existe", "ALERTA");
                        }
                        else
                        {
                            objsocio.Nombre = txtNombre.Text;
                            objsocio.Apellido = txtApellido.Text;
                            objsocio.DNI = Convert.ToInt32(txtDNI.Text);
                            objsocio.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
                            objsocio.FechaAlta = Convert.ToDateTime(txtFechaAlta.Text);
                            objsocio.Direccion = txtDireccion.Text;
                            objsocio.Telefono = Convert.ToInt64(txtTelefono.Text);
                            objsocio.TelContacto = Convert.ToInt64(txtTelContacto.Text);
                            objsocio.CorreoElectronico = txtCorreoElectronico.Text;
                            if (cbxActivo.Text == "SI")
                                objsocio.Activo = 1;
                            else
                                objsocio.Activo = 0;

                            obj.Guardar(objsocio);

                            btnBuscar.PerformClick();

                            stSQL = "select idsocio from socio where dni = " + txtDNI.Text + "";
                            int ID = obj.IDSocio(stSQL);

                            txtIDSocio.Text = ID.ToString();
                        }
                    }
                    else//actualizar
                    {
                        objsocio.IdSocio = Convert.ToInt32(txtIDSocio.Text);
                        objsocio.Nombre = txtNombre.Text;
                        objsocio.Apellido = txtApellido.Text;
                        objsocio.DNI = Convert.ToInt32(txtDNI.Text);
                        objsocio.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
                        objsocio.FechaAlta = Convert.ToDateTime(txtFechaAlta.Text);
                        objsocio.Direccion = txtDireccion.Text;
                        objsocio.Telefono = Convert.ToInt64(txtTelefono.Text);
                        objsocio.TelContacto = Convert.ToInt64(txtTelContacto.Text);
                        objsocio.CorreoElectronico = txtCorreoElectronico.Text;
                        if (cbxActivo.Text == "SI")
                            objsocio.Activo = 1;
                        else
                            objsocio.Activo = 0;

                        obj.Guardar(objsocio);

                        btnBuscar.PerformClick();
                    }
                }
            }
        }

        private void txtLimpiarCampos_Click(object sender, EventArgs e)
        {
            cbxActivo.Text = "SI";
            txtIDSocio.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtFechaNac.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtTelContacto.Text = "";
            txtCorreoElectronico.Text = "";
            txtFechaAlta.Text = "";
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void SoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            } 
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTelContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
