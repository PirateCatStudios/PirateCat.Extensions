namespace PirateCat.Extensions
{
    public static class StopWatchExtensions
    {
        /// <summary>
        /// Get the delta between current and previous tick in milliseconds.
        /// </summary>
        /// <param name="stopWatch"></param>
        /// <param name="previousTicks"></param>
        /// <returns></returns>
        public static float GetTicksDeltaAsMilliseconds(this System.Diagnostics.Stopwatch stopWatch, long previousTicks)
        {
            return (float)((double)(stopWatch.ElapsedTicks - previousTicks) / FrequencyMilliseconds);
        }

        public static long FrequencyMilliseconds = System.Diagnostics.Stopwatch.Frequency / 1000;
    }
}
