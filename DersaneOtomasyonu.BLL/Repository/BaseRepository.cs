using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DersaneOtomasyonu.DAL.DataModel;
using System.Data.Entity;

namespace DersaneOtomasyonu.BLL.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
    {
        DersaneOtomasyonuEntities1 ent = new DersaneOtomasyonuEntities1();
        private readonly DersaneOtomasyonuEntities1 db = new DersaneOtomasyonuEntities1();
        public DbSet<T> Set()
        {
            return db.Set<T>();
        }
        private void SetState(T entity, EntityState state)
        {
            var entry = db.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                Set().Attach(entity);//Attach kullan demek insert delete update gibi
            }
            entry.State = state;
            db.SaveChanges();
        }
        public T Bul(int Id)
        {
            return Set().Find(Id);
        }
        public void Guncelle(T entity)
        {
            SetState(entity, EntityState.Modified);

        }

        public void Ekle(T entity)
        {
            //db.Add(entity);
            //DbContext.T.Add(entity)
            //db.Set<T>().Add(entity);
            SetState(entity, EntityState.Added);//Bunun anlamı yukarıdakiler gibidir.
        }

        public List<T> Listele()
        {
            return Set().ToList();
        }

        public List<T> OzelListele()
        {
            return Set().AsQueryable().ToList(); // istediğimiz kolonları getirmek için
        }

        public void Sil(T entity)
        {
            //db.Remove(entity);
            //DbContext.T.Remove(entity);
            //db.Set<T>().Remove(entity);
            SetState(entity, EntityState.Deleted); // Bunun anlamı yukakrıdaki gibidir.
        }

    }
}
