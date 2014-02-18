using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Lib
{
    public class Palindrome
    {
        public bool Verificar(string palavra)
        {
            palavra = Prepare(palavra);
            int i = 0;
            int j = palavra.Length - 1;
            while (i < palavra.Length / 2)
            {
                if (!palavra[i++].Equals(palavra[j--]))
                {
                    return false;
                }
            }
            return true;
        }
        private string Prepare(string palavra)
        {

            string nova_frase = palavra.ToLower().Replace("-", "");
            nova_frase = nova_frase.Replace(" ", "");
            nova_frase = nova_frase.Replace("á", "a");
            nova_frase = nova_frase.Replace("é", "e");
            nova_frase = nova_frase.Replace("í", "i");
            nova_frase = nova_frase.Replace("ó", "o");
            nova_frase = nova_frase.Replace("ú", "u");
            nova_frase = nova_frase.Replace("â", "a");
            nova_frase = nova_frase.Replace("ê", "e");
            nova_frase = nova_frase.Replace("ô", "o");
            nova_frase = nova_frase.Replace("ã", "a");
            nova_frase = nova_frase.Replace(".", "");
            nova_frase = nova_frase.Replace(",", "");
            nova_frase = nova_frase.Replace("(", "");
            nova_frase = nova_frase.Replace(")", "");
            nova_frase = nova_frase.Replace("'", "");
            nova_frase = nova_frase.Replace("\"", "");
            nova_frase = nova_frase.Replace("?", "");
            nova_frase = nova_frase.Replace("!", "");
            nova_frase = nova_frase.Replace(";", "");
            nova_frase = nova_frase.Replace(":", "");
            nova_frase = nova_frase.Replace("à", "a");
            return nova_frase;
        }

        public bool ArquivoExiste(string path)
        {
            return File.Exists(path);
        }

        public void LerArquivo(string path)
        {
            if (ArquivoExiste(path))
            {
                string[] arquivo = File.ReadAllLines(path);
                StringBuilder conteudo = new StringBuilder();
                for (int i = 0; i < arquivo.Length; i++)
			    {
                    if (!conteudo.ToString().Contains(arquivo[i]))
                    {
                        if (Verificar(arquivo[i]))
                        {
                            conteudo.AppendFormat("{0}:{1}", true, arquivo[i]);
                            conteudo.AppendLine();
                        }
                        else
                        {
                            conteudo.AppendFormat("{0}:{1}", false, arquivo[i]);
                            conteudo.AppendLine();
                        }
                    }
			    }
                
                File.WriteAllText(Path.GetDirectoryName(path) + "\\novoArquivo.txt", conteudo.ToString());
            }            
        }
    }
}
