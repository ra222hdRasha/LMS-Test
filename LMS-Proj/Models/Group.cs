using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS_Proj.Models
{
    public class Group
    {
        //Primary Key
        [Key]
        public int groupID { get; set; }        


        //Attributes
        [Display(Name = "Max. No. of Members")]
        public int maxMembers { get; set; }

        [Display(Name = "Group Name")]
        public string groupName { get; set; }

        [Display(Name = "Location")]
        public string classLocation { get; set; }

        [Display(Name = "Description")]
        public string groupDescription { get; set; }


        //Connections
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
 

    }
}