using Xunit;

public class PagoDeClasesTest
{
    [Fact]
    public void SumTest()
    {
        // Arrange
        var pagoDeClase = new PagoDeClase();

        // Act
        var result = pagoDeClase.Sum(5000);

        // Assert
        Assert.Equal(10000, result);
    }

    [Fact]
    public void SumTestSiLaClaseSale6000()
    {
        // Arrange
        var pagoDeClase = new PagoDeClase();

        // Act
        var result = pagoDeClase.Sum(6000);

        // Assert
        Assert.Equal(12000, result);
    }

 [Fact]
    public void SumTestErrorResultado()
    {
        // Arrange
        var pagoDeClase = new PagoDeClase();

        // Act
        var result = pagoDeClase.Sum(5000);

        // Assert
        Assert.Equal(11000, result);

}
}
