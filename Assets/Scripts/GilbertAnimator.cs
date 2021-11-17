using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GilbertAnimator : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(animate());
    }

    IEnumerator animate()
    {
        while (true)
        {
            yield return wait(0.75f);
            GetComponent<SpriteRenderer>().sprite = sprites[0];
            yield return wait(0.75f);
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
