using System;

namespace Develop05
{
    public abstract class CompletableGoal : Goal
    {
        protected bool _isCompleted = false;

        public CompletableGoal(string name, string description, int points)
            :   base(name, description, points)
        {

        }

        public override string ToString()
        {
            return $"{_name},{_description},{_points},{_isCompleted}";
        }
    }
}


