using Xunit;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        {
            Assert.Equal(11, Sum(5, 6));
        }
    }

        [Fact]
    public void Test2()
    {
        {
            Assert.Equal(12, Sum(5, 6));
        }
    }

    int Sum(int a, int b){
        return a+b;
    }
}