using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Microsoft.Office.Interop.Word;


namespace Controller
{
    class DocumentoController
    {
        public Documento Documento { get; set; }

        public DocumentoController()
        {

            this.CreateDocument(this.OpenWord());
        }

        private void PreencheConteudo(ref Document doc, ref Application app)
        {
            object missing = System.Reflection.Missing.Value;
            doc.Content.SetRange(0, 0);
            doc.Content.Text = "MARÇO/ABRIL SERIA  ...EM .... FOI EM..." + Environment.NewLine;
            

            Paragraph para1 = doc.Content.Paragraphs.Add(ref missing);
            para1.Range.Text = "                                                            LÍNG. PORTUGUESA   2ªF                        MATEMÁTICA  3ª F                 CIÊNCIAS NAT.4ªF-                        HISTÓRIA/GEOGRAFIA5ªF            ARTES /ENS. RELIG./ÈTICA6ªF";
            para1.SpaceAfter = app.CentimetersToPoints(0);
            para1.Range.InsertParagraphAfter();

            Table firstTable = doc.Tables.Add(para1.Range, 7, 6, ref missing, ref missing);
            firstTable.Borders.Enable = 1;


        }

        private void CreateDocument(Application app)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                Document doc = app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                doc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
                doc.PageSetup.LeftMargin = app.CentimetersToPoints(1.27f);
                doc.PageSetup.RightMargin = app.CentimetersToPoints(1.27f);
                doc.PageSetup.TopMargin = app.CentimetersToPoints(1.27f);
                doc.PageSetup.BottomMargin = app.CentimetersToPoints(1.27f);

                this.PreencheConteudo(ref doc, ref app);

                object filename = @"d:\pactw\Desktop\temp7.docx";
                doc.SaveAs2(ref filename);
                doc.Close(ref missing, ref missing, ref missing);
                doc = null;
                app.Quit(ref missing, ref missing, ref missing);
                app = null;
                Console.WriteLine("Documento Criado com sucesso! Localizado em: " + filename);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private Application OpenWord()
        {
            Application winword = new Application();
            winword.ShowAnimation = false;
            winword.Visible = false;
            return winword;
        }
    }
}
