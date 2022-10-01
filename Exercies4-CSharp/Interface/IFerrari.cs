namespace Exercies4_CSharp.Interface
{
    public interface IFerrari
    {
        string Model { get; }

        string Driver { get; }

        string Brakes();

        string GasPedal();
    }
}