namespace OPD_Application.Exceptions
{
    public class StudentNotFoundException : ApplicationException
    {
        public StudentNotFoundException(string message) : base(message)
        {
        }
    }
}
