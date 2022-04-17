using UnityEngine;

public abstract class Shape : MonoBehaviour // INHERITANCE
{
    public abstract string Name { get; } // ENCAPSULATION
    public virtual Color Color // ENCAPSULATION
    {
        get => Color.white;
        protected set => Color = value;
    }

    public virtual int Faces // ENCAPSULATION
    {
        get => 1;
        private set => Faces = value < 1 ? 1 : value;
    }

    public virtual string DisplayText() // ABSTRACTION
    {
        string result = $"The {GetColor()} {Name} has {Faces} face";
        result = Faces > 1 ? result + "s." : result + ".";

        return result;
    }

    private void Start() // POLYMORPHISM
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color;
    }

    string GetColor() // for demonstration purpose to not display RGBA value
    {
        if (Color == Color.red)
            return "red";
        else if (Color == Color.green)
            return "green";
        else if (Color == Color.yellow)
            return "yellow";
        return Color.ToString();
    }
}