using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

public partial class RotationSpeedSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;

        Entities
            .WithName("RotationSpeedSystem")
            // �׻� ref ������ in �� �־���Ѵ�.
            .ForEach((ref Rotation rotation, in RotationSpeed rotationSpeed) => {

                rotation.Value = math.mul(
                        math.normalize(rotation.Value),
                        quaternion.AxisAngle(math.up(), rotationSpeed.RadiansPerSecond * deltaTime));

            }).ScheduleParallel();
    }
}