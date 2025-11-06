
using System;
// Definición clase EquipoEN
namespace NeuralPlayGen.ApplicationCore.EN.NeuralPlay
{
public partial class EquipoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo fechaCreacion
 */
private Nullable<DateTime> fechaCreacion;



/**
 *	Atributo comunidad
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad;



/**
 *	Atributo miembroEquipo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroEquipoEN> miembroEquipo;



/**
 *	Atributo propuestaTorneo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN> propuestaTorneo;



/**
 *	Atributo chatEquipo
 */
private NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ChatEquipoEN chatEquipo;



/**
 *	Atributo invitacion
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN> invitacion;



/**
 *	Atributo solicitudIngreso
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN> solicitudIngreso;



/**
 *	Atributo participacionTorneo
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ParticipacionTorneoEN> participacionTorneo;



/**
 *	Atributo juego
 */
private System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN> juego;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual Nullable<DateTime> FechaCreacion {
        get { return fechaCreacion; } set { fechaCreacion = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN Comunidad {
        get { return comunidad; } set { comunidad = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroEquipoEN> MiembroEquipo {
        get { return miembroEquipo; } set { miembroEquipo = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN> PropuestaTorneo {
        get { return propuestaTorneo; } set { propuestaTorneo = value;  }
}



public virtual NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ChatEquipoEN ChatEquipo {
        get { return chatEquipo; } set { chatEquipo = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN> Invitacion {
        get { return invitacion; } set { invitacion = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN> SolicitudIngreso {
        get { return solicitudIngreso; } set { solicitudIngreso = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ParticipacionTorneoEN> ParticipacionTorneo {
        get { return participacionTorneo; } set { participacionTorneo = value;  }
}



public virtual System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN> Juego {
        get { return juego; } set { juego = value;  }
}





public EquipoEN()
{
        miembroEquipo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroEquipoEN>();
        propuestaTorneo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN>();
        invitacion = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN>();
        solicitudIngreso = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN>();
        participacionTorneo = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ParticipacionTorneoEN>();
        juego = new System.Collections.Generic.List<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN>();
}



public EquipoEN(int id, string nombre, string descripcion, Nullable<DateTime> fechaCreacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroEquipoEN> miembroEquipo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN> propuestaTorneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ChatEquipoEN chatEquipo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN> invitacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN> solicitudIngreso, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ParticipacionTorneoEN> participacionTorneo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN> juego
                )
{
        this.init (Id, nombre, descripcion, fechaCreacion, comunidad, miembroEquipo, propuestaTorneo, chatEquipo, invitacion, solicitudIngreso, participacionTorneo, juego);
}


public EquipoEN(EquipoEN equipo)
{
        this.init (equipo.Id, equipo.Nombre, equipo.Descripcion, equipo.FechaCreacion, equipo.Comunidad, equipo.MiembroEquipo, equipo.PropuestaTorneo, equipo.ChatEquipo, equipo.Invitacion, equipo.SolicitudIngreso, equipo.ParticipacionTorneo, equipo.Juego);
}

private void init (int id
                   , string nombre, string descripcion, Nullable<DateTime> fechaCreacion, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ComunidadEN comunidad, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.MiembroEquipoEN> miembroEquipo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.PropuestaTorneoEN> propuestaTorneo, NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ChatEquipoEN chatEquipo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.InvitacionEN> invitacion, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.SolicitudIngresoEN> solicitudIngreso, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.ParticipacionTorneoEN> participacionTorneo, System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.JuegoEN> juego)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.FechaCreacion = fechaCreacion;

        this.Comunidad = comunidad;

        this.MiembroEquipo = miembroEquipo;

        this.PropuestaTorneo = propuestaTorneo;

        this.ChatEquipo = chatEquipo;

        this.Invitacion = invitacion;

        this.SolicitudIngreso = solicitudIngreso;

        this.ParticipacionTorneo = participacionTorneo;

        this.Juego = juego;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EquipoEN t = obj as EquipoEN;
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
