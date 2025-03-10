using system.componentModel.dataAnnotations;
using system.componentModel.dataAnnotations.schema;

namespace DemoMVC.Models
{
    [table("student")]
    public class Student
    {
        [key]
        public string ID { get; set; }
        public string Fullname { get; set; }
    }
}