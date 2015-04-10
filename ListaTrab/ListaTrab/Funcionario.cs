using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTrab
{
    class Funcionario
    {
        public string sexo, profissao, salario, estado_civil, filhos, tipos_sanguineos, nome, pais, estado, cidade, bairro, rua;
        public int idade, telefone, numero;

        public Funcionario(int idade, string nome/*, int numero, int telefone, string sexo, string profissao, string salario, string estado_civil, string filhos, 
               string tipos_sanguineos, string pais, string estado, string cidade, string bairro, string rua*/)
        {
            this.nome = nome;
            this.idade = idade;
            /*this.profissao = profissao;
            this.salario = salario;
            this.estado_civil = estado_civil;
            this.filhos = filhos;
            this.tipos_sanguineos = tipos_sanguineos;
            this.pais = pais;
            this.estado = estado;
            this.cidade = cidade;
            this.bairro = bairro;
            this.rua = rua;
            this.idade = idade;
            this.sexo = sexo;
            this.telefone = telefone;
            this.numero = numero;*/
        }
        public string asString()
        {
            return nome + " " + idade;
        }
    }
}
