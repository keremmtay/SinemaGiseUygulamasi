using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TheaterManager
    {
        GenericRepository<Theater> _repository = new GenericRepository<Theater>();

        public List<Theater> GetAllBL()
        {
            return _repository.List();
        }

        public string TheaterAddBL(Theater theater)
        {
            string mesaj = "Başarıyla kaydedildi.";

            if (theater != null)
            {
                if (theater.Numarasi != null )
                {
                    _repository.Insert(theater);
                }
                else
                {
                    mesaj = "Salon Numarası boş bırakılamaz.";
                }
            }

            return mesaj;
        }

        public string TheaterUpdateBL(Theater theater)
        {
            string mesaj = "Başarıyla güncellendi.";

            if (theater != null)
            {
                if (theater.Id != 0 && theater.Numarasi != null)
                {
                    _repository.Update(theater, theater.Id);
                }
                else
                {
                    mesaj = "Fim Id, Adı ve Süresi boş bırakılamaz.";
                }
            }

            return mesaj;
        }

        public void TheaterDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }
        }
    }
}
