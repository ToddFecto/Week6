using System.Collections.Generic;

namespace DriveRatingApp
{
	public class Director : TeamMember
	{
		public Director(string firstName, string lastName, string commonId, DriveRating driveRating) : base(firstName, lastName, commonId, driveRating)
		{

		}
		public override double CalculateBonus()
		{
			return base.CalculateBonus() * 3;
		}

		public void CalculateDriveRating(List<TeamMember> tms)
		{
			int exceedsExpectations = 0;
			int needsImprovement = 0;
			int achievesExpectations = 0;
			foreach(TeamMember tm in tms)
			{
				if(tm.DriveRating == DriveRating.ExceedExpectations)
				{
					exceedsExpectations++;
				}
				if (tm.DriveRating == DriveRating.NeedsImprovement) 
				{ 
					needsImprovement++;
				}
				if (tm.DriveRating == DriveRating.AchievingExpectations)
				{
					achievesExpectations++;
				}
			}
			if(exceedsExpectations == tms.Count)
			{
				DriveRating = DriveRating.RockStar;
			}
			if(exceedsExpectations <= 3 && needsImprovement == 0)
			{
				DriveRating = DriveRating.ExceedExpectations;
			}
			if(needsImprovement <= 1)
			{
				DriveRating = DriveRating.AchievingExpectations;			
			}
			if(needsImprovement >= 2)
			{
				DriveRating = DriveRating.NeedsImprovement;
			}
		}
	}
}
