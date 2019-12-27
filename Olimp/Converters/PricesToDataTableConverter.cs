using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using Olimp.Dal.NewdatabaseClasses;
namespace Olimp.Converters
{
   public class PricesToDataTableConverter
    {
        public static DataTable ConvertOlimpPricesTodataTable(List<OlimpPrices> prices)
        {
            DataTable table = new DataTable();

            OlimpPrices p = (OlimpPrices)prices[0];

            PropertyInfo[] mas = p.GetType().GetProperties();

            foreach (PropertyInfo property in mas)
            {
               
                table.Columns.Add(property.Name);
            }


            foreach (OlimpPrices price in prices)
            {
                PropertyInfo[] mas2 = price.GetType().GetProperties();
                DataRow dataRow = table.NewRow();
                for (int i = 0; i < mas2.Length; i++)
                {
                    dataRow[i] = mas2[i].GetValue(price);

                }

                table.Rows.Add(dataRow);
            }

            return table;
        }
    }
}
