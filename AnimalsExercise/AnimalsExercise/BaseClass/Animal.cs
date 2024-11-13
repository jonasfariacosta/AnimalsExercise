namespace AnimalsExercise.BaseClass
{
    public abstract class Animal
    {
        public float Weight { get; set; }

        public Animal(float weight)
        {
            Weight = weight;
        }

        public abstract void MakeSound();
    }
}
