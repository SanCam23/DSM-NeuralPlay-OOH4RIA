
using System;
// Definición clase NotificacionEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class NotificacionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo tipo
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoNotificacionEnum tipo;



/**
 *	Atributo mensaje
 */
private string mensaje;



/**
 *	Atributo leida
 */
private bool leida;



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
 *	Atributo reaccion
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN reaccion;



/**
 *	Atributo propuestaTorneo
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN propuestaTorneo;



/**
 *	Atributo usuario
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoNotificacionEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual string Mensaje {
        get { return mensaje; } set { mensaje = value;  }
}



public virtual bool Leida {
        get { return leida; } set { leida = value;  }
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



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN Reaccion {
        get { return reaccion; } set { reaccion = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN PropuestaTorneo {
        get { return propuestaTorneo; } set { propuestaTorneo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public NotificacionEN()
{
}



public NotificacionEN(int id, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoNotificacionEnum tipo, string mensaje, bool leida, Nullable<DateTime> fechaCreacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN publicacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN comentario, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN reaccion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN propuestaTorneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario
                      )
{
        this.init (Id, tipo, mensaje, leida, fechaCreacion, publicacion, comentario, reaccion, propuestaTorneo, usuario);
}


public NotificacionEN(NotificacionEN notificacion)
{
        this.init (notificacion.Id, notificacion.Tipo, notificacion.Mensaje, notificacion.Leida, notificacion.FechaCreacion, notificacion.Publicacion, notificacion.Comentario, notificacion.Reaccion, notificacion.PropuestaTorneo, notificacion.Usuario);
}

private void init (int id
                   , NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.TipoNotificacionEnum tipo, string mensaje, bool leida, Nullable<DateTime> fechaCreacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN publicacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN comentario, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN reaccion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN propuestaTorneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario)
{
        this.Id = id;


        this.Tipo = tipo;

        this.Mensaje = mensaje;

        this.Leida = leida;

        this.FechaCreacion = fechaCreacion;

        this.Publicacion = publicacion;

        this.Comentario = comentario;

        this.Reaccion = reaccion;

        this.PropuestaTorneo = propuestaTorneo;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        NotificacionEN t = obj as NotificacionEN;
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
