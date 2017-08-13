using SeleniumPOM.Entities;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SeleniumPOM
{
    class CommonFunctions
    {
        /// <summary>
        /// Convert the Datatable into the List of EAEntity type
        /// </summary>
        /// <param name="dataTable">DataTable to be converted to List</param>
        /// <returns></returns>
        public static List<EntityEA> DataTabletoList(DataTable dataTable)
        {
            List<EntityEA> lstEA = dataTable.AsEnumerable().Select(x => new EntityEA()
            {
                UserName = x["UserName"].ToString(),
                Password = x["Password"].ToString(),
               // TitleId = x["TitleId "].ToString(),
                Initial = x["Initial"].ToString(),
                FirstName = x["FirstName"].ToString(),
                MiddleName = x["MiddleName"].ToString()
            }).ToList();

            return lstEA;
        }                      
    }
}
