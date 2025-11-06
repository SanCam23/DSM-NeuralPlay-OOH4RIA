
using System;
// Definición clase MiembroComunidadEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class MiembroComunidadEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo rol
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.RolComunidadEnum rol;



/**
 *	Atributo estado
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoMembresiaEnum estado;



/**
 *	Atributo fechaAlta
 */
private Nullable<DateTime> fechaAlta;



/**
 *	Atributo comunidad
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad;



/**
 *	Atributo usuario
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.RolComunidadEnum Rol {
        get { return rol; } set { rol = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoMembresiaEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual Nullable<DateTime> FechaAlta {
        get { return fechaAlta; } set { fechaAlta = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN Comunidad {
        get { return comunidad; } set { comunidad = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public MiembroComunidadEN()
{
}



public MiembroComunidadEN(int id, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.RolComunidadEnum rol, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoMembresiaEnum estado, Nullable<DateTime> fechaAlta, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario
                          )
{
        this.init (Id, rol, estado, fechaAlta, comunidad, usuario);
}


public MiembroComunidadEN(MiembroComunidadEN miembroComunidad)
{
        this.init (miembroComunidad.Id, miembroComunidad.Rol, miembroComunidad.Estado, miembroComunidad.FechaAlta, miembroComunidad.Comunidad, miembroComunidad.Usuario);
}

private void init (int id
                   , NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.RolComunidadEnum rol, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoMembresiaEnum estado, Nullable<DateTime> fechaAlta, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario)
{
        this.Id = id;


        this.Rol = rol;

        this.Estado = estado;

        this.FechaAlta = fechaAlta;

        this.Comunidad = comunidad;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MiembroComunidadEN t = obj as MiembroComunidadEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
