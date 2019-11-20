using System;
using System.Collections.Generic;
using System.Text;

namespace Aircoin
{
    public class Aircoin
    {
        const int MAX_VALUE = 200000000; 
        public int amount { get; }
        public Aircoin(int amount)
        {   
            if (amount > MAX_VALUE)
            {
                throw new NotValidAmountException("Can not create an aircoin with value larger than 0.2 billion");
            }
            if (amount < 0)
            {
                throw new NotValidAmountException("Can not create an aircoin with negative value ");
            }
            this.amount = amount; 
        }
        public bool hasSameAmountWith(Aircoin aircoin)
        {
            return this.amount == aircoin.amount;
        }
    }
}
