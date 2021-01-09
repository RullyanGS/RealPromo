using Microsoft.AspNetCore.SignalR;
using RealPromo.ApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealPromo.ApiWeb.Hubs
{
    //RPC
    public class PromoHub : Hub
    {
        /*
         * Cliente - JS/C#/Java
         * - Cliente -> Hub(C#) (C# - CadastrarPromocao)
         * - Hub -> Cliente(JS) (JS - ReceberPromocao)
         */

        public async Task CadastrarPromocao(Promocao promocao)
        {
            /*
             * Bancon
             * Queue/Scheduler...
             * Notificar o usuario (SignalR).
             */

            await Clients.Caller.SendAsync("CadastradoSucesso");
            await Clients.Others.SendAsync("ReceberPromocao", promocao);
        }
    }
}
