using System;
using System.Collections.Generic;
using System.Text;  // para usar o StringBuilder

namespace ConsoleApp1.Entidades
{
    class Publicar
    {
        public DateTime Momento { get; set; }
        public string Titulo{ get; set; }
        public string Conteudo { get; set; }
        public int Gosto { get; set; }
        public List<Comentario> Comentar { get; set; } = new List<Comentario>(); // define lista para remover e add coment

        public Publicar()
        {
        }

        public Publicar(DateTime momento, string titulo, string conteudo, int gostos)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Gosto = gostos;
        }

        public void AdicionaComentario(Comentario comentario)
        {
            Comentar.Add(comentario);
        }

        public void RemoveComentario(Comentario comentario)
        {
            Comentar.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder varSB = new StringBuilder(); // variavel StrigBuilder
            varSB.AppendLine(Titulo); // acrescenta linha e conteudo à stringBuilder
            varSB.AppendLine(); // adiciona linha vazia
            varSB.AppendFormat("{0:C} ", Gosto);  // Formada variável Gosto com R$ xx,00
            varSB.Append(" Gostos - ");
            varSB.Insert(10, ". Muito Bem! "); // Adiciona após o caracter 10 o conteudo informado
            varSB.Remove(30, 4); // Remove a partir do caracter 20, 4 caracteres
            varSB.Replace('!', '?'); // troca o cacater ! pelo ? no primeiro que achar
            varSB.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            varSB.AppendLine(Conteudo);
            varSB.AppendLine("Comentario:");
            foreach (Comentario varComentario in Comentar) // percorre a lista Comentar e adiciona o conteudo à 
            {
                varSB.AppendLine(varComentario.Texto);
            }
            varSB.AppendLine("Tamanho da String Builder : " + varSB.Length);
            return varSB.ToString();
        }
    }
}
