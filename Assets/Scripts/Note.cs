using UnityEngine;

namespace Assets.Scripts
{
    public class Note : MonoBehaviour
    {
        public Note note;
        public float speed = -5.0f;

        void Update()
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
    }
}