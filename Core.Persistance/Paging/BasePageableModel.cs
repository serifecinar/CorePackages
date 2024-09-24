using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance.Paging;

public abstract class BasePageableModel
{
    //Kaç data var
    public int Size { get; set; }

    // hangi sayfadayız
    public int Index { get; set; }

    //toplam kayıt sayısı
    public int Count { get; set; }

    //toplam kaç sayfa var
    public int Pages { get; set; }

    // önceki sayfa var mı
    public bool HasPrevious { get; set; }

    //sonraki sayfa var mı
    public bool HasNext { get; set; }
}
