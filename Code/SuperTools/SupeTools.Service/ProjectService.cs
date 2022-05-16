using SuperTools.Data;
using SuperTools.Data.Entity;
using SuperHelper.Extension;

namespace SupeTools.Service
{
    public class ProjectService
    {
        private ToolsDbContext _db;
        public ProjectService(ToolsDbContext db)
        {
            _db = db;
        }

        public bool GetProjects(out List<Project> projects, out string msg)
        {
            projects = _db.Projects.ToList();
            msg = "成功";
            return true;
        }

        public bool GetProject(long id, out Project? project, out string msg)
        {
            project = _db.Projects.FirstOrDefault(x => x.Id == id);
            if (project == null)
            {
                msg = "未找到该项目信息";
                return false;
            }
            else
            {
                msg = "成功";
                return true;
            }
        }

        public bool Delete(long id, out string msg)
        {
            var info = _db.Projects.FirstOrDefault(x => x.Id == id);
            if (info == null)
            {
                msg = "未找到该项目信息";
                return false;
            }
            else
            {
                _db.Projects.Remove(info);
                _db.SaveChanges();
                msg = "成功";
                return true;
            }
        }

        public bool AddOrUpdate(Project project, out string msg)
        {
            if (project.Id == 0)//新增
            {
                _db.Projects.Add(project);
                _db.SaveChanges();
                msg = "成功";
                return true;
            }
            else
            {
                var oldProject = _db.Projects.FirstOrDefault(x => x.Id == project.Id);
                oldProject.ValueAssign(project);
                _db.SaveChanges();
                msg = "成功";
                return true;
            }
        }
    }
}
