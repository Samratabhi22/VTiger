using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTiger.Generic
{
    public class Datavalidation
    {
        public static void createdprojectvalidate(string name)
        {
            bool flag = false;
            string connections = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost:3306;Database=projects;User=root;Password=root;";
            OdbcConnection odbcConnection = new OdbcConnection(connections);
            odbcConnection.Open();
            string query = "select project_name from project;";
            OdbcCommand odbcCommand = new OdbcCommand(query, odbcConnection);
            OdbcDataReader response = odbcCommand.ExecuteReader();
            
            while (response.Read())
            {
                if (response[0].Equals(name))
                {
                    BaseClass.extentTest1.Pass("Project is Created by the name of" + response[0]);
                    flag = true;
                    break;
                }
            }
            if(!flag)
            {
                BaseClass.extentTest1.Fail("Project is NOT created by the name of" + response[0]);
            }
        }
    }   
}
