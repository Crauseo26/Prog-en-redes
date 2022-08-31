using System;
namespace Obligatorio
{
    public class WorkProfile
    {
        private User User { get; set; }
        private string Description { get; set; }
        private IList<string> Skills { get; set; }

        public WorkProfile(User user)
        {
            this.User = user;
            this.Description = "";
            this.Skills = new List<string>();
        }

    }
}

