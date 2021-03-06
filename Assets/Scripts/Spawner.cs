﻿using UnityEngine;

namespace Assets.Scripts
{
    public class Spawner : MonoBehaviour
    {
        public MusicManager musicManager;
        public Note blueNote;
        public Note greenNote;
        public Note redNote;
        public Note yellowNote;
        public GameObject fretBoard;
        public bool shouldSpawn = true;
        public int blue = 0;
        public int green = 1;
        public int red = 2;
        public int yellow = 3;

        Vector3 blueSpanwPos = new Vector3(-2.0f, 4.65f, 7.58f);
        Vector3 greenSpawnPos = new Vector3(-0.7f, 4.65f, 7.58f);
        Vector3 redNoteSpawnPos = new Vector3(0.69f, 4.65f, 7.58f);
        Vector3 yellowNoteSpawnPos = new Vector3(2.0f, 4.65f, 7.58f);

        void Update()
        {
            for (int i = 0; i < 1; i++)
            {
                System.Random random = new System.Random();
                Spawn(random.Next(0, 350));
            }
        }

        void Spawn(int note)
        {
            if (note == 0)
            {
                GameObject.Instantiate(blueNote, blueSpanwPos, new Quaternion(0, 0, 0, 0), fretBoard.transform);
            }

            if (note == 1)
            {
                GameObject.Instantiate(greenNote, greenSpawnPos, new Quaternion(0, 0, 0, 0), fretBoard.transform);
            }

            if (note == 2)
            {
                GameObject.Instantiate(redNote, redNoteSpawnPos, new Quaternion(0, 0, 0, 0), fretBoard.transform);
            }

            if (note == 3)
            {
                GameObject.Instantiate(yellowNote, yellowNoteSpawnPos, new Quaternion(0, 0, 0, 0), fretBoard.transform);
            }
        }
    }
}