using Microsoft.AspNetCore.Mvc;
using System.Data;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data.SqlClient;
using AreaCrud.Areas.COF_Product.Models;

namespace AreaCrud.Areas.COF_Product.Controllers
{
    [Area("COF_Product")]
    [Route("COF_Product/[controller]/[action]")]
    public class ProductController : Controller
    {
        #region configurations
        private IConfiguration _configuration;
        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region List of product
        public IActionResult ProductList()
        {
            string connectionString = _configuration.GetConnectionString("myConnectionString");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PR_Product_SelectAll";
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return View(table);
        }
        #endregion

        #region check for add or edit
        public IActionResult AddEditProduct(int? id)
        {
            string connectionString = this._configuration.GetConnectionString("myConnectionString");
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            SqlCommand command1 = connection1.CreateCommand();
            command1.CommandType = System.Data.CommandType.StoredProcedure;
            command1.CommandText = "PR_User_DropDown";
            SqlDataReader reader1 = command1.ExecuteReader();
            DataTable dataTable1 = new DataTable();
            dataTable1.Load(reader1);
            List<UserDropDownModel> userList = new List<UserDropDownModel>();
            foreach (DataRow data in dataTable1.Rows)
            {
                UserDropDownModel userDropDownModel = new UserDropDownModel();
                userDropDownModel.UserID = Convert.ToInt32(data["UserID"]);
                userDropDownModel.UserName = data["UserName"].ToString();
                userList.Add(userDropDownModel);
            }
            ViewBag.UserList = userList;
            if (id != null)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "PR_Product_SelectByPk";
                command.Parameters.Add("@ProductID", SqlDbType.Int).Value = id;
                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                ProductModel data = new ProductModel();
                foreach (DataRow dr in table.Rows)
                {
                    data.ProductID = Convert.ToInt32(@dr["ProductID"]);
                    data.ProductName = @dr["ProductName"].ToString();
                    data.ProductCode = @dr["ProductCode"].ToString();
                    data.ProductPrice = Convert.ToDecimal(@dr["ProductPrice"]);
                    data.Description = @dr["Description"].ToString();
                    data.UserID = Convert.ToInt32(@dr["UserID"]);
                }
                return View(data);
            }
            else
            {
                return View();
            }
        }

        #endregion

        #region Save Product
        [HttpPost]
        public IActionResult SaveProduct(ProductModel pm)
        {
            ModelState.Remove("ProductID");
            if (ModelState.IsValid)
            {
                string connectionString = this._configuration.GetConnectionString("myConnectionString");
                SqlConnection connection1 = new SqlConnection(connectionString);
                connection1.Open();
                SqlCommand command = connection1.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "PR_Product_Insert";
                if (pm.ProductID > 0)
                {
                    command.CommandText = "PR_Product_UpdateByPk";
                    command.Parameters.Add("@ProductID", SqlDbType.Int).Value = pm.ProductID;
                }
                command.Parameters.AddWithValue("ProductName", pm.ProductName);
                command.Parameters.AddWithValue("ProductPrice", pm.ProductPrice);
                command.Parameters.AddWithValue("ProductCode", pm.ProductCode);
                command.Parameters.AddWithValue("Description", pm.Description);
                command.Parameters.AddWithValue("UserID", pm.UserID);
                command.ExecuteNonQuery();
                return RedirectToAction("ProductList");
            }
            else
            {
                return RedirectToAction("AddEditProduct");
            }
        }
        #endregion

        #region delete Product
        public IActionResult ProductDelete(int ProductID)
        {
            try
            {
                string connectionString = this._configuration.GetConnectionString("myConnectionString");
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "PR_Product_DeleteByPk";
                command.Parameters.Add("@ProductID", SqlDbType.Int).Value = ProductID;
                command.ExecuteNonQuery();
                return RedirectToAction("ProductList");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                Console.WriteLine(ex.ToString());
                return RedirectToAction("ProductList");
            }
        }
        #endregion

        #region Export to Excel
        [HttpGet]
        public IActionResult ExportToExcel()
        {
            string connectionString = _configuration.GetConnectionString("myConnectionString");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "PR_Product_SelectAll";
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            // Generate Excel file
            using (var package = new ExcelPackage())
            {
                // Create a worksheet
                var worksheet = package.Workbook.Worksheets.Add("Products");

                // Set column headings
                worksheet.Cells[1, 1].Value = "Product ID";
                worksheet.Cells[1, 2].Value = "Product Name";
                worksheet.Cells[1, 3].Value = "Product Price";
                worksheet.Cells[1, 4].Value = "Product Code";
                worksheet.Cells[1, 5].Value = "Description";
                worksheet.Cells[1, 6].Value = "User ID";

                // Make the header row bold
                using (var range = worksheet.Cells[1, 1, 1, 6])
                {
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                }
                int i = 0;
                // Add product data
                foreach (DataRow product in table.Rows)
                {
                    worksheet.Cells[i + 2, 1].Value = product["ProductID"];
                    worksheet.Cells[i + 2, 2].Value = product["ProductName"];
                    worksheet.Cells[i + 2, 3].Value = product["ProductPrice"];
                    worksheet.Cells[i + 2, 4].Value = product["ProductCode"];
                    worksheet.Cells[i + 2, 5].Value = product["Description"];
                    worksheet.Cells[i + 2, 6].Value = product["UserID"];
                    i++;
                }

                // AutoFit columns
                worksheet.Cells.AutoFitColumns();

                // Set file format and content
                var stream = new MemoryStream();
                package.SaveAs(stream);
                stream.Position = 0;

                var fileName = "ProductData.xlsx";
                var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

                return File(stream, contentType, fileName);
            }
        }
        #endregion
    }
}
