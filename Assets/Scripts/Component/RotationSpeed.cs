using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct RotationSpeed : IComponentData
{
    public float RadiansPerSecond;
}