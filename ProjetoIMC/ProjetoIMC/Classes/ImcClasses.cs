using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIMC.Classes
{
    public class Clinica
    {
        public string Nome { get; set; }

        private List<Paciente> pacientes;

        public Clinica(String nome)
        {
            Nome = nome;
            pacientes = new List<Paciente>();
        }

        public void Add(Paciente paciente)
        {
            pacientes.Add(paciente);    
        }

        public String relatorio()
        {
            StringBuilder sb = 
                new StringBuilder(String.Concat("Clinica:", Nome , "\r\n\r\n"));

            foreach(Paciente p in pacientes)
            {
                sb.Append(p.ToString());
            }
            return sb.ToString();   
        }

    }
    public class Paciente
    {
        public static int iniId = 0;
        public int Codigo { get; } 
        public string Nome { get; }
        public char Sexo { get; }
        public IMC Imc { get; }
        public Paciente(string nome, char sexo, IMC imc)
        {
            Codigo = ++iniId;
            Nome = nome;
            Sexo = sexo;
            Imc = imc;
        }
        public override string ToString()
        {
            return String.Concat(
            "Código: ", Codigo.ToString("D6"),
            ", Nome: ", Nome, 
            ", Sexo: ", Sexo, 
            ", Diagnóstico: ", Imc.critica(), "\r\n");
        }
    }
    public class IMC
    {
        public float Peso { get;  }
        public float Altura { get;  }
        public IMC (float peso, float altura)
        {
            Peso = peso;
            Altura = altura;
        }
        public float imc()
        {
            return Peso/(Altura * Altura);
        }
        public string critica()
        {
            float vImc = imc();

            if (vImc < 18.5F) return "Magro";
            if (vImc < 25) return "Peso normal";
            if (vImc < 30) return "Obesidade 1";
            if (vImc < 35) return "Obesidade 2";
            return "Obesidade Mórbida";
        }
    }
}
