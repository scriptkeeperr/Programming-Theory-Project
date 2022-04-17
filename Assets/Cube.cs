using UnityEngine;

public class Cube : Shape // INHERITANCE
{
    public override string Name { get => "cube"; } // POLYMORPHISM
    public override Color Color => Color.red; // POLYMORPHISM
    public override int Faces => 6; // POLYMORPHISM
}
