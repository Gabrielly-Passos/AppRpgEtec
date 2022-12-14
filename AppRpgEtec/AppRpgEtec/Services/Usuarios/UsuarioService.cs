using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppRpgEtec.Models;


namespace AppRpgEtec.Services.Usuarios
{
    public class UsuarioService : Request
    {
        private readonly Request _request;
        private const string ApiUrlBase = "http://lzsouza.somee.com/RpgApi/Usuarios";

        public UsuarioService()
        {
            _request = new Request();
        }

        public async Task<Usuario> PostLoginUsuarioAsync(Usuario u)
        {
            //Autenticar: Rota para método na API que verifica usuário e senha  // consomem a API
            string urlComplementar = "/Autenticar";
            u.Token = await _request.PostReturnStringAsync(ApiUrlBase + urlComplementar, u);
            return u;
        }


    }
}
