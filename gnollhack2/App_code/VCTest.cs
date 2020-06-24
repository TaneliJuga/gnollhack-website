﻿//using Microsoft.Web.
//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace gnollhack2.App_code.ViewComponents
//{
//    public class PriorityList : ViewComponent
//    {
//        private readonly ToDoContext db;

//        public PriorityList(ToDoContext context)
//        {
//            db = context;
//        }

//        public async Task<IViewComponentResult> InvokeAsync(
//        int maxPriority, bool isDone)
//        {
//            var items = await GetItemsAsync(maxPriority, isDone);
//            return View(items);
//        }
//        private Task<List<TodoItem>> GetItemsAsync(int maxPriority, bool isDone)
//        {
//            return db.ToDo.Where(x => x.IsDone == isDone &&
//                                 x.Priority <= maxPriority).ToListAsync();
//        }
//    }
//}