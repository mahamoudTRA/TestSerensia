using Xunit;

namespace SerensiaTest.Tests;

public class SirenTest
{
    [Fact]
    public void ValidateSiren_ValidSiren_ReturnsTrue()
    {
        
        IAmTheTest sut = new IAmTheTest();
        string validSiren = "123456782";

        bool resultat = sut.CheckSirenValidity(validSiren);

        Assert.True(resultat);
    }

    [Fact]
    public void ValidateSiren_InvalidSiren_ReturnsFalse()
    {
        IAmTheTest sut = new IAmTheTest();
        string validSiren = "123456789";

        bool resultat = sut.CheckSirenValidity(validSiren);

        Assert.False(resultat);
    }

    [Fact]
    public void CalculateFullSiren_ValidInput_ReturnsFullSiren()
    {
        
        IAmTheTest sut = new IAmTheTest();
        string sirenWithoutKey = "12345678"; 
        string expetedSiren = "123456782";

       
        string result = sut.ComputeFullSiren(sirenWithoutKey);

        Assert.Equal(expetedSiren, result);
    }

    [Fact]
    public void CalculateFullSiren_InvalidInput_ThrowsException()
    {
        
        IAmTheTest sut = new IAmTheTest();
        string invalidSiren = "1234567";

        
        Assert.Throws<ArgumentException>(() => sut.ComputeFullSiren(invalidSiren));
    }
}
