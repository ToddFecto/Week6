using System;
using System.Collections.Generic;
using System.Threading;

namespace DriveRatingApp_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamMember> teamMembers = TeamMemberRepo.GetTeamMembers();
            bool returnToTitleScreen = true;

            while (returnToTitleScreen)
            {
                Console.Write("Enter your CommonID: ");
                string userCommonId = Console.ReadLine().ToLower();
                TeamMember user = GetTMByCommonID(teamMembers, userCommonId);
                
                Thread.Sleep(1000);
                Console.Clear();

//team member flow
                if (user.CommonId[0] == 't')
                {
                    double bonus = user.DetermineBonus();
                    Console.WriteLine(
                        $"{user.FirstName}, Your current Drive Rating is {user.DriveRating} and you will receive {bonus:C} as a bonus.");

                    Console.Write("Return to Title Screen (1)Yes or (2)Exit: ");
                    string choiceToReturn = Console.ReadLine();

                    if (choiceToReturn != "1")
                    {
                        returnToTitleScreen = false;
                    }
                    
                    Thread.Sleep(1000);
                    Console.Clear();
                }

//leader flow
                if (userCommonId[0] == 'l')
                {
                    bool returnToLeaderMenu = true;
                    while (returnToLeaderMenu)
                    {
                        Console.Write("Would you like to (1)Update a Drive Rating or (2)View Bonus Report: ");
                        string leaderChoice = Console.ReadLine().ToLower();
                        
                        Thread.Sleep(1000);
                        Console.Clear();

                        if (leaderChoice == "1")
                        {
                            Console.Write("Enter TM CommonID: ");
                            string tmCommonID = Console.ReadLine().ToLower();
                            
                            Thread.Sleep(1000);
                            Console.Clear();

                            TeamMember tm = GetTMByCommonID(teamMembers, tmCommonID);

                            if (tm.CommonId[0] != 'l' && tm.CommonId[0] != 'd')
                            {
                                Console.Write(
                                    "Choose Drive Rating: (1)Needs Improvement (2)Achieves Expectation (3)Exceeds Expectations (4)RockStar: ");
                                string updatedDriveRating = Console.ReadLine().ToLower();
                                
                                Thread.Sleep(1000);
                                Console.Clear();

                                UpdateDriveRating(updatedDriveRating, tm);

                                Console.WriteLine("Drive Rating has been updated.");
                                
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("You do not have permissions to update leadership.");
                                
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                        }
                        else if (leaderChoice == "2")
                        {
                            Console.WriteLine(
                                $"Your DRIVE rating is {user.DriveRating} and your bonus is {user.DetermineBonus():C}");
                            Console.WriteLine();
                            Console.WriteLine("Team Members:");

                            foreach (var tm in teamMembers)
                            {
                                if (tm.CommonId[0] != 'l' && tm.CommonId[0] != 'd')
                                {
                                    Console.WriteLine(
                                        $"{tm.LastName},{tm.FirstName} DRIVE rating is {tm.DriveRating} and their bonus is {tm.DetermineBonus():C}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please make a valid selection.");
                            
                            Thread.Sleep(1000);
                            Console.Clear();
                        }

                        Console.Write("Return to Leader Menu (1)Yes or (2)No: ");
                        string userChoice = Console.ReadLine();

                        if (userChoice != "1")
                        {
                            returnToLeaderMenu = false;
                        }
                        
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                    Console.Write("Return to Title Screen (1)Yes or (2)Exit: ");
                    string choiceToReturn = Console.ReadLine();

                    if (choiceToReturn != "1")
                    {
                        returnToTitleScreen = false;
                    }
                    
                    Thread.Sleep(1000);
                    Console.Clear();
                }

                //director flow
                if (userCommonId[0] == 'd')
                {
                    Director director = user as Director;
                    
                    
                    bool returnToDirectorMenu = true;
                    while (returnToDirectorMenu)
                    {
                        Console.Write("Would you like to (1)Update a Drive Rating or (2)View Bonus Report: ");
                        string directorChoice = Console.ReadLine().ToLower();
                        
                        Thread.Sleep(1000);
                        Console.Clear();
                        
                        if (directorChoice == "1")
                        {
                            Console.Write("Enter TM CommonID: ");
                            string tmCommonID = Console.ReadLine().ToLower();
                            
                            Thread.Sleep(1000);
                            Console.Clear();

                            TeamMember tm = GetTMByCommonID(teamMembers, tmCommonID);

                            Console.Write(
                                "Choose Drive Rating: (1)Needs Improvement (2)Achieves Expectation (3)Exceeds Expectations (4)RockStar: ");
                            string updatedDriveRating = Console.ReadLine().ToLower();
                            
                            Thread.Sleep(1000);
                            Console.Clear();

                            UpdateDriveRating(updatedDriveRating, tm);

                            Console.WriteLine("Drive Rating has been updated.");
                            
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        else if (directorChoice == "2")
                        {
                            director.DetermineDriveRating(teamMembers);
                            Console.WriteLine(
                                $"Your DRIVE rating is {director.DriveRating} and your bonus is {director.DetermineBonus():C}");
                            Console.WriteLine();

                            Console.WriteLine("Team Members: ");

                            foreach (var tm in teamMembers)
                            {
                                if (tm.CommonId[0] != 'd')
                                {
                                    Console.WriteLine(
                                        $"{tm.LastName},{tm.FirstName} DRIVE rating is {tm.DriveRating} and their bonus is {tm.DetermineBonus():C}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please make a valid selection.");
                            
                            Thread.Sleep(1000);
                            Console.Clear();
                        }

                        Console.Write("Return to Director Menu (1)Yes or (2)No: ");
                        string userChoice = Console.ReadLine();
                        
                        Thread.Sleep(1000);
                        Console.Clear();

                        if (userChoice != "1")
                        {
                            returnToDirectorMenu = false;
                        }
                    }

                    Console.Write("Return to Title Screen (1)Yes or (2)Exit: ");
                    string choiceToReturn = Console.ReadLine();
                    
                    Thread.Sleep(1000);
                    Console.Clear();

                    if (choiceToReturn != "1")
                    {
                        returnToTitleScreen = false;
                    }
                }
            }

            Console.Write("Enter any key to EXIT: ");
            Console.ReadLine();
        }

        private static void UpdateDriveRating(string updatedDriveRating, TeamMember tm)
        {
            switch (updatedDriveRating)
            {
                case "1":
                    tm.DriveRating = DriveRating.NeedsImprovement;
                    break;
                case "2":
                    tm.DriveRating = DriveRating.AchievingExpectations;
                    break;
                case "3":
                    tm.DriveRating = DriveRating.ExceedExpectations;
                    break;
                case "4":
                    tm.DriveRating = DriveRating.RockStar;
                    break;
                default:
                    Console.WriteLine("Please select a valid choice");
                    break;
            }
        }

        private static TeamMember GetTMByCommonID(List<TeamMember> teamMembers, string userCommonId)
        {
            TeamMember user = null;
            foreach (var tm in teamMembers)
            {
                if (tm.CommonId == userCommonId)
                {
                    user = tm;
                }
            }

            return user;
        }
    }
}