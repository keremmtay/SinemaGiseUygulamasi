using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BookingManager
    {
        GenericRepository<Booking> _repository = new GenericRepository<Booking>();

        public List<Booking> GetAllBL()
        {
            return _repository.List();
        }

        public string BookingAddBL(Booking booking)
        {
            string mesaj = "Başarıyla kaydedildi.";

            if (booking != null)
            {
                _repository.Insert(booking);
            }
            else
            {
                mesaj = "Kayıt sırasında hata oluştu.";
            }

            return mesaj;
        }

        public string BookingUpdateBL(Booking booking) 
        {
            string mesaj = "Başarıyla güncellendi.";

            if (booking != null)
            {
                _repository.Update(booking, booking.Id);
            }
            else
            {
                mesaj = "Güncelleme sırasında hata oluştu.";
            }

            return mesaj;
        }

        public void BookingDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }
        }
    }
}
