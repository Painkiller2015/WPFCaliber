using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliber
{
    //////////////// ИДЕЯ ДЛЯ РЕФАКТОРИНГА: переделать на словарь ////////////////
    /*    public static class NamesResourses
        {
            static readonly Dictionary<string, string> NameResourse = new()
            {
                {"alloy", "alloy" },
                {"сплавы", "alloy" }    
                //и т.д.
            };
            public static void GetEngResourseName(ref string resourseName)
            {
                NameResourse.TryGetValue(resourseName, out resourseName);
            }
        }*/

    public enum ResoursesCollectionEng
    {
        alloy,
        component,
        fuel,
        medicine,
        chemistry,
        composite,
        encryption,
        blueprint,
        microchip,
        secretdev
    }
    public enum ResoursesCollectionRus
    {
        сплавы,
        детали,
        топливо,
        медикаменты,
        химические,
        композитные,
        шифровки,
        чертежи,
        чипы,
        секретные
    }
}
