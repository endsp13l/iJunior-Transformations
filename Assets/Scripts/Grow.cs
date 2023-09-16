using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _growthRate;

    void Update()
    {
        transform.localScale += (Vector3.one * _growthRate * Time.deltaTime);
    }
}