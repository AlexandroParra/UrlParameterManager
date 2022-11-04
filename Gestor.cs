using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlManager
{
    public class Gestor
    {
        private const string ParamBeginningMark_default = "{{";
        private const string ParamEndingMark_default = "}}";

        #region Required Param Definitions

        public enum RequiredParam
        {
            PartnerId, Api_Version
        }
        private string[] _RequiredParamTitles =
        { "PartnerId", "Api-Version"};

        private const string RequiredParamBeginningMark = ParamBeginningMark_default;
        private const string RequiredParamEndingMark = ParamEndingMark_default;

        #endregion


        #region Optional Param Definitions

        public enum OptinalParam
        {
            ProviderId, ProductBaseId, ProductId
        }
        private string[] _OptinalParamTitles =
        { "ProviderId", "ProductBaseId", "ProductId"};

        private const string OptionalParamBeginningMark = ParamBeginningMark_default;
        private const string OptionalParamEndingMark = ParamEndingMark_default;

        #endregion

        public Dictionary<string, string> RequiredParams;
        public Dictionary<string, string> OptionalParams;

        public Gestor()
        {
            RequiredParams = new Dictionary<string, string>();
            OptionalParams = new Dictionary<string, string>();
        }

        public void AddRequiredParam(RequiredParam requiredParam, string value)
        {
            RequiredParams.Add(_RequiredParamTitles[(int)requiredParam], value);
        }

        public void AddOptionalParam(OptinalParam optinalParam, string value)
        {
            OptionalParams.Add(value, _OptinalParamTitles[(int)optinalParam]);
        }

        public void Clear()
        {
            RequiredParams.Clear();
            OptionalParams.Clear();
        }

        public delegate string Tfunc(string Url, Dictionary<string, string> RequiredParams, Dictionary<string, string> OptionalParams);

        public string ReplaceParameters(string Url) { return ReplaceParameters(Url, ReplaceParams); }

        public string ReplaceParameters(string Url, Tfunc function) { return function(Url,RequiredParams,OptionalParams); }

        private string ReplaceParams(string Url, Dictionary<string,string> RequiredParams, Dictionary<string, string> OptionalParams)
        {
            string CustomizedUrl = Url;

            if (!string.IsNullOrEmpty(CustomizedUrl))
            {
                CustomizedUrl = "Aquí hay que hacer las modificacinoes que tocan.";
            }

            return CustomizedUrl;
        }

    }
}
