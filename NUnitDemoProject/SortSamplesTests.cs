using NUnit.Framework;

namespace NUnitDemoProject;

[TestFixture]
public class SortSamplesTests
{
    [Test]
    public void TrueTest1()
    {
        int[] array = { 5, 4, 3, 2, 1 };
        int[] result = { 1, 2, 3, 4, 5 };

        try
        {
            SortSamples.SimpleBubbleSort(array);
            Assert.AreEqual(array, result);
        }
        catch (Exception e)
        {
            Assert.Fail();
        }
        
    }

    [Test]
    public void TrueTest2()
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };
        int[] result = { 1, 2, 3, 4, 5, 6 };
        
        try
        {
            SortSamples.SimpleBubbleSort(array);
            Assert.AreEqual(array, result);
        }
        catch (Exception e)
        {
            Assert.Fail();
        }
    }

    [Test]
    public void TrueTest3()
    {
        int[] array = { 1, -4, 0, 12, 5, -49 };
        int[] result = { -49, -4, 0, 1, 5, 12 };
        
        try
        {
            SortSamples.SimpleBubbleSort(array);
            Assert.AreEqual(array, result);
        }
        catch (Exception e)
        {
            Assert.Fail();
        }
    }

    [Test]
    public void FalseTest()
    {
        int[] array = { };
        int[] result = { -49, -4, 0, 1, 5, 12 };
        
        try
        {
            SortSamples.SimpleBubbleSort(array);
            Assert.Fail();
        }
        catch (Exception e)
        {
            Assert.Pass();
        }
    }

}