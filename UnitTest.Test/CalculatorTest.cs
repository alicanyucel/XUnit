
using UniitTest.App;
using Xunit;

namespace UnitTest.Test;

public class CalculatorTest
{
    [Fact] // test edilecek metotlara attribute verdik.
    public void AddTest()
    {
        //  Arrange ilk değerlerin verildiği yer hazırlık evresi class olusumu
        //int a =5;
        //int b = 20;
        //var calculator = new Calculator();
        ////Act testin davranısı test edilen metot burada calısır
        ////var total = calculator.Add(a, b);
        ////asert doğrulama evresi
        ////Assert.Equal<int>(25,total); // generic değer alıyor beklenen değer
        ////// fonksiyondan gelen değer
        /////
        ////aranan //gercek deger
        ////Assert.Contains("Ali", "Ali Can Yücel"); //gerçek değer içerisnde aranan değer varsa true döner
        ////// gerçek değer içerisinde yoksa true döner
        ////Assert.DoesNotContain("enre","ali can yücel");
        //var names = new List<string>() { "ali", "can", "yücel" };
        //Assert.Contains(names, x => x == "ali");
        // boolean olarak kıyalama yapar
        //Assert.True(5 > 2)/*;*/
        //Assert.False(5 > 33);//BAŞARILI DÖNECEK
        //// İKİ TİP AYNI OLDUGU İÇİN BAŞARILI DONECEK
        //Assert.True("".GetType() == typeof(string));

    }
}
