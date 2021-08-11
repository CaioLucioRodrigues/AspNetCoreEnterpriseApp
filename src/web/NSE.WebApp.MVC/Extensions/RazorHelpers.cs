using Microsoft.AspNetCore.Mvc.Razor;
using System.Threading;

namespace NSE.WebApp.MVC.Extensions
{
    public static class RazorHelpers
    {
        public static string FormatarMoeda(this RazorPage page, decimal valor)
        {
            return valor > 0 ? string.Format(Thread.CurrentThread.CurrentCulture, "{0:C}", valor) : "Gratuito";
        }

        public static string MensagemEstoque(this RazorPage page, int quantidade)
        {
            return quantidade > 0 ? $"Apenas {quantidade} em estoque!" : "Produto esgotado";
        }
    }
}
