

using System.ComponentModel.DataAnnotations;

public class Employee{

    [Key]
    public int Id { get; set; }
    [Required]
    [Display(Name ="Nombre Empleado")]
    public string Name { get; set; }
    [Required]
    [Display(Name ="Asignacion")]
    public string Designation { get; set; }
    [Display(Name ="Direccion")]
    public string Adress { get; set; }
    /*[Display(Type)]*/
    public DateTime RecordedCreation { get; set; }

}


