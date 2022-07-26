
public class Usuario
{
    private int _id;
    public int Id { get; set; }

    private string _nombre;
    public string Nombre { get; set; }

    private string _apellido;
    public string Apellido { get; set; }

    private string _nombreUsuario;
    public string NombreUsuario { get; set; }

    private string _contrasegna;
    public string Contrasegna { get; set; }

    private string _mail;
    public string Mail { get; set; }

    public Usuario()
    {
        _id = 0;
        _nombre = string.Empty;
        _apellido = string.Empty;
        _nombreUsuario = string.Empty;
        _contrasegna = string.Empty;
        _mail = string.Empty;
    }
    public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasegna, string mail)
    {
        _id = id;
        _nombre = nombre;
        _apellido = apellido;
        _nombreUsuario = nombreUsuario;
        _contrasegna = contrasegna;
        _mail = mail;
    }
}

public class Producto
{
    private int _id;
    public int Id { get; set; }
    private string _descripcion;
    public string Descripcion { get; set; }
    private double _costo;
    public double Costo { get; set; }
    private double _precioVenta;
    public double PrecioVenta { get; set; }
    private int _stock;
    public int Stock { get; set; }
    private int _idUsuario;
    public int IdUsuario { get; set; }

    public Producto()
    {
        _id = 0;
        _descripcion = string.Empty;
        _costo = 0;
        _precioVenta = 0;
        _stock = 0;
        _idUsuario = 0;
    }
    public Producto(int id, string descripcion, int costo, int precioVenta, int stock, int idUsuario)
    {
        _id = id;
        _descripcion = descripcion;
        _costo = costo;
        _precioVenta = precioVenta;
        _stock = stock;
        _idUsuario = idUsuario;
    }
}

public class ProductoVendido
{
    private int _id;
    public int Id { get; set; }
    private int _idProducto;
    public int IdProducto { get; set; }
    private int _stock;
    public int Stock { get; set; }
    private int _idVenta;
    public int IdVenta { get; set; }

    public ProductoVendido()
    {
        _id = 0;
        _idProducto = 0;
        _stock = 0;
        _idVenta = 0;
    }

    public ProductoVendido(int id, int idProducto, int stock, int idVenta)
    {
        _id = id;
        _idProducto = idProducto;
        _stock = stock;
        _idVenta = idVenta;
    }
}

public class Venta
{
    private int _id;
    public int Id { get; set; }
    private string _comentarios;
    public string Comentarios { get; set; }

    public Venta()
    {
        _id = 0;
        _comentarios = string.Empty;
    }
    public Venta(int id, string comentarios)
    {
        _id = id;
        _comentarios = comentarios;
    }   
}
