using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace friends.Models
{
    public class Friend
    {
        public long Id { get; set; }

        [Required]
        public int FriendId { get; set; }
        [Required]
        public string FriendName { get; set; }
        [MaxLength(25, ErrorMessage = "Friend's place must not be greater than 25 characters")]
        public string Place { get; set; }

    }
}
