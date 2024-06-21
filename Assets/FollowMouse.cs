using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 0;

        Vector3 direction = Camera.main.WorldToScreenPoint(transform.position);
        mousePosition.x = mousePosition.x - direction.x;
        mousePosition.y = mousePosition.y - direction.y;

        float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;
        angle -= 90;
        transform.rotation = Quaternion.Euler(new Vector3(90, 0, angle));

    }
}
