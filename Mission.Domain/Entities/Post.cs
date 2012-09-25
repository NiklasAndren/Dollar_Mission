using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission.Domain.Entities.News
{
    class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
        public int Type { get; set; }
    }
}
