using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0) {
            return 0.0;
        }
        if (1 <= speed && speed <= 4) {
            return 1.0;
        }
        if (5 <= speed && speed <= 8) {
            return 0.9;
        }
        if (9 == speed) {
            return 0.8;
        }
        if (10 == speed) {
            return 0.77;
        }
        return 0.0;
    }

    public static double ProductionRatePerHour(int speed)
    {
        double success = SuccessRate(speed);
        double speedf = Convert.ToDouble(speed);
        double rate = speedf * success * 221.0;
        return rate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double rate = ProductionRatePerHour(speed);
        return (int)(rate / 60.0);
    }
}
