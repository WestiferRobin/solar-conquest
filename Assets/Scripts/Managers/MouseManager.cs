using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    private List<PrismID> SelectedPrismIDs = new();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void HandlePrismSelect(RaycastHit2D hit)
    {
        GameObject gameObject = hit.transform.gameObject;

        SpriteRenderer cubeRenderer = gameObject.GetComponent<SpriteRenderer>();

        PrismModel prismModel = gameObject.GetComponent<PrismModel>();
        Prism prism = prismModel.Prism;

        if (!SelectedPrismIDs.Contains(prism.Pid))
        {
            SelectedPrismIDs.Add(prism.Pid);
            cubeRenderer.material.SetColor("_Color", prismModel.SecondaryColor);
            prismModel.ShowSelectedGrid();
        }
        else
        {
            SelectedPrismIDs.Remove(prism.Pid);
            cubeRenderer.material.SetColor("_Color", prismModel.PrimaryColor);
            prismModel.ClearSelectedGrid();
        }
    }

    bool IsTag(RaycastHit2D hit, string tag)
    {
        return hit.transform.gameObject.CompareTag(tag);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 origin = new(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                                         Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            var hits = Physics2D.RaycastAll(origin, Vector2.zero, 0f);
            foreach (var hit in hits)
            {
                if (IsTag(hit, "Prism"))
                {
                    HandlePrismSelect(hit);
                }
            }
        }
    }
}
