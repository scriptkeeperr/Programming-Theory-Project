using UnityEngine;

public class Capsule : Shape // INHERITANCE
{
    public override string Name { get => "capsule"; } // POLYMORPHISM
    public override Color Color => Color.yellow; // POLYMORPHISM
}