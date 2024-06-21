using DataLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class SchoolBussiness
    {

        public static void businessClass(SchoolClass Class)
        {
            SchoolDB.AddEqDB(Class);
        }


        public static DataTable businesstable()
        {
            return SchoolDB.SelectAll();
        }
        public static void deleteBusiness(SchoolClass lb)
        {
            SchoolDB.deleteEq(lb);
        }
        public static void UpdateBusiness(SchoolClass lb)
        {
            SchoolDB.UpdateEq(lb);
        }


    }
}
