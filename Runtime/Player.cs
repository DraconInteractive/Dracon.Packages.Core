using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Dracon.Core.Player
{
    public class Player : MonoBehaviour
    {
        public static Player Instance;
        InteractionsManager iManager;

        // Start is called before the first frame update
        void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            iManager = InteractionsManager.Instance;
        }

        private void Update()
        {

        }
    }
}

