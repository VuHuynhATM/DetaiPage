using CarAuto.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CarAuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewController : ControllerBase
    {
        private SqlConnection conn;
        private SqlDataReader dr;
        [HttpGet]
        public Car GetCarByID(string carID)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-TDUH124\SQLEXPRESS;Initial Catalog=Mercedes;Integrated Security=SSPI");
            conn.Open();
            var query = "SELECT carID,name,color,price,quantity,image,Decription,categoryName,a.status FROM Car a JOIN Category b ON a.categoryID=b.categoryID WHERE carID=@carid";
            SqlCommand com = new SqlCommand(query, conn);
            com.Parameters.Add("@carid", SqlDbType.Int);
            com.Parameters["@carid"].Value = int.Parse(carID);
            dr = com.ExecuteReader();
            Car cardto = new Car();
            if (dr.Read())
            {
                cardto.carID = dr["carID"].ToString();
                cardto.carName = dr["name"].ToString();
                cardto.carColor = dr["color"].ToString();
                cardto.price = float.Parse(dr["price"].ToString());
                cardto.carQuantity = int.Parse(dr["quantity"].ToString());
                cardto.image = dr["image"].ToString();
                cardto.carDes = dr["Decription"].ToString();
                cardto.carCategory = dr["categoryName"].ToString();
                cardto.status = bool.Parse(dr["status"].ToString());
            }
            conn.Close();
            return cardto;
        }
    }
}
