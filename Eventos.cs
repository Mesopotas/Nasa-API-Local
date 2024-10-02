public class Eventos{

    public int Id {get; set;}
    public string Titulo {get; set;}
    public string Categorias {get; set;} 
    public int Magnitud {get; set;}


    public Eventos( int Id, string Titulo, string Categorias, int Magnitud){

        this.Id = Id;
        this.Titulo = Titulo;
        this.Categorias = Categorias;
        this.Magnitud = Magnitud;

    }

}