using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Info_Net.Models;

namespace Info_Net.Clases
{
    public class DBHelper
    {
    public static Response SaveChanges(InfoNetContex db)
    {
            try
            {
                db.SaveChanges();
                return new Response { Succeded = true };
            }
            catch (Exception ex)
            {
                var response = new Response { Succeded = false, };
                if (ex.InnerException !=null &&
                ex.InnerException.InnerException != null &&
                ex.InnerException.InnerException.Message.Contains("_Index"))
                {
                    response.Message = "Ya se encuentra un registro en el sistema";

                }
                else
                {
                    response.Message = ex.Message;
                }
                return response;
            }
    }
    }
}