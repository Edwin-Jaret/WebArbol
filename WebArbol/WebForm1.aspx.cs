using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassEntidades;
using ClassLogicaNegocios;

namespace WebArbol
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private ArbolB obArbol;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                obArbol = new ArbolB();
                Session["coleccion"] = obArbol;
            }
            else
            {
                obArbol = (ArbolB)Session["coleccion"];
            }
        }
        private void ActualizarViewTree()
        {
            string arbol = obArbol.Conexion();
            ClientScript.RegisterStartupScript(this.GetType(), "conectar", $"conectar(`{arbol}`)", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                NodoArbol entidad = new NodoArbol
                {
                    Valor = int.Parse(TextBox1.Text)
                };
                TextBox2.Text = obArbol.AgregarAArbol(entidad);
                TextBox1.Text = "";
            }
            catch (FormatException)
            {
                TextBox2.Text = "Ingresa un número entero válido";
            }
            ActualizarViewTree();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox antes de mostrar los valores
            ListBox1.Items.Clear();

            // Obtener los valores de los diferentes recorridos
            List<int> inorden = obArbol.ObtenerValoresInOrden();
            List<int> preorden = obArbol.ObtenerValoresPreOrden();
            List<int> postorden = obArbol.ObtenerValoresPostOrden();
            List<int> niveles = obArbol.ObtenerValoresNiveles();

            // Mostrar los valores de los recorridos en una sola línea en el ListBox
            ListBox1.Items.Add("Inorden: " + string.Join(", ", inorden));
            ListBox1.Items.Add("Preorden: " + string.Join(", ", preorden));
            ListBox1.Items.Add("Postorden: " + string.Join(", ", postorden));
            ListBox1.Items.Add("Niveles: " + string.Join(", ", niveles));

            ActualizarViewTree();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(TextBox1.Text);
                TextBox2.Text = obArbol.EliminarDelArbol(valor);
                TextBox1.Text = "";
            }
            catch (FormatException)
            {
                TextBox2.Text = "Ingrese un número entero válido";
            }
            ActualizarViewTree();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ActualizarViewTree();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            ActualizarViewTree();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string mensaje = obArbol.BalancearArbol();
            TextBox2.Text = mensaje;
            ActualizarViewTree();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(TextBox1.Text);
                TextBox2.Text = obArbol.Buscar(valor);
                TextBox1.Text = "";
            }
            catch (FormatException)
            {
                TextBox2.Text = "Ingrese un número entero válido";
            }
            ActualizarViewTree();
        }
    }
}