using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupTransformers
{
    public bool hasStarted, hasFinished;
    List<Transformer> transformers;

    public virtual void StartTransforming()
    {
        hasStarted = true;
        if (transformers.Count > 0 && transformers != null)
        {
            bool allFinished = true;
            foreach (Transformer transformer in transformers)
            {
                transformer.StartTransforming();
                allFinished &= transformer.hasFinished;

            }
            hasFinished = allFinished;

        }
    }

    public void AddTransformers(params Transformer[] transformers)
    {
        this.transformers = new List<Transformer>();
        foreach (Transformer transformer in transformers)
        {
            this.transformers.Add(transformer);
        }

    }
}
