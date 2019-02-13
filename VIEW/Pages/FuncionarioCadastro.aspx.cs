using System;
using System.Web;
using System.Web.UI;
using BLL.Model;
using DAL.Persistence;


namespace VIEW.Pages
{

    public partial class FuncionarioCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = "Iniciando o Cadastro";
        }

        protected void btnCadastrarFuncionario(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = nome.Text;
                funcionario.CodigoRegistro = CodigoRegistro.Text;

                nome.Text = "";
                CodigoRegistro.Text = "";

                string msg = "Funcionario" + funcionario.Nome + " - "
                            + funcionario.CodigoRegistro + " foi cadastrado com Sucesso.";

                lblMensagem.Text = msg;
                lblMensagem.Attributes.CssStyle.Add("color", "green");
            }
            catch(Exception erro)
            {
                lblMensagem.Text = erro.ToString();
            }
        }


    }
}
