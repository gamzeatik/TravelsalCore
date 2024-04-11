using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Office2010.Ink;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TravelsalCore.Models;

namespace TravelsalCore.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<DestinationModel> DestinationList()
        {
             List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c= new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
            }
            return destinationModels;
        }
        public List<ReservationModel> ReservationList()
        {
            List<ReservationModel> reservationModels = new List<ReservationModel>();
            using(var c= new Context())
            {
                reservationModels = c.Reservations.Select(x => new ReservationModel
                {
                    AppUser = x.AppUser,
                    PersonCount = x.PersonCount,
                    ReservationDate = x.ReservationDate,
                    Description = x.Description,
                    Status  = x.Status,
                    DestinationCity = x.Destination.City,
                    DestinationDayNight = x.Destination.DayNight,
                    DestinationPrice = x.Destination.Price
                }).ToList();
            }
            return reservationModels;
        }
        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel.xlsx");

            //ExcelPackage excel = new ExcelPackage();
            //var workSheet = excel.Workbook.Worksheets.Add("Sayfa 1");
            //workSheet.Cells[1, 1].Value = "Rota";
            //workSheet.Cells[1, 2].Value = "Rehber";
            //workSheet.Cells[1, 3].Value = "Kontenjan";

            //workSheet.Cells[2, 1].Value = "Gürcistan Batum Turu";
            //workSheet.Cells[2, 2].Value = "Kadir Keşanlı";
            //workSheet.Cells[2, 3].Value = "50";

            //workSheet.Cells[3, 1].Value = "Sırbistan Makedonya Turu";
            //workSheet.Cells[3, 2].Value = "Ece Taş";
            //workSheet.Cells[3, 3].Value = "35";

            //var bytes = excel.GetAsByteArray();
            //return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "dosya1.xlsx");
        }
        public IActionResult DestinationExcelReport()
        {
            using (var workBook=new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Destinations List");
                workSheet.Cell(1, 1).Value = "City";
                workSheet.Cell(1, 2).Value = "DayNight";
                workSheet.Cell(1, 3).Value = "Price";
                workSheet.Cell(1, 4).Value = "Capacity";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.DayNight;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DestinationsReport.xlsx");
                }
            }            
        }
        public IActionResult ReservationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Reservation List");
                workSheet.Cell(1, 1).Value = "Guset";
                workSheet.Cell(1, 2).Value = "PersonCount";
                workSheet.Cell(1, 3).Value = "ReservationDate";
                workSheet.Cell(1, 4).Value = "Status";
                workSheet.Cell(1, 5).Value = "DestinationCity";
                workSheet.Cell(1, 6).Value = "DestinationDayNight";
                workSheet.Cell(1, 7).Value = "DestinationPrice";

                int rowCount = 2;
                foreach (var item in ReservationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.AppUser;
                    workSheet.Cell(rowCount, 2).Value = item.PersonCount;
                    workSheet.Cell(rowCount, 3).Value = item.ReservationDate;
                    workSheet.Cell(rowCount, 4).Value = item.Status;
                    workSheet.Cell(rowCount, 5).Value = item.DestinationCity;
                    workSheet.Cell(rowCount, 6).Value = item.DestinationDayNight;
                    workSheet.Cell(rowCount, 7).Value = item.DestinationPrice;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ReservationReport.xlsx");
                }
            }
        }

    }
}
