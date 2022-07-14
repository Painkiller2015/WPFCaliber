using Caliber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCaliber.Value;
using System.Reflection;

namespace WPFCaliber.Model
{
    public class TehnologiesPriority : Priority
    {
        static readonly PriceQuartesTehologies _QuartersPrise = StaticObject.GetQuartersPrise();
        static readonly Caliber.Json.Accaunt.LogObject.Technologies _Quarters = LogObject.GetQuarters();
        static readonly int _QuartestMaxLvl = 9;

        public static void SetPriority()
        {
            _limitResourseValue = GetPrice();

            SetDesiredNumber();
            OrderPriority();
            UpdateData();
        }
        public static ResourseValue GetPrice()
        {
            FieldInfo[]? quartersLines = typeof(PriceQuartesTehologies).GetFields();
            ResourseValue result = new ResourseValue();

            foreach (var quartersLine in quartersLines)
            {
                //TODO дебажить
                for (int i = (int)quartersLine.GetValue(_Quarters); i < _QuartestMaxLvl; i++)
                {
                    result = ResourseValue.Sum(result, _QuartersPrise.Protective[i]);
                }
            }
            return result;
        }
    }
}