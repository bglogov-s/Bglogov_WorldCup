using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace DataLibrary.Config
{
    public static class Endpoints
    {
        public static readonly RestClient _restClient = new RestClient("https://worldcup-vua.nullbit.hr");

    }
}
