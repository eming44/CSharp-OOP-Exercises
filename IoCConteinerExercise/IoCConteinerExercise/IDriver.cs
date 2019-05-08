namespace IoCConteinerExercise
{
    public interface IDriver
    {
        int YearsOld { get; set; }
        int ExperienceYears { get; set; }
        bool ProfessionalDriver { get; set; }

        void RunCar();
    }
}