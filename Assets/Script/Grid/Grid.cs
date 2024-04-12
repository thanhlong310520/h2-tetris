using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    //[SerializeField] List<Transform> listSquareInGrid;
    [SerializeField] RectTransform rect;
    [SerializeField] GridLayoutGroup glg;
    [SerializeField] Image square;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnSquareInGrid(10,3);
        }
    }

    void SpawnSquareInGrid(int col,int row)
    {
        Debug.Log("change rect");
        glg.constraintCount = col;
        //Debug.Log(rect.position);
        rect.sizeDelta = new Vector2(col*100, 100);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                var tempsquare = Instantiate<Image>(square);
                tempsquare.transform.SetParent(gameObject.transform);
                tempsquare.GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
                tempsquare.GetComponent<RectTransform>().localScale = Vector3.one;
                var ctr = tempsquare.GetComponent<GridElement>();
                ctr.row = i;
                ctr.col = j;
            }
        }
    }
    
}
