using Ganyariya.SampleAdder;
using UnityEngine;


namespace Ganyariya.SampleAdder.Sample
{
    public class AdderConsoleLogger : MonoBehaviour
    {
        [SerializeField] private int x;
        [SerializeField] private int y;

        void Start()
        {
            var adder = new Adder();
            var result = adder.Add(x, y);

            Debug.Log($"x = {x}, y = {y}, addResult = {result} in AdderConsoleLogger");
        }
    }
}