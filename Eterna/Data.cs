using Eterna.Models;

namespace Eterna
{
    public static class Data
    {
        public static List<Feature> Features = new List<Feature>()
        {
            new Feature() {Id=1, Icon="bi bi-card-checklist", Title="Lorem Ipsum", Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new Feature() {Id=2, Icon="bi bi-bar-chart", Title="Dolor Sitema", Description="Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata\r\n\r\n"},
            new Feature() {Id=3, Icon="bi bi-binoculars", Title="Sed ut perspiciatis", Description="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur\r\n\r\n"},
        };
        public static List<Service> Services = new List<Service>()
        {
            new Service(){Id=1,Icon="bx bxl-dribbble", Title="Lorem Ipsum", Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi\r\n\r\n"},
            new Service(){Id=2,Icon="bx bx-file", Title="Lorem Ipsum", Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi\r\n\r\n"},
            new Service(){Id=3,Icon="bx bx-tachometer", Title="Lorem Ipsum", Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi\r\n\r\n"},
            new Service(){Id=4,Icon="bx bx-world", Title="Lorem Ipsum", Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi\r\n\r\n"},
            new Service(){Id=5,Icon="bx bx-slideshow", Title="Lorem Ipsum", Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi\r\n\r\n"},
            new Service(){Id=6,Icon="bx bx-arch", Title="Lorem Ipsum", Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi\r\n\r\n"},
        };
        public static List<TeamMember> TeamMembers = new List<TeamMember>()
        {
            new TeamMember() {Id=1, Image="../assets/img/team/team-1.jpg", Name="Walter White", Position="Chief Executive Officer", Info="Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut", TwitterUrl="www.facebook.com", FacebookUrl="www.facebook.com", InstagramUrl="www.facebook.com", LinkedinUrl="www.facebook.com"},
            new TeamMember() {Id=2, Image="../assets/img/team/team-2.jpg", Name="Sarah Jhinson", Position="Product Manager", Info="Repellat fugiat adipisci nemo illum nesciunt voluptas repellendus. In architecto rerum rerum temporibus\r\n\r\n", TwitterUrl="www.facebook.com", FacebookUrl="www.facebook.com", InstagramUrl="www.facebook.com", LinkedinUrl="www.facebook.com"},
            new TeamMember() {Id=3, Image="../assets/img/team/team-3.jpg", Name="William Anderson", Position="CTO", Info="Voluptas necessitatibus occaecati quia. Earum totam consequuntur qui porro et laborum toro des clara\r\n\r\n", TwitterUrl="www.facebook.com", FacebookUrl="www.facebook.com", InstagramUrl="www.facebook.com", LinkedinUrl="www.facebook.com"},
        };
    }
}
