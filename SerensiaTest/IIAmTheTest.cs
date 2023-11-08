using System;
namespace SerensiaTest
{
	public interface IIAmTheTest
	{
        public bool CheckSirenValidity(string siren);
        public string ComputeFullSiren(string sirenWithoutControlNumber);
    }
}

