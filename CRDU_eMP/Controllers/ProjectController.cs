using CRDU_eMP.Models;
using Microsoft.AspNetCore.Mvc;

public class ProjectController : Controller
{
    private readonly EFContext _context;

    public ProjectController(EFContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        List<Project> projects = _context.Projects.ToList();
        return View(projects);
    }

    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var project = _context.Projects.FirstOrDefault(p => p.Id == id);
        if (project == null)
        {
            return NotFound();
        }

        return View(project);
    }

    // GET: Project/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Project/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Project project)
    {
        try
        {
            _context.Add(project);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            return Content($"Something went wrong\n {ex}");
        }
    }

    // GET: Project/Edit/1
    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var project = _context.Projects.FirstOrDefault(p => p.Id == id);
        if (project == null)
        {
            return NotFound();
        }

        return View(project);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Project project)
    {
        Project oldProject = _context.Projects.SingleOrDefault(p => p.Id == project.Id);

        if (id != project.Id)
        {
            return NotFound();
        }

        try
        {
            oldProject.Name = project.Name;
            oldProject.Description = project.Description;

            _context.Update(oldProject);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            return Content($"Something went wrong\n {ex}");
        }
    }

    // GET: Project/Delete/1

    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var project = _context.Projects.FirstOrDefault(p => p.Id == id);
        if (project == null)
        {
            return NotFound();
        }

        return View(project);
    }

    // POST: Project/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var project = _context.Projects.FirstOrDefault(p => p.Id == id);
        if (project == null)
        {
            return NotFound();
        }

        _context.Projects.Remove(project);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
