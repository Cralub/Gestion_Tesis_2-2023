﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Usuario_PAgregarCelular : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAgregarCelular_Click(object sender, EventArgs e)
    {
        CCelular cCelular = new CCelular();
        cCelular.Insertar_GCelular_I(Session["CodigoUsuario"].ToString(), txbCodigoArea.Text, int.Parse(txbNumeroCelular.Text));
        Response.Redirect("PPerfilUsuario.aspx");
    }
}