using System;
using System.Collections.Generic;
using System.Text;

namespace LearningVersoinControle
{
    internal class TransferData
    {
        private readonly string data;
        private string personId;
        private string account;
        private decimal amount;

        public TransferData(string data)
        {
            this.data = data;
        }

        public string Data { get; }
        public string PersonId { get; set; }
        public string Account { get; set; }

        public string GetPersonID()
        {
            return personId;
        }

        public static void NoImplementoin()
        {

        }

        private bool isEmpty(decimal amoung)
        {
            if (amoung == 0 || amount < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
