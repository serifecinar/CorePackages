using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance.Paging;

public class Paginate<T>
{
    public Paginate()
    {
        Items = Array.Empty<T>();
    }

    //Kaç data var
    public int Size { get; set; }

    // hangi sayfadayız
    public int Index { get; set; }

    //toplam kayıt sayısı
    public int Count { get; set; }

    //toplam kaç sayfa var
    public int Pages { get; set; }

    //datamız ne
    public IList<T> Items { get; set; }

    // önceki sayfa var mı
    public bool HasPrevious => Index > 0;   

    //sonraki sayfa var mı
    public bool HasNext => Index+1 < Pages;
}

