namespace FirstApp.Models
{
     public static class Repository  {
        private static List<Candidate> applications =  new();
        public static IEnumerable<Candidate> Applications => applications;

        public static void AddApplication(Candidate application) {
            applications.Add(application);
        }
     }
    
}