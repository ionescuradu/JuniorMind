using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTests
{
    class RowsAndColoms
    {
        private static int rows = 0;
        private static int coloms = 0;

        public RowsAndColoms(int addRow, int addColom)
        {
            rows = rows + addRow;
            coloms = coloms + addColom;
        }
    }
}
