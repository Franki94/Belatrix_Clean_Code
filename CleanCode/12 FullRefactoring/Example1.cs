using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI.WebControls;

namespace Project.UserControls
{
    public class PostControl : System.Web.UI.UserControl
    {
        private readonly PostRepository _postRepository;
        private readonly PostValidator _validatePost;
        public PostControl()
        {
            _postRepository = new PostRepository();
            _validatePost = new PostValidator();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) ChargePost();

            var post = CastPost();
            var results = _validatePost.Validate(CastPost());
            if (!results.IsValid) ManageErrors(results.Errors);

            _postRepository.AddNewPost(CastPost());
        }
        private Post CastPost()
        {
            return new Post()
            {
                Id = Convert.ToInt32(PostId.Value),
                Title = PostTitle.Text.Trim(),
                Body = PostBody.Text.Trim()
            };
        }

        private void ChargePost()
        {
            Post post = _postRepository.GetPostById(Convert.ToInt32(Request.QueryString["id"]));
            PostBody.Text = post.Body;
            PostTitle.Text = post.Title;
        }

        private void ManageErrors(IEnumerable<ValidationError> errors)
        {
            BulletedList summary = (BulletedList)FindControl("ErrorSummary");
            foreach (var failure in errors)
            {
                Label errorMessage = FindControl(failure.PropertyName + "Error") as Label;
                if (errorMessage != null) errorMessage.Text = failure.ErrorMessage;

                summary.Items.Add(new ListItem(failure.ErrorMessage));
            }
        }

        public Label PostBody { get; set; }

        public Label PostTitle { get; set; }

        public int? PostId { get; set; }
    }
}

public class PostRepository
{
    private readonly PostDbContext _dbContext;

    public PostRepository()
    {
        _dbContext = new PostDbContext();
    }

    public void AddNewPost(Post post)
    {
        _dbContext.Posts.Add(post);
        _dbContext.SaveChanges();
    }
    public Post GetPostById(int id)
    {
        return _dbContext.Posts.SingleOrDefault(p => p.Id == id);
    }
}

#region helpers

public class ValidationResult
{
    public bool IsValid { get; set; }
    public IEnumerable<ValidationError> Errors { get; set; }

}

public class ValidationError
{
    public string PropertyName { get; set; }
    public string ErrorMessage { get; set; }
}

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}

public class PostValidator
{
    public ValidationResult Validate(Post entity)
    {
        throw new NotImplementedException();
    }
}

public class DbSet<T> : IQueryable<T>
{
    public void Add(T entity)
    {
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Expression Expression
    {
        get { throw new NotImplementedException(); }
    }

    public Type ElementType
    {
        get { throw new NotImplementedException(); }
    }

    public IQueryProvider Provider
    {
        get { throw new NotImplementedException(); }
    }
}

public class PostDbContext
{
    public DbSet<Post> Posts { get; set; }

    public void SaveChanges()
    {
    }
}
#endregion


