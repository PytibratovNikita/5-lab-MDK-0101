using PhoneRepositoryMDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PhoneRepositoryMDK
{
    public class PhoneRepository
    {
        private List<Phone> phones = new List<Phone>();

        public List<Phone> GetAll()
        {
            return phones;
        }

        public Phone GetById(int id)
        {
            return phones.FirstOrDefault(c => c.Id == id);
        }

        public void Insert(Phone phone)
        {
            phones.Add(phone);
        }

        public void Delete(int id)
        {
            Phone phone = GetById(id);
            if (phone != null)
            {
                phones.Remove(phone);
            }
        }

        public void Update(int id, Phone phone)
        {
            Phone existingPhone = GetById(id);
            if (existingPhone != null)
            {
                existingPhone.Модель = phone.Модель;
                existingPhone.Год = phone.Год;
                existingPhone.Цвет = phone.Цвет;
            }
        }

        public List<Phone> Find(Predicate<Phone> predicate)
        {
            return phones.FindAll(predicate);
        }
    }
}