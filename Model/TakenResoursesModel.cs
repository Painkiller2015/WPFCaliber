using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliber
{
    public static class TakenResoursesModel
    {
        public static event EventHandler<string[]> TakenResoursesChanged;
        public static void TakenResourses()
        {
            TakenResoursesChanged?.Invoke(null, new string[] {"",""} );
        }
    }
}