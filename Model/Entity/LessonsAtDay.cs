//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Table.Model.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class LessonsAtDay
    {
        public int Id { get; set; }
        public int DayId { get; set; }
        public int WeekId { get; set; }
        public int ClassId { get; set; }
        public int LessonObjectId { get; set; }
        public int Number { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual DayType DayType { get; set; }
        public virtual LessonObject LessonObject { get; set; }
        public virtual WeekType WeekType { get; set; }
    }
}
