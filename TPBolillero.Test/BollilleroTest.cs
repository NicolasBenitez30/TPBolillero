using Xunit;
using TPBolillero.Core;

namespace TPBolillero.Test;

public class BolilleroTest
{
    public Bolillero Bolillero { get; set; }
    static IAzar _primero = new Primera();
    public BolilleroTest()
    {
        Bolillero = new Bolillero(_primero, 10);
    }
    [Fact]
    public void TestSacarBolilla()
    {
        Bolillero.SacarBolilla();
        Assert.Equal();
        Assert.Equal();
        Assert.Equal();
    }
    
}