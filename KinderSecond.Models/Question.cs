using System.Collections.Generic;

namespace KinderSecond.Models
{
    public class Question
    {
        private ICollection<Answer> answers;
        public Question()
        {
            this.answers = new HashSet<Answer>();
        }
        public int Id {get; set;}
        public int RightId { get; set; }
        public virtual ICollection<Answer> Answers
        {
            get { return this.answers; }
            set { this.answers = value; }
        }
    }
}