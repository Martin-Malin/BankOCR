using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOCR
{
    public class Checksum
    {
        public string InputNumber { get; }

        public bool IsValid
        {
            get
            {
                return Mod11 == 0;
            }
        }

        private int? _Mod11;
        private int Mod11
        {
            get
            {
                if (_Mod11 == null)
                    computeMod11();

                return _Mod11.Value;
            }
            set { _Mod11 = value; }
        }

        public Checksum(string number)
        {
            InputNumber = number;
        }

        private void computeMod11()
        {
            int[] intArray = convertInputToIntArray();

            int sum = 0;
            int multiplier = 9;
            for (int i = 0; i < 9; i++)
            {
                sum += intArray[i] * multiplier;
                multiplier--;
            }

            this.Mod11 = sum % 11;
        }

        private int[] convertInputToIntArray()
        {
            int[] result = new int[9];
            for (int i = 0; i < 9; i++)
            {
                result[i] = int.Parse(InputNumber[i].ToString());
            }

            return result;
        }
    }
}
