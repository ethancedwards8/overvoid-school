using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GilbertAnimator : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    [SerializeField] float animationSpeed;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(animate());
    }

    IEnumerator animate()
    {
        while (true)
        {
            yield return wait(animationSpeed);
            GetComponent<SpriteRenderer>().sprite = sprites[0];
            yield return wait(animationSpeed);
            GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
    }

    IEnumerator wait(float waitTime)
    {
        float cnt = 0;
        while (cnt < waitTime)
        {
            cnt += Time.deltaTime;
            yield return null;
        }
    }

}
