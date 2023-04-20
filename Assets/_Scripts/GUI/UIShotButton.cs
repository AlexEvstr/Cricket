using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Evstr.Rocket;
using Evstr.Player;

namespace Evstr.GUI
{
    public class UIShotButton : UIBaseButton
    {
        [SerializeField] private RocketSpawner _rocketSpawner;

        public override void OnClick()
        {
            _rocketSpawner.SpawnRocket();
        }
    }
}
