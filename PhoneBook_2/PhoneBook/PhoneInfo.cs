using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneInfo : IComparable
    {
        string name;
        string phoneNumber;
        string birth;

        public string Name //읽기전용 속성
        {
            get { return name; }
        }
        public string PhoneNumber //읽기전용 속성
        {
            get { return phoneNumber; }
        }

        public PhoneInfo(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public PhoneInfo(string name, string phoneNumber, string birth)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.birth = birth;
        }

        public virtual void ShowPhoneInfo()
        {
            Console.Write($"name:{this.name}");
            Console.Write($"\t phone:{this.phoneNumber}");
            Console.Write($"\t birth:{this.birth}");
        }
        public int CompareTo(object obj)  //IComparable
        {
            //나의 사번과 다른 사번을 비교해서 -1, 0, 1 을 반환
            if (obj is PhoneInfo other)
            {
                return this.name.CompareTo(other.name);
            }
            else
                return 0;

        }
    }

    class PhoneUnivInfo : PhoneInfo
    {
        string major;
        int year;
        public PhoneUnivInfo(string name, string phone, string birth,
                                string major, int year) : base(name, phone, birth)
        {
            this.major = major;
            this.year = year;
        }

        public override void ShowPhoneInfo()
        {
            base.ShowPhoneInfo();
            Console.Write($"\t major:{this.major}");
            Console.Write($"\t year:{this.year}");
        }
    }

    class PhoneCompanyInfo : PhoneInfo
    {
        string company;
        public PhoneCompanyInfo(string name, string phone, string birth,
                                    string company) : base(name, phone, birth)
        {
            this.company = company;
        }

        public override void ShowPhoneInfo()
        {
            base.ShowPhoneInfo();
            Console.Write($"\t company:{this.company}");
        }
    }
}
