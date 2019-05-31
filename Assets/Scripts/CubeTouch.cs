using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTouch : MonoBehaviour
{
    private bool isMat1 = true;
    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.name == "Cube")
                {
                    Renderer render = raycastHit.transform.gameObject.GetComponent<Renderer>();
                    if (isMat1)
                    {
                        render.material.color = Color.blue;
                    }
                    else
                    {
                        render.material.color = Color.red;
                    }
                    isMat1 = !isMat1;
                }
            }
        }
    }
}
