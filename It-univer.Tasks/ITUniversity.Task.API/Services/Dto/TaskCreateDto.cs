using System;
using System.Collections.Generic;
using System.Text;

namespace ITUniversity.Task.API.Services.Dto
{
    public class TaskCreateDto
    {
        public virtual string Subject { get; set; }

        public virtual string Description { get; set; }
    }
}
