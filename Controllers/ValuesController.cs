using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http; //namespace que contém a classe ApiController

namespace FirstWebAPIDemo.Controllers
{
    public class ValuesController : ApiController
    {

       
        //Está reclamando para deixar a lista somente leitura (ReadOnly)
        static  List<string> strings = new List<string>()
        {
            "value0", "value1", "value2"
        };

        //Então aqui, iremos criar uma lista do tipo string e logo após definiremos 3 elementos.



        //O comentário XML permite documentarmos trechos do código. Nesse caso podemos especificar a funcionalidade do método implementado HTTP GET, colocamos um sumary, porém o a tag que apresentará o comentário no Swagger ou outro testador será o <remarks>

        /// <summary>
        /// Get All the Values
        /// </summary>
        /// <remarks>
        /// Get All the Values
        /// </remarks>
        /// <returns></returns>
        public IEnumerable<string> Get() //IEnumerable<T> é uma interface que possui uma assinatura de um método com parametrização genérica
        {

            return strings;
            /*
            return new string[] { "value1", "value2"} ;
            estamos retornando um vetor string, com comprimento e conteúdos definidos logo após a sua declaração. */
            //Veja que nós não precisamos fazer a lógica de varredura da lista, pois estamos utilizando
            //um método concreto da interface IEnumerable<TYPE> que dá suporte a uma iteração simples.
        }

        // GET api/values/5
        public string Get(int id)
        {
            return strings[id];
            //iremos retornar a posição id da lista string
        }
        
        // POST api/values
        public void Post([FromBody] string value)
        {
            //Abaixo iremos adicionar uma novo valor à lista toda vez que acionarmos o método posto. a lista receberá o value do parâmetro de entrada.
            strings.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            strings[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            strings.RemoveAt(id);
            //Remove o elemento de acordo com o índice especificado.
        }
    }
}
