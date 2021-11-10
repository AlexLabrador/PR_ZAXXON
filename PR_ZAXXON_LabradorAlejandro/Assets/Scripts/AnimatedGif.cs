using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatedGif : MonoBehaviour
{
    public Sprite[] animatedImages;
    public Image animateImageObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animateImageObject.sprite = animatedImages [(int)(Time.time * 8)%animatedImages.Length];
    }
}
