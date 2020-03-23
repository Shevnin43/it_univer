using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using ItUniversity.Application.Services;

namespace ITUniversity.Task.API.Services
{
    public interface ITaskAppService : IApplicationService
    {
        ApiCreateModel ApiCreate(ApiCreateModel task);
        bool ApiRemove(long id);
        ApiCreateModel ApiUpdate(ApiCreateModel task);
        List<ApiCreateModel> ApiAllTasks();
        ApiCreateModel ApiDetails(long id);

    }

        public class ApiCreateModel
        {
            public static ApiCreateModel New
            {
                get { return new ApiCreateModel(); }
            }

            [Required(ErrorMessage = "Заполните поле:")]
            [DisplayName("Тема")] 
            public string Subject { get; set; }

            [DisplayName("Описание")]
            public string Description { get; set; }

            public long Id { get; set; }
        }
}
