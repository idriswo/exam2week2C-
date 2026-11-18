// MyMath math = new MyMath();


// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(math.Abs(n));


// double double1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(math.AbsDouble(double1));


// double x = Convert.ToDouble(Console.ReadLine());
// double y = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(math.Pow(x,y));


// int nSqrt = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(math.Sqrt(nSqrt));


// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(math.Max(a,b));


// int a1 = Convert.ToInt32(Console.ReadLine());
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(math.Min(a1,b1));


MyPost myPost = new MyPost()
{
    Title = "Abdulaziz",
    Description = "pisari zebo",
    LikeCount = 15,
    Comments = ["boaql" , "dono" , "owiq"],
    IsPublished = true
};

MyPost myPost2 = new MyPost()
{
    Title = "idris",
    Description = "pisar",
    LikeCount = 16,
    Comments = ["boaql" , "dono" , "owiq"],
    IsPublished = true
};

MyPost myPost3 = new MyPost()
{
    Title = "Muhammad",
    Description = "pisar",
    LikeCount = 16,
    Comments = ["boaql" , "dono" , "owiq"],
    IsPublished = true
};

MyPost myPost4 = new MyPost()
{
    Title = "Ahmad",
    Description = "pisar",
    LikeCount = 16,
    Comments = ["boaql" , "dono" , "owiq"],
    IsPublished = true
};

MyPost myPost5 = new MyPost()
{
    Title = "Abdullo",
    Description = "pisar",
    LikeCount = 16,
    Comments = ["boaql" , "dono" , "owiq"],
    IsPublished = true
};


myPost.addPost(myPost);
myPost.Like();
myPost.GetPosts();


myPost2.addPost(myPost);
myPost2.Like();
myPost2.GetPosts();


myPost3.addPost(myPost);
myPost3.Like();
myPost3.GetPosts();

myPost4.addPost(myPost);
myPost4.Like();
myPost4.GetPosts();

myPost5.addPost(myPost);
myPost5.Like();
myPost5.GetPosts();