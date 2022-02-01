using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FirstWebAPIDemo
{
    public static class WebApiConfig
    {
        //método estático que possui um parâmetro de entradad do tipo HttpConfiguration
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();


            //Mapeia o modelo de rota especificada e defini os valores da rota padrão.
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional } 
                //Esse é o motivo no qual podemos utilizar a sobrecarga do método GET com ou sem parâmetro na classe  ValuesController.
                //Definimos o Id como opcional.
                
            );
        }
    }
}
