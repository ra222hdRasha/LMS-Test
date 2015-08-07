using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Proj.Models
{
    public class Activity
    {
        //Primary Key
        [Key]
        public int activityId { get; set;}

        [Display(Name = "Name")]
        public string name { get; set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? StartDate { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        // ToDo:       
        //[Display(Name = "Attachment")]
        //public linkedFile { get; set; }

        // Connection
        [Display(Name = "Group")]
        public Group Group { get; set;}

        public File Attachment { get; set; }
        
        //[ForeignKey("ownerGroupId")]
        //public virtual Group groups { get; set; }

    }
}