using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Tracking.Data;
using Tracking.Models;

namespace Tracking.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IssueDbContext _context;

        public IndexModel(ILogger<IndexModel> logger , IssueDbContext issueDbContext )
        {
            _logger = logger;
            _context = issueDbContext;
        }
        // public list<Issue>  issues { get; set; } =  new list<Issue>():
        public IEnumerable<Issue> Issues { get; set; } = Enumerable.Empty<Issue>();

        //execute on the Http Verb GET 
        public void OnGet()
        {
            Issues =  _context.Issues.Where(i => i.CompletedOn == null)
                                        .OrderByDescending(i => i.CreatedOn).ToList();
        }
        //execute on the Http Verb POST 
        public void OnPost()
        {
        }
       
        public string Name { get; set; } = "Lohitha";
    }
}