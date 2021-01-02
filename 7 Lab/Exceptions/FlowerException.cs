using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6.Exceptions
{
    class FlowerException : CustomException
    {
        public int ErrorPrice { get; set; }

        public FlowerException(string message, int errorPrice)
            : base(message, "Flower")
        {
            this.ErrorPrice = errorPrice;
        }
    }
}