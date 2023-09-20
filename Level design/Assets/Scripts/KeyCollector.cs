using UnityEngine;
using UnityEngine.UI;

public class KeyCollector : MonoBehaviour
{
    public Image keyImage; // Reference to the UI Image component for the key.
    public Sprite grayKeySprite; // The gray key sprite.
    public Sprite coloredKeySprite; // The colored key sprite.

    private bool isCollected = false; // Keep track of whether the key is collected.

    private void Start()
    {
        keyImage.sprite = grayKeySprite; // Set the initial sprite to gray.
    }

    public void CollectKey()
    {
        if (!isCollected)
        {
            keyImage.sprite = coloredKeySprite; // Change the UI Image to the colored key.
            isCollected = true; // Mark the key as collected to prevent repeated collection.
        }
    }
}
