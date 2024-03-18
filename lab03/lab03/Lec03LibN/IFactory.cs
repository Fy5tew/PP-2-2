namespace Lec03BLibN
{
    public interface IFactory
    {
        IBonus GetA(float costOneHour);
        IBonus GetB(float costOneHour, float x);
        IBonus GetC(float costOneHour, float x, float y);
    }
}
