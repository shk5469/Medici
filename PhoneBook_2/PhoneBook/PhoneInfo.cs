using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneInfo
    {
        string name;
        string phoneNumber;
        string birth;

        public string Name //읽기전용 속성
        {
            get { return name; }
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
