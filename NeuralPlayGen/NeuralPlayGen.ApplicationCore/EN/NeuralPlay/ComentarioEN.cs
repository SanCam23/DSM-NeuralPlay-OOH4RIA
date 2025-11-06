
using System;
// Definición clase ComentarioEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class ComentarioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo contenido
 */
private string contenido;



/**
 *	Atributo fechaCreacion
 */
private Nullable<DateTime> fechaCreacion;



/**
 *	Atributo fechaEdicion
 */
private Nullable<DateTime> fechaEdicion;



/**
 *	Atributo publicacion
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN publicacion;



/**
 *	Atributo reaccion
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN> reaccion;



/**
 *	Atributo notificacion
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN> usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Contenido {
        get { return contenido; } set { contenido = value;  }
}



public virtual Nullable<DateTime> FechaCreacion {
        get { return fechaCreacion; } set { fechaCreacion = value;  }
}



public virtual Nullable<DateTime> FechaEdicion {
        get { return fechaEdicion; } set { fechaEdicion = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN Publicacion {
        get { return publicacion; } set { publicacion = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN> Reaccion {
        get { return reaccion; } set { reaccion = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> Notificacion {
        get { return notificacion; } set { notificacion = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}





public ComentarioEN()
{
        reaccion = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN>();
        notificacion = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN>();
        usuario = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN>();
}



public ComentarioEN(int id, string contenido, Nullable<DateTime> fechaCreacion, Nullable<DateTime> fechaEdicion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN publicacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN> reaccion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN> usuario
                    )
{
        this.init (Id, contenido, fechaCreacion, fechaEdicion, publicacion, reaccion, notificacion, usuario);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (comentario.Id, comentario.Contenido, comentario.FechaCreacion, comentario.FechaEdicion, comentario.Publicacion, comentario.Reaccion, comentario.Notificacion, comentario.Usuario);
}

private void init (int id
                   , string contenido, Nullable<DateTime> fechaCreacion, Nullable<DateTime> fechaEdicion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN publicacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN> reaccion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN> usuario)
{
        this.Id = id;


        this.Contenido = contenido;

        this.FechaCreacion = fechaCreacion;

        this.FechaEdicion = fechaEdicion;

        this.Publicacion = publicacion;

        this.Reaccion = reaccion;

        this.Notificacion = notificacion;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
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
