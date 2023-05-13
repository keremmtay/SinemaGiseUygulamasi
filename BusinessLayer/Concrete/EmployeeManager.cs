using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EmployeeManager
    {
        GenericRepository<Employee> _repository = new GenericRepository<Employee>();

        public List<Employee> GetAllBL()
        {
            return _repository.List();
        }

        public string EmployeeAddBL(Employee employee)
        {
            string mesaj = "Başarıyla kaydedildi.";

            if (employee != null)
            {
                if (employee.Adi != null && employee.Soyadi != null && employee.KullaniciAdi != null && employee.KullaniciAdi.Length < 20 && employee.Sifre != null && employee.Sifre.Length < 20)
                {
                    _repository.Insert(employee);
                }
                else
                {
                    mesaj = "Personel Adı, Soyadı, Kullanıcı Adı ve Şifre alanları boş bırakılamaz. Kullanıcı Adı ve Şifre 20 karakterden uzun olamaz.";
                }
            }

            return mesaj;
        }

        public string EmployeeUpdateBL(Employee employee)
        {
            string mesaj = "Başarıyla güncellendi.";

            if (employee != null)
            {
                if (employee.Id != 0 && employee.Adi != null && employee.Soyadi != null && employee.KullaniciAdi != null && employee.KullaniciAdi.Length < 20 && employee.Sifre != null && employee.Sifre.Length < 20)
                {
                    _repository.Update(employee, employee.Id);
                }
                else
                {
                    mesaj = "Personel Id, Adı, Soyadı, Kullanıcı Adı ve Şifre alanları boş bırakılamaz. Kullanıcı Adı ve Şifre 20 karakterden uzun olamaz.";
                }
            }

            return mesaj;
        }

        public void EmployeeDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }
        }

        public bool IsUserExists(string userName)
        {
            bool result = false;

            Employee employee = _repository.Get(x => x.KullaniciAdi == userName && x.AktifMi == true);

            if (employee != null)
            {
                result = true;
            }

            return result;
        }

        public bool CheckUserNameAndPassword(string username, string password)
        {
            bool result = false;

            var employee = _repository.Get(x => x.KullaniciAdi == username && x.Sifre == password && x.AktifMi == true);

            if (employee != null)
            {
                result = true;
            }

            return result;
        }
    }
}
