using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Enemy
{
    public class EnemySpawner : MonoBehaviour
    {
        private float _xPosition = 13.0f;
        private float _yPosition;
        private float _yBoards = 4.0f;
        private float _timeIndex;


        private void Start()
        {
            StartCoroutine(SpawnObstacle());
        }

        private IEnumerator SpawnObstacle()
        {
            while (true)
            {
                _timeIndex = Random.Range(4, 8);
                yield return new WaitForSeconds(_timeIndex);
                GameObject enemy = ObjectPool.SharedInstance.GetPooledObjectEnemy();
                _yPosition = Random.Range(-_yBoards, _yBoards);
                if (enemy != null)
                {
                    enemy.transform.position = new Vector2(_xPosition, _yPosition);
                    enemy.SetActive(true);
                }
            }
        }
    }
}
