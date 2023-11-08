using System;
namespace SerensiaTest
{
	public class IAmTheTest : IIAmTheTest
	{
		public bool CheckSirenValidity(string siren)
        {
            if (siren.Length != 9) return false;

            int somme = 0;
            int[] sirenEntiers = ConvertToDigit(siren);
            for (int i = 0; i < sirenEntiers.Length; i++)
            {
                int temp = sirenEntiers[i];
                if (i % 2 != 0)
                {
                    temp = temp * 2;
                    if(temp > 9)
                    {
                        temp = temp - 9;
                    }
                }
                somme += temp;
            }

            return somme % 10 == 0;
        }

        public string ComputeFullSiren(string sirenWithoutControlNumber)
        {
            if (string.IsNullOrEmpty(sirenWithoutControlNumber) || sirenWithoutControlNumber.Length != 8 )
            {
                throw new ArgumentException("Invalid input for SIREN without control number.");
            }

            int sum = 0;
            int[] sirenEntiers = ConvertToDigit(sirenWithoutControlNumber);
            for (int i = 0; i < sirenEntiers.Length; i++)
            {
                int temp = sirenEntiers[i];
                if (i % 2 != 0)
                {
                    temp = temp * 2;
                    if (temp > 9)
                    {
                        temp = temp - 9;
                    }
                }
                sum += temp;
            }
            var t = sum % 10;
            int sirenKey = (10 - (sum % 10)) % 10;
            return sirenWithoutControlNumber + sirenKey.ToString();
        }

        private int[] ConvertToDigit(string siren)
        {
            int[] sirenEntiers = new int[siren.Length];
            for (int i = 0; i < sirenEntiers.Length; i++)
            {
                if (int.TryParse(siren[i].ToString(), out int chiffre))
                {
                    sirenEntiers[i] = chiffre;
                }
                else
                {
                    throw new ArgumentException($"Le caractère {siren[i]} n'est pas un chiffre");
                }
            }

            return sirenEntiers;
        }
    }
}

