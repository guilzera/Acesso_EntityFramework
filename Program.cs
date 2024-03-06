using var context = new BlogDataContext();

// context.Users.Add(new User
// {
//     Bio = "10x Microsoft MVP",
//     Email = "andre@balta.com",
//     Image = "https://balta.io",
//     Name = "André Baltieri",
//     PasswordHash = "1234",
//     Slug = "andre-baltieri"
// });
// context.SaveChanges();

var user = context.Users.FirstOrDefault(x => x.Id == 3);
var post = new Post
{
    Author = user,
    Body = "Meu artigo",
    Category = new Category {
        Name = "FullStack",
        Slug = "fullstack"
    },
    CreateDate = DateTime.Now,
    //LastUpdateDate=
    Slug = "meu-artigo",
    Summary = "Neste artigo vamos conferir...",
    //Tags=null,
    Title = "Meu artigo"
};
context.Posts.Add(post);
context.SaveChanges();