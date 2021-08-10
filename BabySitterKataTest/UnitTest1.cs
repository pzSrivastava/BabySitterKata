using BabySitterKata;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace BabySitterKataTest
{
    public class BabySitterTest
    {
        
        [Fact]
        public void TestCalculateChargeforFamilyAatRegulerOneHours()
        {
            int startTime,endTime;
            startTime = 17;      // 5 PM
            endTime = 18;        // 6 pM     

            Assert.Equal(15, new BabySitterCalculatCharge().CalculateBabySitterRegularHoursPay(startTime, endTime));
        }

        [Fact]
        public void TestCalculateChargeforFamilyAatRegulertwoHours()
        {
            int startTime, endTime;
            startTime = 17;      // 5 PM
            endTime = 19;        // 7 pM     

            Assert.Equal(30, new BabySitterCalculatCharge().CalculateBabySitterRegularHoursPay(startTime, endTime));
        }

        [Fact]
        public void TestCalculateChargeforFamilyAatIrRegulerHours()
        {
            int startTime, endTime;
            startTime = 16;      // 4 PM  -- baby sitter reaches before 5pm
            endTime = 19;        // 7 pM     

            Assert.Equal(30, new BabySitterCalculatCharge().CalculateBabySitterRegularHoursPay(startTime, endTime));
        }

        [Fact]
        public void TestCalculateChargeforFamilyAfter11pm()
        {
            int startTime, endTime;
            startTime = 17;      //  5PM - 11 pm = 6hr
            endTime = 24;        // 11 -12 pm     

            Assert.Equal(110, new BabySitterCalculatCharge().CalculateBabySitterPremiumHoursPay(startTime, endTime));
        }

        [Fact]
        public void TestCalculateChargeforFamilyTill2Am()
        {
            int startTime, endTime;
            startTime = 17;       // ||  17 - 23 = 6 * 15 
            endTime = 2;    //   || 23 - [24 + 2 ]=  3 * 20

            Assert.Equal(150, new BabySitterCalculatCharge().CalculateBabySitterPremiumHoursPay(startTime, endTime));
        }

    }
}
