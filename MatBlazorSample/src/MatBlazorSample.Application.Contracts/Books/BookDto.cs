using System;
using Volo.Abp.Application.Dtos;

namespace MatBlazorSample.Books
{
    public class BookDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        
        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}