using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Bonuses
{
    public class BonusSpawner : MonoBehaviour
    {
        private float _xPosition = 12.0f;
        private float _yPosition;
        private float _yBoards = 4.0f;
        private float _timeIndex;


        private void Start()
        {
            StartCoroutine(SpawnBonus());
        }

        private IEnumerator SpawnBonus()
        {
            while (true)
            {
                _timeIndex = Random.Range(5, 10);
                yield return new WaitForSeconds(_timeIndex);
                GameObject bonus = ObjectPool.SharedInstance.GetPooledObjectStarBonus();
                _yPosition = Random.Range(-_yBoards, _yBoards);
                if (bonus != null)
                {
                    bonus.transform.position = new Vector2(_xPosition, _yPosition);
                    bonus.SetActive(true);
                }
            }
        }
    }
}
