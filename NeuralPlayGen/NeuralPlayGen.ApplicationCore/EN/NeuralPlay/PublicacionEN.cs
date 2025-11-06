
using System;
// Definición clase PublicacionEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class PublicacionEN
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
 *	Atributo comunidad
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN> comentario;



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
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario;






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



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN Comunidad {
        get { return comunidad; } set { comunidad = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN> Reaccion {
        get { return reaccion; } set { reaccion = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> Notificacion {
        get { return notificacion; } set { notificacion = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public PublicacionEN()
{
        comentario = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN>();
        reaccion = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN>();
        notificacion = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN>();
}



public PublicacionEN(int id, string contenido, Nullable<DateTime> fechaCreacion, Nullable<DateTime> fechaEdicion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN> comentario, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN> reaccion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario
                     )
{
        this.init (Id, contenido, fechaCreacion, fechaEdicion, comunidad, comentario, reaccion, notificacion, usuario);
}


public PublicacionEN(PublicacionEN publicacion)
{
        this.init (publicacion.Id, publicacion.Contenido, publicacion.FechaCreacion, publicacion.FechaEdicion, publicacion.Comunidad, publicacion.Comentario, publicacion.Reaccion, publicacion.Notificacion, publicacion.Usuario);
}

private void init (int id
                   , string contenido, Nullable<DateTime> fechaCreacion, Nullable<DateTime> fechaEdicion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN> comentario, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN> reaccion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario)
{
        this.Id = id;


        this.Contenido = contenido;

        this.FechaCreacion = fechaCreacion;

        this.FechaEdicion = fechaEdicion;

        this.Comunidad = comunidad;

        this.Comentario = comentario;

        this.Reaccion = reaccion;

        this.Notificacion = notificacion;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PublicacionEN t = obj as PublicacionEN;
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
