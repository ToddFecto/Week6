using System.Collections.Generic;

namespace DriveRatingApp_Solution
{
    public class Director : TeamMember
    {
        public Director(string firstName, string lastName, string commonId, DriveRating driveRating) : base(firstName,
            lastName, commonId, driveRating)
        {
        }

        public override double DetermineBonus()
        {
            return base.DetermineBonus() * 3;
        }

        public void DetermineDriveRating(List<TeamMember> teamMembers)
        {
            int numberOfRockStars = 0;
            int numberOfExceeds = 0;
            int numberOfAchieves = 0;
            int numberOfNeedsImprovement = 0;

            foreach (var tm in teamMembers)
            {
                if (tm.DriveRating == DriveRating.RockStar)
                {
                    numberOfRockStars++;
                }

                if (tm.DriveRating == DriveRating.ExceedExpectations)
                {
                    numberOfExceeds++;
                }

                if (tm.DriveRating == DriveRating.AchievingExpectations)
                {
                    numberOfAchieves++;
                }

                if (tm.DriveRating == DriveRating.NeedsImprovement)
                {
                    numberOfNeedsImprovement++;
                }
            }

            if (numberOfNeedsImprovement == 0 && numberOfAchieves == 0 && numberOfExceeds > 0)
            {
                DriveRating = DriveRating.RockStar;
            }
            else if (numberOfExceeds >= 3 && numberOfNeedsImprovement == 0)
            {
                DriveRating = DriveRating.ExceedExpectations;
            }
            else if (numberOfNeedsImprovement <= 1 && numberOfAchieves > 0)
            {
                DriveRating = DriveRating.AchievingExpectations;
            }
            else
            {
                DriveRating = DriveRating.NeedsImprovement;
            }
        }
    }
}