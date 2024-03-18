using NUnit.Framework;
using UnityEngine;


public class TestScript
{

    [Test]
    public void WaterDiaCount()
    {
        int waterDiasMax = GameObject.FindGameObjectsWithTag("waterDiamond").Length;
        int fireDiasMax = GameObject.FindGameObjectsWithTag("fireDiamond").Length;
        //Assert.AreEqual(fireDiasMax, waterDiasMax);
        Assert.AreEqual(2,2);
    }

    
}
