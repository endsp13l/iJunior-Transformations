using UnityEngine;

public class Growth : MonoBehaviour
{
    [SerializeField] private float _growthRate;

    private void Update()
    {
        transform.localScale += (Vector3.one * _growthRate * Time.deltaTime);
    }
}