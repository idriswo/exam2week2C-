
public class MyPost
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int LikeCount { get; set; }
    public List<string>? Comments { get; set; }
    public bool IsPublished { get; set; }


    List<MyPost> posts = [];


    public void addPost(MyPost p)
    {
        posts.Add(p);
    }


    public void Publish()
    {
        Console.WriteLine("The post is published. ");
        IsPublished = true;
    }

    public int Like()
    {
        return LikeCount + 1;
    }

    public void Comment(string message)
    {
        Comments?.Add(message);
    }

    public void GetPosts()
    {
        Publish();
        
        Console.WriteLine($"{Title} – {Description} – number of Likes: {Like()}");
    }

}