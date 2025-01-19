using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjBase.Forms
{
    public partial class index : System.Web.UI.Page
    {
        private static char[] chave = { '2', '7', 'z', 'c', '9' };
        protected void Page_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "Trabalho de Segurança da Informação";
            lbArquivo.Text = "Selecione o arquivo";
            lbNomeArquivoSaida.Text = "Nome arquivo de saida!";
        }

        protected void btDecrip_Click(object sender, EventArgs e)
        {
            string arq = Server.MapPath("/") + 
                Path.GetFileName(arquivo.PostedFile.FileName);
            arquivo.PostedFile.SaveAs(arq); // faço uma cópia no server
            byte [] stream = carregandoArquivo(arq);

            deCripta(stream, arq);
            // Bola com voces
        }

        protected void btCrip_Click(object sender, EventArgs e)
        {
            string arq = Server.MapPath("/") + Path.GetFileName(arquivo.PostedFile.FileName);
            arquivo.PostedFile.SaveAs(arq);
            byte[] stream = carregandoArquivo(arq);

            // Bola com voces
            cripta(stream, arq);

        }

        private void deCripta(byte[] stream, string arq)
        {

            byte[] buf = new byte[stream.Length];

            for (int i = 0; i < stream.Length; i++)
            {
                buf[i] = (byte)(stream[i] - chave[i % 5]);
            }

            using (FileStream fs = new FileStream(arq, FileMode.Create))
            {
                using (BinaryWriter sr = new BinaryWriter(fs))
                {
                    sr.Write(buf);
                }
            }
        }
        private void cripta(byte [] stream, string arq)
        {
            byte []buf = new byte[stream.Length];

            for(int i = 0; i < stream.Length; i++)
            {
                buf[i] = (byte) (stream[i] + chave[i % 5]);
            }
            using (FileStream fs = new FileStream(arq, FileMode.Create))
            {
                using (BinaryWriter sr = new BinaryWriter(fs))
                {
                    sr.Write(buf);                    
                }
            }
        }
        private byte []carregandoArquivo(String arquivo)
        {
            byte[] arq = {0};

            FileInfo file = new FileInfo(arquivo); // using System.IO;
            long fileSize = file.Length;

            try
            {                              
                using (FileStream fs = new FileStream(arquivo, FileMode.Open))
                {
                    using (BinaryReader sr = new BinaryReader(fs))
                    {
                        arq = sr.ReadBytes((int) file.Length);                        
                    }                     
                }               
            } 
            catch(Exception e1)
            {
                lbArquivo.Text =  e1.Message;
            }
            return arq;
        } 
        
    }
}