using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class HordeManager : MonoBehaviour
{

  public Wave enemyWave;
  public Path enemyPath;

  IEnumerator Start()
  {

    StartCoroutine("SpawnSmallEnemies");
    StartCoroutine("SpawnBigEnemies");

    yield break;

  }

  IEnumerator SpawnSmallEnemies()
  {
    for (int i = 0; i < enemyWave.groupsOfEnemiesInWave.Length; i++)
    {

      for (int j = 0; j < enemyWave.groupsOfEnemiesInWave[i].numberOfSmall; j++)
      {
        Enemy spawnedEnemy = Instantiate(enemyWave.groupsOfEnemiesInWave[i].smallMichaelEnemy).GetComponent<Enemy>();
        spawnedEnemy.route = enemyPath;
        yield return new WaitForSeconds(enemyWave.groupsOfEnemiesInWave[i].coolDownBetweenSmallEnemies);

      }

      yield return new WaitForSeconds(enemyWave.coolDownBetweenSmallWave); // cooldown between groups
    }

  }

  IEnumerator SpawnBigEnemies()
  {
        for (int i = 0; i < enemyWave.groupsOfEnemiesInWave.Length; i++)
        {
            for (int j = 0; j < enemyWave.groupsOfEnemiesInWave[i].numberOfLarge; j++)
            {
                Enemy spawnedEnemy = Instantiate(enemyWave.groupsOfEnemiesInWave[i].bigAwesomeSuperBadGuyClayEnemy).GetComponent<Enemy>();
                spawnedEnemy.route = enemyPath;
                yield return new WaitForSeconds(enemyWave.groupsOfEnemiesInWave[i].coolDownBetweenLargeEnemies);

            }

            yield return new WaitForSeconds(enemyWave.coolDownBetweenLargeWave);
        }
    }
}



[Serializable]
public struct Group
{
  public GameObject smallMichaelEnemy;
  public GameObject bigAwesomeSuperBadGuyClayEnemy;
  public int numberOfSmall;
  public int numberOfLarge;
  public float coolDownBetweenSmallEnemies;
  public float coolDownBetweenLargeEnemies;
}

[Serializable]
public struct Wave
{
  public Group[] groupsOfEnemiesInWave;
  public float coolDownBetweenSmallWave;
  public float coolDownBetweenLargeWave;
}

