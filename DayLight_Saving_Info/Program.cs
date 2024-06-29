using System;

class Program
{
    static void Main()
    {

        TimeZoneInfo localTimeZone = TimeZoneInfo.Local;


        if (localTimeZone.SupportsDaylightSavingTime)
        {
            Console.WriteLine($"Standard name: {localTimeZone.StandardName}");
            Console.WriteLine($"Daylight name: {localTimeZone.DaylightName}");

          
            TimeZoneInfo.AdjustmentRule[] adjustmentRules = localTimeZone.GetAdjustmentRules();
            
            foreach (TimeZoneInfo.AdjustmentRule rule in adjustmentRules)
            {
                Console.WriteLine($"Adjustment rule start date: {rule.DateStart}");
                Console.WriteLine($"Adjustment rule end date: {rule.DateEnd}");
                Console.WriteLine($"Base offset: {rule.DaylightDelta.TotalHours} hours");

                
                TimeZoneInfo.TransitionTime startTransition = rule.DaylightTransitionStart;
                Console.WriteLine($"Transition start date: {startTransition.TimeOfDay}, {startTransition.Month}/{startTransition.DayOfWeek}/{startTransition.Week}");

               
                TimeZoneInfo.TransitionTime endTransition = rule.DaylightTransitionEnd;
                Console.WriteLine($"Transition end date: {endTransition.TimeOfDay}, {endTransition.Month}/{endTransition.DayOfWeek}/{endTransition.Week}");
            }
        }
        else
        {
            Console.WriteLine("Daylight saving time is not supported for this time zone.");
        }
    }
}
