using System.Collections;
using System.Collections.Generic;
using Evstr.Obstacles;
using UnityEngine;

namespace Evstr.Obstacles
{
    public class ObstacleSpawner : MonoBehaviour
    {
        private float _xPosition = 3.0f;
        private float _yPosition;
        private float _yBoardDown = -5.0f;
        private float _yBoardUp = -2.0f;


        private void Start()
        {
            StartCoroutine(SpawnObstacle());
        }

        private IEnumerator SpawnObstacle()
        {
            while (true)
            {
                yield return new WaitForSeconds(1.6f);
                GameObject obstacle = ObjectPool.SharedInstance.GetPooledObjectObstacle();
                _yPosition = Random.Range(_yBoardDown, _yBoardUp);
                if (obstacle != null)
                {
                    obstacle.transform.position = new Vector2(_xPosition, _yPosition);
                    obstacle.SetActive(true);
                }
            }
        }
    }
}
