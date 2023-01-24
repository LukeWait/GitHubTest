/*
	testbranch changes changes changes
	File name:	Dog.cs 
	Purpose:	Class to describe pet dog
	Author:		Luke Wait
	Date:		24-Jan-2023
	Version:	1.0
	Notes:
*/ 


namespace VetPractice
{
	public class Dog : IComparable<Dog>
	{
		public string Name {get; set;}
		public string Type {get; set;}
		public string Sex {get; set;}
		public bool IsDesexed {get; set;}
		
		public Dog (string name, string type, string sex, bool isDesexed)
		{
			Name = name;
			Type = type;
			Sex = sex;
			IsDesexed = isDesexed;
		}
		
		public int CompareTo(Dog otherDog)
		{
			return Name.CompareTo(otherDog.Name);
		}
	
	} // end Dog class

} // end namespace
