namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Publisher publisher = new Publisher();
           Student student = new Student();
           Employee employee = new Employee();
           //subsciption
           publisher.IsArived += student.IsArrivedStudent;
           publisher.IsArived += employee.IsArrivedEmployee;

            Web web = new Web();
            web.IsArived += student.IsArrivedStudent;
            //publisher.IsArived -= employee.IsArrivedEmployee;
            //publisher.IsArived = employee.IsArrivedEmployee;// not valid
            //publisher.IsArived = null; // not valid


            publisher.Notify(new EventData { Message="meeeee"});
            web.Notify(new EventData { Message = "l;k;lkl;k;l" });
        }
    }
}