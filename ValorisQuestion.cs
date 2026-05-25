/* As infrastructure providers we would like to provide with a package which will include an API for re-running their code.
In this project you can find a skeleton of this API in "Retry.cs" file.
Your task is to implement the functionality and verify it is working properly, based on the following requirements:
1. Support retry of up to configurable amount of times (e.g. try up to 3 times)
2. Support retry of up to configurable amount of times and return true if success or false otherwise
3. Support retry with timeout (e.g. try up to 2 min)
4. Support retry with timeout with wait between tries (e.g. try up to 2 min)
5. Users should not be able to create instance of this class, they should only be able to use its methods */

using System;

public static class MyRetry
{
    static void RetryTimes(Func<int, char> myMethodName, int arg, int timesToRetry)
    {
        
        while (timesToRetry > 0)
        {
            try
            {
                var result = myMethodName(arg);
                return;
            }
            catch (Exception e)
            {
                timestoRetry--;
                if (timesToRetry < 1)
                {
                    throw;
                }
            }
            
        }
    }

    static bool RetryTimesWithReport((Func<int, char> myMethodName, int arg, int timesToRetry)
    {

        try
        {
            retryTimes(myMethodName, arg, timesToRetry);
            return true;
        }
        catch
        {
            return false;
        }

    }

    static void RetryWithTimeout(Func<int, char> myMethodName, int arg, int ms)
    {
        Stopwatch sw = Stopwatch.StartNew();

        while (sw.ElapsedMilliseconds < ms)
        {
            try
            {
                var result = myMethodName(arg);
                return;
            }
            catch
            {
                if(sw.ElapsedMilliseconds > ms)
                {
                    throw;
                }
            }
            
        }
        
    } 
}
