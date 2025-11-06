
using System;
// Definición clase PropuestaTorneoEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class PropuestaTorneoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fechaPropuesta
 */
private Nullable<DateTime> fechaPropuesta;



/**
 *	Atributo estado
 */
private NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum estado;



/**
 *	Atributo torneo
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN torneo;



/**
 *	Atributo equipo
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo;



/**
 *	Atributo votoTorneo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.VotoTorneoEN> votoTorneo;



/**
 *	Atributo notificacion
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion;



/**
 *	Atributo usuario
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo comunidad
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN> comunidad;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> FechaPropuesta {
        get { return fechaPropuesta; } set { fechaPropuesta = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN Torneo {
        get { return torneo; } set { torneo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN Equipo {
        get { return equipo; } set { equipo = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.VotoTorneoEN> VotoTorneo {
        get { return votoTorneo; } set { votoTorneo = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> Notificacion {
        get { return notificacion; } set { notificacion = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN> Comunidad {
        get { return comunidad; } set { comunidad = value;  }
}





public PropuestaTorneoEN()
{
        votoTorneo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.VotoTorneoEN>();
        notificacion = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN>();
        comunidad = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN>();
}



public PropuestaTorneoEN(int id, Nullable<DateTime> fechaPropuesta, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum estado, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN torneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.VotoTorneoEN> votoTorneo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario, string nombre, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN> comunidad
                         )
{
        this.init (Id, fechaPropuesta, estado, torneo, equipo, votoTorneo, notificacion, usuario, nombre, comunidad);
}


public PropuestaTorneoEN(PropuestaTorneoEN propuestaTorneo)
{
        this.init (propuestaTorneo.Id, propuestaTorneo.FechaPropuesta, propuestaTorneo.Estado, propuestaTorneo.Torneo, propuestaTorneo.Equipo, propuestaTorneo.VotoTorneo, propuestaTorneo.Notificacion, propuestaTorneo.Usuario, propuestaTorneo.Nombre, propuestaTorneo.Comunidad);
}

private void init (int id
                   , Nullable<DateTime> fechaPropuesta, NeuralPlayGen.ApplicationCore.Enumerated.NeuralPlay.EstadoSolicitudEnum estado, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN torneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.EquipoEN equipo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.VotoTorneoEN> votoTorneo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.NotificacionEN> notificacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.UsuarioEN usuario, string nombre, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN> comunidad)
{
        this.Id = id;


        this.FechaPropuesta = fechaPropuesta;

        this.Estado = estado;

        this.Torneo = torneo;

        this.Equipo = equipo;

        this.VotoTorneo = votoTorneo;

        this.Notificacion = notificacion;

        this.Usuario = usuario;

        this.Nombre = nombre;

        this.Comunidad = comunidad;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PropuestaTorneoEN t = obj as PropuestaTorneoEN;
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
