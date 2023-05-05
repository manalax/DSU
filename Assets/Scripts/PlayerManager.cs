using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DSU
{
    public class PlayerManager : MonoBehaviour
    {
        InputHandler inputHandler;
        // Start is called before the first frame update
        void Start()
        {
            inputHandler = GetComponent<InputHandler>();   
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }   
}
