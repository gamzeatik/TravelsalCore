using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace TravelsalCore.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            Paragraph paragraph = new Paragraph("Traversal rezervasyon pdf raporu.");
            document.Add(paragraph); 
            document.Close();
            return File("PdfReports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");

            pdfPTable.AddCell("Yaşar");
            pdfPTable.AddCell("Atalay");
            pdfPTable.AddCell("11111111111");

            pdfPTable.AddCell("Alim");
            pdfPTable.AddCell("Şimşek");
            pdfPTable.AddCell("22222222222");

            pdfPTable.AddCell("Mehmet");
            pdfPTable.AddCell("Özkan");
            pdfPTable.AddCell("33333333333");
            document.Add(pdfPTable);
            document.Close();
            return File("PdfReports/dosya1.pdf", "application/pdf", "dosya2.pdf");
        }

    }
}
