using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationContext _context;
        public List<Contact> Contacts { get; set; }
        public IndexModel(ApplicationContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
            Contacts = _context.Contacts.AsNoTracking().ToList();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var product = await _context.Contacts.FindAsync(id);

            if (product != null)
            {
                _context.Contacts.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
