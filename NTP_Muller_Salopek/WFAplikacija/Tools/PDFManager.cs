using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Compression;


using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.HtmlConverter;
using System.IO;

// Syncfusion.Pdf.WinForms nuGet package needed
namespace WFAplikacija.Tools
{
    public static class PDFManager
    {
        /// <summary>
        /// Creates pdf document with table created from list, 
        /// Location example @"C:\Users\Alen\Desktop\output.pdf"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        public static void createPDFfromList<T>(List<T> items, string title, string location)
        {
            //Create a new PDF document
            PdfDocument doc = new PdfDocument();
            //Add a page
            PdfPage page = doc.Pages.Add();
            //Create PDF graphics for the page.
            PdfGraphics graphics = page.Graphics;
            //Set the standard font.
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
            //Draw the text.
            PdfTextElement textElement = new PdfTextElement(title, font);
            textElement.Draw(graphics, new PointF(200, 0));
        
            //Create a PdfGrid
            PdfGrid pdfGrid = new PdfGrid();
            //Create table from list
            var myType = typeof(T);
            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in myType.GetProperties())
            {
                dataTable.Columns.Add(new DataColumn(info.Name, info.PropertyType));
            }
            foreach (var item in items)
            {
                DataRow dr = dataTable.NewRow();
                foreach (PropertyInfo info in myType.GetProperties())
                {
                    dr[info.Name] = info.GetValue(item);
                }
                dataTable.Rows.Add(dr);
            }
            //Assign data source
            pdfGrid.DataSource = dataTable;
            //Draw grid to the page of PDF document
            pdfGrid.Draw(page, new PointF(0, 50));
            //Save the document
            doc.Save(location);
            //Close the document
            doc.Close(true);
        }

        public static void BillsXmlToPdf()
        {
            //Initialize the HtmlToPdfConverter with IE rendering engine
            HtmlToPdfConverter htmlToPDFConverter = new HtmlToPdfConverter(HtmlRenderingEngine.IE);

            //Initialize IE converter settings
            IEConverterSettings IEsettings = new IEConverterSettings();

            //Set the additional delay for conversion
            IEsettings.AdditionalDelay = 1000;

            //Assign the IEConverterSettings to ConverterSettings of HtmlToPdfConverter
            htmlToPDFConverter.ConverterSettings = IEsettings;

            //Convert the XML file to PDF
            PdfDocument document = htmlToPDFConverter.Convert(Path.GetFullPath(XmlManager.AllBillXmlLoaction));

            //Save the PDF document
            document.Save(@"C:\Users\Alen\Desktop\output.pdf");

            //Close the instance of PdfDocument
            document.Close(true);
        }

    

  
    }
}
