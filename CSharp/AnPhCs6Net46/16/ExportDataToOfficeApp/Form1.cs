using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace ExportDataToOfficeApp
{
    

    public partial class Form1 : Form
    {
        List<Car> carsInStock = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carsInStock = new List<Car>
    {
      new Car {Color="Green", Make="VW", PetName="Mary"},
      new Car {Color="Red", Make="Saab", PetName="Mel"},
      new Car {Color="Black", Make="Ford", PetName="Hank"},
      new Car {Color="Yellow", Make="BMW", PetName="Davie"}
    };
            UpdateGrid();

        }
        private void UpdateGrid()
        {
            // Reset the source of data.
            dataGridCars.DataSource = null;
            dataGridCars.DataSource = carsInStock;
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            NewCarDialog d = new NewCarDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                // Add new car to list.
                carsInStock.Add(d.theCar);
                UpdateGrid();
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(carsInStock);
        }

        static void ExportToExcel(List<Car> carsInStock)
        {
            // Load up Excel, then make a new empty workbook.
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();

            // This example uses a single workSheet.
            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            // Establish column headings in cells.
            workSheet.Cells[1, "A"] = "Make";
            workSheet.Cells[1, "B"] = "Color";
            workSheet.Cells[1, "C"] = "Pet Name";

            // Now, map all data in List<Car> to the cells of the spreadsheet.
            int row = 1;
            foreach (Car c in carsInStock)
            {
                row++;
                workSheet.Cells[row, "A"] = c.Make;
                workSheet.Cells[row, "B"] = c.Color;
                workSheet.Cells[row, "C"] = c.PetName;
            }

            // Give our table data a nice look and feel.
            workSheet.Range["A1"].AutoFormat(
              Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);

            // Save the file, quit Excel, and display message to user.
            workSheet.SaveAs(string.Format(@"{0}\Inventory.xlsx", Environment.CurrentDirectory));
            excelApp.Quit();
            MessageBox.Show("The Inventory.xslx file has been saved to your app folder",
              "Export complete!");
        }
    }

    public class Car
    {
        public string Color { get; set; }
        public string Make { get; set; }
        public string PetName { get; set; }
    }
}
