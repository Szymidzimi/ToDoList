using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoManager.Models;

namespace ToDoManager.Controllers
{
    public class TaskController : Controller
    {
        private static IList<TaskModel> tasks = new List<TaskModel>()
        {
            new TaskModel(){IdTask=1,Name="kup mleko",DataOfStart=DateTime.Now,Description="UHT 3,2",Status=false},
            new TaskModel(){IdTask=2,Name="kup mleko 2",DataOfStart=DateTime.Now,Description="UHT 1,5",Status=false},
            new TaskModel(){IdTask=3,Name="kup mleko 3",DataOfStart=DateTime.Now,Description="UHT 0,5",Status=false}
        };
        // GET: TaskController
        public ActionResult Index()
        {
            return View(tasks);
        }

        // GET: TaskController/Details/5
        public ActionResult Details(int id)
        {
            return View(tasks.FirstOrDefault(x=>x.IdTask==id));
        }

        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View(new TaskModel());
        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskModel taskModel)
        {
            taskModel.IdTask = tasks.Count + 1;
            taskModel.DataOfStart = DateTime.Now;
            tasks.Add(taskModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: TaskController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(tasks.FirstOrDefault(x=>x.IdTask==id));
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TaskModel taskModel)
        {
            TaskModel task = tasks.FirstOrDefault(x => x.IdTask == id);
            task.Name = taskModel.Name;
            task.Description = taskModel.Description;
            task.DataOfEvent = taskModel.DataOfEvent;
            return RedirectToAction(nameof(Index));

        }

        // GET: TaskController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(tasks.FirstOrDefault(x=>x.IdTask==id));
        }

        // POST: TaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TaskModel taskModel)
        {
            TaskModel task = tasks.FirstOrDefault(x => x.IdTask == id);
            tasks.Remove(task);
            return RedirectToAction(nameof(Index));

        }
    }
}
