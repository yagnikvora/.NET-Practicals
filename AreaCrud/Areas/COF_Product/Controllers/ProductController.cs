using Microsoft.AspNetCore.Mvc;
using System.Data;
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

        #region add edit product
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
            if (id> 0)
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
                foreach(DataRow dr in table.Rows)
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
        [HttpPost]
        #region Save Product
        public IActionResult SaveProduct(ProductModel pm)
        {
            try
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
                command.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = pm.ProductName;
                command.Parameters.Add("@ProductPrice", SqlDbType.Decimal).Value = pm.ProductPrice;
                command.Parameters.Add("@ProductCode", SqlDbType.NVarChar).Value = pm.ProductCode;
                command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = pm.Description;
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = pm.UserID;

                command.ExecuteNonQuery();
                return RedirectToAction("ProductList");
            } catch(Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                Console.WriteLine(ex.ToString());
                return RedirectToAction("ProductList");
            }
            
        }
        #endregion

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
    }
}
