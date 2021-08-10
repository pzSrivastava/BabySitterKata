using System;

namespace BabySitterKata
{
    public class BabySitterCalculatCharge
    {
        int famalyAWage = 15;
        int famalyASpecialWageAfter11 = 20;
        int babySitterStartTime = 17;

        const int RegularTimeStart = 1;
        const int RegularTimeEnd = 12;
        const int ExtraMoneyTime = 23;
        const int midNightTime = 24;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public double CalculateBabySitterRegularHoursPay(int startTime, int endTime)
        {
            double cost = 0;
            if (startTime < babySitterStartTime)
                startTime = babySitterStartTime;

            if (startTime >= babySitterStartTime && endTime <= ExtraMoneyTime)
                cost = (endTime - startTime) * famalyAWage;

            return cost;

        }
        public double CalculateBabySitterPremiumHoursPay(int startTime, int endTime)
        {
            double cost = 0;

            int startToBefore11 = (ExtraMoneyTime - startTime) * famalyAWage;
            int actualEndTime = endTime >= RegularTimeStart && endTime <= RegularTimeEnd ? (midNightTime + endTime) : endTime;
            int after11 = actualEndTime < ExtraMoneyTime ? 0 : (actualEndTime - ExtraMoneyTime) * famalyASpecialWageAfter11;
            cost = startToBefore11 + after11;
            return cost;

        }


        //public double CalculateBabySitterPremiumHours(int startTime, int endTime)
        //{
        //    double cost = 0;
        //    // 5PM -> 2AM
        //    // 5 PM - 11 PM = 6 hr * 15
        //    // 11 PM - 2 AM = 3hr * 20   ==> 150           

        //    int startToBefore11 = (boudarytime - startTime) * famalyAWage;
        //    int after11 = endTime < boudarytime ? 0 : (endTime - boudarytime) * famalyASpecialWageAfter11;
        //    cost = startToBefore11 + after11;
        //    return cost;

        //}
    }
}
