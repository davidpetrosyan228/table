using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Table.Model.Entity;

namespace Table.Model
{
    public class LessonAtDayModel
    {
        public string Day { get; set; }
        public string Week { get; set; }
        public string LessonObject { get; set; }

        public static LessonAtDayModel GetModelFromDb(LessonsAtDay context)
        {
            return new LessonAtDayModel()
            {
                Day = context.DayType.Type,
                Week = context.WeekType.Description,
                LessonObject = context.LessonObject.Name
            };
        }
    }
    
}
