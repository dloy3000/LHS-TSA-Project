using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignImg : MonoBehaviour
{
    private SpriteRenderer rend;
    private InventoryObj invObj;

    // Start is called before the first frame update
    void Start()
    {
        Texture2D tex = invObj.returnImage();
        rend.sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f));
    }
}
