using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Controller {
    public class Resultado {
        public bool condicao { get; set; }
        public String mensagem { get; set; }
        public Object resultado { get; set; }

        public Resultado(bool condicao, string mensagem) {
            this.condicao = condicao;
            this.mensagem = mensagem;
        }

        public Resultado(bool condicao, string mensagem, object resultado) {
            this.condicao = condicao;
            this.mensagem = mensagem;
            this.resultado = resultado;
        }
    }
}
