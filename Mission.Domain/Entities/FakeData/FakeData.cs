using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mission.Domain.Entities.Abstract;


namespace Mission.Domain.Entities.FakeData 
{
    public class FakeData 
    {
    //Fake users
        public static User firstTestUser { get { return new User{ Username = "Test 1", Password ="pass", Role = Role.User, ID = Guid.NewGuid() }; } }
        public static User secondTestUser { get { return new User { Username = "Test 2", Password = "pass", Role = Role.User, ID = Guid.NewGuid() }; } }
        public static User thirdTestUser { get { return new User { Username = "Test 3", Password = "pass", Role = Role.User, ID = Guid.NewGuid() }; } }

        public static List<User> testUserList { get { return new List<User> { firstTestUser, secondTestUser, thirdTestUser }; } }

    //Fake posts till blog
        public static Post firstTestPost { get { return new Post { ID = Guid.NewGuid(), Body = "test body 1", Date = DateTime.Now, Title = "test title 1", Type = Type.Blog }; } }
        public static Post secondTestPost { get { return new Post { ID = Guid.NewGuid(), Body = "test body 2", Date = DateTime.Now, Title = "test title 2", Type = Type.Blog }; } }
        public static Post thirdTestPost { get { return new Post { ID = Guid.NewGuid(), Body = "test body 3", Date = DateTime.Now, Title = "test title 3", Type = Type.Blog }; } }

        public static List<Post> testPostList { get { return new List<Post> { firstTestPost, secondTestPost, thirdTestPost }; } }

    //fake news
        public static Post firstTestNews { get { return new Post { ID = Guid.NewGuid(), Body = "test body 1 newwws", Date = DateTime.Now, Title = "test title 1", Type = Type.News }; } }
        public static Post secondTestNews { get { return new Post { ID = Guid.NewGuid(), Body = "test body 2 neweews", Date = DateTime.Now, Title = "test title 2", Type = Type.News }; } }
        public static Post thirdTestNews { get { return new Post { ID = Guid.NewGuid(), Body = "test body 3   news?", Date = DateTime.Now, Title = "test title 3", Type = Type.News }; } }

        public static List<Post> testNewsList { get { return new List<Post> { firstTestNews, secondTestNews, thirdTestNews }; } }



    }
}
