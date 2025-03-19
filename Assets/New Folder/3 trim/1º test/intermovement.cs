using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpNolineal : MonoBehaviour
{

    public GameObject prefab;
    public Transform A;
    public Transform B;
    public float animationDuration;
    public AnimationCurve ease;

    private Transform instantiatedPrefab;

    void Start()
    {
        instantiatedPrefab = Instantiate(prefab, A.position, Quaternion.identity).transform;
        StartCoroutine(AtoB());
    }

    IEnumerator AtoB()
    {
        float t = 0f;

        while (true)
        {
            while (t < animationDuration)
            {
                t += Time.deltaTime;
                instantiatedPrefab.position = Vector3.Lerp(
                    A.position,
                    B.position,
                    ease.Evaluate(t / animationDuration)
                );

                yield return null;
            }

            t = 0f;
            while (t < animationDuration)
            {
                t += Time.deltaTime;

                instantiatedPrefab.position = Vector3.Lerp(
                    B.position,
                    A.position,
                    ease.Evaluate(t / animationDuration)
                );

                yield return null;
            }

            t = 0f;
        }
    }
}
