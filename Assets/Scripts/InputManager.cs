
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private GameObject item;

    private Vector2 direction = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        UpdateOrientation();
    }

    void Awake()
    {

    }

    void UpdateOrientation()
    {
        float imageScale = 1.75f; //change to how large you want the sprite to be
        if (direction == Vector2.up)
        {
            item.transform.localScale = new Vector3(imageScale, imageScale, 1);
            item.transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        else if (direction == Vector2.down)
        {
            item.transform.localScale = new Vector3(imageScale, imageScale, 1);
            item.transform.localRotation = Quaternion.Euler(0, 0, -90);
        }
        else if (direction == Vector2.left)
        {
            item.transform.localScale = new Vector3(-imageScale, imageScale, 1);
            item.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (direction == Vector2.right)
        {
            item.transform.localScale = new Vector3(imageScale, imageScale, 1);
            item.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
