namespace Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Eager Execution
            //var CouresDto = SampleData.Courses.FilterV1(a => a.Hours >= 45).MySelect(a => new { a.Name, a.Hours });
            //foreach (var course in CouresDto)
            //{
            //    Console.WriteLine(course.Name);
            //}

            //Defferd Execution
            var CouresDto = SampleData.Courses.FilterV2(a => a.Hours >= 45).MySelect(a=> new  { a.Name, a.Hours });
            foreach (var course in CouresDto)
            {
                Console.WriteLine(course.Name);
            }

            
        }
    }
}
