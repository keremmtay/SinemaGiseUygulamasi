using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MovieManager
    {
        GenericRepository<Movie> _repository = new GenericRepository<Movie>();

        public List<Movie> GetAllBL()
        {
            return _repository.List();
        }

        public string MovieAddBL(Movie movie)
        {
            string mesaj = "Başarıyla kaydedildi.";

            if (movie != null)
            {
                if (movie.Adi != null && movie.Sure != 0 && movie.Aciklama.Length < 200)
                {
                    _repository.Insert(movie);
                }
                else
                {
                    mesaj = "Film Adı ve Süresi boş bırakılamaz. Açıklama 200 karakterden uzun olamaz.";
                }
            }

            return mesaj;
        }

        public string MovieUpdateBL(Movie movie)
        {
            string mesaj = "Başarıyla güncellendi.";

            if (movie != null)
            {
                if (movie.Id != 0 && movie.Adi != "" && movie.Sure != 0 && movie.Aciklama.Length < 200)
                {
                    _repository.Update(movie, movie.Id);
                }
                else
                {
                    mesaj = "Film Id, Adı ve Süresi boş bırakılamaz. Açıklama 200 karakterden uzun olamaz.";
                }
            }

            return mesaj;
        }

        public void MovieDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }
        }
    }
}
