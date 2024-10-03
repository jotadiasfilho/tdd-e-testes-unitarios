using NewTalents;

namespace TestesNewTalents;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "03/10/2024";
        Calculadora calc = new Calculadora("03/10/2024");

        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]

    public void TestarSoma(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (3, 2, 1)]
    [InlineData (8, 4, 4)]

    public void TestarSubtracao(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (5, 5, 25)]
    [InlineData (8, 2, 16)]

    public void TestarMultiplicacao(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (8, 2, 4)]
    [InlineData (9, 3, 3)]

    public void TestarDivisao(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3,0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClasse();

        calc.somar (1, 2);
        calc.somar (2, 8);
        calc.somar (3, 7);
        calc.somar (4, 1);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}