using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[BurstCompile]
partial struct CannonColoringJob : IJobEntity
{
    public EntityCommandBuffer.ParallelWriter ECB;

    public float4 Color;

    void Execute()
    {
        
    }
}
