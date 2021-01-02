using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6.Exceptions
{
    class PlantException : CustomException
    {
        public int ErrorPour { get; set; }

        public PlantException(string message, int errorpour)
            : base(message, "Plant")
        {
            this.ErrorPour = errorpour;
        }
    }
}