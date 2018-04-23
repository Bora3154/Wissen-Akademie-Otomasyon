using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersaneOtomasyonu.BLL
{
    interface IRepository<T>
    {
        void Ekle(T entity);
        void Guncelle(T entity);
        void Sil(T entity);
        List<T> Listele();
        List<T> OzelListele();
        T Bul(int Id);
    }

}
