using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
    public override string Name { get => "sphere"; } // POLYMORPHISM
    public override Color Color => Color.green; // POLYMORPHISM
}
