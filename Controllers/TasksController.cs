using Microsoft.AspNetCore.Mvc;
using TaskManagement.Data;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    public class TasksController : Controller
    {
        private readonly Appdbcontext _context;

        public TasksController(Appdbcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Tasks.ToList());
        }

       

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskItem task)
        {
            task.CreatedOn = DateTime.Now;
            task.UpdatedOn = DateTime.Now;

            task.CreatedById = 1;
            task.CreatedByName = "Admin";

            task.UpdatedById = 1;
            task.UpdatedByName = "Admin";

            _context.Tasks.Add(task);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(_context.Tasks.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(TaskItem task)
        {
            var existingTask = _context.Tasks.Find(task.Id);

           
            existingTask.TaskTitle = task.TaskTitle;
            existingTask.TaskDescription = task.TaskDescription;
            existingTask.Status = task.Status;
            existingTask.UpdatedOn = DateTime.Now;
            existingTask.UpdatedById = 2;
            existingTask.UpdatedByName = "Manager";
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var task = _context.Tasks.Find(id);
            _context.Tasks.Remove(task);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
