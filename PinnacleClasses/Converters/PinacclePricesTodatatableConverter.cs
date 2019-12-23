using System;
using System.Collections.Generic;
using System.Text;
using PinnacleClasses.DatabaseObjects;
using System.Reflection;
using System.Data;

namespace PinnacleClasses.Converters
{
   public class PinacclePricesTodatatableConverter
    {

        public static DataTable ConvertPinacclePricesTodataTable(List<PinacclePrices> prices)
        {
            DataTable table = new DataTable();

            PinacclePrices p = (PinacclePrices)prices[0];

            PropertyInfo[] mas = p.GetType().GetProperties();

            foreach (PropertyInfo property in mas)
            {
                if (property.Name.Contains("__") == true)
                {
                    table.Columns.Add(property.Name.Replace("__","-"));
                    continue;
                }
                table.Columns.Add(property.Name);
            }


            foreach (PinacclePrices price in prices)
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
