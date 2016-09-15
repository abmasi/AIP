using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIP.Model;
using AIP.DATA.Repositories;

namespace AIP.Service
{
    public interface IActivityService
    {
        IEnumerable<Activity> GetActivities();
        Activity GetActivity(int id);
        void CreateActivity(Activity activity);
        void SaveActivity();
    }
}
