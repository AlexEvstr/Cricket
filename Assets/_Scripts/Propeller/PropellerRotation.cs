using System.Collections;
using UnityEngine;

namespace Evstr.Propeller
{
    public class PropellerRotation : MonoBehaviour
    {
        private float _speed = 10.0f;

        private void Start()
        {
            StartCoroutine(RotatePropeller());
        }

        private IEnumerator RotatePropeller()
        {
            while(true)
            {
                transform.Rotate(0, 0, 45 * _speed * Time.deltaTime);
                yield return null;
            }
        }
    }
}
