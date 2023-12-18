﻿using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text;

namespace PETROLIMEX.Helper
{
    public class TextFormatingTool
    {
        #region: Money Format
        public static string ConvertToMoneyFormat<T>(T money) where T : IComparable, IConvertible, IFormattable
        {
            CultureInfo culutreInfo = new CultureInfo("vi-VN");
            culutreInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            culutreInfo.DateTimeFormat.DateSeparator = "/";
            culutreInfo.NumberFormat.PercentDecimalSeparator = ".";
            return money.ToString("C0", culutreInfo);
        }

        public static string GetMoneyFormat(string str_money)
        {
            try
            {
                long money = Convert.ToInt64(str_money.Trim());
                CultureInfo culutreInfo = new CultureInfo("vi-VN");
                culutreInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
                culutreInfo.DateTimeFormat.DateSeparator = "/";
                culutreInfo.NumberFormat.PercentDecimalSeparator = ".";
                return money.ToString("C0", culutreInfo);
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static T MoneyToSpecific<T>(string money) where T : IComparable, IConvertible, IFormattable
        {
            try
            {
                while (money[0] == '0')
                {
                    money = money.Substring(1);
                }
                CultureInfo culutreInfo = new CultureInfo("vi-VN");
                culutreInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
                culutreInfo.DateTimeFormat.DateSeparator = "/";
                culutreInfo.NumberFormat.PercentDecimalSeparator = ".";
                return (T)Convert.ChangeType(decimal.Parse(money, NumberStyles.Currency, culutreInfo), typeof(T));
            }
            catch (Exception ex)
            {
                return default;
            }

        }
        #endregion

        #region: Char Helper
        public static char NextCharacter(char input)
        {
            return input == 'z' ? 'a' : (char)(input + 1);
        }
        public static string ConvertToACSIIString(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, string.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        #endregion

        #region: Render
        public static Size GetTextSize(string data, Font font)
        {
            return TextRenderer.MeasureText(data, font);
        }
        #endregion: End Render

        public static string StandardlizePlateNumber(string plateNunber)
        {
            plateNunber = plateNunber.Trim();
            plateNunber = plateNunber.ToUpper();
            plateNunber = plateNunber.Replace("-", string.Empty);
            plateNunber = plateNunber.Replace("_", string.Empty);
            plateNunber = plateNunber.Replace(".", string.Empty);
            return plateNunber;
        }

        #region: Internal
        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
        public static string BeautyJson(Object obj)
        {

            var options = new JsonSerializerOptions(_options)
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            var jsonString = System.Text.Json.JsonSerializer.Serialize(obj, options).Replace("\r\n", "\r").Replace("\n", "\r").Replace("\r", "<br>\r\n").Replace("  ", " &nbsp;");
            return jsonString;
        }
        #endregion: End Internal
    }
}
