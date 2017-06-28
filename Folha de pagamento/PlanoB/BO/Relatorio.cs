using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using BaseModels;
using PlanoB.Models;

namespace PlanoB.BO
{
    public class Relatorio : TNEReport
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public Relatorio()
        {
            Paisagem = false;
        }

        public override void MontaCorpoDados()
        {
            base.MontaCorpoDados();

            #region Cabeçalho do Relatório
            PdfPTable table = new PdfPTable(7);
            BaseColor preto = new BaseColor(0, 0, 0);
            BaseColor fundo = new BaseColor(200, 200, 200);
            Font font = FontFactory.GetFont("Verdana", 8, Font.NORMAL, preto);
            Font titulo = FontFactory.GetFont("Verdana", 8, Font.BOLD, preto);

            float[] colsW = { 10, 10, 10, 10, 10, 10, 10 };
            table.SetWidths(colsW);
            table.HeaderRows = 1;
            table.WidthPercentage = 100f;

            table.DefaultCell.Border = PdfPCell.BOTTOM_BORDER;
            table.DefaultCell.BorderColor = preto;
            table.DefaultCell.BorderColorBottom = new BaseColor(255, 255, 255);
            table.DefaultCell.Padding = 10;
            //colunas de cabeçario
            table.AddCell(getNewCell("Nome", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Cpf", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Bruto", titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("IR", titulo, Element.ALIGN_RIGHT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Inss", titulo, Element.ALIGN_RIGHT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Fgts", titulo, Element.ALIGN_RIGHT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            table.AddCell(getNewCell("Liquido", titulo, Element.ALIGN_RIGHT, 10, PdfPCell.BOTTOM_BORDER, preto, fundo));
            #endregion

              //var duplicatas = new DadosRelatorio().duplicatas;//banco de dados
             List<Folha> Folhas = db.Folhas.ToList();
              var clienteOld = string.Empty;

              foreach (var item in Folhas)//mudar para o bd
              {

                  var cell = getNewCell(item.Funcionario.Nome, titulo, Element.ALIGN_LEFT, 10, PdfPCell.BOTTOM_BORDER);
                  cell.Colspan = 5;
                  table.AddCell(cell);
                  clienteOld = item.Funcionario.Nome;
                float bruto, ir, inss,Fgts,liquido;
                bruto = FolhaNegocio.calculoBruto(item);
                ir=FolhaNegocio.calculoIr(bruto);
                inss = FolhaNegocio.calculoInss(bruto);
                Fgts = FolhaNegocio.calculoFgts(bruto);
                liquido = FolhaNegocio.salarioLiquido(bruto, ir, inss);
                /* //dados que eu quero mostrar no caso o retorno dos metodos que estão no FolhaNegocio
                 table.AddCell(getNewCell(, font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER)); //mudar os atributos
                 table.AddCell(getNewCell(d.Emissao.ToString("dd/MM/yyyy"), font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));
                 table.AddCell(getNewCell(d.Vencimento.ToString("dd/MM/yyyy"), font, Element.ALIGN_LEFT, 5, PdfPCell.BOTTOM_BORDER));
                 table.AddCell(getNewCell(string.Format("{0:0.00}", d.Valor), font, Element.ALIGN_RIGHT, 5, PdfPCell.BOTTOM_BORDER));
                 table.AddCell(getNewCell(string.Format("{0:0.00}", d.Saldo), font, Element.ALIGN_RIGHT, 5, PdfPCell.BOTTOM_BORDER));
                 */
                table.AddCell(getNewCell(string.Format("{0:0.00}",bruto), font, Element.ALIGN_RIGHT, 5, PdfPCell.BOTTOM_BORDER));
                table.AddCell(getNewCell(string.Format("{0:0.00}", ir), font, Element.ALIGN_RIGHT, 5, PdfPCell.BOTTOM_BORDER));
                table.AddCell(getNewCell(string.Format("{0:0.00}",inss), font, Element.ALIGN_RIGHT, 5, PdfPCell.BOTTOM_BORDER));
                table.AddCell(getNewCell(string.Format("{0:0.00}",Fgts ), font, Element.ALIGN_RIGHT, 5, PdfPCell.BOTTOM_BORDER));
                table.AddCell(getNewCell(string.Format("{0:0.00}",liquido), font, Element.ALIGN_RIGHT, 5, PdfPCell.BOTTOM_BORDER));
            }              
            doc.Add(table);
        }
    }
}