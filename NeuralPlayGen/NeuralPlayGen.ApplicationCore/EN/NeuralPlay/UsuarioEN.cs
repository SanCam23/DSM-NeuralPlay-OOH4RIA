
using System;
// Definición clase UsuarioEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class UsuarioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo pass
 */
private String pass;



/**
 *	Atributo nick
 */
private string nick;



/**
 *	Atributo correoElectronico
 */
private string correoElectronico;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo fechaRegistro
 */
private Nullable<DateTime> fechaRegistro;



/**
 *	Atributo estadoCuenta
 */
private bool estadoCuenta;



/**
 *	Atributo miembroComunidad
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroComunidadEN> miembroComunidad;



/**
 *	Atributo miembroEquipo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroEquipoEN> miembroEquipo;



/**
 *	Atributo mensajeChat
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MensajeChatEN> mensajeChat;



/**
 *	Atributo invitacionEmisor
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN> invitacionEmisor;



/**
 *	Atributo invitacionReceptor
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN> invitacionReceptor;



/**
 *	Atributo solicitudIngreso
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN> solicitudIngreso;



/**
 *	Atributo publicacion
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN> publicacion;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN> comentario;



/**
 *	Atributo notificacion
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion;



/**
 *	Atributo reaccion
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN> reaccion;



/**
 *	Atributo propuestaTorneo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN> propuestaTorneo;



/**
 *	Atributo votoTorneo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.VotoTorneoEN> votoTorneo;



/**
 *	Atributo perfil
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN perfil;



/**
 *	Atributo sesion
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SesionEN> sesion;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}



public virtual string Nick {
        get { return nick; } set { nick = value;  }
}



public virtual string CorreoElectronico {
        get { return correoElectronico; } set { correoElectronico = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual Nullable<DateTime> FechaRegistro {
        get { return fechaRegistro; } set { fechaRegistro = value;  }
}



public virtual bool EstadoCuenta {
        get { return estadoCuenta; } set { estadoCuenta = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroComunidadEN> MiembroComunidad {
        get { return miembroComunidad; } set { miembroComunidad = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroEquipoEN> MiembroEquipo {
        get { return miembroEquipo; } set { miembroEquipo = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MensajeChatEN> MensajeChat {
        get { return mensajeChat; } set { mensajeChat = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN> InvitacionEmisor {
        get { return invitacionEmisor; } set { invitacionEmisor = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN> InvitacionReceptor {
        get { return invitacionReceptor; } set { invitacionReceptor = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN> SolicitudIngreso {
        get { return solicitudIngreso; } set { solicitudIngreso = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN> Publicacion {
        get { return publicacion; } set { publicacion = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> Notificacion {
        get { return notificacion; } set { notificacion = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN> Reaccion {
        get { return reaccion; } set { reaccion = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN> PropuestaTorneo {
        get { return propuestaTorneo; } set { propuestaTorneo = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.VotoTorneoEN> VotoTorneo {
        get { return votoTorneo; } set { votoTorneo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN Perfil {
        get { return perfil; } set { perfil = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SesionEN> Sesion {
        get { return sesion; } set { sesion = value;  }
}





public UsuarioEN()
{
        miembroComunidad = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroComunidadEN>();
        miembroEquipo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroEquipoEN>();
        mensajeChat = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MensajeChatEN>();
        invitacionEmisor = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN>();
        invitacionReceptor = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN>();
        solicitudIngreso = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN>();
        publicacion = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN>();
        comentario = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN>();
        notificacion = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN>();
        reaccion = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN>();
        propuestaTorneo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN>();
        votoTorneo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.VotoTorneoEN>();
        sesion = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SesionEN>();
}



public UsuarioEN(int id, String pass, string nick, string correoElectronico, string telefono, Nullable<DateTime> fechaRegistro, bool estadoCuenta, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroComunidadEN> miembroComunidad, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroEquipoEN> miembroEquipo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MensajeChatEN> mensajeChat, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN> invitacionEmisor, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN> invitacionReceptor, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN> solicitudIngreso, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN> publicacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN> comentario, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN> reaccion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN> propuestaTorneo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.VotoTorneoEN> votoTorneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN perfil, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SesionEN> sesion
                 )
{
        this.init (Id, pass, nick, correoElectronico, telefono, fechaRegistro, estadoCuenta, miembroComunidad, miembroEquipo, mensajeChat, invitacionEmisor, invitacionReceptor, solicitudIngreso, publicacion, comentario, notificacion, reaccion, propuestaTorneo, votoTorneo, perfil, sesion);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.Id, usuario.Pass, usuario.Nick, usuario.CorreoElectronico, usuario.Telefono, usuario.FechaRegistro, usuario.EstadoCuenta, usuario.MiembroComunidad, usuario.MiembroEquipo, usuario.MensajeChat, usuario.InvitacionEmisor, usuario.InvitacionReceptor, usuario.SolicitudIngreso, usuario.Publicacion, usuario.Comentario, usuario.Notificacion, usuario.Reaccion, usuario.PropuestaTorneo, usuario.VotoTorneo, usuario.Perfil, usuario.Sesion);
}

private void init (int id
                   , String pass, string nick, string correoElectronico, string telefono, Nullable<DateTime> fechaRegistro, bool estadoCuenta, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroComunidadEN> miembroComunidad, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroEquipoEN> miembroEquipo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MensajeChatEN> mensajeChat, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN> invitacionEmisor, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN> invitacionReceptor, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN> solicitudIngreso, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PublicacionEN> publicacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComentarioEN> comentario, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ReaccionEN> reaccion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN> propuestaTorneo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.VotoTorneoEN> votoTorneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PerfilEN perfil, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SesionEN> sesion)
{
        this.Id = id;


        this.Pass = pass;

        this.Nick = nick;

        this.CorreoElectronico = correoElectronico;

        this.Telefono = telefono;

        this.FechaRegistro = fechaRegistro;

        this.EstadoCuenta = estadoCuenta;

        this.MiembroComunidad = miembroComunidad;

        this.MiembroEquipo = miembroEquipo;

        this.MensajeChat = mensajeChat;

        this.InvitacionEmisor = invitacionEmisor;

        this.InvitacionReceptor = invitacionReceptor;

        this.SolicitudIngreso = solicitudIngreso;

        this.Publicacion = publicacion;

        this.Comentario = comentario;

        this.Notificacion = notificacion;

        this.Reaccion = reaccion;

        this.PropuestaTorneo = propuestaTorneo;

        this.VotoTorneo = votoTorneo;

        this.Perfil = perfil;

        this.Sesion = sesion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
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
