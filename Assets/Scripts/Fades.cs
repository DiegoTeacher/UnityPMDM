using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fades : MonoBehaviour
{
    private SpriteRenderer _rend;

    // Start is called before the first frame update
    void Start()
    {
        _rend = GetComponent<SpriteRenderer>();

        StartCoroutine(FadeOut());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator FadeOut()
    {
        Color currentColor = _rend.material.color;

        for(float alpha = 1.0f; alpha > 0; alpha -= 0.1f)
        {
            currentColor.a = alpha;
            _rend.material.color = currentColor;

            yield return new WaitForSeconds(0.1f);
        }
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        Color currentColor = _rend.material.color;

        for (float alpha = 0.0f; alpha < 1.0; alpha += 0.1f)
        {
            currentColor.a = alpha;
            _rend.material.color = currentColor;

            yield return new WaitForSeconds(0.1f);
        }
        StartCoroutine(FadeOut());
    }
}
