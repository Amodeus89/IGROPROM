using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour{
    void OnMouseDown()
    {
        transform.localScale = new Vector3 (0.90f, 0.90f, 0.90f);
    }
    void OnMouseUp()
    {
        transform.localScale = new Vector3 (1f, 1f, 1f);
    }
}