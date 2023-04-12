namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }              // prop + tab = the function

        // for our calculating max result
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }


        public float Average 
        {   get
            {
                return this.Sum / this.Count;
            }

        }

        // private means, that we only operate inside
        public char AverageLetter 
        {   get
            {
                switch (this.Average)
                {
                    case var average when average >= 80:
                        return 'A';
                    case var average when average >= 60:
                        return 'B';
                    case var average when average >= 40:
                        return 'C';
                    case var average when average >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()                                     // to create a constructor = ctor + TAB
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);
        }

    }
}
