using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public GameObject[] TilePrefabs;

    public int width = 6;
    public int height = 6;

    public float tileSpacing = 1.1f; // Kutular arasýndaki boþluk

    private void Start()
    {
        GenerateBoard();
    }

    void GenerateBoard()
    {
        // Sol alt köþe için baþlangýç pozisyonu hesaplama
        Vector2 startPosition = new Vector2(-width / 2f, -height / 2f);

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                //Random Square
                int tilePrefabIndex = Random.Range(0, TilePrefabs.Length);

                // Pozisyonu hesapla
                Vector2 position = startPosition + new Vector2(x * tileSpacing, y * tileSpacing);
                Instantiate(TilePrefabs[tilePrefabIndex], position, Quaternion.identity);
            }
        }
    }

}
