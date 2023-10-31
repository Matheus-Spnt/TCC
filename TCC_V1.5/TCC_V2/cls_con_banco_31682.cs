using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace cls_con_banco_31682
{
    public class cls_con_banco_31682
    {
        #region Local
        public static string Local()
        {
            string connectionString = "SERVER=127.0.0.1;UID=root;PASSWORD=30042002Mc_@;DATABASE=TCC";
            return connectionString;
        }
        #endregion

        //#region Local
        //public static string Local()
        //{
        //    return "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=TCC";
        //    //return "SERVER=localhost;UID=root;PASSWORD=2812;DATABASE=series";
        //}

        ////Usar para internet
        ////public static string Servidor()
        ////{
        ////    return "SERVER=200.65.1.122;UID=proffreddy;PASSWORD=123;DATABASE=prjBlobImage";
        ////}
        //#endregion 
    }
}
