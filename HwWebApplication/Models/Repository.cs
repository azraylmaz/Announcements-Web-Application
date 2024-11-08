namespace HwWebApplication.Models{
    public static class Repository{
        private static List<Announcement> announcements = new();
        

        static Repository(){
            announcements.Add(new Announcement(){
                Id=1, 
                Title="Artificial Intelligence Academic Thesis Program Begins", 
                Text="The program aims to increase competencies in the field of artificial intelligence in the defense industry, contribute to the need for qualified human resources in the sector and establish cooperation between academia and industry in the field of artificial intelligence. Students accepted to the program will be announced on October 31. Successful students will benefit from opportunities such as internship, candidate engineering program and project support in line with their competencies.", 
                ResponsiblePerson="Alican",
                date = new DateTime(2023, 10, 15, 14, 30, 0)
            });
            announcements.Add(new Announcement(){
                Id=2, 
                Title="2209-A - University Students Research Projects Support Program Call", 
                Text="2209-A University Students Research Projects Support Program 2024 1st semester call is open for application. Applications can be made via TUBITAK Management Information System (tybs.tubitak.gov.tr) until 17.30 on November 01, 2024.", 
                ResponsiblePerson="Nurcan",
                date = new DateTime(2024, 1, 20, 10, 15, 0)
            });
            announcements.Add(new Announcement(){
                Id=3, 
                Title="4001 National and International Competition/Event Participation Support 2nd Call", 
                Text="The 2nd call for 4001 National and International Competition/Event Participation Support, whose first call period was held between August 2 and September 30, was published on October 1, 2024 and opened for application.", 
                ResponsiblePerson="Gülcan",
                date = new DateTime(2024, 3, 5, 9, 45, 0)
            });
                announcements.Add(new Announcement(){
                Id=4, 
                Title="Adaptation to University Life Program", 
                Text="An orientation program has been organized for our new students to get to know university life and Sakarya University more closely; the topics, programs, people and places to be informed are attached.", 
                ResponsiblePerson="Mehmetcan",
                date = new DateTime(2024, 5, 25, 13, 0, 0)
            });
        }

        

        public static List<Announcement> Announcements{
            get{
               return announcements;
            }
        }

        public static void CreateAnnouncement(Announcement model)
        {
            model.Id = Announcements.Count + 1;
            model.date = DateTime.Now;
            announcements.Add(model);
        }

        public static Announcement? GetById(int id)
        {
            return announcements.FirstOrDefault(model => model.Id == id);
        }

    }
}