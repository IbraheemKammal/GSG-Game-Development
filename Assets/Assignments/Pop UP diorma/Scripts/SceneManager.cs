using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;


namespace Pop_Up
{


    public class SceneManager : MonoBehaviour
    {
        public Transform ringTransform, cameraTransform, spaceTransform, staffTransform, swordTransform;
        public CameraDirector cameraDirector;
        Vector3 initialRingPosition, initialRingRotation, spaceInitialPosition, spaceInitialScale;
        int currentStageIndex = 1;

        public Space worldRelativety = Space.World, selfRelativety = Space.Self;

        SequanceTransformers currentTransformers, stage1, stage2, stage3, stage4;

        Renderer spaceRenderer; float spaceAlphaLerper = 1f;


        #region Stage1
        [Header("Stage1")]
        public float stage1RingeTransformingTime = 1f;
        public Transformer s1_ringSelfRotator, s1_ringWorldTransitionar, s1_cameraWorldTransitionar, s1_cameraSelfTransitionar;
        public Vector3 s1_selfRingRotation, s1_ringWorldTransition, s1_cameraWorldTransition, s1_cameraSelfTransition;
        #endregion

        #region Stage2
        [Header("Stage2")]
        public float stage2TransformingTime = 1f;
        public Vector3 s2_spaceNewPosition, s2_cameraWorldTransition, s2_cameraSelfTransition;
        public Transformer s2_spaceWorldTransitionar, s2_cameraWorldTransitionar, s2_cameraSelfTransitionar, s2_spaceScaler;
        #endregion

        #region Stage3
        [Header("Stage3")]
        public float stage3TransformingTime = 1f;
        public Vector3 s3_cameraTransition;
        Vector3 s3_spaceTransition;
        Transformer s3_spaceScaler, s3_spaceTransitioner, s3_cameraWorldTransitioner;
        #endregion

        #region Stage4
        [Header("Stage4")]
        public float stage4TransformingTime = 3f;
        public Vector3 s4_staffTransition, s4_staffRotation;
        Transformer s4_swordTransitionar, s4_swordRotator;

        #endregion



        void Awake()
        {
            initialRingPosition = ringTransform.position;
            initialRingRotation = ringTransform.eulerAngles;
            spaceInitialPosition = ringTransform.position;
            spaceInitialScale = spaceTransform.localScale;
            spaceTransform.localScale = Vector3.zero;
            spaceRenderer = spaceTransform.GetComponent<Renderer>();
            ConfigureStage(currentStageIndex);

        }

        void Update()
        {

            if (Input.GetMouseButtonDown(0) && (currentStageIndex == 1 || currentStageIndex == 2 || currentStageIndex == 3))
            {
                currentTransformers.hasStarted = true;
            }
            else if (currentStageIndex == 4) currentTransformers.hasStarted = true;
            if (currentTransformers.hasStarted && !currentTransformers.hasFinished)
            {
                currentTransformers.StartTransforming();
            }
            if (currentTransformers.hasStarted && currentTransformers.hasFinished)
            {
                currentStageIndex++;
                ConfigureStage(currentStageIndex);
            }

            LerpSpaceMaterialAlpha();


            if (currentStageIndex == 1)
            {
                spaceTransform.position = ringTransform.position;
            }

        }

        private void LerpSpaceMaterialAlpha()
        {
            Color initialColor = spaceRenderer.material.color;
            if (currentStageIndex == 2)
            {
                if (spaceAlphaLerper > 0.3f)
                    spaceAlphaLerper -= Time.deltaTime;

            }
            else if (currentStageIndex == 3f && currentTransformers.hasStarted)
            {
                if (spaceAlphaLerper <= 1f) spaceAlphaLerper += Time.deltaTime;
            }
            initialColor.a = spaceAlphaLerper;

            spaceRenderer.material.color = initialColor;



        }

