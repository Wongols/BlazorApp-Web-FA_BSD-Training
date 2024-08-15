
/*
using System.Net.Http;

namespace BlazorApp_FA_BSD_Training.Data;

public class BlogPostService
{

    private readonly HttpClient _httpClient;

    public BlogPostService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<BlogPost>> GetBlogPosts()
    {
        return await _httpClient.GetFromJsonAsync<List<BlogPost>>("/BlogPosts");
    }
}



*/

namespace BlazorApp_FA_BSD_Training.Data;

    public class BlogPostService
    {
        public Task<List<BlogPost>> GetBlogPosts()
        { 
        List<BlogPost> blogPosts = new();
        blogPosts.Add(new BlogPost
        {
            Title = "This is a static blog post",
            Author = "Author Name",
            Category = "dotnet",
            Content = "This is the post content, we can add whatever we want here.Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
            DateCreated = DateTime.Parse("01/01/2023")
        });
        blogPosts.Add(new BlogPost
        {
            Title = "This is the second blog post",
            Author = "Author Name",
            Category = "dotnet",
            Content = "This is the post content, we can add whatever we want here.Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
            DateCreated = DateTime.Parse("01/01/2024")
        });
        return Task.FromResult(blogPosts);

    }
}
    