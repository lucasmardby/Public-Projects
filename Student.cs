namespace First_Repository
{
    public class Student
    {
        public string Name;
        private string Space;
        private int Sum;
        public decimal Score;
        public string Grade;
        //Class average method?
        
        /*
        Add dictionary for subjects
        Dictionary<string, int> openWith =
            new Dictionary<string, int>();
        */

        private int Math;
        private int Biology;
        private int Physics;
        private int Chemistry;
        private int Programming;

        public Student(string name, int math, int biology, int physics, int chemistry, int programming)
        {
            this.Name = name;
            
            this.Math = math;
            this.Biology = biology;
            this.Physics = physics;
            this.Chemistry = chemistry;
            this.Programming = programming;

            Sum = math + biology + physics + chemistry + programming;
            Score = Sum / 5.0m;
        }
        public string Grading()
        {
            switch (Score)
            {
                case > 97:
                    Grade = "A+";
                    return Grade;
                case > 93:
                    Grade = "A";
                    return Grade;
                case > 90:
                    Grade = "A-";
                    return Grade;
                case > 87:
                    Grade = "B+";
                    return Grade;
                case > 83:
                    Grade = "B";
                    return Grade;
                case > 80:
                    Grade = "B-";
                    return Grade;
                case > 77:
                    Grade = "C+";
                    return Grade;
                case > 73:
                    Grade = "C";
                    return Grade;
                case > 70:
                    Grade = "C-";
                    return Grade;
                case > 67:
                    Grade = "D+";
                    return Grade;
                case > 63:
                    Grade = "D";
                    return Grade;
                case > 60:
                    Grade = "D-";
                    return Grade;
                default:
                    Grade = "E";
                    return Grade;
            }
        }
        public string FirstSpacing()
        {
            if (Name.Length > 6)
            {
                this.Space = ":\t";
                return Space;
            }
            else
            {
                this.Space = ":\t\t";
                return Space;
            }
        }
    }
}
