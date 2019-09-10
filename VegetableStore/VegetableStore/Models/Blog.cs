using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Models.Enums;

namespace VegetableStore.Models
{
    [Table("Blogs")]
    public class Blog: DomainEntity<int>
    {
        public Blog()
        {
        }

        public Blog(string title, string image, DateTime dateCreated, int vote, string content, string tags, Status status)
        {
            Title = title;
            Image = image;
            DateCreated = dateCreated;
            Vote = vote;
            Content = content;
            Tags = tags;
            Status = status;
        }

        public Blog(string title, int vote, string image, string content, string tags, DateTime dateCreated, DateTime dateModified, Status status)
        {
            Title = title;
            Vote = vote;
            Image = image;
            Content = content;
            Tags = tags;
            DateCreated = dateCreated;
            DateModified = dateModified;
            Status = status;
        }

        [StringLength(255)]
        [Required]
        public string Title { get; set; }
        public int Vote { get; set; }
        [StringLength(255)]
        public string Image { get; set; }

        public string Content { get; set; }

        [StringLength(255)]
        public string Tags { get; set; }

        public DateTime DateCreated { set; get; }

        public DateTime DateModified { set; get; }

        public Status Status { set; get; }
        
    }
}
