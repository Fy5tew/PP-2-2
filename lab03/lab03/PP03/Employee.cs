using Lec03BLibN;

namespace PP03
{
    public class Employee
    {
        public IBonus Bonus { get; private set; }

        public Employee(IBonus bonus)
        {
            Bonus = bonus;
        }

        public float CalculateBonus(float numberOfHours)
        {
            return Bonus.Calculate(numberOfHours);
        }
    }
}
