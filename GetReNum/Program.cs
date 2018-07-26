using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace GetReNum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入你的机器码：");
                string strMun = Console.ReadLine();
                GetHTML.SoftReg soft = new GetHTML.SoftReg();
                Console.WriteLine(soft.GetRNumByMum(strMun));
            }
            catch
            {
 
            }
        }
       
        //根据订单号获取
        //public string[] GetinfoByOrderNo(string strNo)
        //{
        //    string[] arr = new string[2];
        //    string sql = string.Format("select ShippingCompany, TrackingNumer from Order_Shipping where OrderNO='{0}'", strNo);
        //    DataTable dt = ShoppingDataOpear.DBUtility.DbHelperSQL.Query(sql).Tables[0];
        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        arr[0] = dt.Rows[0][0].ToString();
        //        arr[1] = dt.Rows[0][1].ToString();
        //    }
        //    return arr;
        //}

        //public void Mainfunction()
        //{
        //    DataTable dt = CommonSpace.Conmmon.ExcelToDataTable("D:\\tracking2.xls", "Sheet1", CommonSpace.ExcelVersions.Excel8);

        //    DataTable dtSave = dt.Clone();
        //    DataRow drs;
        //    string strnum = string.Empty;
        //    string[] strValue = new string[2];
        //    int colmun = dt.Columns.Count;

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        drs = dtSave.NewRow();
        //        //for (int i = 0; i < colmun; i++)
        //        //{
        //        strnum = dr[2].ToString();
        //        strValue = GetinfoByOrderNo(strnum);

        //        //设置行的值
        //        drs["序号"] = dr[0].ToString();
        //        drs["交易流水号"] = dr[1].ToString();
        //        drs["商户订单号"] = dr[2].ToString();
        //        drs["交易日期"] = dr[3].ToString();
        //        drs["订单金额"] = dr[4].ToString();

        //        drs["快递公司"] = strValue[0];
        //        drs["跟踪单号"] = strValue[1];
        //        drs["网址"] = dr[7].ToString();
        //        //}
        //        dtSave.Rows.Add(drs);
        //    }

        //    //导出数据
        //    ExcelFile.SetData(dtSave, "D:\\a.xls", ExcelVersion.Excel8, HDRType.Yes);
        //    MessageBox.Show("导出成功");
        //}

        //public string SplitString(string strInput)
        //{
        //    string res = string.Empty;
        //    if (!string.IsNullOrEmpty(strInput))
        //    {
        //        if (strInput.Contains(","))
        //        {
        //            string[] arr = strInput.Split(',');
        //            if (arr.Length > 0)
        //            {
        //                res = arr[0];
        //            }
        //        }
        //        else
        //        {
        //            res = strInput;
        //        }
        //    }
        //    else
        //    {
        //        res = "NoContent";
        //    }
        //    return res;
        //}
    }
}
