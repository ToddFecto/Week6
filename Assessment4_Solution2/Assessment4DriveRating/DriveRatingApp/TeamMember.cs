namespace DriveRatingApp
{
	public class TeamMember
	{

		public string FirstName { get; set; }
	
		public string LastName { get; set; }

		public string CommonId { get; set; }

		public DriveRating DriveRating { get; set; }
		public TeamMember(string firstName, string lastName, string comminId, DriveRating driveRating)
		{
			FirstName = firstName;
			LastName = lastName;
			CommonId = comminId;
			DriveRating = driveRating;
		}

		public virtual double CalculateBonus()
		{
			
			if (DriveRating == DriveRating.AchievingExpectations)
			{
				return 1000;
			}
			if (DriveRating == DriveRating.ExceedExpectations)
			{
				return	5000;
			}
			if (DriveRating == DriveRating.RockStar)
			{
				return 10000;
			}
			else
			{
				return 0;
			}
		}

		public override string ToString()
		{
			return $"Name: {FirstName}. Drive Rating is {DriveRating} and bonus is ${CalculateBonus()}";
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
