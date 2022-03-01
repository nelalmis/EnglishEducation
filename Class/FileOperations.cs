using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace EnglishEducation.Class
{
   public class FileOperations
    {
       DatabaseOperations doc;
       public FileOperations() {
           doc = new DatabaseOperations();
       }
       
       public void ExcelRead(Enums.ExcelDataType dataType,string fileLocation)
       {
           DataSet ds = new DataSet();
           string fileExtension = System.IO.Path.GetExtension(fileLocation);
           string excelConnectionString = string.Empty;
           if (fileExtension == ".xls")
           {
               excelConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
               fileLocation + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
           }
           //connection String for xlsx file format.
           else if (fileExtension == ".xlsx")
           {
               excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
               fileLocation + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
           }
           //Create Connection to Excel work book and add oledb namespace
           OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);

           DataTable dt = new DataTable();
           excelConnection.Open();
           dt = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

           if (dt == null)
           {

           }
           excelConnection.Close();
           String[] excelSheets = new String[dt.Rows.Count];
           int t = 0;
           //excel data saves in temp file here.
           foreach (DataRow row in dt.Rows)
           {
               excelSheets[t] = row["TABLE_NAME"].ToString();
               t++;
           }

           OleDbConnection excelConnection1 = new OleDbConnection(excelConnectionString);


           string query = string.Format("Select * from [{0}]", excelSheets[0]);
           using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, excelConnection1))
           {
               dataAdapter.Fill(ds);
           }
           if (!ds.Tables[0].Columns.Contains("English") && !ds.Tables[0].Columns.Contains("Turkish"))
           {
               return;
           }
           for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
           {

               var English = ds.Tables[0].Rows[i]["English"].ToString();
               var Turkish = ds.Tables[0].Rows[i]["Turkish"].ToString();
               if (English != null && Turkish != null)
               {
                   if (dataType == Enums.ExcelDataType.Question)
                       doc.AddQuestion(English, Turkish);
                   else if (dataType == Enums.ExcelDataType.Vocabulary)
                       doc.AddVocabulary(English, Turkish);
                   //else
                   //QuestionAnswer
               }

           }
       }
    }
}
