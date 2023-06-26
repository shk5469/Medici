using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBookManager
    {
        const int MAX_CNT = 100;
        PhoneInfo[] infoStorage = new PhoneInfo[MAX_CNT];
        int curCnt = 0;

        public void ShowMenu()
        {
            Console.WriteLine("------------------------   전화번호부    --------------------");
            Console.WriteLine(" 1.입력  |  2.목록  |  3.검색  |  4.삭제  |  5.종료");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("선택 : ");
        }

        public void InputData() //입력
        {
            Console.WriteLine("1.일반   2.대학   3.회사");
            Console.Write("선택 >>> ");
            int choice = int.Parse(Console.ReadLine());

            PhoneInfo info = null;
            switch(choice)
            {
                case 1: info = CreatePhoneInfo(); break;
                case 2: info = CreatePhoneUnivInfo(); break;
                case 3: info = CreatePhoneCompanyInfo(); break;
            }

            if (info != null)
            {
                infoStorage[curCnt++] = info;
                Console.WriteLine("입력이 완료되었습니다.");
            }
            else
            {
                Console.WriteLine("입력중 오류가 발생했습니다. 다시 입력하여 주십시오.");
            }
        }

        //각 항목별로 입력을 받아서 PhoneInfo 객체를 생성해서 반환
        private PhoneInfo CreatePhoneInfo()
        {
            string[] comInfo = InputCommonItem();
            if (comInfo == null || comInfo.Length != 3)
            {
                return null;
            }

            return new PhoneInfo(comInfo[0], comInfo[1], comInfo[2]);
        }

        //각 항목별로 입력을 받아서 PhoneUnivInfo 객체를 생성해서 PhoneInfo로 자동변환하여 반환
        private PhoneInfo CreatePhoneUnivInfo()
        {
            string[] comInfo = InputCommonItem();
            if (comInfo == null || comInfo.Length != 3)
            {
                return null;
            }

            Console.Write("전공 :");
            string major = Console.ReadLine().Trim();

            Console.Write("학년 :");
            int year = int.Parse(Console.ReadLine().Trim());

            return new PhoneUnivInfo(comInfo[0], comInfo[1], comInfo[2], major, year);
        }

        //각 항목별로 입력을 받아서 PhoneCompanyInfo 객체를 생성해서 PhoneInfo로 자동변환하여 반환
        private PhoneInfo CreatePhoneCompanyInfo()
        {
            string[] comInfo = InputCommonItem();
            if (comInfo == null || comInfo.Length != 3)
            {
                return null;
            }

            Console.Write("회사 :");
            string company = Console.ReadLine().Trim();

            return new PhoneCompanyInfo(comInfo[0], comInfo[1], comInfo[2], company);
        }

        //공통항목(이름, 전화번호, 생일)을 입력받아서 문자열[]로 반환
        private string[] InputCommonItem()
        {
            #region 이름, 전화번호, 생일 입력
            Console.Write("이름 :");
            string name = Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("이름은 필수입력입니다.");
                return null;
            }
            int idx = SearchName(name);
            if (idx > -1) //같은 이름을 찾은경우
            {
                Console.WriteLine("이미 등록된 이름입니다. 다른 이름으로 입력하세요.");
                return null;
            }

            Console.Write("전화번호 :");
            string phone = Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(phone))
            {
                Console.WriteLine("전화번호는 필수입력입니다.");
                return null;
            }

            Console.Write("생일 :");
            string birth = Console.ReadLine().Trim();
            #endregion

            return new string[3] { name, phone, birth };
        }

        /// <summary>
        /// 저장된 전화번호부의 이름에서 검색어를 찾아서 해당 index를 반환
        /// </summary>
        /// <param name="name">검색어</param>
        /// <returns>배열의 번째(찾았을때는 해당 index, 못찾았을때는 -1)</returns>
        private int SearchName(string name)
        {
            for (int i = 0; i < curCnt; i++)
            {
                if (infoStorage[i].Name == name)
                {
                    return i;
                }
            }

            return -1;
        }

        public void ListData()  //목록
        {
            if (curCnt == 0)
            {
                Console.WriteLine("입력된 데이터가 없습니다.");
                return;
            }

            //for (int i = 0; i < infoStorage.Length; i++)
            //{
            //    if (infoStorage[i] != null)
            //        infoStorage[i].ShowPhoneInfo();
            //}

            for (int i = 0; i < curCnt; i++)
            {
                infoStorage[i].ShowPhoneInfo();
                Console.WriteLine();
            }
        }

        public void SearchData() //검색
        {
            Console.Write("이름 :");
            string searchName = Console.ReadLine().Trim();

            int idx = SearchName(searchName);

            if (idx < 0)
            {
                Console.WriteLine("검색된 데이터가 없습니다.");
            }
            else
            {
                infoStorage[idx].ShowPhoneInfo();
                Console.WriteLine();
            }
        }

        public void DeleteData() //삭제
        {
            Console.Write("이름 :");
            string deleteName = Console.ReadLine().Trim();

            int idx = SearchName(deleteName);

            if (idx < 0)
            {
                Console.WriteLine("삭제할 데이터가 없습니다.");
            }
            else
            {
                for (int i = idx; i < curCnt; i++)
                {
                    infoStorage[i] = infoStorage[i + 1];
                }
                curCnt--;
                Console.WriteLine("삭제가 완료되었습니다.");
            }
        }
    }
}
