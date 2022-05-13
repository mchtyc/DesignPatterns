using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Enemy SpawnEnemy(Enemy prototype)
    {
        return (Enemy)prototype.Copy();
    }
}
