using It_Univer.Tasks.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace ITUniversity.Task.API.Services.Dto
{
    public class TaskDto
    {
        public virtual long Id { get; set; }

        public virtual string Subject { get; set; }

        public virtual string Description { get; set; }

        public virtual DateTime CreationDate { get; set; }

        public virtual TaskStatus Status { get; set; }
    }
}
