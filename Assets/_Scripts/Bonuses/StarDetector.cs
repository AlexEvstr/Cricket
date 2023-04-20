using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Evstr.Score;

namespace Evstr.Bonuses
{
    public class StarDetector : MonoBehaviour
    {
        [SerializeField] private GameObject _plus25;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Star"))
            {
                collision.gameObject.SetActive(false);
                ScoreIncrease.score += 25;
                Instantiate(_plus25);
            }
        }
    }
}
