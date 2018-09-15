using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySupply
{
    public partial class CurrentPriceFormat
    {
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Format { get; set; }
        public string Description { get; set; }

        public static CurrentPriceFormat GetCurrency(string code)
        {
            try
            {
                if (!string.IsNullOrEmpty(code))
                    return GetCurrencyFormats().Where(x => x.Code.Equals(code)).Take(1).ElementAt(0);
                else
                    return new CurrentPriceFormat { Code = "NAN", Format = "NAN" };
            }
            catch (Exception ex)
            {
                Commons.Status(Commons.GetErrorCode("CPF", 1) + ex.Message);
                return new CurrentPriceFormat { Code = "NAN", Format = "NAN" };
            }
        }
        public static List<CurrentPriceFormat> GetCurrencyFormats()
        {
            List<CurrentPriceFormat> rv = new List<CurrentPriceFormat>();
            rv.Add(new CurrentPriceFormat { Code = "TRY", Format = "###,###,##0.00 ₺", Symbol = "₺", Description = "TURKISH LIRA" });
            rv.Add(new CurrentPriceFormat { Code = "USD", Format = "$ ###,###,##0.00", Symbol = "$", Description = "U.S. DOLLAR" });
            rv.Add(new CurrentPriceFormat { Code = "AUD", Format = "$ ###,###,##0.00", Symbol = "$", Description = "AUSTRALIAN DOLLAR" });
            rv.Add(new CurrentPriceFormat { Code = "DKK", Format = "###,###,##0.00 DKK", Symbol = "Dk", Description = "Danish Krone" });
            rv.Add(new CurrentPriceFormat { Code = "EUR", Format = "€ ###,###,##0.00", Symbol = "€", Description = "EURO" });
            rv.Add(new CurrentPriceFormat { Code = "GBP", Format = "£ ###,###,##0.00", Symbol = "£", Description = "British Pound" });
            rv.Add(new CurrentPriceFormat { Code = "CHF", Format = "###,###,##0.00 CHF", Symbol = "Fr", Description = "Swiss Franc" });
            rv.Add(new CurrentPriceFormat { Code = "SEK", Format = "###,###,##0.00 SEK", Symbol = "Sk", Description = "Swedish Krona" });
            rv.Add(new CurrentPriceFormat { Code = "CAD", Format = "$ ###,###,##0.00", Symbol = "$", Description = "CANADIAN DOLLARS" });
            rv.Add(new CurrentPriceFormat { Code = "KWD", Format = "###,###,##0.00 KWD", Symbol = "Kd", Description = "Kuwaiti Dinar" });
            rv.Add(new CurrentPriceFormat { Code = "NOK", Format = "###,###,##0.00 NOK", Symbol = "Nk", Description = "Norwegian Krone" });
            rv.Add(new CurrentPriceFormat { Code = "SAR", Format = "###,###,##0.00 SAR", Symbol = "Sr", Description = "Saudi Arabian Riyal" });
            rv.Add(new CurrentPriceFormat { Code = "JPY", Format = "###,###,##0.00 JPY", Symbol = "Jy", Description = "JAPANESE YEN" });
            rv.Add(new CurrentPriceFormat { Code = "BGN", Format = "###,###,##0.00 BGN", Symbol = "BL", Description = "Bulgarian Lev" });
            rv.Add(new CurrentPriceFormat { Code = "RON", Format = "###,###,##0.00 RON", Symbol = "Rn", Description = "Romanian leu" });
            rv.Add(new CurrentPriceFormat { Code = "RUB", Format = "###,###,##0.00 RUB", Symbol = "Rb", Description = "Russian Ruble" });
            rv.Add(new CurrentPriceFormat { Code = "IRR", Format = "###,###,##0.00 IRR", Symbol = "Ir", Description = "Iranian Rial" });
            rv.Add(new CurrentPriceFormat { Code = "CNY", Format = "###,###,##0.00 CNY", Symbol = "Cy", Description = "Chinese Yuan" });
            rv.Add(new CurrentPriceFormat { Code = "PKR", Format = "###,###,##0.00 PKR", Symbol = "Pr", Description = "Pakistan Rupee" });
            return rv;
        }
    }
}
