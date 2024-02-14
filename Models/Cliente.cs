namespace Miles_Car_Rental.Models
{
    public class Cliente
    {
       public int id_cliente { get; set; }  
       public string? nombre { get; set; }  
       public string? apellido  { get; set;}
       public string? email { get; set;}
       public string? telefono { get; set;} 
       public int id_localidad { get; set;}

    }
}
