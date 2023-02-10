namespace DriveRatingApp_Solution
{
    public class TeamMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CommonId { get; set; }
        public DriveRating DriveRating { get; set; }

        public TeamMember(string firstName, string lastName, string commonId, DriveRating driveRating)
        {
            FirstName = firstName;
            LastName = lastName;
            CommonId = commonId;
            DriveRating = driveRating;
        }

        public virtual double DetermineBonus()
        {
            if (DriveRating == DriveRating.NeedsImprovement)
            {
                return 0;
            }
            
            if (DriveRating == DriveRating.AchievingExpectations)
            {
                return 1000;
            }
            
            if (DriveRating == DriveRating.ExceedExpectations)
            {
                return 5000;
            }
            
            return 10000;
        }
    }

    public enum DriveRating
    {
        NeedsImprovement,
        AchievingExpectations,
        ExceedExpectations,
        RockStar
    }
}