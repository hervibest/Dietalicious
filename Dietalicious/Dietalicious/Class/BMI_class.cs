using System.Collections.Generic;
using System;

namespace Dietalicious
{
    public class BMI_class //Class yang berisikan perhitungan BMI
    {
        private float weight;
        private float height;
        private float Total_BMI;

        public BMI_class(float BB, float TB)
        {
            weight = BB;
            height = TB;
        }

        public float calcBMI(float weight, float height)
        {

            Total_BMI = (weight * 703) / (height * height);
            return Total_BMI;
        }
    }
}