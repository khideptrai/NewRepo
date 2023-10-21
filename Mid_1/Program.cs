using Mid_1;

class Program
{
    public static void Main(string[] args)
    {
        int option;
        TestStudent testSt = new TestStudent();
        while (true)
        {
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("====================================================================");
            Console.WriteLine("1. Input information (input details for a student)");
            Console.WriteLine("2. Sorting student asccending by average mark");
            Console.WriteLine("3. Display all the student.");
            Console.WriteLine("4. Search Student by Name.");
            Console.WriteLine("5. Delete Student by student ID.");
            Console.WriteLine("6. Exit program.");
            Console.WriteLine("====================================================================");
            Console.Write("Option: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    testSt.AddStudent();
                    break;
                case 2:
                    testSt.SortByMarkAVG();
                    break;
                case 3:
                    testSt.ShowListStudent();
                    break;
                case 4:
                    Console.WriteLine("Nhap ten hoc sinh ban muon tin:");
                    string name = Console.ReadLine();
                    testSt.GetStudent(name);
                    break;
                case 5:
                    Console.WriteLine("Nhap id hoc sinh muon xoa: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    testSt.DeleteStudentById(id);
                    break;
                case 6:
                    return;
            }
        }
 
    }
}