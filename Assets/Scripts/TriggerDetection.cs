using UnityEngine;

namespace Assets.Scripts
{
    public class TriggerDetection : MonoBehaviour
    {
        public Note note;
        public string buttonName;
        public ScoreManager scoreManager;
        public ParticleSystem hitEffect;

        void Start()
        {
            hitEffect = hitEffect.GetComponent<ParticleSystem>();
            hitEffect.Stop();
        }

        void Update()
        {
            if (Input.GetButton(buttonName) && note != null)
            {
                scoreManager.currentScore += scoreManager.CORRECT_NOTE_BONUS;

                scoreManager.totalCorrectNotes++;

                hitEffect.Play();

                Destroy(note.gameObject);
                note = null;
            }
        }

        void OnTriggerEnter(Collider collider)
        {
            if (collider.GetComponent<Note>())
            {
                note = collider.GetComponent<Note>();
            }
        }

        void OnTriggerExit(Collider collider)
        {
            if (collider.GetComponent<Note>() == note)
            {
                scoreManager.totalNotesPassed += 1;

                scoreManager.totalWrongNotes++;
                scoreManager.currentScore -= scoreManager.WRONG_NOTE_PENALTY;

                if (scoreManager.currentScore < 0)
                {
                    scoreManager.currentScore = 0;
                }

                Destroy(note.gameObject);
                note = null;
            }
        }
    }
}