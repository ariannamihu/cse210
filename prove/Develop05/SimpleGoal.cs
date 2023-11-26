using System.Numerics;

namespace Develop05
{
    public class SimpleGoal : CompletableGoal
    {   
        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {

        }

        public override int RecordEvent()
        {
            Console.WriteLine($"Your goal has been recorded and {_points} points have been added");
            _isCompleted = true;
            return _points;
        }

        public override string ToSavedString(string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
                outputFile.WriteLine($"2,{this.ToString()},1");
            }

            return this.ToString();
        }
    }
}
