using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance.Dynamic;

public class DinamicQuery
{
    public IEnumerable<Sort>? Sort { get; set; }
    public Filter? Filter { get; set; }
    public DinamicQuery()
    {
        
    }

    public DinamicQuery(IEnumerable<Sort>? sort, Filter? filter)
    {
        Filter= filter;
        Sort= sort;
    }
}
