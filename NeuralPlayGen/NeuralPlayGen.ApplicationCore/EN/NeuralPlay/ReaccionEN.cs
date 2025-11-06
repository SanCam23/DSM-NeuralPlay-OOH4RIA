
using System;
// Definición clase ReaccionEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class ReaccionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo tipo
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoReaccionEnum tipo;



/**
 *	Atributo fechaCreacion
 */
private Nullable<DateTime> fechaCreacion;



/**
 *	Atributo publicacion
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN publicacion;



/**
 *	Atributo comentario
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN comentario;



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



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoReaccionEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual Nullable<DateTime> FechaCreacion {
        get { return fechaCreacion; } set { fechaCreacion = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN Publicacion {
        get { return publicacion; } set { publicacion = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> Notificacion {
        get { return notificacion; } set { notificacion = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public ReaccionEN()
{
        notificacion = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN>();
}



public ReaccionEN(int id, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoReaccionEnum tipo, Nullable<DateTime> fechaCreacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN publicacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN comentario, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario
                  )
{
        this.init (Id, tipo, fechaCreacion, publicacion, comentario, notificacion, usuario);
}


public ReaccionEN(ReaccionEN reaccion)
{
        this.init (reaccion.Id, reaccion.Tipo, reaccion.FechaCreacion, reaccion.Publicacion, reaccion.Comentario, reaccion.Notificacion, reaccion.Usuario);
}

private void init (int id
                   , NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoReaccionEnum tipo, Nullable<DateTime> fechaCreacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN publicacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN comentario, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario)
{
        this.Id = id;


        this.Tipo = tipo;

        this.FechaCreacion = fechaCreacion;

        this.Publicacion = publicacion;

        this.Comentario = comentario;

        this.Notificacion = notificacion;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReaccionEN t = obj as ReaccionEN;
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
