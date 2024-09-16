using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance.Dynamic;

public class DynamicQuery
{
    public IEnumerable<Sort>? Sort { get; set; }
    public Filter? Filter { get; set; }
    public DynamicQuery()
    {
        
    }

    public DynamicQuery(IEnumerable<Sort>? sort, Filter? filter)
    {
        Filter= filter;
        Sort= sort;
    }
}

// klasik adonet tarafı -- select *from cars where unitPrice<100 and (transmition=1 or dfgdfgdfg)
// p=>p.unitPrice<=100 && ()