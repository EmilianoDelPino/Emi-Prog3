﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_5
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            string query = "delete from sucursal where Id_Sucursal=" + tbxSucursal.Text;
            int elimino = con.ejecutarConsulta(query);
            con.eliminoBD(elimino, lblSucursalEliminado);
            if (elimino == 0)
            {
                tbxSucursal.Text = "";
            }
        }
    }
}