using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Notifies
    {
        public Notifies()
        {
            notifies = new List<Notifies>();
        }

        public string NomeProp { get; set; }

        public string Mensagem { get; set; }

        public List<Notifies> notifies { get; set; }

        //validações
        public bool ValidarProp(string valor, string nomeProp) 
        {
            if(string.IsNullOrWhiteSpace(valor)|| string.IsNullOrWhiteSpace(nomeProp))
            {
                notifies.Add(new Notifies { Mensagem="Campo Obrigatório",
                NomeProp =nomeProp });

                return false;
            }
            return true;
        }

        public bool ValidarPropInt(int valor, string nomeProp)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomeProp))
            {
                notifies.Add(new Notifies
                {
                    Mensagem = "Campo Obrigatório",
                    NomeProp = nomeProp
                });

                return false;
            }
            return true;
        }
    }
}
