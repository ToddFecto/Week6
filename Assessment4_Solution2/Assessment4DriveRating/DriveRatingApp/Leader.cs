namespace DriveRatingApp
{
	public class Leader : TeamMember
	{
		public Leader(string firstName, string lastName, string commonId, DriveRating driveRating): base(firstName, lastName, commonId, driveRating)
		{

		}
		public override double CalculateBonus()
		{
			return base.CalculateBonus() * 2;
		}
	}
}
