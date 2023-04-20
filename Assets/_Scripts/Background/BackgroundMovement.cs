using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Background
{
    public class BackgroundMovement : MonoBehaviour
    {
        private float _speed = 2.0f;

        private void Update()
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
            if (transform.position.x <= -25.0f)
            {
                transform.position = new Vector2(24.8f, 0);
            }
        }
    }
}
