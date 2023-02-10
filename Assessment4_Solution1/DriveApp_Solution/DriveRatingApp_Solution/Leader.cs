namespace DriveRatingApp_Solution
{
    public class Leader: TeamMember
    {
        
        public Leader(string firstName, string lastName, string commonId, DriveRating driveRating) : base(firstName, lastName, commonId, driveRating)
        {
        }
        public override double DetermineBonus()
        {
            return base.DetermineBonus() *2;
        }
    }
}