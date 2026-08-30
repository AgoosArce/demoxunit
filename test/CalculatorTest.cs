using Xunit;

public class PagoDeClasesTest
{
    [Fact]
    public void SumTest()
    {
        // Arrange
        const int precioBase = 5000;
        var pagoDeClase = new PagoDeClase();

        // Act
        var result = pagoDeClase.Sum(precioBase);

        // Assert
        Assert.Equal(10000, result);
    }

    [Fact]
    public void SumTest2()
    {
        // Arrange
        var pagoDeClase = new PagoDeClase();

        // Act
        var result = pagoDeClase.Sum(6000);

        // Assert
        Assert.Equal(10000, result);
    }
  [Fact]
    public void SumTest3()
    {
        // Arrange
        const int precioBase = 5000;
        var pagoDeClase = new PagoDeClase();

        // Act
        var result = pagoDeClase.Sum(precioBase);

        // Assert
        Assert.Equal(35000, result);
    }
}

