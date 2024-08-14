using tdd_bobs_bagels.CSharp.Main;
using NUnit.Framework;

namespace csharp_tdd_bobs_bagels.tests;
public class BasketTests
{
    [Test]
    public void AddedBagelToBasket()
    {
        // 1. Setup
        Basket basket = new Basket();

        // 2. Execute
        basket.Add("Cream-cheese bagel");

        // 3. Verify
        Assert.IsTrue(basket.Bagels.Contains("Cream-cheese bagel"));
    }
   
    [Test]
    public void RemovedBagelFromBasket()
    {
        // 1. Setup
        // 2. Execute
        // 3. Verify
        Assert.Fail();
    }   

    [Test]
    public void BasketIsFullWhenTryingToAddBagel()
    {
        // 1. Setup
        // 2. Execute
        // 3. Verify
        Assert.Fail();
    }

    [Test]
    public void SetBasketCapacity()
    {
        // 1. Setup
        // 2. Execute
        // 3. Verify
        Assert.Fail();
    }

    [Test]
    public void RemoveBagelThatDoesntExist()
    {
        // 1. Setup
        // 2. Execute
        // 3. Verify
        Assert.Fail();
    }
}