using System;
using System.Collections.Generic;

namespace DriveRatingApp
{
	class Program
	{
		static void Main(string[] args)
		{
			List<TeamMember> teamMembers = TeamMemberRepo.GetTeamMembers();
			string goAgain = "y";
			while (goAgain == "y")
			{
				Console.WriteLine("Please enter your CommonId:");
				string commonId = Console.ReadLine();

				// TeamMember logic
				if (commonId.StartsWith('t'))
				{
					foreach (TeamMember tm in teamMembers)
					{
						if (tm.CommonId == commonId)
						{
							Console.WriteLine(tm); ;
						}
					}
				}

				// Leader logic
				if (commonId.StartsWith('l'))
				{
					// Get the leader
					Leader leader = null;
					foreach (TeamMember tm in teamMembers)
					{
						if (tm.CommonId == commonId)
						{
							leader = (Leader)tm;
						}
					}
					string leaderContinue = "y";
					while (leaderContinue == "y")
					{
						Console.WriteLine("Would you like to update a drive rating or see a report (1/2)?");
						int leaderMenuChoice = int.Parse(Console.ReadLine());
						if (leaderMenuChoice == 1)
						{
							Console.WriteLine("Enter the CommonId of the Team Member you would like to update: ");
							string tmId = Console.ReadLine();
							while (tmId.StartsWith('l') || tmId.StartsWith('d'))
							{
								Console.WriteLine("Error - you don't have access to that Team Member. Please enter another Id: ");
								tmId = Console.ReadLine();
							}
							foreach (TeamMember tm in teamMembers)
							{
								if (tm.CommonId == tmId)
								{
									Console.WriteLine($"What would you like to update the Drive Rating for {tm.FirstName} to? 1) Needs improvement, 2) Achieves Expectations, 3) Exceeds Expectations, 4) Rockstar?");
									int driveRatingChoice = int.Parse(Console.ReadLine());
									if (driveRatingChoice == 1)
									{
										tm.DriveRating = DriveRating.NeedsImprovement;
									}
									if (driveRatingChoice == 2)
									{
										tm.DriveRating = DriveRating.AchievingExpectations;
									}
									if (driveRatingChoice == 3)
									{
										tm.DriveRating = DriveRating.ExceedExpectations;
									}
									if (driveRatingChoice == 4)
									{
										tm.DriveRating = DriveRating.RockStar;
									}
								}
							}
						}
						if (leaderMenuChoice == 2)
						{
							Console.WriteLine(leader);
							Console.WriteLine();
							foreach (TeamMember tm in teamMembers)
							{
								if (tm.CommonId.StartsWith('t'))
								{
									Console.WriteLine(tm);
								}
							}
						}
						Console.WriteLine("Would you like to return to the leader menu? (y/n)");
						leaderContinue = Console.ReadLine();
					}
				}

				// Director logic
				if (commonId.StartsWith('d'))
				{
					// Get the director
					Director director = null;
					foreach (TeamMember tm in teamMembers)
					{
						if (tm.CommonId == commonId)
						{
							director = (Director)tm;
						}
					}
					string directorContinue = "y";
					while (directorContinue == "y")
					{
						Console.WriteLine("Would you like to update a drive rating or see a report (1/2)?");
						int directorMenuChoice = int.Parse(Console.ReadLine());
						if (directorMenuChoice == 1)
						{
							Console.WriteLine("Enter the CommonId of the Team Member you would like to update: ");
							string tmId = Console.ReadLine();
							foreach (TeamMember tm in teamMembers)
							{
								if (tm.CommonId == tmId)
								{
									Console.WriteLine($"What would you like to update the Drive Rating for {tm.FirstName} to? 1) Needs improvement, 2) Achieves Expectations, 3) Exceeds Expectations, 4) Rockstar?");
									int driveRatingChoice = int.Parse(Console.ReadLine());
									if (driveRatingChoice == 1)
									{
										tm.DriveRating = DriveRating.NeedsImprovement;
									}
									if (driveRatingChoice == 2)
									{
										tm.DriveRating = DriveRating.AchievingExpectations;
									}
									if (driveRatingChoice == 3)
									{
										tm.DriveRating = DriveRating.ExceedExpectations;
									}
									if (driveRatingChoice == 4)
									{
										tm.DriveRating = DriveRating.RockStar;
									}
								}
							}
						}
						if (directorMenuChoice == 2)
						{
							// Update the director's DriveRating and print their report
							director.CalculateDriveRating(teamMembers);
							Console.WriteLine(director);
							Console.WriteLine();
							foreach (TeamMember tm in teamMembers)
							{
								if (tm.CommonId != director.CommonId)
								{
									Console.WriteLine(tm);
								}
							}
						}
						Console.WriteLine("Would you like to return to the director menu?(y/n)");
						directorContinue = Console.ReadLine();
					}
				}
				Console.WriteLine("Would you like to return to the main menu?");
				goAgain = Console.ReadLine();
			}
		}
	}
}