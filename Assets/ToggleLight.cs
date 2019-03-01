using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    public AnimationCurve Intensity;

    private float initInt;
    private float rabd;

    void Start()
    {
        initInt = GetComponent<Light>().intensity;
        rabd = Random.Range(-5f, 1.5f);
    }

    private void Update()
    {
        GetComponent<Light>().intensity = Intensity.Evaluate(Time.time + rabd) + initInt;
    }
}
