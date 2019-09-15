using UnityEngine;

public class PointCalculator
{
    public int CalculateTotalPoints(int killedEnemies, int killedVillagers, int multiplicator)
    {
        int points = 0;

        points += killedEnemies * 100;
        points += Mathf.FloorToInt(killedEnemies / 10) * 500;
        points -= killedVillagers * 100;

        if (killedVillagers > 10)
        {
            multiplicator = 1;
        }

        points *= multiplicator;

        return points;
    }
}
