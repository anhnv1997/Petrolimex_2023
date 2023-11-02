using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralTool
{
    public static class EventHelpers
    {
        public static Dictionary<string, string> GetEventContent(string[] datas)
        {
            Dictionary<string, string> output = new Dictionary<string, string>();
            foreach (string data in datas)
            {
                if (data.Contains("="))
                {
                    string[] subData = data.Split('=');
                    output.Add(subData[0].ToLower().Trim(), subData[1].Trim());
                }
            }
            return output;
        }
    }
}
