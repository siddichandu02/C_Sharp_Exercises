using System;
using System.Collections.Generic;
using System.Text;

namespace NhibernateDemo
{
    public class Friend
    {
        public virtual long FriendId { get; set; }
        public virtual string FriendName { get; set; }
        public virtual string Place { get; set; }
    }
}
