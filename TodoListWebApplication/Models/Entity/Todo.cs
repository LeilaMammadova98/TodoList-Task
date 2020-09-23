using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListWebApplication.Models.Entity
{
    public class Todo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Doldurulmalıdır")]
        public string Title  { get; set; }
        [Required(ErrorMessage = "Doldurulmalıdır")]

        public string Description  { get; set; }

        public string ResponsiblePerson  { get; set; }
        public bool isComplated { get; set; }
        [BindNever]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime  CreatedDate { get; set; }
        [BindNever]
        public DateTime?  UpdatedDate { get; set; }
        [BindNever]
        public DateTime? DeletedDate { get; set; }
        public int PlId { get; set; }
        [ForeignKey("PlId")]
        public virtual ProgrammeLanguage ProgrammeLanguage { get; set; }
    }
}
