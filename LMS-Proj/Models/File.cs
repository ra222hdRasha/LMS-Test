using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LMS_Proj.Models
{
    public class File
    {
        //Primary Key
        [Key]
        public int fileId { get; set; }     

        //Attributes

        [Display(Name = "Type")]
        public FileType type { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Submission Date/Time")]
        public DateTime submissionDate { get; set; }

        [Display(Name = "File Name")]        
        public string fileName { get; set; }  // shortname on filesystem

        [Display(Name = "File Path")]        
        public string filePath { get; set; }  // basepath on filesystem

        [Display(Name = "File Link")]       
        public string fileLink { get; set; }  // http/https url
        
        [Display(Name = "Comments")]        
        public string comment { get; set; }
        
        [Display(Name = "Receiver")]        
        public ApplicationUser receiver { get; set; }

        //Visar att filen är läst eller oläst
        [Display(Name = "Read")]
        public bool readByReciever { get; set; }

        // Connection
        [Display(Name = "Owner")]
        public ApplicationUser owner { get; set; }

        public virtual ICollection<Group> Groups {get; set;}

        public virtual ICollection<Activity> Activities { get; set; }
      
    }

    public enum FileType
    {
        Exercise,
        Lesson,
        Comment,
        SharedFile,
        Etc
    }
}