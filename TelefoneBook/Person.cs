using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefoneBook
{
   public class Person
    {
        public string Name { get; set; }//так выглядит get/set, когда не нужны проверки
        public int Age { get; private set; }//возраст доступен для чтения, но не доступен для изменения
        private DateTime bday;
        string telephone;
        public string Photo { get; set; }

        public string Telephone
        {
            get { return telephone; }
            set
            {
                bool isCorrect = true;
                for(int i=0;i<value.Length;i++)
                {
                    if (value[i] < '0' || value[i] > '9')
                    {
                        isCorrect = false;
                        break;
                    }
                }
                if (isCorrect)
                    telephone = value;
                else
                    telephone = "Номер не опеределен";
            }
        }
        public DateTime Bday
        {
            get { return bday; }
            set
            {
                bday = value;
                //если меняем др, то меняется возраст
                Age = DateTime.Now.Year - bday.Year;
            }
        }
    }
}
