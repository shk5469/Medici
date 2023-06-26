using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class BankAccount : Object
    {
        public string AccNum { get; set; } //계좌번호
        public string Name { get; set; } //예금주명
        public int Balance { get; set; } //잔액

        public BankAccount() 
        {
            this.Balance = 1;
        }

        public BankAccount(string accNum, string name) : this (accNum, name, 1)
        {
        }

        public BankAccount(string accNum, string name, int balance)
        {
            this.AccNum = accNum;
            this.Name = name;
            this.Balance = balance;
        }

        public void InputMoney(int amount) //입금하다
        {
            this.Balance = this.Balance + amount;
        }

        /// <summary>
        /// 출금
        /// </summary>
        /// <param name="amount">출금액</param>
        /// <returns>출금처리 결과 에러메세지 (성공:빈문자열, 실패:에러메세지)</returns>
        public ResultMessage OutputMoney(int amount) //출금하다
        {
            ResultMessage msg = new ResultMessage();

            if (this.Balance >= amount)
            {
                this.Balance = this.Balance - amount;
                msg.ErrCode = "0";
                msg.ErrMsg = "정상";
            }
            else
            {
                msg.ErrCode = "E0001";
                msg.ErrMsg = "잔액이 부족합니다.";
            }

            return msg;
        }

        public string PrintAccInfo() //통장정리하다
        {
            return $"계좌번호:{this.AccNum} / 예금주명:{Name} / 잔액:{Balance}";
        }
    }

    class ResultMessage
    {
        public string ErrCode { get; set; }
        public string ErrMsg { get; set; }
    }
}