        void ConfigureStage(int stage)
        {
            switch (stage)
            {
                case 1:
                    s1_cameraWorldTransitionar = new Transitionar(cameraTransform, s1_cameraWorldTransition, stage1RingeTransformingTime, worldRelativety);
                    s1_cameraSelfTransitionar = new Transitionar(cameraTransform, s1_cameraSelfTransition, stage1RingeTransformingTime, selfRelativety);
                    s1_ringSelfRotator = new Rotator(ringTransform, s1_selfRingRotation, stage1RingeTransformingTime, selfRelativety);
                    s1_ringWorldTransitionar = new Transitionar(ringTransform, s1_ringWorldTransition, stage1RingeTransformingTime, worldRelativety);
                    GroupTransformers s1_g1 = new();
                    s1_g1.AddTransformers(s1_cameraWorldTransitionar, s1_cameraSelfTransitionar,
                    s1_ringSelfRotator, s1_ringWorldTransitionar);
                    stage1 = new(s1_g1);
                    currentTransformers = stage1;
                    cameraDirector.SetTarget(ringTransform, stage1RingeTransformingTime);
                    break;

                case 2:
                    s2_spaceWorldTransitionar = new Transitionar(spaceTransform, s2_spaceNewPosition, stage2TransformingTime, worldRelativety);
                    s2_spaceScaler = new Scaler(spaceTransform, spaceInitialScale, stage2TransformingTime);
                    s2_cameraWorldTransitionar = new Transitionar(cameraTransform, s2_cameraWorldTransition, stage2TransformingTime, worldRelativety);
                    s2_cameraSelfTransitionar = new Transitionar(cameraTransform, s2_cameraSelfTransition, stage2TransformingTime, selfRelativety);
                    GroupTransformers s2_g1 = new();
                    s2_g1.AddTransformers(s2_spaceWorldTransitionar, s2_cameraWorldTransitionar, s2_cameraSelfTransitionar
                    , s2_spaceScaler);
                    stage2 = new(s2_g1);
                    currentTransformers = stage2;
                    cameraDirector.SetTarget(spaceTransform, stage2TransformingTime);

                    break;
                case 3:

                    s3_spaceScaler = new Scaler(spaceTransform, -spaceTransform.localScale, stage3TransformingTime);
                    s3_spaceTransition = ringTransform.position - spaceTransform.position;
                    s3_spaceTransitioner = new Transitionar(spaceTransform, s3_spaceTransition, stage3TransformingTime, worldRelativety);
                    GroupTransformers s3_g1 = new();
                    s3_g1.AddTransformers(s3_spaceScaler, s3_spaceTransitioner);
                    Transformer s3_ringRotator = new Rotator(ringTransform, -s1_selfRingRotation, stage3TransformingTime, selfRelativety);
                    Transformer s3_ringTransitioner = new Transitionar(ringTransform, -s1_ringWorldTransition, stage3TransformingTime, worldRelativety);
                    GroupTransformers s3_g2 = new();
                    s3_g2.AddTransformers(s3_ringRotator, s3_ringTransitioner);
                    s3_cameraWorldTransitioner = new Transitionar(cameraTransform, s3_cameraTransition, stage3TransformingTime, worldRelativety);
                    GroupTransformers s3_g3 = new GroupTransformers();
                    s3_g3.AddTransformers(s3_cameraWorldTransitioner);
                    stage3 = new(s3_g1, s3_g3, s3_g2);

                    currentTransformers = stage3;
                    swordTransform.SetParent(null);
                    cameraDirector.SetTarget(swordTransform, stage3TransformingTime);
                    break;
                case 4:
                    s4_swordTransitionar = new Transitionar(swordTransform, s4_staffTransition, stage4TransformingTime, selfRelativety);
                    GroupTransformers s4_g1 = new();
                    s4_g1.AddTransformers(s4_swordTransitionar);

                    stage4 = new(s4_g1);
                    currentTransformers = stage4;

                    break;

            }

        }


    }
}
