using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Rocket
{
    public class RocketMovement : MonoBehaviour
    {
        private float _speed = 10.0f;

        private void Update()
        {
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
            if (transform.position.x > 12.0f)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
