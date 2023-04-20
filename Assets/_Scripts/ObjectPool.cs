using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr
{
    public class ObjectPool : MonoBehaviour
    {
        public static ObjectPool SharedInstance;
        public List<GameObject> objectToPool;

        public List<GameObject> pooledObstacles;
        public List<GameObject> pooledStarsBonus;
        public List<GameObject> pooledEnemies;
        public List<GameObject> pooledRockets;

        public int amountToPoolObstacle;
        public int amountToPoolStarBonus;
        public int amountToPoolEnemy;
        public int amountToPoolRocket;

        private void Awake()
        {
            SharedInstance = this;
        }

        private void Start()
        {
            PoolObjects();
        }

        private void PoolObjects()
        {
            PoolObstacles();
            PoolStars();
            PoolEnemy();
            PoolRocket();
        }

        public GameObject GetPooledObjectObstacle()
        {
            for (int i = 0; i < amountToPoolObstacle; i++)
            {
                if (!pooledObstacles[i].activeInHierarchy)
                {
                    return pooledObstacles[i];
                }
            }
            return null;
        }

        private void PoolObstacles()
        {
            pooledObstacles = new List<GameObject>();
            GameObject obstacle;
            for (int i = 0; i < amountToPoolObstacle; i++)
            {
                obstacle = Instantiate(objectToPool[0]);
                obstacle.SetActive(false);
                pooledObstacles.Add(obstacle);
            }
        }

        public GameObject GetPooledObjectStarBonus()
        {
            for (int i = 0; i < amountToPoolStarBonus; i++)
            {
                if (!pooledStarsBonus[i].activeInHierarchy)
                {
                    return pooledStarsBonus[i];
                }
            }
            return null;
        }

        private void PoolStars()
        {
            pooledStarsBonus = new List<GameObject>();
            GameObject star;
            for (int i = 0; i < amountToPoolStarBonus; i++)
            {
                star = Instantiate(objectToPool[1]);
                star.SetActive(false);
                pooledStarsBonus.Add(star);
            }
        }

        public GameObject GetPooledObjectEnemy()
        {
            for (int i = 0; i < amountToPoolEnemy; i++)
            {
                if (!pooledEnemies[i].activeInHierarchy)
                {
                    return pooledEnemies[i];
                }
            }
            return null;
        }

        private void PoolEnemy()
        {
            pooledEnemies = new List<GameObject>();
            GameObject enemy;
            for (int i = 0; i < amountToPoolEnemy; i++)
            {
                enemy = Instantiate(objectToPool[2]);
                enemy.SetActive(false);
                pooledEnemies.Add(enemy);
            }
        }

        public GameObject GetPooledObjectRocket()
        {
            for (int i = 0; i < amountToPoolRocket; i++)
            {
                if (!pooledRockets[i].activeInHierarchy)
                {
                    return pooledRockets[i];
                }
            }
            return null;
        }

        private void PoolRocket()
        {
            pooledRockets = new List<GameObject>();
            GameObject rocket;
            for (int i = 0; i < amountToPoolRocket; i++)
            {
                rocket = Instantiate(objectToPool[3]);
                rocket.SetActive(false);
                pooledRockets.Add(rocket);
            }
        }
    }
}
