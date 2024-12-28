using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pop_Up
{
    public class SequanceTransformers : GroupTransformers
    {
        readonly int firstElementIndex = 0, lastElementIndex;
        int currentIndex;
        List<GroupTransformers> groupTransformers = new();

        GroupTransformers currentTransformer;
        public SequanceTransformers(params GroupTransformers[] transformers)
        {
            foreach (var transformer in transformers)
                this.groupTransformers.Add(transformer);
            lastElementIndex = transformers.Length - 1;
            currentIndex = firstElementIndex;
            currentTransformer = groupTransformers[currentIndex];

        }
        public override void StartTransforming()
        {
            hasStarted = true;
            if (!hasFinished && currentIndex >= firstElementIndex && currentIndex <= lastElementIndex)
            {
                currentTransformer.StartTransforming();
                if (currentTransformer.hasStarted && currentTransformer.hasFinished)
                {
                    ++currentIndex;
                    if (currentIndex <= lastElementIndex)
                    {
                        currentTransformer = groupTransformers[currentIndex];
                    }
                }
            }

            if (currentIndex > lastElementIndex && currentTransformer.hasFinished)
            {
                hasFinished = true;
            }
        }


        public void Dereferance()
        {
            groupTransformers = null;
        }
    }
}