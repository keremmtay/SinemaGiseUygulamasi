using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager
    {
        GenericRepository<Customer> _repository = new GenericRepository<Customer> ();

        public List<Customer> GetAllBL()
        {
            return _repository.List();
        }

        public List<Customer> GetMemberCustomers()
        {
            return _repository.List(x => x.UyeMi == true);
        }

        public List<Customer> GetNonMemberCustomers()
        {
            return _repository.List(x => x.UyeMi == false);
        }

        public string CustomerAddBL(Customer customer)
        {
            string mesaj = "Başarıyla kaydedildi.";

            if (customer != null)
            {
                if (customer.Adi != null && customer.Adi.Length < 20 && customer.Soyadi != null && customer.Soyadi.Length < 20 && customer.Telefon != null && customer.Telefon.Length <= 15)
                {
                    _repository.Insert(customer);
                }
                else
                {
                    mesaj = "Müşteri Adı ve Soyadı boş bırakılamaz ve 20'den fazla karakter yazılamaz. Telefon alanı boş bırakılamaz ve 15'den fazla karakter yazılamaz.";
                }
            }

            return mesaj;
        }

        public string CustomerUpdateBL(Customer customer)
        {
            string mesaj = "Başarıyla güncellendi.";

            if (customer != null)
            {
                if (customer.Id != 0 && customer.Adi != null && customer.Adi.Length < 20 && customer.Soyadi != null && customer.Soyadi.Length < 20 && customer.Telefon != null && customer.Telefon.Length <= 15)
                {
                    _repository.Update(customer, customer.Id);
                }
                else
                {
                    mesaj = "Müşteri Id, Adı ve Soyadı boş bırakılamaz ve 20'den fazla karakter yazılamaz. Telefon alanı boş bırakılamaz ve 15'den fazla karakter yazılamaz.";
                }
            }

            return mesaj;
        }

        public void CustomerDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }
        }
    }
}
