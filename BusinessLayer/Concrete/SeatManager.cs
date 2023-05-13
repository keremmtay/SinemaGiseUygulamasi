using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SeatManager
    {
        GenericRepository<Seat> _repository = new GenericRepository<Seat>();

        public List<Seat> GetAllBL()
        {
            return _repository.List();
        }

        public string SeatAddBL(Seat seat)
        {
            string mesaj = "Başarıyla kaydedildi.";

            if (seat != null)
            {
                if (seat.Sıra != 0 && seat.No != 0 && seat.Fiyat != 0)
                {
                    _repository.Insert(seat);
                }
                else
                {
                    mesaj = "Koltuk Sıra, Numara ve Fiyat alanları boş bırakılamaz.";
                }
            }

            return mesaj;
        }

        public string SeatUpdateBL(Seat seat)
        {
            string mesaj = "Başarıyla güncellendi.";

            if (seat != null)
            {
                if (seat.Id != 0 && seat.Sıra != 0 && seat.No != 0 && seat.Fiyat != 0)
                {
                    _repository.Update(seat, seat.Id);
                }
                else
                {
                    mesaj = "Koltuk Id, Sıra, Numara ve Fiyat alanları boş bırakılamaz.";
                }
            }

            return mesaj;
        }

        public void SeatDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }
        }
    }
}
