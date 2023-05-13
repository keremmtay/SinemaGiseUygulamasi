using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenreManager
    {
        GenericRepository<Genre> _repository = new GenericRepository<Genre>();

        public List<Genre> GetAllBL()
        {
            return _repository.List();
        }

        public string GenreAddBL(Genre genre)
        {
            string mesaj = "Başarıyla kaydedildi.";

            if (genre != null)
            {
                if (genre.Adi != null && genre.YasSiniri != 0)
                {
                    _repository.Insert(genre);
                }
                else
                {
                    mesaj = "Tür Adı ve Yaş Sınırı alanları boş bırakılamaz.";
                }
            }

            return mesaj;
        }

        public string GenreUpdateBL(Genre genre)
        {
            string mesaj = "Başarıyla güncellendi.";

            if (genre != null)
            {
                if (genre.Id != 0 && genre.Adi != null && genre.YasSiniri != 0)
                {
                    _repository.Update(genre, genre.Id);
                }
                else
                {
                    mesaj = "Tür Id, Adı ve Yaş Sınırı alanları boş bırakılamaz.";
                }
            }

            return mesaj;
        }

        public void GenreDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }
        }
    }
}
