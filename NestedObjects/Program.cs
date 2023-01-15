
using NestedObjects;

Advisor ScienceAdvisor = new() {
	Email = "Bacon@school.com",
	FullName = "Alfred Bacon",
	OfficeLocation = "B4 Rm 234"
};

Student student1 = new Student() {
	FirstName = "David",
	LastName = "Bacon",
	DateOfBirth = new DateOnly(1996, 4, 25),
	AssignedAdvisor = ScienceAdvisor,
	PhoneNumber = "3605462020",
	SchoolEmail = "Bacon2@school.com"
};

Console.WriteLine($"Student: {student1.FirstName} has {student1.AssignedAdvisor.FullName} for their advisor");
