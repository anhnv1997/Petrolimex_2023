using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IPGS.Ultility.TextFormats
{
    public static class TextFormatingTool
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
                return default(T);
            }

        }
        #endregion

        #region: Char Helper
        public static char NextCharacter(char input)
        {
            return (input == 'z' ? 'a' : (char)(input + 1));
        }
        public static string ConvertToACSIIString(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        #endregion

        #region: Render
        public static Size GetTextSize(string data, Font font)
        {
            return TextRenderer.MeasureText(data, font);
        }
        public static Size GetTextSize(string data, Font font, Size size)
        {
            return TextRenderer.MeasureText(data, font, size, TextFormatFlags.WordBreak);
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
    }
}
