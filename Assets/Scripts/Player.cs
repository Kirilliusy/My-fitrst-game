using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private string _name;

    private void Start()
    {
        Cursor.visible = false;
        transform.name = _name;
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    private void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);
    }
}
