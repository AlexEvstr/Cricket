using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Obstacles
{
    public class ObstacleMovement : MonoBehaviour
    {
        private float _speed = 5.0f;

        private void Update()
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
            if (transform.position.x < -23.0f)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
