using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PcbScoring.Entities
{
    public class API_PARAM
    {
        public int ID { get; set; }
        public string PARAMNAME { get; set; }
        public string CALCULATOR { get; set; }
        public string DATATYPE { get; set; }
    }

    public static class ParamDataTypes
    {
        public static string DATETIME = "DATETIME";
        public static string STRING = "STRING";
        public static string INT = "INT";
        public static string LONG = "LONG";
        public static string FLOAT = "FLOAT";
        public static string DECIMAL = "DECIMAL";
    }
}