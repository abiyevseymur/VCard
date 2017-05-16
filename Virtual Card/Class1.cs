using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Card
{
    class RealCard
    {
        private string cardNumber;
        private string cardName;
        private DateTime cardDate;
        private short cardCvv;
        private int mebleg;

        public string CardNumber
        {
            get
            {
                return this.cardNumber;
            }
            set
            {
                this.cardNumber = value;
            }
        }
        public string CardName
        {
            get
            {
                return this.cardName;
            }
            set
            {
                this.cardName = value;
            }
        }
        public DateTime CardDate
        {
            get
            {
                return this.cardDate;
            }
            set
            {
                this.cardDate = value;
            }
        }
        public short CardCvv
        {
            get
            {
                return this.cardCvv;
            }
            set
            {
                this.cardCvv = value;
            }
        }
        public int Mebleg
        {
            get
            {
                return this.mebleg;
            }
            set
            {
                this.mebleg = value;
            }
        }
    }
}
