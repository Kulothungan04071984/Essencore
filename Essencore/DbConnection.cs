using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Essencore
{
   
    class DbConnection
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"].ToString());
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt;
        public string DbConnect(string barcode)
        {
            cmd = new SqlCommand("pro_getCustomerSerialNo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pcbserialno", barcode);
            con.Open();
            var reader = cmd.ExecuteScalar();
            con.Close();
            return reader.ToString(); 
        }

        public List<BarcodeDetails> GetBarcodeDetails(string productno)
        {
            var list = new List<BarcodeDetails>();
            BarcodeDetails objBar;
            cmd = new SqlCommand("pro_getPrintedValue", con);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter=new SqlDataAdapter (cmd);
            dt=new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                objBar=new BarcodeDetails();
                objBar.CustomerSerialNo = Convert.ToString(dr["CustomerSerialNo"]);
                objBar.PCBSerialNo= Convert.ToString(dr["PCBSerialNo"]);
                objBar.ProductNo = productno; 
                list.Add(objBar);
            }
            return list;
        }

        public List<labeltype> GetLabels() {
            var lstType = new List<labeltype>();
            labeltype objType=new labeltype ();
            cmd = new SqlCommand("getLabelType", con);
            cmd.CommandType=CommandType.StoredProcedure;
            adapter=new SqlDataAdapter (cmd);
            dt=new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                objType = new labeltype();
                objType.labelmasterid = Convert.ToInt32(dr["labelmasterid"]);
                objType.labelname = Convert.ToString(dr["labeltype"]);
                lstType.Add(objType);
            }
            return lstType;

        }

        public BarcodeDetails GetProductDetails(int labelid)
        {
            var barCodeDetils = new BarcodeDetails();
            string result = string.Empty;
            cmd = new SqlCommand("get_ProductNo", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@labelid", labelid);
            adapter=new SqlDataAdapter (cmd);
            dt=new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                barCodeDetils.SyrmaSGSPartno = dt.Rows[0]["SyrmaSGSPartno"].ToString();
                barCodeDetils.WorkOrderNo = dt.Rows[0]["WorkOrderNo"].ToString();
                barCodeDetils.CustomerPartNo = dt.Rows[0]["CustomerPartNo"].ToString();
                barCodeDetils.Bar_Description = dt.Rows[0]["Bar_Description"].ToString();
                barCodeDetils.WeekDetails = Convert.ToInt32(dt.Rows[0]["WeekDetails"].ToString());
                barCodeDetils.ProductNo = dt.Rows[0]["productno"].ToString();
            }
            //con.Open();
            //result = Convert.ToString(cmd.ExecuteScalar());
            //con.Close();
            return barCodeDetils;
        }
    }
}
